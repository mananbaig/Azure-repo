// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Partner Namespace update. </summary>
    public partial class PartnerNamespacePatch
    {
        /// <summary> Initializes a new instance of PartnerNamespacePatch. </summary>
        public PartnerNamespacePatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
            InboundIPRules = new Core.ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Tags of the Partner Namespace. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PartnerNamespaceUpdateParameterProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> Minimum TLS version of the publisher allowed to publish to this domain. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the partner namespace. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
    }
}
