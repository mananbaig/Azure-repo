// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Delegated subnet usage data.
    /// </summary>
    public partial class DelegatedSubnetUsage
    {
        /// <summary>
        /// Initializes a new instance of the DelegatedSubnetUsage class.
        /// </summary>
        public DelegatedSubnetUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelegatedSubnetUsage class.
        /// </summary>
        /// <param name="subnetName">name of the subnet</param>
        /// <param name="usage">Number of used delegated subnets</param>
        public DelegatedSubnetUsage(string subnetName = default(string), long? usage = default(long?))
        {
            SubnetName = subnetName;
            Usage = usage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the subnet
        /// </summary>
        [JsonProperty(PropertyName = "subnetName")]
        public string SubnetName { get; private set; }

        /// <summary>
        /// Gets number of used delegated subnets
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public long? Usage { get; private set; }

    }
}
