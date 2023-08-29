// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary>
    /// A class representing the NewRelicMonitorResource data model.
    /// A Monitor Resource by NewRelic
    /// </summary>
    public partial class NewRelicMonitorResourceData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicMonitorResourceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public NewRelicMonitorResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicMonitorResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="provisioningState"> Provisioning State of the resource. </param>
        /// <param name="monitoringStatus"> MonitoringStatus of the resource. </param>
        /// <param name="marketplaceSubscriptionStatus"> NewRelic Organization properties of the resource. </param>
        /// <param name="marketplaceSubscriptionId"> Marketplace Subscription Id. </param>
        /// <param name="newRelicAccountProperties"> MarketplaceSubscriptionStatus of the resource. </param>
        /// <param name="userInfo"> User Info. </param>
        /// <param name="planData"> Plan details. </param>
        /// <param name="liftrResourceCategory"> Liftr resource category. </param>
        /// <param name="liftrResourcePreference"> Liftr resource preference. The priority of the resource. </param>
        /// <param name="orgCreationSource"> Source of org creation. </param>
        /// <param name="accountCreationSource"> Source of account creation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicMonitorResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, NewRelicProvisioningState? provisioningState, NewRelicObservabilityMonitoringStatus? monitoringStatus, NewRelicObservabilityMarketplaceSubscriptionStatus? marketplaceSubscriptionStatus, string marketplaceSubscriptionId, NewRelicAccountProperties newRelicAccountProperties, NewRelicObservabilityUserInfo userInfo, NewRelicPlanDetails planData, NewRelicLiftrResourceCategory? liftrResourceCategory, int? liftrResourcePreference, NewRelicObservabilityOrgCreationSource? orgCreationSource, NewRelicObservabilityAccountCreationSource? accountCreationSource, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            MonitoringStatus = monitoringStatus;
            MarketplaceSubscriptionStatus = marketplaceSubscriptionStatus;
            MarketplaceSubscriptionId = marketplaceSubscriptionId;
            NewRelicAccountProperties = newRelicAccountProperties;
            UserInfo = userInfo;
            PlanData = planData;
            LiftrResourceCategory = liftrResourceCategory;
            LiftrResourcePreference = liftrResourcePreference;
            OrgCreationSource = orgCreationSource;
            AccountCreationSource = accountCreationSource;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicMonitorResourceData"/> for deserialization. </summary>
        internal NewRelicMonitorResourceData()
        {
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning State of the resource. </summary>
        public NewRelicProvisioningState? ProvisioningState { get; }
        /// <summary> MonitoringStatus of the resource. </summary>
        public NewRelicObservabilityMonitoringStatus? MonitoringStatus { get; }
        /// <summary> NewRelic Organization properties of the resource. </summary>
        public NewRelicObservabilityMarketplaceSubscriptionStatus? MarketplaceSubscriptionStatus { get; }
        /// <summary> Marketplace Subscription Id. </summary>
        public string MarketplaceSubscriptionId { get; }
        /// <summary> MarketplaceSubscriptionStatus of the resource. </summary>
        public NewRelicAccountProperties NewRelicAccountProperties { get; set; }
        /// <summary> User Info. </summary>
        public NewRelicObservabilityUserInfo UserInfo { get; set; }
        /// <summary> Plan details. </summary>
        public NewRelicPlanDetails PlanData { get; set; }
        /// <summary> Liftr resource category. </summary>
        public NewRelicLiftrResourceCategory? LiftrResourceCategory { get; }
        /// <summary> Liftr resource preference. The priority of the resource. </summary>
        public int? LiftrResourcePreference { get; }
        /// <summary> Source of org creation. </summary>
        public NewRelicObservabilityOrgCreationSource? OrgCreationSource { get; set; }
        /// <summary> Source of account creation. </summary>
        public NewRelicObservabilityAccountCreationSource? AccountCreationSource { get; set; }
    }
}
