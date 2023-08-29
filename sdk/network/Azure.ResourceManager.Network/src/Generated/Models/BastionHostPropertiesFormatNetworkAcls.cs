// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The BastionHostPropertiesFormatNetworkAcls. </summary>
    internal partial class BastionHostPropertiesFormatNetworkAcls
    {
        /// <summary> Initializes a new instance of BastionHostPropertiesFormatNetworkAcls. </summary>
        public BastionHostPropertiesFormatNetworkAcls()
        {
            IPRules = new ChangeTrackingList<IPRule>();
        }

        /// <summary> Initializes a new instance of BastionHostPropertiesFormatNetworkAcls. </summary>
        /// <param name="ipRules"> Sets the IP ACL rules for Developer Bastion Host. </param>
        internal BastionHostPropertiesFormatNetworkAcls(IList<IPRule> ipRules)
        {
            IPRules = ipRules;
        }

        /// <summary> Sets the IP ACL rules for Developer Bastion Host. </summary>
        public IList<IPRule> IPRules { get; }
    }
}
