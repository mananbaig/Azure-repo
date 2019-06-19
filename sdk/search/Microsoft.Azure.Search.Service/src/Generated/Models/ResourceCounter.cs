// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a resource's usage and quota.
    /// </summary>
    public partial class ResourceCounter
    {
        /// <summary>
        /// Initializes a new instance of the ResourceCounter class.
        /// </summary>
        public ResourceCounter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceCounter class.
        /// </summary>
        /// <param name="usage">The resource usage amount.</param>
        /// <param name="quota">The resource amount quota.</param>
        public ResourceCounter(long usage = default(long), long? quota = default(long?))
        {
            Usage = usage;
            Quota = quota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource usage amount.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public long Usage { get; set; }

        /// <summary>
        /// Gets or sets the resource amount quota.
        /// </summary>
        [JsonProperty(PropertyName = "quota")]
        public long? Quota { get; set; }

    }
}
