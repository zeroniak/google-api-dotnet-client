#!/bin/bash

set -e

source CSharpGeneratorFunctions.sh

# "nuget restore" fails if local package source directories don't exist.
mkdir -p NuPkgs/Support

# Final output directory of NuPkgs.
NUPKG_DIR=$(pwd)/NuPkgs/Generated
# Build configuration to build/pack.
BUILD_CONFIGURATION=Release
# Directory in which to download discovery docs.
DISCOVERY_DOC_DIR=$(pwd)/DiscoveryJson
# Permanent code generation directory
PERM_CODE_GENERATION_DIR=$(pwd)/Src/Generated
# Temporary code generation directory
TEMP_CODE_GENERATION_DIR=$(pwd)/Src/TempGenerated
# Directory containing tools used during the build.
TOOLS_DIR=$(pwd)/Src/Tools
# Only generate libraries for which the discovery has changed or are new.
GENERATE_CHANGES_ONLY=TRUE

# Forces sourcelink to work during the build.
export CI=true

while [[ $# -gt 0 ]]; do
  key="$1"
  case $key in
    --skipdownload)
      SKIPDOWNLOAD=TRUE
      ;;
    --skiprevert)
      SKIPREVERT=TRUE
      ;;
    --skipgenerate)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      ;;
    --skipbuild)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      ;;
    --skippack)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      SKIPPACK=TRUE
      ;;
    --onlydownload)
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      SKIPPACK=TRUE
      ;;
    --onlygenerate)
      SKIPDOWNLOAD=TRUE
      SKIPBUILD=TRUE
      SKIPPACK=TRUE
      ;;
    --onlybuild)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPPACK=TRUE
      ;;
    --onlypack)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      ;;
    --forcegenerateall)
      GENERATE_CHANGES_ONLY=FALSE
      ;;
    *)
      echo ERROR: Invalid argument to BuildGenerated.sh: \'$key\'
      exit 1
  esac
  shift
done

install_csharp_generator

if [ -z ${SKIPDOWNLOAD+x} ]; then
  # Delete all discovery docs
  echo Deleting existing \'$DISCOVERY_DOC_DIR\' directory...
  rm -rf $DISCOVERY_DOC_DIR
  # Download all discovery docs
  dotnet run --project $TOOLS_DIR/DiscoveryDocDownloader -- $DISCOVERY_DOC_DIR
  # Patch discovery docs
  dotnet run --project $TOOLS_DIR/DiscoveryDocPatcher -- $DISCOVERY_DOC_DIR
  
  if [[ $SKIPREVERT == "TRUE" ]]
  then
    echo "Skipping revision/etag-only check of discovery docs"
  else
    # Revert changes that only affect the revision
    for discovery in $(git status -s -- $DISCOVERY_DOC_DIR | grep -E '^ M' | cut "-d " -f3)
    do
      # All but the last lines of grep here are removing extraneous output from git diff.
      # The last lines identify lines that are just changes to "revision" or "etag".
      if [[ ! $(git diff --unified=0 -- $discovery 2>&1 | \
                grep -v "warning:" | \
                grep -v "original line endings" |
                grep -v '\-\-\-' | \
                grep -v '+++' | \
                grep -v @@ | \
                grep -v "diff --git" | \
                grep -v -E '^index' | \
                grep -v -E '[-+] "revision":' | \
                grep -v -E '[-+] "etag":' ) ]]
      then
        echo "$discovery has only changed revision; reverting"
        git checkout -q -- $discovery
      fi   
    done
  fi
fi

if [ -z ${SKIPGENERATE+x} ];
then
  if [[ $GENERATE_CHANGES_ONLY == "TRUE" ]]
  then
    # Only generate libraries for discovery docs that have changed or are new.
    modified=$(git status -s -- $DISCOVERY_DOC_DIR | grep -E '\.json$' | grep -E '^ M' | cut "-d " -f3)
    added=$(git status -s -- $DISCOVERY_DOC_DIR | grep -E '\.json$' | grep -E '^\?\?' | cut "-d " -f2)
    needs_generation=(${modified[@]} ${added[@]})
    # If we generate only a subset of the existing discoveries, we do so in a temporary
    # folder so as not to delete generated code for the unmodified discoveries.
    CODE_GENERATION_DIR=$TEMP_CODE_GENERATION_DIR
  else
    needs_generation=$(find $DISCOVERY_DOC_DIR -name '*.json')
    CODE_GENERATION_DIR=$PERM_CODE_GENERATION_DIR
  fi
  # Delete all generated code
  echo Deleting existing \'$CODE_GENERATION_DIR\' directory...
  rm -rf $CODE_GENERATION_DIR
  for jsonfile in ${needs_generation[@]}
  do
    IFS='/'; names=($jsonfile); unset IFS
    name=$(echo ${names[-1]} | sed 's/.json//g')
    case $name in
      identitytoolkit_v3|oauth2_v1)
        echo Ignoring: \'$name\'
        ;;
      *)
        echo Generating: \'$name\'
        run_csharp_generator "$jsonfile" "$CODE_GENERATION_DIR" features.json "EnumStorage/$name.json"
        if [[ -f $(pwd)/PostGeneration/$name.sh ]]
        then
          echo "Running post-generation step for $name"
          $(pwd)/PostGeneration/$name.sh "$CODE_GENERATION_DIR"
        fi
        ;;
    esac
  done
fi

if [ -z ${SKIPBUILD+x} ]; then
  rm -f Generated.sln
  dotnet new sln --name Generated
  echo $CODE_GENERATION_DIR/*/*.csproj | xargs dotnet sln Generated.sln add
  dotnet restore Generated.sln
  dotnet build Generated.sln --configuration $BUILD_CONFIGURATION --no-restore
fi

if [ -z ${SKIPPACK+x} ]; then
  # Delete all generated nupkgs
  echo Deleting existing \'$NUPKG_DIR\' directory...
  rm -rf $NUPKG_DIR
  dotnet pack Generated.sln --configuration $BUILD_CONFIGURATION --no-restore --no-build --output $NUPKG_DIR
fi

if [[ $GENERATE_CHANGES_ONLY == "TRUE" ]]
then
  # If we only generated libraries for changed discoveries only, we know
  # we did so on TEMP_CODE_GENERATION_DIR, so we know have to move those changes
  # to PERM_CODE_GENERATION_DIR
  for generatedFolder in $(dir $TEMP_CODE_GENERATION_DIR)
  do
    # Remove the old generated code first
    rm -rf $PERM_CODE_GENERATION_DIR/$generatedFolder
    # Now we copy the new generated code
    cp -R $TEMP_CODE_GENERATION_DIR/$generatedFolder $PERM_CODE_GENERATION_DIR
  done
  # Now we delete $TEMP_CODE_GENERATION_DIR
  rm -rf $TEMP_CODE_GENERATION_DIR
  # And now we regenerate the solution
  rm -f Generated.sln
  dotnet new sln --name Generated
  echo $PERM_CODE_GENERATION_DIR/*/*.csproj | xargs dotnet sln Generated.sln add
fi
