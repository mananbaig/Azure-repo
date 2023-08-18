// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties of Access Rule. </summary>
    public partial class EventHubsNspAccessRuleProperties
    {
        /// <summary> Initializes a new instance of EventHubsNspAccessRuleProperties. </summary>
        internal EventHubsNspAccessRuleProperties()
        {
            AddressPrefixes = new Core.ChangeTrackingList<string>();
            Subscriptions = new Core.ChangeTrackingList<SubResource>();
            NetworkSecurityPerimeters = new Core.ChangeTrackingList<EventHubsNetworkSecurityPerimeter>();
            FullyQualifiedDomainNames = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of EventHubsNspAccessRuleProperties. </summary>
        /// <param name="direction"> Direction of Access Rule. </param>
        /// <param name="addressPrefixes"> Address prefixes in the CIDR format for inbound rules. </param>
        /// <param name="subscriptions"> Subscriptions for inbound rules. </param>
        /// <param name="networkSecurityPerimeters"> NetworkSecurityPerimeters for inbound rules. </param>
        /// <param name="fullyQualifiedDomainNames"> FQDN for outbound rules. </param>
        internal EventHubsNspAccessRuleProperties(EventHubsNspAccessRuleDirection? direction, IReadOnlyList<string> addressPrefixes, IReadOnlyList<SubResource> subscriptions, IReadOnlyList<EventHubsNetworkSecurityPerimeter> networkSecurityPerimeters, IReadOnlyList<string> fullyQualifiedDomainNames)
        {
            Direction = direction;
            AddressPrefixes = addressPrefixes;
            Subscriptions = subscriptions;
            NetworkSecurityPerimeters = networkSecurityPerimeters;
            FullyQualifiedDomainNames = fullyQualifiedDomainNames;
        }

        /// <summary> Direction of Access Rule. </summary>
        public EventHubsNspAccessRuleDirection? Direction { get; }
        /// <summary> Address prefixes in the CIDR format for inbound rules. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> Subscriptions for inbound rules. </summary>
        public IReadOnlyList<SubResource> Subscriptions { get; }
        /// <summary> NetworkSecurityPerimeters for inbound rules. </summary>
        public IReadOnlyList<EventHubsNetworkSecurityPerimeter> NetworkSecurityPerimeters { get; }
        /// <summary> FQDN for outbound rules. </summary>
        public IReadOnlyList<string> FullyQualifiedDomainNames { get; }
    }
}
