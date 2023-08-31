// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Delegated subnet usage data. </summary>
    public partial class MySqlFlexibleServerDelegatedSubnetUsage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerDelegatedSubnetUsage"/>. </summary>
        internal MySqlFlexibleServerDelegatedSubnetUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerDelegatedSubnetUsage"/>. </summary>
        /// <param name="subnetName"> name of the subnet. </param>
        /// <param name="usage"> Number of used delegated subnets. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerDelegatedSubnetUsage(string subnetName, long? usage, Dictionary<string, BinaryData> rawData)
        {
            SubnetName = subnetName;
            Usage = usage;
            _rawData = rawData;
        }

        /// <summary> name of the subnet. </summary>
        public string SubnetName { get; }
        /// <summary> Number of used delegated subnets. </summary>
        public long? Usage { get; }
    }
}
