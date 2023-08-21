﻿/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Json;
using Google.Apis.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Google.Apis.Util
{
    /// <summary>A utility class which contains helper methods and extension methods.</summary>
    public static class Utilities
    {
        private static readonly JsonSerializerSettings s_serializerSettingsWithoutDateParsing = new JsonSerializerSettings { DateParseHandling = DateParseHandling.None };

        /// <summary>Returns the version of the core library.</summary>
        [VisibleForTestOnly]
        public static string GetLibraryVersion()
        {
            return Regex.Match(typeof(Utilities).GetTypeInfo().Assembly.FullName, "Version=([\\d\\.]+)").Groups[1].ToString();
        }

        /// <summary>
        /// A Google.Apis utility method for throwing an <see cref="System.ArgumentNullException"/> if the object is
        /// <c>null</c>.
        /// </summary>
        public static T ThrowIfNull<T>(this T obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }

            return obj;
        }

        /// <summary>
        /// A Google.Apis utility method for throwing an <see cref="System.ArgumentNullException"/> if the string is
        /// <c>null</c> or empty.
        /// </summary>
        /// <returns>The original string.</returns>
        public static string ThrowIfNullOrEmpty(this string str, string paramName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Parameter was empty", paramName);
            }
            return str;
        }

        /// <summary>Returns <c>true</c> in case the enumerable is <c>null</c> or empty.</summary>
        internal static bool IsNullOrEmpty<T>(this IEnumerable<T> coll)
        {
            return coll == null || coll.Count() == 0;
        }

        /// <summary>
        /// Checks that the given value is in fact defined in the enum used as the type argument of the method.
        /// </summary>
        /// <typeparam name="T">The enum type to check the value within.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="paramName">The name of the parameter whose value is being tested.</param>
        /// <returns><paramref name="value"/> if it was a defined value</returns>
        public static T CheckEnumValue<T>(T value, string paramName) where T : struct
        {
            CheckArgument(
                Enum.IsDefined(typeof(T), value),
                paramName,
                "Value {0} not defined in enum {1}", value, typeof(T).Name);
            return value;
        }

        /// <summary>
        /// Checks that given argument-based condition is met, throwing an <see cref="ArgumentException"/> otherwise.
        /// </summary>
        /// <param name="condition">The (already evaluated) condition to check.</param>
        /// <param name="paramName">The name of the parameter whose value is being tested.</param>
        /// <param name="format">The format string to use to create the exception message if the
        /// condition is not met.</param>
        /// <param name="arg0">The first argument to the format string.</param>
        /// <param name="arg1">The second argument to the format string.</param>
        public static void CheckArgument<T1, T2>(bool condition, string paramName, string format, T1 arg0, T2 arg1)
        {
            if (!condition)
            {
                throw new ArgumentException(string.Format(format, arg0, arg1), paramName);
            }
        }

        /// <summary>
        /// A Google.Apis utility method for returning the first matching custom attribute (or <c>null</c>) of the specified member.
        /// </summary>
        public static T GetCustomAttribute<T>(this MemberInfo info) where T : Attribute
        {
            object[] results = info.GetCustomAttributes(typeof(T), false).ToArray();
            return results.Length == 0 ? null : (T)results[0];
        }

        /// <summary>Returns the defined string value of an Enum.</summary>
        internal static string GetStringValue(this Enum value)
        {
            FieldInfo entry = value.GetType().GetField(value.ToString());
            entry.ThrowIfNull("value");

            // If set, return the value.
            var attribute = entry.GetCustomAttribute<StringValueAttribute>();
            if (attribute != null)
            {
                return attribute.Text;
            }

            // Otherwise, throw an exception.
            throw new ArgumentException(
                string.Format("Enum value '{0}' does not contain a StringValue attribute", entry), "value");
        }

        /// <summary>
        /// Returns the defined string value of an Enum. Use for test purposes or in other Google.Apis projects.
        /// </summary>
        public static string GetEnumStringValue(Enum value)
        {
            return value.GetStringValue();
        }

        /// <summary>
        /// Tries to convert the specified object to a string. Uses custom type converters if available.
        /// Returns null for a null object.
        /// </summary>
        [VisibleForTestOnly]
        public static string ConvertToString(object o)
        {
            if (o == null)
            {
                return null;
            }

            if (o.GetType().GetTypeInfo().IsEnum)
            {
                // Try to convert the Enum value using the StringValue attribute.
                var enumType = o.GetType();
                FieldInfo field = enumType.GetField(o.ToString());
                StringValueAttribute attribute = field.GetCustomAttribute<StringValueAttribute>();
                return attribute != null ? attribute.Text : o.ToString();
            }

            if (o is DateTime)
            {
                // Honor RFC3339.
                return ConvertToRFC3339((DateTime)o);
            }

            if (o is bool)
            {
                return o.ToString().ToLowerInvariant();
            }

            return o.ToString();
        }

        /// <summary>Converts the input date into a RFC3339 string (http://www.ietf.org/rfc/rfc3339.txt).</summary>
        internal static string ConvertToRFC3339(DateTime date)
        {
            if (date.Kind == DateTimeKind.Unspecified)
            {
                date = date.ToUniversalTime();
            }
            return date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Parses the input string and returns <see cref="System.DateTime"/> if the input is a valid 
        /// representation of a date. Otherwise it returns <c>null</c>.
        /// </summary>
        public static DateTime? GetDateTimeFromString(string raw)
        {
            DateTime result;
            if (!DateTime.TryParse(raw, out result))
            {
                return null;
            }
            return result;
        }

        /// <summary>Returns a string (by RFC3339) form the input <see cref="DateTime"/> instance.</summary>
        public static string GetStringFromDateTime(DateTime? date)
        {
            if (!date.HasValue)
            {
                return null;
            }
            return ConvertToRFC3339(date.Value);
        }

        /// <summary>
        /// Parses the input string and returns <see cref="System.DateTimeOffset"/> if the input is
        /// of the format "yyyy-MM-ddTHH:mm:ss.FFFZ" or "yyyy-MM-ddTHH:mm:ssZ". If the input is null,
        /// this method returns <c>null</c>. Otherwise, <see cref="FormatException"/> is thrown.
        /// </summary>
        public static DateTimeOffset? GetDateTimeOffsetFromString(string raw) =>
            raw is null
            ? (DateTimeOffset?) null
            : DateTimeOffset.ParseExact(raw, "yyyy-MM-dd'T'HH:mm:ss.FFF'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);

        /// <summary>
        /// Returns a string from the input <see cref="DateTimeOffset"/> instance, or <c>null</c> if
        /// <paramref name="date"/> is null. The string is always in the format "yyyy-MM-ddTHH:mm:ss.fffZ" or
        /// "yyyy-MM-ddTHH:mm:ssZ" - always UTC, always either second or millisecond precision, and always using the
        /// invariant culture.
        /// </summary>
        public static string GetStringFromDateTimeOffset(DateTimeOffset? date) =>
            date is null
            ? null
            // While FFF sounds like it should work, we really want to produce no subsecond parts or 3 digits.
            : date.Value.Millisecond == 0 ? date.Value.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture)
            : date.Value.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture);

        /// <summary>
        /// Deserializes the given raw value to an object using <see cref="NewtonsoftJsonSerializer.Instance"/>,
        /// as if it were a JSON string value.
        /// </summary>
        /// <param name="rawValue">The string value to deserialize. May be null, in which case null is returned.</param>
        /// <returns>The deserialized value.</returns>
        public static object DeserializeForGoogleFormat(string rawValue)
        {
            if (rawValue is null)
            {
                return null;
            }
            // We need to encode the string as JSON - add quotes round it, escape backslashes etc.
            string json = JsonConvert.SerializeObject(rawValue);
            return NewtonsoftJsonSerializer.Instance.Deserialize<object>(json);
        }

        /// <summary>
        /// Serializes the given value using <see cref="NewtonsoftJsonSerializer.Instance"/>.
        /// </summary>
        /// <param name="value">The value to serialize. May be null, in which case null is returned.</param>
        /// <returns>The string representation of the object.</returns>
        /// <exception cref="ArgumentException">The value does not serialize to a JSON string.</exception>
        public static string SerializeForGoogleFormat(object value)
        {
            if (value is null)
            {
                return null;
            }
            var json = NewtonsoftJsonSerializer.Instance.Serialize(value);
            if (json is null || json.Length < 2 || !json.StartsWith("\"") || !json.EndsWith("\""))
            {
                throw new ArgumentException("Value did not serialize to a JSON string.");
            }
            // Okay, so we have a JSON string. Now we need to parse it to retrieve the actual string value,
            // with no conversion to DateTime etc.
            return JsonConvert.DeserializeObject<string>(json, s_serializerSettingsWithoutDateParsing);
        }
    }
}
