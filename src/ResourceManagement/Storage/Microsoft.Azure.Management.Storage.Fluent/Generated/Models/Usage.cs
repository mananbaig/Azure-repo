// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes Storage Resource Usage.
    /// </summary>
    public partial class UsageInner
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public UsageInner() { }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        /// <param name="unit">Gets the unit of measurement. Possible values
        /// include: 'Count', 'Bytes', 'Seconds', 'Percent',
        /// 'CountsPerSecond', 'BytesPerSecond'</param>
        /// <param name="currentValue">Gets the current count of the allocated
        /// resources in the subscription.</param>
        /// <param name="limit">Gets the maximum count of the resources that
        /// can be allocated in the subscription.</param>
        /// <param name="name">Gets the name of the type of usage.</param>
        public UsageInner(UsageUnit? unit = default(UsageUnit?), int? currentValue = default(int?), int? limit = default(int?), UsageName name = default(UsageName))
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary>
        /// Gets the unit of measurement. Possible values include: 'Count',
        /// 'Bytes', 'Seconds', 'Percent', 'CountsPerSecond', 'BytesPerSecond'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unit")]
        public UsageUnit? Unit { get; private set; }

        /// <summary>
        /// Gets the current count of the allocated resources in the
        /// subscription.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; private set; }

        /// <summary>
        /// Gets the maximum count of the resources that can be allocated in
        /// the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "limit")]
        public int? Limit { get; private set; }

        /// <summary>
        /// Gets the name of the type of usage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public UsageName Name { get; private set; }

    }
}
