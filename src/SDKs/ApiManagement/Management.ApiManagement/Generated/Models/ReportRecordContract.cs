// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Report data.
    /// </summary>
    public partial class ReportRecordContract
    {
        /// <summary>
        /// Initializes a new instance of the ReportRecordContract class.
        /// </summary>
        public ReportRecordContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportRecordContract class.
        /// </summary>
        /// <param name="name">Name depending on report endpoint specifies
        /// product, API, operation or developer name.</param>
        /// <param name="timestamp">Start of aggregation period. The date
        /// conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
        /// specified by the ISO 8601 standard.
        /// </param>
        /// <param name="interval">Length of agregation period.  Interval must
        /// be multiple of 15 minutes and may not be zero. The value should be
        /// in ISO 8601 format
        /// (http://en.wikipedia.org/wiki/ISO_8601#Durations).</param>
        /// <param name="country">Country to which this record data is
        /// related.</param>
        /// <param name="region">Country region to which this record data is
        /// related.</param>
        /// <param name="zip">Zip code to which this record data is
        /// related.</param>
        /// <param name="userId">User identifier path. /users/{userId}</param>
        /// <param name="productId">Product identifier path.
        /// /products/{productId}</param>
        /// <param name="apiId">API identifier path. /apis/{apiId}</param>
        /// <param name="operationId">Operation identifier path.
        /// /apis/{apiId}/operations/{operationId}</param>
        /// <param name="apiRegion">API region identifier.</param>
        /// <param name="subscriptionId">Subscription identifier path.
        /// /subscriptions/{subscriptionId}</param>
        /// <param name="callCountSuccess">Number of succesful calls. This
        /// includes calls returning HttpStatusCode &lt;= 301 and
        /// HttpStatusCode.NotModified and
        /// HttpStatusCode.TemporaryRedirect</param>
        /// <param name="callCountBlocked">Number of calls blocked due to
        /// invalid credentials. This includes calls returning
        /// HttpStatusCode.Unauthorize and HttpStatusCode.Forbidden and
        /// HttpStatusCode.TooManyRequests</param>
        /// <param name="callCountFailed">Number of calls failed due to proxy
        /// or backend errors. This includes calls returning
        /// HttpStatusCode.BadRequest(400) and any Code between
        /// HttpStatusCode.InternalServerError (500) and 600</param>
        /// <param name="callCountOther">Number of other calls.</param>
        /// <param name="callCountTotal">Total number of calls.</param>
        /// <param name="bandwidth">Bandwidth consumed.</param>
        /// <param name="cacheHitCount">Number of times when content was served
        /// from cache policy.</param>
        /// <param name="cacheMissCount">Number of times content was fetched
        /// from backend.</param>
        /// <param name="apiTimeAvg">Average time it took to process
        /// request.</param>
        /// <param name="apiTimeMin">Minimum time it took to process
        /// request.</param>
        /// <param name="apiTimeMax">Maximum time it took to process
        /// request.</param>
        /// <param name="serviceTimeAvg">Average time it took to process
        /// request on backend.</param>
        /// <param name="serviceTimeMin">Minimum time it took to process
        /// request on backend.</param>
        /// <param name="serviceTimeMax">Maximum time it took to process
        /// request on backend.</param>
        public ReportRecordContract(string name = default(string), System.DateTime? timestamp = default(System.DateTime?), string interval = default(string), string country = default(string), string region = default(string), string zip = default(string), string userId = default(string), string productId = default(string), string apiId = default(string), string operationId = default(string), string apiRegion = default(string), string subscriptionId = default(string), int? callCountSuccess = default(int?), int? callCountBlocked = default(int?), int? callCountFailed = default(int?), int? callCountOther = default(int?), int? callCountTotal = default(int?), long? bandwidth = default(long?), int? cacheHitCount = default(int?), int? cacheMissCount = default(int?), double? apiTimeAvg = default(double?), double? apiTimeMin = default(double?), double? apiTimeMax = default(double?), double? serviceTimeAvg = default(double?), double? serviceTimeMin = default(double?), double? serviceTimeMax = default(double?))
        {
            Name = name;
            Timestamp = timestamp;
            Interval = interval;
            Country = country;
            Region = region;
            Zip = zip;
            UserId = userId;
            ProductId = productId;
            ApiId = apiId;
            OperationId = operationId;
            ApiRegion = apiRegion;
            SubscriptionId = subscriptionId;
            CallCountSuccess = callCountSuccess;
            CallCountBlocked = callCountBlocked;
            CallCountFailed = callCountFailed;
            CallCountOther = callCountOther;
            CallCountTotal = callCountTotal;
            Bandwidth = bandwidth;
            CacheHitCount = cacheHitCount;
            CacheMissCount = cacheMissCount;
            ApiTimeAvg = apiTimeAvg;
            ApiTimeMin = apiTimeMin;
            ApiTimeMax = apiTimeMax;
            ServiceTimeAvg = serviceTimeAvg;
            ServiceTimeMin = serviceTimeMin;
            ServiceTimeMax = serviceTimeMax;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name depending on report endpoint specifies product,
        /// API, operation or developer name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets start of aggregation period. The date conforms to the
        /// following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO
        /// 8601 standard.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets length of agregation period.  Interval must be
        /// multiple of 15 minutes and may not be zero. The value should be in
        /// ISO 8601 format (http://en.wikipedia.org/wiki/ISO_8601#Durations).
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Gets or sets country to which this record data is related.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets country region to which this record data is related.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets zip code to which this record data is related.
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Gets user identifier path. /users/{userId}
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; private set; }

        /// <summary>
        /// Gets product identifier path. /products/{productId}
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public string ProductId { get; private set; }

        /// <summary>
        /// Gets or sets API identifier path. /apis/{apiId}
        /// </summary>
        [JsonProperty(PropertyName = "apiId")]
        public string ApiId { get; set; }

        /// <summary>
        /// Gets or sets operation identifier path.
        /// /apis/{apiId}/operations/{operationId}
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets API region identifier.
        /// </summary>
        [JsonProperty(PropertyName = "apiRegion")]
        public string ApiRegion { get; set; }

        /// <summary>
        /// Gets or sets subscription identifier path.
        /// /subscriptions/{subscriptionId}
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets number of succesful calls. This includes calls
        /// returning HttpStatusCode &amp;lt;= 301 and
        /// HttpStatusCode.NotModified and HttpStatusCode.TemporaryRedirect
        /// </summary>
        [JsonProperty(PropertyName = "callCountSuccess")]
        public int? CallCountSuccess { get; set; }

        /// <summary>
        /// Gets or sets number of calls blocked due to invalid credentials.
        /// This includes calls returning HttpStatusCode.Unauthorize and
        /// HttpStatusCode.Forbidden and HttpStatusCode.TooManyRequests
        /// </summary>
        [JsonProperty(PropertyName = "callCountBlocked")]
        public int? CallCountBlocked { get; set; }

        /// <summary>
        /// Gets or sets number of calls failed due to proxy or backend errors.
        /// This includes calls returning HttpStatusCode.BadRequest(400) and
        /// any Code between HttpStatusCode.InternalServerError (500) and 600
        /// </summary>
        [JsonProperty(PropertyName = "callCountFailed")]
        public int? CallCountFailed { get; set; }

        /// <summary>
        /// Gets or sets number of other calls.
        /// </summary>
        [JsonProperty(PropertyName = "callCountOther")]
        public int? CallCountOther { get; set; }

        /// <summary>
        /// Gets or sets total number of calls.
        /// </summary>
        [JsonProperty(PropertyName = "callCountTotal")]
        public int? CallCountTotal { get; set; }

        /// <summary>
        /// Gets or sets bandwidth consumed.
        /// </summary>
        [JsonProperty(PropertyName = "bandwidth")]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// Gets or sets number of times when content was served from cache
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "cacheHitCount")]
        public int? CacheHitCount { get; set; }

        /// <summary>
        /// Gets or sets number of times content was fetched from backend.
        /// </summary>
        [JsonProperty(PropertyName = "cacheMissCount")]
        public int? CacheMissCount { get; set; }

        /// <summary>
        /// Gets or sets average time it took to process request.
        /// </summary>
        [JsonProperty(PropertyName = "apiTimeAvg")]
        public double? ApiTimeAvg { get; set; }

        /// <summary>
        /// Gets or sets minimum time it took to process request.
        /// </summary>
        [JsonProperty(PropertyName = "apiTimeMin")]
        public double? ApiTimeMin { get; set; }

        /// <summary>
        /// Gets or sets maximum time it took to process request.
        /// </summary>
        [JsonProperty(PropertyName = "apiTimeMax")]
        public double? ApiTimeMax { get; set; }

        /// <summary>
        /// Gets or sets average time it took to process request on backend.
        /// </summary>
        [JsonProperty(PropertyName = "serviceTimeAvg")]
        public double? ServiceTimeAvg { get; set; }

        /// <summary>
        /// Gets or sets minimum time it took to process request on backend.
        /// </summary>
        [JsonProperty(PropertyName = "serviceTimeMin")]
        public double? ServiceTimeMin { get; set; }

        /// <summary>
        /// Gets or sets maximum time it took to process request on backend.
        /// </summary>
        [JsonProperty(PropertyName = "serviceTimeMax")]
        public double? ServiceTimeMax { get; set; }

    }
}
