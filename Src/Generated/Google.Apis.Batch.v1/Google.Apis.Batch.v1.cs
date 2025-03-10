// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Batch.v1
{
    /// <summary>The Batch Service.</summary>
    public class BatchService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BatchService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BatchService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "batch";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://batch.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://batch.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Batch API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Batch API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Batch requests.</summary>
    public abstract class BatchBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BatchBaseServiceRequest instance.</summary>
        protected BatchBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Batch parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Jobs = new JobsResource(service);
                Operations = new OperationsResource(service);
                State = new StateResource(service);
            }

            /// <summary>Gets the Jobs resource.</summary>
            public virtual JobsResource Jobs { get; }

            /// <summary>The "jobs" collection of methods.</summary>
            public class JobsResource
            {
                private const string Resource = "jobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public JobsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    TaskGroups = new TaskGroupsResource(service);
                }

                /// <summary>Gets the TaskGroups resource.</summary>
                public virtual TaskGroupsResource TaskGroups { get; }

                /// <summary>The "taskGroups" collection of methods.</summary>
                public class TaskGroupsResource
                {
                    private const string Resource = "taskGroups";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TaskGroupsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Tasks = new TasksResource(service);
                    }

                    /// <summary>Gets the Tasks resource.</summary>
                    public virtual TasksResource Tasks { get; }

                    /// <summary>The "tasks" collection of methods.</summary>
                    public class TasksResource
                    {
                        private const string Resource = "tasks";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TasksResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Return a single Task.</summary>
                        /// <param name="name">Required. Task name.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Return a single Task.</summary>
                        public class GetRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Task>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. Task name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/taskGroups/[^/]+/tasks/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List Tasks associated with a job.</summary>
                        /// <param name="parent">
                        /// Required. Name of a TaskGroup from which Tasks are being requested. Pattern:
                        /// "projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}"
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List Tasks associated with a job.</summary>
                        public class ListRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.ListTasksResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of a TaskGroup from which Tasks are being requested. Pattern:
                            /// "projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Task filter, null filter matches all Tasks. Filter string should be of the format
                            /// State=TaskStatus.State e.g. State=RUNNING
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Page size.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Page token.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tasks";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/taskGroups/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }
                }

                /// <summary>Create a Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name where the Job will be created. Pattern:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Batch.v1.Data.Job body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Create a Job.</summary>
                public class CreateRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Job>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Batch.v1.Data.Job body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name where the Job will be created. Pattern:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// ID used to uniquely identify the Job within its parent scope. This field should contain at most
                    /// 63 characters and must start with lowercase characters. Only lowercase characters, numbers and
                    /// '-' are accepted. The '-' character cannot be the first or the last one. A system generated ID
                    /// will be used if the field is not set. The job.name field in the request will be ignored and the
                    /// created resource name of the Job will be "{parent}/jobs/{job_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string JobId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Batch.v1.Data.Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/jobs";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a Job.</summary>
                /// <param name="name">Job name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Delete a Job.</summary>
                public class DeleteRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Job name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Reason for this deletion.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("reason", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Reason { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                        RequestParameters.Add("reason", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reason",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get a Job specified by its resource name.</summary>
                /// <param name="name">Required. Job name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get a Job specified by its resource name.</summary>
                public class GetRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Job name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>List all Jobs for a project within a region.</summary>
                /// <param name="parent">Parent path.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List all Jobs for a project within a region.</summary>
                public class ListRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Parent path.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Sort results. Supported are "name", "name desc", "create_time", and "create_time
                    /// desc".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/jobs";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Batch.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Batch.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Batch.v1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation's parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The standard list filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/operations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the State resource.</summary>
            public virtual StateResource State { get; }

            /// <summary>The "state" collection of methods.</summary>
            public class StateResource
            {
                private const string Resource = "state";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StateResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Report agent's state, e.g. agent status and tasks information</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Format: projects/{project}/locations/{location} {project} should be a project number.
                /// </param>
                public virtual ReportRequest Report(Google.Apis.Batch.v1.Data.ReportAgentStateRequest body, string parent)
                {
                    return new ReportRequest(service, body, parent);
                }

                /// <summary>Report agent's state, e.g. agent status and tasks information</summary>
                public class ReportRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.ReportAgentStateResponse>
                {
                    /// <summary>Constructs a new Report request.</summary>
                    public ReportRequest(Google.Apis.Services.IClientService service, Google.Apis.Batch.v1.Data.ReportAgentStateRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: projects/{project}/locations/{location} {project} should be a project number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Batch.v1.Data.ReportAgentStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "report";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/state:report";

                    /// <summary>Initializes Report parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : BatchBaseServiceRequest<Google.Apis.Batch.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/locations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Batch.v1.Data
{
    /// <summary>Accelerator describes Compute Engine accelerators to be attached to the VM.</summary>
    public class Accelerator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of accelerators of this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// Optional. The NVIDIA GPU driver version that should be installed for this type. You can define the specific
        /// driver version such as "470.103.01", following the driver version requirements in
        /// https://cloud.google.com/compute/docs/gpus/install-drivers-gpu#minimum-driver. Batch will install the
        /// specific accelerator driver if qualified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driverVersion")]
        public virtual string DriverVersion { get; set; }

        /// <summary>Deprecated: please use instances[0].install_gpu_drivers instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installGpuDrivers")]
        public virtual System.Nullable<bool> InstallGpuDrivers { get; set; }

        /// <summary>
        /// The accelerator type. For example, "nvidia-tesla-t4". See `gcloud compute accelerator-types list`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conditions for actions to deal with task failures.</summary>
    public class ActionCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Exit codes of a task execution. If there are more than 1 exit codes, when task executes with any of the exit
        /// code in the list, the condition is met and the action will be executed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ExitCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container runnable representation on the agent side.</summary>
    public class AgentContainer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Overrides the `CMD` specified in the container. If there is an ENTRYPOINT (either in the container image or
        /// with the entrypoint field below) then commands are appended as arguments to the ENTRYPOINT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<string> Commands { get; set; }

        /// <summary>Overrides the `ENTRYPOINT` specified in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>The URI to pull the container image from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Arbitrary additional options to include in the "docker run" command when running this container, e.g.
        /// "--network host".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual string Options { get; set; }

        /// <summary>
        /// Volumes to mount (bind mount) from the host machine files or directories into the container, formatted to
        /// match docker run's --volume option, e.g. /foo:/bar, or /foo:/bar:ro
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<string> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AgentEnvironment is the Environment representation between Agent and CLH communication. The environment is used
    /// in both task level and agent level.
    /// </summary>
    public class AgentEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their
        /// values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedVariables")]
        public virtual AgentKMSEnvMap EncryptedVariables { get; set; }

        /// <summary>
        /// A map of environment variable names to Secret Manager secret names. The VM will access the named secrets to
        /// set the value of each environment variable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretVariables { get; set; }

        /// <summary>A map of environment variable names to values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variables")]
        public virtual System.Collections.Generic.IDictionary<string, string> Variables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM Agent Info.</summary>
    public class AgentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The assigned Job ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        private string _reportTimeRaw;

        private object _reportTime;

        /// <summary>When the AgentInfo is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual string ReportTimeRaw
        {
            get => _reportTimeRaw;
            set
            {
                _reportTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _reportTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReportTimeDateTimeOffset instead.")]
        public virtual object ReportTime
        {
            get => _reportTime;
            set
            {
                _reportTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _reportTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReportTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReportTimeRaw);
            set => ReportTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Agent state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The assigned task group ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskGroupId")]
        public virtual string TaskGroupId { get; set; }

        /// <summary>Task Info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<AgentTaskInfo> Tasks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AgentKMSEnvMap contains the encrypted key/value pair to be used in the environment on the Agent side.
    /// </summary>
    public class AgentKMSEnvMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the cipherText response from the `encrypt` method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cipherText")]
        public virtual string CipherText { get; set; }

        /// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyName")]
        public virtual string KeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM Agent Metadata.</summary>
    public class AgentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>When the VM agent started. Use agent_startup_time instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw
        {
            get => _creationTimeRaw;
            set
            {
                _creationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimeDateTimeOffset instead.")]
        public virtual object CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Full name of the entity that created this vm. For MIG, this path is:
        /// projects/{project}/regions/{region}/InstanceGroupManagers/{igm} The value is retrieved from the vm metadata
        /// key of "created-by".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>image version for the VM that this agent is installed on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersion")]
        public virtual string ImageVersion { get; set; }

        /// <summary>GCP instance name (go/instance-name).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>GCP instance ID (go/instance-id).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual System.Nullable<ulong> InstanceId { get; set; }

        /// <summary>If the GCP instance has received preemption notice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancePreemptionNoticeReceived")]
        public virtual System.Nullable<bool> InstancePreemptionNoticeReceived { get; set; }

        /// <summary>parsed contents of /etc/os-release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osRelease")]
        public virtual System.Collections.Generic.IDictionary<string, string> OsRelease { get; set; }

        /// <summary>agent binary version running on VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>Agent zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Script runnable representation on the agent side.</summary>
    public class AgentScript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Script file path on the host VM. To specify an interpreter, please add a `#!`(also known as [shebang
        /// line](https://en.wikipedia.org/wiki/Shebang_(Unix))) as the first line of the file.(For example, to execute
        /// the script using bash, `#!/bin/bash` should be the first line of the file. To execute the script
        /// using`Python3`, `#!/usr/bin/env python3` should be the first line of the file.) Otherwise, the file will by
        /// default be excuted by `/bin/sh`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Shell script text. To specify an interpreter, please add a `#!\n` at the beginning of the text.(For example,
        /// to execute the script using bash, `#!/bin/bash\n` should be added. To execute the script using`Python3`,
        /// `#!/usr/bin/env python3\n` should be added.) Otherwise, the script will by default be excuted by `/bin/sh`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TODO(b/182501497) The message needs to be redefined when the Agent API server updates data in storage per the
    /// backend design.
    /// </summary>
    public class AgentTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// AgentTaskSpec is the taskSpec representation between Agent and CLH communication. This field will replace
        /// the TaskSpec field above in future to have a better separation between user-facaing API and internal API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentTaskSpec")]
        public virtual AgentTaskSpec AgentTaskSpec { get; set; }

        /// <summary>The intended state of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intendedState")]
        public virtual string IntendedState { get; set; }

        /// <summary>The highest barrier reached by all tasks in the task's TaskGroup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reachedBarrier")]
        public virtual System.Nullable<long> ReachedBarrier { get; set; }

        /// <summary>Task Spec. This field will be replaced by agent_task_spec below in future.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual TaskSpec Spec { get; set; }

        /// <summary>Task status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual TaskStatus Status { get; set; }

        /// <summary>Task name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("task")]
        public virtual string Task { get; set; }

        /// <summary>TaskSource represents the source of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskSource")]
        public virtual string TaskSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Task Info</summary>
    public class AgentTaskInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The highest index of a runnable started by the agent for this task. The runnables are indexed from 1. Value
        /// 0 is undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runnable")]
        public virtual System.Nullable<long> Runnable { get; set; }

        /// <summary>ID of the Task</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskId")]
        public virtual string TaskId { get; set; }

        /// <summary>
        /// The status of the Task. If we need agent specific fields we should fork the public TaskStatus into an agent
        /// specific one. Or add them below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskStatus")]
        public virtual TaskStatus TaskStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AgentTaskRunnable is the Runnable representation between Agent and CLH communication.</summary>
    public class AgentTaskRunnable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, after a Runnable fails, no further Runnable are executed. This flag indicates that this Runnable
        /// must be run even if the Task has already failed. This is useful for Runnables that copy output files off of
        /// the VM or for debugging. The always_run flag does not override the Task's overall max_run_duration. If the
        /// max_run_duration has expired then no further Runnables will execute, not even always_run Runnables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysRun")]
        public virtual System.Nullable<bool> AlwaysRun { get; set; }

        /// <summary>
        /// This flag allows a Runnable to continue running in the background while the Task executes subsequent
        /// Runnables. This is useful to provide services to other Runnables (or to provide debugging support tools like
        /// SSH servers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("background")]
        public virtual System.Nullable<bool> Background { get; set; }

        /// <summary>Container runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual AgentContainer Container { get; set; }

        /// <summary>
        /// Environment variables for this Runnable (overrides variables set for the whole Task or TaskGroup).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual AgentEnvironment Environment { get; set; }

        /// <summary>
        /// Normally, a non-zero exit status causes the Task to fail. This flag allows execution of other Runnables to
        /// continue instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreExitStatus")]
        public virtual System.Nullable<bool> IgnoreExitStatus { get; set; }

        /// <summary>Script runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual AgentScript Script { get; set; }

        /// <summary>Timeout for this Runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AgentTaskSpec is the user's TaskSpec representation between Agent and CLH communication.</summary>
    public class AgentTaskSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environment variables to set before running the Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual AgentEnvironment Environment { get; set; }

        /// <summary>
        /// Maximum duration the task should run. The task will be killed and marked as FAILED if over this limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRunDuration")]
        public virtual object MaxRunDuration { get; set; }

        /// <summary>AgentTaskRunnable is runanbles that will be executed on the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runnables")]
        public virtual System.Collections.Generic.IList<AgentTaskRunnable> Runnables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM timing information</summary>
    public class AgentTimingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _agentStartupTimeRaw;

        private object _agentStartupTime;

        /// <summary>Agent startup time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentStartupTime")]
        public virtual string AgentStartupTimeRaw
        {
            get => _agentStartupTimeRaw;
            set
            {
                _agentStartupTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _agentStartupTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AgentStartupTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AgentStartupTimeDateTimeOffset instead.")]
        public virtual object AgentStartupTime
        {
            get => _agentStartupTime;
            set
            {
                _agentStartupTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _agentStartupTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AgentStartupTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AgentStartupTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(AgentStartupTimeRaw);
            set => AgentStartupTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _bootTimeRaw;

        private object _bootTime;

        /// <summary>Boot timestamp of the VM OS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootTime")]
        public virtual string BootTimeRaw
        {
            get => _bootTimeRaw;
            set
            {
                _bootTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _bootTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BootTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BootTimeDateTimeOffset instead.")]
        public virtual object BootTime
        {
            get => _bootTime;
            set
            {
                _bootTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _bootTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="BootTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BootTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(BootTimeRaw);
            set => BootTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _scriptStartupTimeRaw;

        private object _scriptStartupTime;

        /// <summary>Startup time of the Batch VM script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptStartupTime")]
        public virtual string ScriptStartupTimeRaw
        {
            get => _scriptStartupTimeRaw;
            set
            {
                _scriptStartupTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scriptStartupTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScriptStartupTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScriptStartupTimeDateTimeOffset instead.")]
        public virtual object ScriptStartupTime
        {
            get => _scriptStartupTime;
            set
            {
                _scriptStartupTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scriptStartupTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ScriptStartupTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScriptStartupTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ScriptStartupTimeRaw);
            set => ScriptStartupTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Job's resource allocation policy describes when, where, and how compute resources should be allocated for the
    /// Job.
    /// </summary>
    public class AllocationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describe instances that can be created by this AllocationPolicy. Only instances[0] is supported now.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<InstancePolicyOrTemplate> Instances { get; set; }

        /// <summary>
        /// Labels applied to all VM instances and other resources created by AllocationPolicy. Labels could be user
        /// provided or system generated. You can assign up to 64 labels. [Google Compute Engine label
        /// restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) apply. Label names that
        /// start with "goog-" or "google-" are reserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Location where compute resources should be allocated for the Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LocationPolicy Location { get; set; }

        /// <summary>The network policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual NetworkPolicy Network { get; set; }

        /// <summary>The placement policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placement")]
        public virtual PlacementPolicy Placement { get; set; }

        /// <summary>Service account that VMs will run as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A new or an existing persistent disk (PD) or a local ssd attached to a VM instance.</summary>
    public class AttachedDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device name that the guest operating system will see. It is used by Runnable.volumes field to mount disks.
        /// So please specify the device_name if you want Batch to help mount the disk, and it should match the
        /// device_name field in volumes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>Name of an existing PD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingDisk")]
        public virtual string ExistingDisk { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("newDisk")]
        public virtual Disk NewDisk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Barrier runnable blocks until all tasks in a taskgroup reach it.</summary>
    public class Barrier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Barriers are identified by their index in runnable list. Names are not required, but if present should be an
        /// identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Compute resource requirements. ComputeResource defines the amount of resources required for each task. Make sure
    /// your tasks have enough resources to successfully run. If you also define the types of resources for a job to use
    /// with the
    /// [InstancePolicyOrTemplate](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicyortemplate)
    /// field, make sure both fields are compatible with each other.
    /// </summary>
    public class ComputeResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Extra boot disk size in MiB for each task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskMib")]
        public virtual System.Nullable<long> BootDiskMib { get; set; }

        /// <summary>
        /// The milliCPU count. `cpuMilli` defines the amount of CPU resources per task in milliCPU units. For example,
        /// `1000` corresponds to 1 vCPU per task. If undefined, the default value is `2000`. If you also define the
        /// VM's machine type using the `machineType` in
        /// [InstancePolicy](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicy)
        /// field or inside the `instanceTemplate` in the
        /// [InstancePolicyOrTemplate](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicyortemplate)
        /// field, make sure the CPU resources for both fields are compatible with each other and with how many tasks
        /// you want to allow to run on the same VM at the same time. For example, if you specify the `n2-standard-2`
        /// machine type, which has 2 vCPUs each, you are recommended to set `cpuMilli` no more than `2000`, or you are
        /// recommended to run two tasks on the same VM if you set `cpuMilli` to `1000` or less.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuMilli")]
        public virtual System.Nullable<long> CpuMilli { get; set; }

        /// <summary>
        /// Memory in MiB. `memoryMib` defines the amount of memory per task in MiB units. If undefined, the default
        /// value is `2000`. If you also define the VM's machine type using the `machineType` in
        /// [InstancePolicy](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicy)
        /// field or inside the `instanceTemplate` in the
        /// [InstancePolicyOrTemplate](https://cloud.google.com/batch/docs/reference/rest/v1/projects.locations.jobs#instancepolicyortemplate)
        /// field, make sure the memory resources for both fields are compatible with each other and with how many tasks
        /// you want to allow to run on the same VM at the same time. For example, if you specify the `n2-standard-2`
        /// machine type, which has 8 GiB each, you are recommended to set `memoryMib` to no more than `8192`, or you
        /// are recommended to run two tasks on the same VM if you set `memoryMib` to `4096` or less.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMib")]
        public virtual System.Nullable<long> MemoryMib { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container runnable.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, external network access to and from container will be blocked, containers that are with
        /// block_external_network as true can still communicate with each other, network cannot be specified in the
        /// `container.options` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockExternalNetwork")]
        public virtual System.Nullable<bool> BlockExternalNetwork { get; set; }

        /// <summary>
        /// Overrides the `CMD` specified in the container. If there is an ENTRYPOINT (either in the container image or
        /// with the entrypoint field below) then commands are appended as arguments to the ENTRYPOINT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<string> Commands { get; set; }

        /// <summary>Overrides the `ENTRYPOINT` specified in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>The URI to pull the container image from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Arbitrary additional options to include in the "docker run" command when running this container, e.g.
        /// "--network host".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual string Options { get; set; }

        /// <summary>
        /// Optional password for logging in to a docker registry. If password matches `projects/*/secrets/*/versions/*`
        /// then Batch will read the password from the Secret Manager;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional username for logging in to a docker registry. If username matches `projects/*/secrets/*/versions/*`
        /// then Batch will read the username from the Secret Manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Volumes to mount (bind mount) from the host machine files or directories into the container, formatted to
        /// match docker run's --volume option, e.g. /foo:/bar, or /foo:/bar:ro
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<string> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A new persistent disk or a local ssd. A VM can only have one local SSD setting but multiple local SSD
    /// partitions. See https://cloud.google.com/compute/docs/disks#pdspecs and
    /// https://cloud.google.com/compute/docs/disks#localssds.
    /// </summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Local SSDs are available through both "SCSI" and "NVMe" interfaces. If not indicated, "NVMe" will be the
        /// default one for local ssds. We only support "SCSI" for persistent disks now.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskInterface")]
        public virtual string DiskInterface { get; set; }

        /// <summary>
        /// URL for a VM image to use as the data source for this disk. For example, the following are all valid URLs: *
        /// Specify the image by its family name: projects/{project}/global/images/family/{image_family} * Specify the
        /// image version: projects/{project}/global/images/{image_version} You can also use Batch customized image in
        /// short names. The following image values are supported for a boot disk: * `batch-debian`: use Batch Debian
        /// images. * `batch-centos`: use Batch CentOS images. * `batch-cos`: use Batch Container-Optimized images. *
        /// `batch-hpc-centos`: use Batch HPC CentOS images.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Disk size in GB. For persistent disk, this field is ignored if `data_source` is `image` or `snapshot`. For
        /// local SSD, size_gb should be a multiple of 375GB, otherwise, the final size will be the next greater
        /// multiple of 375 GB. For boot disk, Batch will calculate the boot disk size based on source image and task
        /// requirements if you do not speicify the size. If both this field and the boot_disk_mib field in task spec's
        /// compute_resource are defined, Batch will only honor this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>Name of a snapshot used as the data source. Snapshot is not supported as boot disk now.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual string Snapshot { get; set; }

        /// <summary>
        /// Disk type as shown in `gcloud compute disk-types list`. For example, local SSD uses type "local-ssd".
        /// Persistent disks and boot disks use "pd-balanced", "pd-extreme", "pd-ssd" or "pd-standard".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Environment describes a collection of environment variables to set when executing Tasks.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An encrypted JSON dictionary where the key/value pairs correspond to environment variable names and their
        /// values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedVariables")]
        public virtual KMSEnvMap EncryptedVariables { get; set; }

        /// <summary>
        /// A map of environment variable names to Secret Manager secret names. The VM will access the named secrets to
        /// set the value of each environment variable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretVariables { get; set; }

        /// <summary>A map of environment variable names to values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variables")]
        public virtual System.Collections.Generic.IDictionary<string, string> Variables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Cloud Storage volume.</summary>
    public class GCS : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Remote path, either a bucket name or a subdirectory of a bucket, e.g.: bucket_name,
        /// bucket_name/subdirectory/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remotePath")]
        public virtual string RemotePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// InstancePolicy describes an instance type and resources attached to each VM created by this InstancePolicy.
    /// </summary>
    public class InstancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accelerators attached to each VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<Accelerator> Accelerators { get; set; }

        /// <summary>
        /// Boot disk to be created and attached to each VM by this InstancePolicy. Boot disk will be deleted when the
        /// VM is deleted. Batch API now only supports booting from image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDisk")]
        public virtual Disk BootDisk { get; set; }

        /// <summary>
        /// Non-boot disks to be attached for each VM created by this InstancePolicy. New disks will be deleted when the
        /// VM is deleted. A non-boot disk is a disk that can be of a device with a file system or a raw storage drive
        /// that is not ready for data storage and accessing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<AttachedDisk> Disks { get; set; }

        /// <summary>The Compute Engine machine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// The minimum CPU platform. See https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>The provisioning model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningModel")]
        public virtual string ProvisioningModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// InstancePolicyOrTemplate lets you define the type of resources to use for this job either with an InstancePolicy
    /// or an instance template. If undefined, Batch picks the type of VM to use and doesn't include optional VM
    /// resources such as GPUs and extra disks.
    /// </summary>
    public class InstancePolicyOrTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set this field true if users want Batch to help fetch drivers from a third party location and install them
        /// for GPUs specified in policy.accelerators or instance_template on their behalf. Default is false. For
        /// Container-Optimized Image cases, Batch will install the accelerator driver following milestones of
        /// https://cloud.google.com/container-optimized-os/docs/release-notes. For non Container-Optimized Image cases,
        /// following
        /// https://github.com/GoogleCloudPlatform/compute-gpu-installation/blob/main/linux/install_gpu_driver.py.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installGpuDrivers")]
        public virtual System.Nullable<bool> InstallGpuDrivers { get; set; }

        /// <summary>
        /// Name of an instance template used to create VMs. Named the field as 'instance_template' instead of
        /// 'template' to avoid c++ keyword conflict.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceTemplate")]
        public virtual string InstanceTemplate { get; set; }

        /// <summary>InstancePolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual InstancePolicy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM instance status.</summary>
    public class InstanceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The VM boot disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDisk")]
        public virtual Disk BootDisk { get; set; }

        /// <summary>The Compute Engine machine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The VM instance provisioning model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningModel")]
        public virtual string ProvisioningModel { get; set; }

        /// <summary>The max number of tasks can be assigned to this instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskPack")]
        public virtual System.Nullable<long> TaskPack { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Cloud Batch Job description.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compute resource allocation for all TaskGroups in the Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocationPolicy")]
        public virtual AllocationPolicy AllocationPolicy { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the Job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Labels for the Job. Labels could be user provided or system generated. For example, "labels": {
        /// "department": "finance", "environment": "test" } You can assign up to 64 labels. [Google Compute Engine
        /// label restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) apply. Label
        /// names that start with "goog-" or "google-" are reserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Log preservation policy for the Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsPolicy")]
        public virtual LogsPolicy LogsPolicy { get; set; }

        /// <summary>Output only. Job name. For example: "projects/123456/locations/us-central1/jobs/job01".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notification configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifications")]
        public virtual System.Collections.Generic.IList<JobNotification> Notifications { get; set; }

        /// <summary>
        /// Priority of the Job. The valid value range is [0, 100). Default value is 0. Higher value indicates higher
        /// priority. A job with higher priority value is more likely to run earlier if all other requirements are
        /// satisfied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<long> Priority { get; set; }

        /// <summary>Output only. Job status. It is read only for users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>Required. TaskGroups in the Job. Only one TaskGroup is supported now.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskGroups")]
        public virtual System.Collections.Generic.IList<TaskGroup> TaskGroups { get; set; }

        /// <summary>Output only. A system generated unique ID (in UUID4 format) for the Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time the Job was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Notification configurations.</summary>
    public class JobNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The attribute requirements of messages to be sent to this Pub/Sub topic. Without this field, no message will
        /// be sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>
        /// The Pub/Sub topic where notifications like the job state changes will be published. The topic must exist in
        /// the same project as the job and billings will be charged to this project. If not specified, no Pub/Sub
        /// messages will be sent. Topic format: `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job status.</summary>
    public class JobStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of time that the Job spent in status RUNNING.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runDuration")]
        public virtual object RunDuration { get; set; }

        /// <summary>Job state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Job status events</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusEvents")]
        public virtual System.Collections.Generic.IList<StatusEvent> StatusEvents { get; set; }

        /// <summary>Aggregated task status for each TaskGroup in the Job. The map key is TaskGroup ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskGroups")]
        public virtual System.Collections.Generic.IDictionary<string, TaskGroupStatus> TaskGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class KMSEnvMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the cipherText response from the `encrypt` method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cipherText")]
        public virtual string CipherText { get; set; }

        /// <summary>The name of the KMS key that will be used to decrypt the cipher text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyName")]
        public virtual string KeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LifecyclePolicy describes how to deal with task failures based on different conditions.</summary>
    public class LifecyclePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Action to execute when ActionCondition is true. When RETRY_TASK is specified, we will retry failed tasks if
        /// we notice any exit code match and fail tasks if no match is found. Likewise, when FAIL_TASK is specified, we
        /// will fail tasks if we notice any exit code match and retry tasks if no match is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Conditions that decide why a task failure is dealt with a specific action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionCondition")]
        public virtual ActionCondition ActionCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListJob Response.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListTasks Response.</summary>
    public class ListTasksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<Task> Tasks { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LocationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of allowed location names represented by internal URLs. Each location can be a region or a zone. Only
        /// one region or multiple zones in one region is supported now. For example, ["regions/us-central1"] allow VMs
        /// in any zones in region us-central1. ["zones/us-central1-a", "zones/us-central1-c"] only allow VMs in zones
        /// us-central1-a and us-central1-c. All locations end up in different regions would cause errors. For example,
        /// ["regions/us-central1", "zones/us-central1-a", "zones/us-central1-b", "zones/us-west1-a"] contains 2 regions
        /// "us-central1" and "us-west1". An error is expected in this case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedLocations")]
        public virtual System.Collections.Generic.IList<string> AllowedLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LogsPolicy describes how outputs from a Job's Tasks (stdout/stderr) will be preserved.</summary>
    public class LogsPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Where logs should be saved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>
        /// The path to which logs are saved when the destination = PATH. This can be a local file path on the VM, or
        /// under the mount point of a Persistent Disk or Filestore, or a Cloud Storage path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsPath")]
        public virtual string LogsPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message details. Describe the conditions under which messages will be sent. If no attribute is defined, no
    /// message will be sent by default. One message should specify either the job or the task level attributes, but not
    /// both. For example, job level: JOB_STATE_CHANGED and/or a specified new_job_state; task level: TASK_STATE_CHANGED
    /// and/or a specified new_task_state.
    /// </summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new job state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newJobState")]
        public virtual string NewJobState { get; set; }

        /// <summary>The new task state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTaskState")]
        public virtual string NewTaskState { get; set; }

        /// <summary>The message type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an NFS volume.</summary>
    public class NFS : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Remote source path exported from the NFS, e.g., "/share".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remotePath")]
        public virtual string RemotePath { get; set; }

        /// <summary>The IP address of the NFS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("server")]
        public virtual string Server { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network interface.</summary>
    public class NetworkInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The URL of an existing network resource. You can specify the network as a full or partial URL. For example,
        /// the following are all valid URLs: *
        /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network} *
        /// projects/{project}/global/networks/{network} * global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Default is false (with an external IP address). Required if no external public IP address is attached to the
        /// VM. If no external public IP address, additional configuration is required to allow the VM to access Google
        /// Services. See https://cloud.google.com/vpc/docs/configure-private-google-access and
        /// https://cloud.google.com/nat/docs/gce-example#create-nat for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noExternalIpAddress")]
        public virtual System.Nullable<bool> NoExternalIpAddress { get; set; }

        /// <summary>
        /// The URL of an existing subnetwork resource in the network. You can specify the subnetwork as a full or
        /// partial URL. For example, the following are all valid URLs: *
        /// https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetwork} *
        /// projects/{project}/regions/{region}/subnetworks/{subnetwork} * regions/{region}/subnetworks/{subnetwork}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NetworkPolicy describes VM instance network configurations.</summary>
    public class NetworkPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PlacementPolicy describes a group placement policy for the VMs controlled by this AllocationPolicy.
    /// </summary>
    public class PlacementPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// UNSPECIFIED vs. COLLOCATED (default UNSPECIFIED). Use COLLOCATED when you want VMs to be located close to
        /// each other for low network latency between the VMs. No placement policy will be generated when collocation
        /// is UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collocation")]
        public virtual string Collocation { get; set; }

        /// <summary>
        /// When specified, causes the job to fail if more than max_distance logical switches are required between VMs.
        /// Batch uses the most compact possible placement of VMs even when max_distance is not specified. An explicit
        /// max_distance makes that level of compactness a strict requirement. Not yet implemented
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDistance")]
        public virtual System.Nullable<long> MaxDistance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to report agent's state. The Request itself implies the agent is healthy.</summary>
    public class ReportAgentStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Agent info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentInfo")]
        public virtual AgentInfo AgentInfo { get; set; }

        /// <summary>Agent timing info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentTimingInfo")]
        public virtual AgentTimingInfo AgentTimingInfo { get; set; }

        /// <summary>Agent metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual AgentMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to ReportAgentStateRequest.</summary>
    public class ReportAgentStateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default report interval override</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultReportInterval")]
        public virtual object DefaultReportInterval { get; set; }

        /// <summary>Minimum report interval override</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minReportInterval")]
        public virtual object MinReportInterval { get; set; }

        /// <summary>Tasks assigned to the agent</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<AgentTask> Tasks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Runnable describes instructions for executing a specific script or container as part of a Task.
    /// </summary>
    public class Runnable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, after a Runnable fails, no further Runnable are executed. This flag indicates that this Runnable
        /// must be run even if the Task has already failed. This is useful for Runnables that copy output files off of
        /// the VM or for debugging. The always_run flag does not override the Task's overall max_run_duration. If the
        /// max_run_duration has expired then no further Runnables will execute, not even always_run Runnables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysRun")]
        public virtual System.Nullable<bool> AlwaysRun { get; set; }

        /// <summary>
        /// This flag allows a Runnable to continue running in the background while the Task executes subsequent
        /// Runnables. This is useful to provide services to other Runnables (or to provide debugging support tools like
        /// SSH servers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("background")]
        public virtual System.Nullable<bool> Background { get; set; }

        /// <summary>Barrier runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barrier")]
        public virtual Barrier Barrier { get; set; }

        /// <summary>Container runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual Container Container { get; set; }

        /// <summary>
        /// Environment variables for this Runnable (overrides variables set for the whole Task or TaskGroup).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>
        /// Normally, a non-zero exit status causes the Task to fail. This flag allows execution of other Runnables to
        /// continue instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreExitStatus")]
        public virtual System.Nullable<bool> IgnoreExitStatus { get; set; }

        /// <summary>Labels for this Runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Script runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual Script Script { get; set; }

        /// <summary>Timeout for this Runnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Script runnable.</summary>
    public class Script : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Script file path on the host VM. To specify an interpreter, please add a `#!`(also known as [shebang
        /// line](https://en.wikipedia.org/wiki/Shebang_(Unix))) as the first line of the file.(For example, to execute
        /// the script using bash, `#!/bin/bash` should be the first line of the file. To execute the script
        /// using`Python3`, `#!/usr/bin/env python3` should be the first line of the file.) Otherwise, the file will by
        /// default be excuted by `/bin/sh`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Shell script text. To specify an interpreter, please add a `#!\n` at the beginning of the text.(For example,
        /// to execute the script using bash, `#!/bin/bash\n` should be added. To execute the script using`Python3`,
        /// `#!/usr/bin/env python3\n` should be added.) Otherwise, the script will by default be excuted by `/bin/sh`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a Google Cloud service account.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Email address of the service account. If not specified, the default Compute Engine service account for the
        /// project will be used. If instance template is being used, the service account has to be specified in the
        /// instance template and it has to match the email field here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// List of scopes to be enabled for this service account on the VM, in addition to the cloud-platform API scope
        /// that will be added by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status event</summary>
    public class StatusEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>The time this event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Task Execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecution")]
        public virtual TaskExecution TaskExecution { get; set; }

        /// <summary>Task State</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskState")]
        public virtual string TaskState { get; set; }

        /// <summary>Type of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Batch task.</summary>
    public class Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Task name. The name is generated from the parent TaskGroup name and 'id' field. For example:
        /// "projects/123456/locations/us-west1/jobs/job01/taskGroups/group01/tasks/task01".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Task Status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual TaskStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This Task Execution field includes detail information for task execution procedures, based on StatusEvent types.
    /// </summary>
    public class TaskExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When task is completed as the status of FAILED or SUCCEEDED, exit code is for one task execution result,
        /// default is 0 as success.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A TaskGroup defines one or more Tasks that all share the same TaskSpec.</summary>
    public class TaskGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. TaskGroup name. The system generates this field based on parent Job name. For example:
        /// "projects/123456/locations/us-west1/jobs/job01/taskGroups/group01".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Max number of tasks that can run in parallel. Default to min(task_count, 1000). Field parallelism must be 1
        /// if the scheduling_policy is IN_ORDER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<long> Parallelism { get; set; }

        /// <summary>
        /// When true, Batch will configure SSH to allow passwordless login between VMs running the Batch tasks in the
        /// same TaskGroup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissiveSsh")]
        public virtual System.Nullable<bool> PermissiveSsh { get; set; }

        /// <summary>
        /// When true, Batch will populate a file with a list of all VMs assigned to the TaskGroup and set the
        /// BATCH_HOSTS_FILE environment variable to the path of that file. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireHostsFile")]
        public virtual System.Nullable<bool> RequireHostsFile { get; set; }

        /// <summary>Scheduling policy for Tasks in the TaskGroup. The default value is AS_SOON_AS_POSSIBLE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedulingPolicy")]
        public virtual string SchedulingPolicy { get; set; }

        /// <summary>Number of Tasks in the TaskGroup. Default is 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<long> TaskCount { get; set; }

        /// <summary>
        /// Max number of tasks that can be run on a VM at the same time. If not specified, the system will decide a
        /// value based on available compute resources on a VM and task requirements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCountPerNode")]
        public virtual System.Nullable<long> TaskCountPerNode { get; set; }

        /// <summary>
        /// An array of environment variable mappings, which are passed to Tasks with matching indices. If
        /// task_environments is used then task_count should not be specified in the request (and will be ignored). Task
        /// count will be the length of task_environments. Tasks get a BATCH_TASK_INDEX and BATCH_TASK_COUNT environment
        /// variable, in addition to any environment variables set in task_environments, specifying the number of Tasks
        /// in the Task's parent TaskGroup, and the specific Task's index in the TaskGroup (0 through BATCH_TASK_COUNT -
        /// 1).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskEnvironments")]
        public virtual System.Collections.Generic.IList<Environment> TaskEnvironments { get; set; }

        /// <summary>Required. Tasks in the group share the same task spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskSpec")]
        public virtual TaskSpec TaskSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated task status for a TaskGroup.</summary>
    public class TaskGroupStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of task in each state in the TaskGroup. The map key is task state name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counts")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Counts { get; set; }

        /// <summary>Status of instances allocated for the TaskGroup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<InstanceStatus> Instances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Spec of a task</summary>
    public class TaskSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ComputeResource requirements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeResource")]
        public virtual ComputeResource ComputeResource { get; set; }

        /// <summary>Environment variables to set before running the Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>Deprecated: please use environment(non-plural) instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IDictionary<string, string> Environments { get; set; }

        /// <summary>
        /// Lifecycle management schema when any task in a task group is failed. Currently we only support one lifecycle
        /// policy. When the lifecycle policy condition is met, the action in the policy will execute. If task execution
        /// result does not meet with the defined lifecycle policy, we consider it as the default policy. Default policy
        /// means if the exit code is 0, exit task. If task ends with non-zero exit code, retry the task with
        /// max_retry_count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecyclePolicies")]
        public virtual System.Collections.Generic.IList<LifecyclePolicy> LifecyclePolicies { get; set; }

        /// <summary>
        /// Maximum number of retries on failures. The default, 0, which means never retry. The valid value range is [0,
        /// 10].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetryCount")]
        public virtual System.Nullable<int> MaxRetryCount { get; set; }

        /// <summary>
        /// Maximum duration the task should run. The task will be killed and marked as FAILED if over this limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRunDuration")]
        public virtual object MaxRunDuration { get; set; }

        /// <summary>
        /// The sequence of scripts or containers to run for this Task. Each Task using this TaskSpec executes its list
        /// of runnables in order. The Task succeeds if all of its runnables either exit with a zero status or any that
        /// exit with a non-zero status have the ignore_exit_status flag. Background runnables are killed automatically
        /// (if they have not already exited) a short time after all foreground runnables have completed. Even though
        /// this is likely to result in a non-zero exit status for the background runnable, these automatic kills are
        /// not treated as Task failures.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runnables")]
        public virtual System.Collections.Generic.IList<Runnable> Runnables { get; set; }

        /// <summary>Volumes to mount before running Tasks using this TaskSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of a task</summary>
    public class TaskStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Task state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Detailed info about why the state is reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusEvents")]
        public virtual System.Collections.Generic.IList<StatusEvent> StatusEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume describes a volume and parameters for it to be mounted to a VM.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device name of an attached disk volume, which should align with a device_name specified by
        /// job.allocation_policy.instances[0].policy.disks[i].device_name or defined by the given instance template in
        /// job.allocation_policy.instances[0].instance_template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>A Google Cloud Storage (GCS) volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcs")]
        public virtual GCS Gcs { get; set; }

        /// <summary>
        /// For Google Cloud Storage (GCS), mount options are the options supported by the gcsfuse tool
        /// (https://github.com/GoogleCloudPlatform/gcsfuse). For existing persistent disks, mount options provided by
        /// the mount command (https://man7.org/linux/man-pages/man8/mount.8.html) except writing are supported. This is
        /// due to restrictions of multi-writer mode
        /// (https://cloud.google.com/compute/docs/disks/sharing-disks-between-vms). For other attached disks and
        /// Network File System (NFS), mount options are these supported by the mount command
        /// (https://man7.org/linux/man-pages/man8/mount.8.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountOptions")]
        public virtual System.Collections.Generic.IList<string> MountOptions { get; set; }

        /// <summary>The mount path for the volume, e.g. /mnt/disks/share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

        /// <summary>A Network File System (NFS) volume. For example, a Filestore file share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfs")]
        public virtual NFS Nfs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
