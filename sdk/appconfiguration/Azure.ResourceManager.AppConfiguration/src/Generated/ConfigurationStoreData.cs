// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing the ConfigurationStore data model. </summary>
    public partial class ConfigurationStoreData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ConfigurationStoreData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku of the configuration store. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ConfigurationStoreData(AzureLocation location, AppConfigurationSku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionReference>();
        }

        /// <summary> Initializes a new instance of ConfigurationStoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity information, if configured. </param>
        /// <param name="sku"> The sku of the configuration store. </param>
        /// <param name="provisioningState"> The provisioning state of the configuration store. </param>
        /// <param name="createdOn"> The creation date of configuration store. </param>
        /// <param name="endpoint"> The DNS endpoint where the configuration store API will be available. </param>
        /// <param name="encryption"> The encryption settings of the configuration store. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="disableLocalAuth"> Disables all authentication methods other than AAD authentication. </param>
        /// <param name="softDeleteRetentionInDays"> The amount of time in days that the configuration store will be retained when it is soft deleted. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this configuration store. </param>
        /// <param name="createMode"> Indicates whether the configuration store need to be recovered. </param>
        internal ConfigurationStoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, AppConfigurationSku sku, ProvisioningState? provisioningState, DateTimeOffset? createdOn, string endpoint, Models.EncryptionProperties encryption, IReadOnlyList<PrivateEndpointConnectionReference> privateEndpointConnections, PublicNetworkAccess? publicNetworkAccess, bool? disableLocalAuth, int? softDeleteRetentionInDays, bool? enablePurgeProtection, CreateMode? createMode) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            Endpoint = endpoint;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            DisableLocalAuth = disableLocalAuth;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            EnablePurgeProtection = enablePurgeProtection;
            CreateMode = createMode;
        }

        /// <summary> The managed identity information, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The sku of the configuration store. </summary>
        internal AppConfigurationSku Sku { get; set; }
        /// <summary> The SKU name of the configuration store. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new AppConfigurationSku(value);
        }

        /// <summary> The provisioning state of the configuration store. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The creation date of configuration store. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The DNS endpoint where the configuration store API will be available. </summary>
        public string Endpoint { get; }
        /// <summary> The encryption settings of the configuration store. </summary>
        internal Models.EncryptionProperties Encryption { get; set; }
        /// <summary> Key vault properties. </summary>
        public Models.KeyVaultProperties EncryptionKeyVaultProperties
        {
            get => Encryption is null ? default : Encryption.KeyVaultProperties;
            set
            {
                if (Encryption is null)
                    Encryption = new Models.EncryptionProperties();
                Encryption.KeyVaultProperties = value;
            }
        }

        /// <summary> The list of private endpoint connections that are set up for this resource. </summary>
        public IReadOnlyList<PrivateEndpointConnectionReference> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Disables all authentication methods other than AAD authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> The amount of time in days that the configuration store will be retained when it is soft deleted. </summary>
        public int? SoftDeleteRetentionInDays { get; set; }
        /// <summary> Property specifying whether protection against purge is enabled for this configuration store. </summary>
        public bool? EnablePurgeProtection { get; set; }
        /// <summary> Indicates whether the configuration store need to be recovered. </summary>
        public CreateMode? CreateMode { get; set; }
    }
}
