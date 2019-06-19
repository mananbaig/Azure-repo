// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Api request input for LogAnalytics getRequestRateByInterval Api.
    /// </summary>
    public partial class RequestRateByIntervalInput : LogAnalyticsInputBase
    {
        /// <summary>
        /// Initializes a new instance of the RequestRateByIntervalInput class.
        /// </summary>
        public RequestRateByIntervalInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequestRateByIntervalInput class.
        /// </summary>
        /// <param name="blobContainerSasUri">SAS Uri of the logging blob
        /// container to which LogAnalytics Api writes output logs to.</param>
        /// <param name="fromTime">From time of the query</param>
        /// <param name="toTime">To time of the query</param>
        /// <param name="intervalLength">Interval value in minutes used to
        /// create LogAnalytics call rate logs. Possible values include:
        /// 'ThreeMins', 'FiveMins', 'ThirtyMins', 'SixtyMins'</param>
        /// <param name="groupByThrottlePolicy">Group query result by Throttle
        /// Policy applied.</param>
        /// <param name="groupByOperationName">Group query result by Operation
        /// Name.</param>
        /// <param name="groupByResourceName">Group query result by Resource
        /// Name.</param>
        public RequestRateByIntervalInput(string blobContainerSasUri, System.DateTime fromTime, System.DateTime toTime, IntervalInMins intervalLength, bool? groupByThrottlePolicy = default(bool?), bool? groupByOperationName = default(bool?), bool? groupByResourceName = default(bool?))
            : base(blobContainerSasUri, fromTime, toTime, groupByThrottlePolicy, groupByOperationName, groupByResourceName)
        {
            IntervalLength = intervalLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets interval value in minutes used to create LogAnalytics
        /// call rate logs. Possible values include: 'ThreeMins', 'FiveMins',
        /// 'ThirtyMins', 'SixtyMins'
        /// </summary>
        [JsonProperty(PropertyName = "intervalLength")]
        public IntervalInMins IntervalLength { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
