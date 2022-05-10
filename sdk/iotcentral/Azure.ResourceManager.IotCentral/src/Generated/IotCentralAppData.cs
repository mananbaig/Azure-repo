// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotCentral.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotCentral
{
    /// <summary> A class representing the IotCentralApp data model. </summary>
    public partial class IotCentralAppData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IotCentralAppData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> A valid instance SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public IotCentralAppData(AzureLocation location, AppSkuInfo sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            PrivateEndpointConnections = new ChangeTrackingList<IotCentralPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of IotCentralAppData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> A valid instance SKU. </param>
        /// <param name="identity"> The managed identities for the IoT Central application. </param>
        /// <param name="provisioningState"> The provisioning state of the application. </param>
        /// <param name="applicationId"> The ID of the application. </param>
        /// <param name="displayName"> The display name of the application. </param>
        /// <param name="subdomain"> The subdomain of the application. </param>
        /// <param name="template"> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </param>
        /// <param name="state"> The current state of the application. </param>
        /// <param name="publicNetworkAccess"> Whether requests from the public network are allowed. </param>
        /// <param name="networkRuleSets"> Network Rule Set Properties of this IoT Central application. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IoT Central application. </param>
        internal IotCentralAppData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AppSkuInfo sku, SystemAssignedServiceIdentity identity, ProvisioningState? provisioningState, string applicationId, string displayName, string subdomain, string template, AppState? state, PublicNetworkAccess? publicNetworkAccess, NetworkRuleSets networkRuleSets, IReadOnlyList<IotCentralPrivateEndpointConnectionData> privateEndpointConnections) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ProvisioningState = provisioningState;
            ApplicationId = applicationId;
            DisplayName = displayName;
            Subdomain = subdomain;
            Template = template;
            State = state;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkRuleSets = networkRuleSets;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> A valid instance SKU. </summary>
        internal AppSkuInfo Sku { get; set; }
        /// <summary> The name of the SKU. </summary>
        public AppSku? SkuName
        {
            get => Sku is null ? default(AppSku?) : Sku.Name;
            set
            {
                Sku = value.HasValue ? new AppSkuInfo(value.Value) : null;
            }
        }

        /// <summary> The managed identities for the IoT Central application. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> The provisioning state of the application. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The ID of the application. </summary>
        public string ApplicationId { get; }
        /// <summary> The display name of the application. </summary>
        public string DisplayName { get; set; }
        /// <summary> The subdomain of the application. </summary>
        public string Subdomain { get; set; }
        /// <summary> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </summary>
        public string Template { get; set; }
        /// <summary> The current state of the application. </summary>
        public AppState? State { get; }
        /// <summary> Whether requests from the public network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Network Rule Set Properties of this IoT Central application. </summary>
        public NetworkRuleSets NetworkRuleSets { get; set; }
        /// <summary> Private endpoint connections created on this IoT Central application. </summary>
        public IReadOnlyList<IotCentralPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
