// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListAzureFirewalls API service call. </summary>
    internal partial class AzureFirewallListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallListResult"/>. </summary>
        internal AzureFirewallListResult()
        {
            Value = new ChangeTrackingList<AzureFirewallData>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureFirewallListResult"/>. </summary>
        /// <param name="value"> List of Azure Firewalls in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureFirewallListResult(IReadOnlyList<AzureFirewallData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Azure Firewalls in a resource group. </summary>
        public IReadOnlyList<AzureFirewallData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
