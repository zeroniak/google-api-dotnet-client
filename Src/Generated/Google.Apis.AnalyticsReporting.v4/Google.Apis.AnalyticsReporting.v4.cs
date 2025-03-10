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

namespace Google.Apis.AnalyticsReporting.v4
{
    /// <summary>The AnalyticsReporting Service.</summary>
    public class AnalyticsReportingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AnalyticsReportingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AnalyticsReportingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Reports = new ReportsResource(this);
            UserActivity = new UserActivityResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "analyticsreporting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://analyticsreporting.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://analyticsreporting.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Analytics Reporting API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Analytics data</summary>
            public static string Analytics = "https://www.googleapis.com/auth/analytics";

            /// <summary>See and download your Google Analytics data</summary>
            public static string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Analytics Reporting API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Analytics data</summary>
            public const string Analytics = "https://www.googleapis.com/auth/analytics";

            /// <summary>See and download your Google Analytics data</summary>
            public const string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>Gets the UserActivity resource.</summary>
        public virtual UserActivityResource UserActivity { get; }
    }

    /// <summary>A base abstract class for AnalyticsReporting requests.</summary>
    public abstract class AnalyticsReportingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AnalyticsReportingBaseServiceRequest instance.</summary>
        protected AnalyticsReportingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AnalyticsReporting parameter list.</summary>
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

    /// <summary>The "reports" collection of methods.</summary>
    public class ReportsResource
    {
        private const string Resource = "reports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns the Analytics data.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchGetRequest BatchGet(Google.Apis.AnalyticsReporting.v4.Data.GetReportsRequest body)
        {
            return new BatchGetRequest(service, body);
        }

        /// <summary>Returns the Analytics data.</summary>
        public class BatchGetRequest : AnalyticsReportingBaseServiceRequest<Google.Apis.AnalyticsReporting.v4.Data.GetReportsResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsReporting.v4.Data.GetReportsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsReporting.v4.Data.GetReportsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/reports:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "userActivity" collection of methods.</summary>
    public class UserActivityResource
    {
        private const string Resource = "userActivity";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UserActivityResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns User Activity data.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.AnalyticsReporting.v4.Data.SearchUserActivityRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>Returns User Activity data.</summary>
        public class SearchRequest : AnalyticsReportingBaseServiceRequest<Google.Apis.AnalyticsReporting.v4.Data.SearchUserActivityResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsReporting.v4.Data.SearchUserActivityRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsReporting.v4.Data.SearchUserActivityRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/userActivity:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.AnalyticsReporting.v4.Data
{
    /// <summary>
    /// An Activity represents data for an activity of a user. Note that an Activity is different from a hit. A hit
    /// might result in multiple Activity's. For example, if a hit includes a transaction and a goal completion, there
    /// will be two Activity protos for this hit, one for ECOMMERCE and one for GOAL. Conversely, multiple hits can also
    /// construct one Activity. In classic e-commerce, data for one transaction might be sent through multiple hits.
    /// These hits will be merged into one ECOMMERCE Activity.
    /// </summary>
    public class Activity : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _activityTimeRaw;

        private object _activityTime;

        /// <summary>
        /// Timestamp of the activity. If activities for a visit cross midnight and occur in two separate dates, then
        /// two sessions (one per date) share the session identifier. For example, say session ID 113472 has activity
        /// within 2019-08-20, and session ID 243742 has activity within 2019-08-25 and 2019-08-26. Session ID 113472 is
        /// one session, and session ID 243742 is two sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityTime")]
        public virtual string ActivityTimeRaw
        {
            get => _activityTimeRaw;
            set
            {
                _activityTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _activityTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ActivityTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ActivityTimeDateTimeOffset instead.")]
        public virtual object ActivityTime
        {
            get => _activityTime;
            set
            {
                _activityTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _activityTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ActivityTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ActivityTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ActivityTimeRaw);
            set => ActivityTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Type of this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityType")]
        public virtual string ActivityType { get; set; }

        /// <summary>This will be set if `activity_type` equals `SCREEN_VIEW`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appview")]
        public virtual ScreenviewData Appview { get; set; }

        /// <summary>
        /// For manual campaign tracking, it is the value of the utm_campaign campaign tracking parameter. For AdWords
        /// autotagging, it is the name(s) of the online ad campaign(s) you use for the property. If you use neither,
        /// its value is (not set).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual string Campaign { get; set; }

        /// <summary>
        /// The Channel Group associated with an end user's session for this View (defined by the View's Channel
        /// Groupings).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelGrouping")]
        public virtual string ChannelGrouping { get; set; }

        /// <summary>A list of all custom dimensions associated with this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimension")]
        public virtual System.Collections.Generic.IList<CustomDimension> CustomDimension { get; set; }

        /// <summary>This will be set if `activity_type` equals `ECOMMERCE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecommerce")]
        public virtual EcommerceData Ecommerce { get; set; }

        /// <summary>
        /// This field contains all the details pertaining to an event and will be set if `activity_type` equals
        /// `EVENT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual EventData Event__ { get; set; }

        /// <summary>
        /// This field contains a list of all the goals that were reached in this activity when `activity_type` equals
        /// `GOAL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goals")]
        public virtual GoalSetData Goals { get; set; }

        /// <summary>The hostname from which the tracking request was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>
        /// For manual campaign tracking, it is the value of the utm_term campaign tracking parameter. For AdWords
        /// traffic, it contains the best matching targeting criteria. For the display network, where multiple targeting
        /// criteria could have caused the ad to show up, it returns the best matching targeting criteria as selected by
        /// Ads. This could be display_keyword, site placement, boomuserlist, user_interest, age, or gender. Otherwise
        /// its value is (not set).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyword")]
        public virtual string Keyword { get; set; }

        /// <summary>The first page in users' sessions, or the landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landingPagePath")]
        public virtual string LandingPagePath { get; set; }

        /// <summary>
        /// The type of referrals. For manual campaign tracking, it is the value of the utm_medium campaign tracking
        /// parameter. For AdWords autotagging, it is cpc. If users came from a search engine detected by Google
        /// Analytics, it is organic. If the referrer is not a search engine, it is referral. If users came directly to
        /// the property and document.referrer is empty, its value is (none).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>
        /// This will be set if `activity_type` equals `PAGEVIEW`. This field contains all the details about the visitor
        /// and the page that was visited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageview")]
        public virtual PageviewData Pageview { get; set; }

        /// <summary>
        /// The source of referrals. For manual campaign tracking, it is the value of the utm_source campaign tracking
        /// parameter. For AdWords autotagging, it is google. If you use neither, it is the domain of the source (e.g.,
        /// document.referrer) referring the users. It may also contain a port address. If users arrived without a
        /// referrer, its value is (direct).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a cohort. A cohort is a group of users who share a common characteristic. For example, all users with
    /// the same acquisition date belong to the same cohort.
    /// </summary>
    public class Cohort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is used for `FIRST_VISIT_DATE` cohort, the cohort selects users whose first visit date is between start
        /// date and end date defined in the DateRange. The date ranges should be aligned for cohort requests. If the
        /// request contains `ga:cohortNthDay` it should be exactly one day long, if `ga:cohortNthWeek` it should be
        /// aligned to the week boundary (starting at Sunday and ending Saturday), and for `ga:cohortNthMonth` the date
        /// range should be aligned to the month (starting at the first and ending on the last day of the month). For
        /// LTV requests there are no such restrictions. You do not need to supply a date range for the
        /// `reportsRequest.dateRanges` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// A unique name for the cohort. If not defined name will be auto-generated with values cohort_[1234...].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Type of the cohort. The only supported type as of now is `FIRST_VISIT_DATE`. If this field is unspecified
        /// the cohort is treated as `FIRST_VISIT_DATE` type cohort.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a cohort group. For example: "cohortGroup": { "cohorts": [{ "name": "cohort 1", "type":
    /// "FIRST_VISIT_DATE", "dateRange": { "startDate": "2015-08-01", "endDate": "2015-08-01" } },{ "name": "cohort 2"
    /// "type": "FIRST_VISIT_DATE" "dateRange": { "startDate": "2015-07-01", "endDate": "2015-07-01" } }] }
    /// </summary>
    public class CohortGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition for the cohort.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohorts")]
        public virtual System.Collections.Generic.IList<Cohort> Cohorts { get; set; }

        /// <summary>
        /// Enable Life Time Value (LTV). LTV measures lifetime value for users acquired through different channels.
        /// Please see: [Cohort Analysis](https://support.google.com/analytics/answer/6074676) and [Lifetime
        /// Value](https://support.google.com/analytics/answer/6182550) If the value of lifetimeValue is false: - The
        /// metric values are similar to the values in the web interface cohort report. - The cohort definition date
        /// ranges must be aligned to the calendar week and month. i.e. while requesting `ga:cohortNthWeek` the
        /// `startDate` in the cohort definition should be a Sunday and the `endDate` should be the following Saturday,
        /// and for `ga:cohortNthMonth`, the `startDate` should be the 1st of the month and `endDate` should be the last
        /// day of the month. When the lifetimeValue is true: - The metric values will correspond to the values in the
        /// web interface LifeTime value report. - The Lifetime Value report shows you how user value (Revenue) and
        /// engagement (Appviews, Goal Completions, Sessions, and Session Duration) grow during the 90 days after a user
        /// is acquired. - The metrics are calculated as a cumulative average per user per the time increment. - The
        /// cohort definition date ranges need not be aligned to the calendar week and month boundaries. - The `viewId`
        /// must be an [app view ID](https://support.google.com/analytics/answer/2649553#WebVersusAppViews)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetimeValue")]
        public virtual System.Nullable<bool> LifetimeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Column headers.</summary>
    public class ColumnHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension names in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Metric headers for the metrics in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeader")]
        public virtual MetricHeader MetricHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom dimension.</summary>
    public class CustomDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Slot number of custom dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Value of the custom dimension. Default value (i.e. empty string) indicates clearing sesion/visitor scope
        /// custom dimension value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A contiguous set of days: startDate, startDate + 1 day, ..., endDate. The start and end dates are specified in
    /// [ISO8601](https://en.wikipedia.org/wiki/ISO_8601) date format `YYYY-MM-DD`.
    /// </summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end date for the query in the format `YYYY-MM-DD`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>The start date for the query in the format `YYYY-MM-DD`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to return a list of metrics for a single DateRange / dimension combination</summary>
    public class DateRangeValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values of each pivot region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotValueRegions")]
        public virtual System.Collections.Generic.IList<PivotValueRegion> PivotValueRegions { get; set; }

        /// <summary>Each value corresponds to each Metric in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Dimensions](https://support.google.com/analytics/answer/1033861) are attributes of your data. For example, the
    /// dimension `ga:city` indicates the city, for example, "Paris" or "New York", from which a session originates.
    /// </summary>
    public class Dimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If non-empty, we place dimension values into buckets after string to int64. Dimension values that are not
        /// the string representation of an integral value will be converted to zero. The bucket values have to be in
        /// increasing order. Each bucket is closed on the lower end, and open on the upper end. The "first" bucket
        /// includes all values less than the first boundary, the "last" bucket includes all values up to infinity.
        /// Dimension values that fall in a bucket get transformed to a new dimension value. For example, if one gives a
        /// list of "0, 1, 3, 4, 7", then we return the following buckets: - bucket #1: values &amp;lt; 0, dimension
        /// value "&amp;lt;0" - bucket #2: values in [0,1), dimension value "0" - bucket #3: values in [1,3), dimension
        /// value "1-2" - bucket #4: values in [3,4), dimension value "3" - bucket #5: values in [4,7), dimension value
        /// "4-6" - bucket #6: values &amp;gt;= 7, dimension value "7+" NOTE: If you are applying histogram mutation on
        /// any dimension, and using that dimension in sort, you will want to use the sort type `HISTOGRAM_BUCKET` for
        /// that purpose. Without that the dimension values will be sorted according to dictionary (lexicographic)
        /// order. For example the ascending dictionary order is: "&amp;lt;50", "1001+", "121-1000", "50-120" And the
        /// ascending `HISTOGRAM_BUCKET` order is: "&amp;lt;50", "50-120", "121-1000", "1001+" The client has to
        /// explicitly request `"orderType": "HISTOGRAM_BUCKET"` for a histogram-mutated dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramBuckets")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> HistogramBuckets { get; set; }

        /// <summary>Name of the dimension to fetch, for example `ga:browser`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension filter specifies the filtering options on a dimension.</summary>
    public class DimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Should the match be case sensitive? Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>The dimension to filter on. A DimensionFilter must contain a dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>
        /// Strings or regular expression to match against. Only the first value of the list is used for comparison
        /// unless the operator is `IN_LIST`. If `IN_LIST` operator, then the entire list is used to filter the
        /// dimensions as explained in the description of the `IN_LIST` operator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual System.Collections.Generic.IList<string> Expressions { get; set; }

        /// <summary>
        /// Logical `NOT` operator. If this boolean is set to true, then the matching dimension values will be excluded
        /// in the report. The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("not")]
        public virtual System.Nullable<bool> Not { get; set; }

        /// <summary>How to match the dimension to the expression. The default is REGEXP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group of dimension filters. Set the operator value to specify how the filters are logically combined.
    /// </summary>
    public class DimensionFilterClause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The repeated set of filters. They are logically combined based on the operator specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<DimensionFilter> Filters { get; set; }

        /// <summary>
        /// The operator for combining multiple dimension filters. If unspecified, it is treated as an `OR`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Dynamic segment definition for defining the segment within the request. A segment can select users, sessions or
    /// both.
    /// </summary>
    public class DynamicSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the dynamic segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Session Segment to select sessions to include in the segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionSegment")]
        public virtual SegmentDefinition SessionSegment { get; set; }

        /// <summary>User Segment to select users to include in the segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSegment")]
        public virtual SegmentDefinition UserSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>E-commerce details associated with the user activity.</summary>
    public class EcommerceData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action associated with this e-commerce action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>The type of this e-commerce activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecommerceType")]
        public virtual string EcommerceType { get; set; }

        /// <summary>Details of the products in this transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<ProductData> Products { get; set; }

        /// <summary>Transaction details of this e-commerce action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual TransactionData Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents all the details pertaining to an event.</summary>
    public class EventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of interaction with the object. Eg: 'play'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventAction")]
        public virtual string EventAction { get; set; }

        /// <summary>The object on the page that was interacted with. Eg: 'Video'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventCategory")]
        public virtual string EventCategory { get; set; }

        /// <summary>Number of such events in this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventCount")]
        public virtual System.Nullable<long> EventCount { get; set; }

        /// <summary>Label attached with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventLabel")]
        public virtual string EventLabel { get; set; }

        /// <summary>Numeric value associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventValue")]
        public virtual System.Nullable<long> EventValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The batch request containing multiple report request.</summary>
    public class GetReportsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Requests, each request will have a separate response. There can be a maximum of 5 requests. All requests
        /// should have the same `dateRanges`, `viewId`, `segments`, `samplingLevel`, and `cohortGroup`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportRequests")]
        public virtual System.Collections.Generic.IList<ReportRequest> ReportRequests { get; set; }

        /// <summary>
        /// Enables [resource based
        /// quotas](/analytics/devguides/reporting/core/v4/limits-quotas#analytics_reporting_api_v4), (defaults to
        /// `False`). If this field is set to `True` the per view (profile) quotas are governed by the computational
        /// cost of the request. Note that using cost based quotas will higher enable sampling rates. (10 Million for
        /// `SMALL`, 100M for `LARGE`. See the [limits and quotas
        /// documentation](/analytics/devguides/reporting/core/v4/limits-quotas#analytics_reporting_api_v4) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useResourceQuotas")]
        public virtual System.Nullable<bool> UseResourceQuotas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The main response class which holds the reports from the Reporting API `batchGet` call.</summary>
    public class GetReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of resource quota tokens deducted to execute the query. Includes all responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryCost")]
        public virtual System.Nullable<int> QueryCost { get; set; }

        /// <summary>Responses corresponding to each of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>The amount of resource quota remaining for the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceQuotasRemaining")]
        public virtual ResourceQuotasRemaining ResourceQuotasRemaining { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents all the details pertaining to a goal.</summary>
    public class GoalData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of the page where this goal was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalCompletionLocation")]
        public virtual string GoalCompletionLocation { get; set; }

        /// <summary>Total number of goal completions in this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalCompletions")]
        public virtual System.Nullable<long> GoalCompletions { get; set; }

        /// <summary>This identifies the goal as configured for the profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalIndex")]
        public virtual System.Nullable<int> GoalIndex { get; set; }

        /// <summary>Name of the goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalName")]
        public virtual string GoalName { get; set; }

        /// <summary>URL of the page one step prior to the goal completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalPreviousStep1")]
        public virtual string GoalPreviousStep1 { get; set; }

        /// <summary>URL of the page two steps prior to the goal completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalPreviousStep2")]
        public virtual string GoalPreviousStep2 { get; set; }

        /// <summary>URL of the page three steps prior to the goal completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalPreviousStep3")]
        public virtual string GoalPreviousStep3 { get; set; }

        /// <summary>Value in this goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goalValue")]
        public virtual System.Nullable<double> GoalValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a set of goals that were reached in an activity.</summary>
    public class GoalSetData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All the goals that were reached in the current activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goals")]
        public virtual System.Collections.Generic.IList<GoalData> Goals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Metrics](https://support.google.com/analytics/answer/1033861) are the quantitative measurements. For example,
    /// the metric `ga:users` indicates the total number of users for the requested time period.
    /// </summary>
    public class Metric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An alias for the metric expression is an alternate name for the expression. The alias can be used for
        /// filtering and sorting. This field is optional and is useful if the expression is not a single metric but a
        /// complex expression which cannot be used in filtering and sorting. The alias is also used in the response
        /// column header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>
        /// A metric expression in the request. An expression is constructed from one or more metrics and numbers.
        /// Accepted operators include: Plus (+), Minus (-), Negation (Unary -), Divided by (/), Multiplied by (*),
        /// Parenthesis, Positive cardinal numbers (0-9), can include decimals and is limited to 1024 characters.
        /// Example `ga:totalRefunds/ga:users`, in most cases the metric expression is just a single metric name like
        /// `ga:users`. Adding mixed `MetricType` (E.g., `CURRENCY` + `PERCENTAGE`) metrics will result in unexpected
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>Specifies how the metric expression should be formatted, for example `INTEGER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattingType")]
        public virtual string FormattingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MetricFilter specifies the filter on a metric.</summary>
    public class MetricFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value to compare against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
        public virtual string ComparisonValue { get; set; }

        /// <summary>
        /// The metric that will be filtered on. A metricFilter must contain a metric name. A metric name can be an
        /// alias earlier defined as a metric or it can also be a metric expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>
        /// Logical `NOT` operator. If this boolean is set to true, then the matching metric values will be excluded in
        /// the report. The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("not")]
        public virtual System.Nullable<bool> Not { get; set; }

        /// <summary>
        /// Is the metric `EQUAL`, `LESS_THAN` or `GREATER_THAN` the comparisonValue, the default is `EQUAL`. If the
        /// operator is `IS_MISSING`, checks if the metric is missing and would ignore the comparisonValue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a group of metric filters. Set the operator value to specify how the filters are logically combined.
    /// </summary>
    public class MetricFilterClause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The repeated set of filters. They are logically combined based on the operator specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<MetricFilter> Filters { get; set; }

        /// <summary>
        /// The operator for combining multiple metric filters. If unspecified, it is treated as an `OR`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The headers for the metrics.</summary>
    public class MetricHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Headers for the metrics in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeaderEntries")]
        public virtual System.Collections.Generic.IList<MetricHeaderEntry> MetricHeaderEntries { get; set; }

        /// <summary>Headers for the pivots in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotHeaders")]
        public virtual System.Collections.Generic.IList<PivotHeader> PivotHeaders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Header for the metrics.</summary>
    public class MetricHeaderEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The type of the metric, for example `INTEGER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of segment filters in the `OR` group are combined with the logical OR operator.</summary>
    public class OrFiltersForSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of segment filters to be combined with a `OR` operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentFilterClauses")]
        public virtual System.Collections.Generic.IList<SegmentFilterClause> SegmentFilterClauses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the sorting options.</summary>
    public class OrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The field which to sort by. The default sort order is ascending. Example: `ga:browser`. Note, that you can
        /// only specify one field for sort here. For example, `ga:browser, ga:city` is not valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>The order type. The default orderType is `VALUE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderType")]
        public virtual string OrderType { get; set; }

        /// <summary>The sorting order for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortOrder")]
        public virtual string SortOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents details collected when the visitor views a page.</summary>
    public class PageviewData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL of the page that the visitor viewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagePath")]
        public virtual string PagePath { get; set; }

        /// <summary>The title of the page that the visitor viewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageTitle")]
        public virtual string PageTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Pivot describes the pivot section in the request. The Pivot helps rearrange the information in the table for
    /// certain reports by pivoting your data on a second dimension.
    /// </summary>
    public class Pivot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// DimensionFilterClauses are logically combined with an `AND` operator: only data that is included by all
        /// these DimensionFilterClauses contributes to the values in this pivot region. Dimension filters can be used
        /// to restrict the columns shown in the pivot region. For example if you have `ga:browser` as the requested
        /// dimension in the pivot region, and you specify key filters to restrict `ga:browser` to only "IE" or
        /// "Firefox", then only those two browsers would show up as columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilterClauses")]
        public virtual System.Collections.Generic.IList<DimensionFilterClause> DimensionFilterClauses { get; set; }

        /// <summary>
        /// A list of dimensions to show as pivot columns. A Pivot can have a maximum of 4 dimensions. Pivot dimensions
        /// are part of the restriction on the total number of dimensions allowed in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Specifies the maximum number of groups to return. The default value is 10, also the maximum value is 1,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxGroupCount")]
        public virtual System.Nullable<int> MaxGroupCount { get; set; }

        /// <summary>
        /// The pivot metrics. Pivot metrics are part of the restriction on total number of metrics allowed in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>
        /// If k metrics were requested, then the response will contain some data-dependent multiple of k columns in the
        /// report. E.g., if you pivoted on the dimension `ga:browser` then you'd get k columns for "Firefox", k columns
        /// for "IE", k columns for "Chrome", etc. The ordering of the groups of columns is determined by descending
        /// order of "total" for the first of the k values. Ties are broken by lexicographic ordering of the first pivot
        /// dimension, then lexicographic ordering of the second pivot dimension, and so on. E.g., if the totals for the
        /// first value for Firefox, IE, and Chrome were 8, 2, 8, respectively, the order of columns would be Chrome,
        /// Firefox, IE. The following let you choose which of the groups of k columns are included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startGroup")]
        public virtual System.Nullable<int> StartGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The headers for each of the pivot sections defined in the request.</summary>
    public class PivotHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A single pivot section header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotHeaderEntries")]
        public virtual System.Collections.Generic.IList<PivotHeaderEntry> PivotHeaderEntries { get; set; }

        /// <summary>The total number of groups for this pivot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPivotGroupsCount")]
        public virtual System.Nullable<int> TotalPivotGroupsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The headers for the each of the metric column corresponding to the metrics requested in the pivots section of
    /// the response.
    /// </summary>
    public class PivotHeaderEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the dimensions in the pivot response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionNames")]
        public virtual System.Collections.Generic.IList<string> DimensionNames { get; set; }

        /// <summary>The values for the dimensions in the pivot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<string> DimensionValues { get; set; }

        /// <summary>The metric header for the metric in the pivot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual MetricHeaderEntry Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metric values in the pivot region.</summary>
    public class PivotValueRegion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values of the metrics in each of the pivot regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the products in an e-commerce transaction.</summary>
    public class ProductData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total revenue from purchased product items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemRevenue")]
        public virtual System.Nullable<double> ItemRevenue { get; set; }

        /// <summary>
        /// The product name, supplied by the e-commerce tracking application, for the purchased items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productName")]
        public virtual string ProductName { get; set; }

        /// <summary>Total number of this product units in the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productQuantity")]
        public virtual System.Nullable<long> ProductQuantity { get; set; }

        /// <summary>Unique code that represents the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSku")]
        public virtual string ProductSku { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data response corresponding to the request.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The column headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeader")]
        public virtual ColumnHeader ColumnHeader { get; set; }

        /// <summary>Response data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual ReportData Data { get; set; }

        /// <summary>Page token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data part of the report.</summary>
    public class ReportData : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _dataLastRefreshedRaw;

        private object _dataLastRefreshed;

        /// <summary>
        /// The last time the data in the report was refreshed. All the hits received before this timestamp are included
        /// in the calculation of the report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLastRefreshed")]
        public virtual string DataLastRefreshedRaw
        {
            get => _dataLastRefreshedRaw;
            set
            {
                _dataLastRefreshed = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dataLastRefreshedRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DataLastRefreshedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DataLastRefreshedDateTimeOffset instead.")]
        public virtual object DataLastRefreshed
        {
            get => _dataLastRefreshed;
            set
            {
                _dataLastRefreshedRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dataLastRefreshed = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DataLastRefreshedRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DataLastRefreshedDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DataLastRefreshedRaw);
            set => DataLastRefreshedRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>If empty reason is specified, the report is empty for this reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emptyReason")]
        public virtual string EmptyReason { get; set; }

        /// <summary>
        /// Indicates if response to this request is golden or not. Data is golden when the exact same request will not
        /// produce any new results if asked at a later point in time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDataGolden")]
        public virtual System.Nullable<bool> IsDataGolden { get; set; }

        /// <summary>
        /// Minimum and maximum values seen over all matching rows. These are both empty when `hideValueRanges` in the
        /// request is false, or when rowCount is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximums")]
        public virtual System.Collections.Generic.IList<DateRangeValues> Maximums { get; set; }

        /// <summary>
        /// Minimum and maximum values seen over all matching rows. These are both empty when `hideValueRanges` in the
        /// request is false, or when rowCount is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimums")]
        public virtual System.Collections.Generic.IList<DateRangeValues> Minimums { get; set; }

        /// <summary>Total number of matching rows for this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>There's one ReportRow for every unique combination of dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<ReportRow> Rows { get; set; }

        /// <summary>
        /// If the results are [sampled](https://support.google.com/analytics/answer/2637192), this returns the total
        /// number of samples read, one entry per date range. If the results are not sampled this field will not be
        /// defined. See [developer guide](/analytics/devguides/reporting/core/v4/basics#sampling) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplesReadCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> SamplesReadCounts { get; set; }

        /// <summary>
        /// If the results are [sampled](https://support.google.com/analytics/answer/2637192), this returns the total
        /// number of samples present, one entry per date range. If the results are not sampled this field will not be
        /// defined. See [developer guide](/analytics/devguides/reporting/core/v4/basics#sampling) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplingSpaceSizes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> SamplingSpaceSizes { get; set; }

        /// <summary>
        /// For each requested date range, for the set of all rows that match the query, every requested value format
        /// gets a total. The total for a value format is computed by first totaling the metrics mentioned in the value
        /// format and then evaluating the value format as a scalar expression. E.g., The "totals" for `3 / (ga:sessions
        /// + 2)` we compute `3 / ((sum of all relevant ga:sessions) + 2)`. Totals are computed before pagination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totals")]
        public virtual System.Collections.Generic.IList<DateRangeValues> Totals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The main request class which specifies the Reporting API request.</summary>
    public class ReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cohort group associated with this request. If there is a cohort group in the request the `ga:cohort`
        /// dimension must be present. Every [ReportRequest](#ReportRequest) within a `batchGet` method must contain the
        /// same `cohortGroup` definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohortGroup")]
        public virtual CohortGroup CohortGroup { get; set; }

        /// <summary>
        /// Date ranges in the request. The request can have a maximum of 2 date ranges. The response will contain a set
        /// of metric values for each combination of the dimensions for each date range in the request. So, if there are
        /// two date ranges, there will be two set of metric values, one for the original date range and one for the
        /// second date range. The `reportRequest.dateRanges` field should not be specified for cohorts or Lifetime
        /// value requests. If a date range is not provided, the default date range is (startDate: current date - 7
        /// days, endDate: current date - 1 day). Every [ReportRequest](#ReportRequest) within a `batchGet` method must
        /// contain the same `dateRanges` definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<DateRange> DateRanges { get; set; }

        /// <summary>
        /// The dimension filter clauses for filtering Dimension Values. They are logically combined with the `AND`
        /// operator. Note that filtering occurs before any dimensions are aggregated, so that the returned metrics
        /// represent the total for only the relevant dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilterClauses")]
        public virtual System.Collections.Generic.IList<DimensionFilterClause> DimensionFilterClauses { get; set; }

        /// <summary>The dimensions requested. Requests can have a total of 9 dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Dimension or metric filters that restrict the data returned for your request. To use the
        /// `filtersExpression`, supply a dimension or metric on which to filter, followed by the filter expression. For
        /// example, the following expression selects `ga:browser` dimension which starts with Firefox;
        /// `ga:browser=~^Firefox`. For more information on dimensions and metric filters, see [Filters
        /// reference](https://developers.google.com/analytics/devguides/reporting/core/v3/reference#filters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filtersExpression")]
        public virtual string FiltersExpression { get; set; }

        /// <summary>
        /// If set to true, hides the total of all metrics for all the matching rows, for every date range. The default
        /// false and will return the totals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideTotals")]
        public virtual System.Nullable<bool> HideTotals { get; set; }

        /// <summary>
        /// If set to true, hides the minimum and maximum across all matching rows. The default is false and the value
        /// ranges are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideValueRanges")]
        public virtual System.Nullable<bool> HideValueRanges { get; set; }

        /// <summary>
        /// If set to false, the response does not include rows if all the retrieved metrics are equal to zero. The
        /// default is false which will exclude these rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeEmptyRows")]
        public virtual System.Nullable<bool> IncludeEmptyRows { get; set; }

        /// <summary>
        /// The metric filter clauses. They are logically combined with the `AND` operator. Metric filters look at only
        /// the first date range and not the comparing date range. Note that filtering on metrics occurs after the
        /// metrics are aggregated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFilterClauses")]
        public virtual System.Collections.Generic.IList<MetricFilterClause> MetricFilterClauses { get; set; }

        /// <summary>
        /// The metrics requested. Requests must specify at least one metric. Requests can have a total of 10 metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>
        /// Sort order on output rows. To compare two rows, the elements of the following are applied in order until a
        /// difference is found. All date ranges in the output get the same row order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBys")]
        public virtual System.Collections.Generic.IList<OrderBy> OrderBys { get; set; }

        /// <summary>
        /// Page size is for paging and specifies the maximum number of returned rows. Page size should be &amp;gt;= 0.
        /// A query returns the default of 1,000 rows. The Analytics Core Reporting API returns a maximum of 100,000
        /// rows per request, no matter how many you ask for. It can also return fewer rows than requested, if there
        /// aren't as many dimension segments as you expect. For instance, there are fewer than 300 possible values for
        /// `ga:country`, so when segmenting only by country, you can't get more than 300 rows, even if you set
        /// `pageSize` to a higher value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A continuation token to get the next page of the results. Adding this to the request will return the rows
        /// after the pageToken. The pageToken should be the value returned in the nextPageToken parameter in the
        /// response to the GetReports request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The pivot definitions. Requests can have a maximum of 2 pivots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivots")]
        public virtual System.Collections.Generic.IList<Pivot> Pivots { get; set; }

        /// <summary>
        /// The desired report [sample](https://support.google.com/analytics/answer/2637192) size. If the the
        /// `samplingLevel` field is unspecified the `DEFAULT` sampling level is used. Every
        /// [ReportRequest](#ReportRequest) within a `batchGet` method must contain the same `samplingLevel` definition.
        /// See [developer guide](/analytics/devguides/reporting/core/v4/basics#sampling) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplingLevel")]
        public virtual string SamplingLevel { get; set; }

        /// <summary>
        /// Segment the data returned for the request. A segment definition helps look at a subset of the segment
        /// request. A request can contain up to four segments. Every [ReportRequest](#ReportRequest) within a
        /// `batchGet` method must contain the same `segments` definition. Requests with segments must have the
        /// `ga:segment` dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<Segment> Segments { get; set; }

        /// <summary>
        /// The Analytics [view ID](https://support.google.com/analytics/answer/1009618) from which to retrieve data.
        /// Every [ReportRequest](#ReportRequest) within a `batchGet` method must contain the same `viewId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewId")]
        public virtual string ViewId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row in the report.</summary>
    public class ReportRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of requested dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>List of metrics for each requested DateRange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<DateRangeValues> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The resource quota tokens remaining for the property after the request is completed.</summary>
    public class ResourceQuotasRemaining : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily resource quota remaining remaining.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyQuotaTokensRemaining")]
        public virtual System.Nullable<int> DailyQuotaTokensRemaining { get; set; }

        /// <summary>Hourly resource quota tokens remaining.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourlyQuotaTokensRemaining")]
        public virtual System.Nullable<int> HourlyQuotaTokensRemaining { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ScreenviewData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The application name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appName")]
        public virtual string AppName { get; set; }

        /// <summary>Mobile manufacturer or branded name. Eg: "Google", "Apple" etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDeviceBranding")]
        public virtual string MobileDeviceBranding { get; set; }

        /// <summary>Mobile device model. Eg: "Pixel", "iPhone" etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDeviceModel")]
        public virtual string MobileDeviceModel { get; set; }

        /// <summary>The name of the screen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenName")]
        public virtual string ScreenName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to fetch User Report from Reporting API `userActivity:get` call.</summary>
    public class SearchUserActivityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of all activity types being requested. Only acvities matching these types will be returned in the
        /// response. If empty, all activies will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityTypes")]
        public virtual System.Collections.Generic.IList<string> ActivityTypes { get; set; }

        /// <summary>
        /// Date range for which to retrieve the user activity. If a date range is not provided, the default date range
        /// is (startDate: current date - 7 days, endDate: current date - 1 day).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// Page size is for paging and specifies the maximum number of returned rows. Page size should be &amp;gt; 0.
        /// If the value is 0 or if the field isn't specified, the request returns the default of 1000 rows per page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A continuation token to get the next page of the results. Adding this to the request will return the rows
        /// after the pageToken. The pageToken should be the value returned in the nextPageToken parameter in the
        /// response to the [SearchUserActivityRequest](#SearchUserActivityRequest) request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. Unique user Id to query for. Every [SearchUserActivityRequest](#SearchUserActivityRequest) must
        /// contain this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>
        /// Required. The Analytics [view ID](https://support.google.com/analytics/answer/1009618) from which to
        /// retrieve data. Every [SearchUserActivityRequest](#SearchUserActivityRequest) must contain the `viewId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewId")]
        public virtual string ViewId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from `userActivity:get` call.</summary>
    public class SearchUserActivityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This token should be passed to [SearchUserActivityRequest](#SearchUserActivityRequest) to retrieve the next
        /// page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// This field represents the [sampling rate](https://support.google.com/analytics/answer/2637192) for the given
        /// request and is a number between 0.0 to 1.0. See [developer
        /// guide](/analytics/devguides/reporting/core/v4/basics#sampling) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRate")]
        public virtual System.Nullable<double> SampleRate { get; set; }

        /// <summary>Each record represents a session (device details, duration, etc).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessions")]
        public virtual System.Collections.Generic.IList<UserActivitySession> Sessions { get; set; }

        /// <summary>Total rows returned by this query (across different pages).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRows")]
        public virtual System.Nullable<int> TotalRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The segment definition, if the report needs to be segmented. A Segment is a subset of the Analytics data. For
    /// example, of the entire set of users, one Segment might be users from a particular country or city.
    /// </summary>
    public class Segment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A dynamic segment definition in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSegment")]
        public virtual DynamicSegment DynamicSegment { get; set; }

        /// <summary>The segment ID of a built-in or custom segment, for example `gaid::-3`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SegmentDefinition defines the segment to be a set of SegmentFilters which are combined together with a logical
    /// `AND` operation.
    /// </summary>
    public class SegmentDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A segment is defined by a set of segment filters which are combined together with a logical `AND` operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentFilters")]
        public virtual System.Collections.Generic.IList<SegmentFilter> SegmentFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension filter specifies the filtering options on a dimension.</summary>
    public class SegmentDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Should the match be case sensitive, ignored for `IN_LIST` operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Name of the dimension for which the filter is being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>The list of expressions, only the first element is used for all operators</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual System.Collections.Generic.IList<string> Expressions { get; set; }

        /// <summary>Maximum comparison values for `BETWEEN` match type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxComparisonValue")]
        public virtual string MaxComparisonValue { get; set; }

        /// <summary>Minimum comparison values for `BETWEEN` match type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minComparisonValue")]
        public virtual string MinComparisonValue { get; set; }

        /// <summary>The operator to use to match the dimension with the expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SegmentFilter defines the segment to be either a simple or a sequence segment. A simple segment condition
    /// contains dimension and metric conditions to select the sessions or users. A sequence segment condition can be
    /// used to select users or sessions based on sequential conditions.
    /// </summary>
    public class SegmentFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, match the complement of simple or sequence segment. For example, to match all visits not from "New
        /// York", we can define the segment as follows: "sessionSegment": { "segmentFilters": [{ "simpleSegment" :{
        /// "orFiltersForSegment": [{ "segmentFilterClauses":[{ "dimensionFilter": { "dimensionName": "ga:city",
        /// "expressions": ["New York"] } }] }] }, "not": "True" }] },
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("not")]
        public virtual System.Nullable<bool> Not { get; set; }

        /// <summary>
        /// Sequence conditions consist of one or more steps, where each step is defined by one or more dimension/metric
        /// conditions. Multiple steps can be combined with special sequence operators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceSegment")]
        public virtual SequenceSegment SequenceSegment { get; set; }

        /// <summary>
        /// A Simple segment conditions consist of one or more dimension/metric conditions that can be combined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleSegment")]
        public virtual SimpleSegment SimpleSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Filter Clause to be used in a segment definition, can be wither a metric or a dimension filter.
    /// </summary>
    public class SegmentFilterClause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dimension Filter for the segment definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual SegmentDimensionFilter DimensionFilter { get; set; }

        /// <summary>Metric Filter for the segment definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFilter")]
        public virtual SegmentMetricFilter MetricFilter { get; set; }

        /// <summary>Matches the complement (`!`) of the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("not")]
        public virtual System.Nullable<bool> Not { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metric filter to be used in a segment filter clause.</summary>
    public class SegmentMetricFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value to compare against. If the operator is `BETWEEN`, this value is treated as minimum comparison
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
        public virtual string ComparisonValue { get; set; }

        /// <summary>Max comparison value is only used for `BETWEEN` operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxComparisonValue")]
        public virtual string MaxComparisonValue { get; set; }

        /// <summary>The metric that will be filtered on. A `metricFilter` must contain a metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>Specifies is the operation to perform to compare the metric. The default is `EQUAL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>
        /// Scope for a metric defines the level at which that metric is defined. The specified metric scope must be
        /// equal to or greater than its primary scope as defined in the data model. The primary scope is defined by if
        /// the segment is selecting users or sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A segment sequence definition.</summary>
    public class SegmentSequenceStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies if the step immediately precedes or can be any time before the next step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>
        /// A sequence is specified with a list of Or grouped filters which are combined with `AND` operator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orFiltersForSegment")]
        public virtual System.Collections.Generic.IList<OrFiltersForSegment> OrFiltersForSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sequence conditions consist of one or more steps, where each step is defined by one or more dimension/metric
    /// conditions. Multiple steps can be combined with special sequence operators.
    /// </summary>
    public class SequenceSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, first step condition must match the first hit of the visitor (in the date range).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstStepShouldMatchFirstHit")]
        public virtual System.Nullable<bool> FirstStepShouldMatchFirstHit { get; set; }

        /// <summary>The list of steps in the sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentSequenceSteps")]
        public virtual System.Collections.Generic.IList<SegmentSequenceStep> SegmentSequenceSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Simple segment conditions consist of one or more dimension/metric conditions that can be combined.
    /// </summary>
    public class SimpleSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of segment filters groups which are combined with logical `AND` operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orFiltersForSegment")]
        public virtual System.Collections.Generic.IList<OrFiltersForSegment> OrFiltersForSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents details collected when the visitor performs a transaction on the page.</summary>
    public class TransactionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The transaction ID, supplied by the e-commerce tracking method, for the purchase in the shopping cart.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>The total sale revenue (excluding shipping and tax) of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionRevenue")]
        public virtual System.Nullable<double> TransactionRevenue { get; set; }

        /// <summary>Total cost of shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionShipping")]
        public virtual System.Nullable<double> TransactionShipping { get; set; }

        /// <summary>Total tax for the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionTax")]
        public virtual System.Nullable<double> TransactionTax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information to identify a particular user uniquely.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the user in the request. The field `userId` is associated with this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Unique Id of the user for which the data is being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This represents a user session performed on a specific device at a certain time over a period of time.
    /// </summary>
    public class UserActivitySession : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a detailed view into each of the activity in this session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activities")]
        public virtual System.Collections.Generic.IList<Activity> Activities { get; set; }

        /// <summary>
        /// The data source of a hit. By default, hits sent from analytics.js are reported as "web" and hits sent from
        /// the mobile SDKs are reported as "app". These values can be overridden in the Measurement Protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>The type of device used: "mobile", "tablet" etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCategory")]
        public virtual string DeviceCategory { get; set; }

        /// <summary>Platform on which the activity happened: "android", "ios" etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Date of this session in ISO-8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionDate")]
        public virtual string SessionDate { get; set; }

        /// <summary>Unique ID of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
