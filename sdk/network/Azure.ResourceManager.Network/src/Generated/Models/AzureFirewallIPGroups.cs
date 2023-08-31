// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IpGroups associated with azure firewall. </summary>
    public partial class AzureFirewallIPGroups
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallIPGroups"/>. </summary>
        internal AzureFirewallIPGroups()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureFirewallIPGroups"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="changeNumber"> The iteration number. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureFirewallIPGroups(ResourceIdentifier id, string changeNumber, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ChangeNumber = changeNumber;
            _rawData = rawData;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The iteration number. </summary>
        public string ChangeNumber { get; }
    }
}
