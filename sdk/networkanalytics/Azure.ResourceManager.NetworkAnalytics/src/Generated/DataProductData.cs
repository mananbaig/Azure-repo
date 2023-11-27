// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkAnalytics.Models;

namespace Azure.ResourceManager.NetworkAnalytics
{
    /// <summary>
    /// A class representing the DataProduct data model.
    /// The data product resource.
    /// </summary>
    public partial class DataProductData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DataProductData. </summary>
        /// <param name="location"> The location. </param>
        public DataProductData(AzureLocation location) : base(location)
        {
            Owners = new ChangeTrackingList<string>();
            AvailableMinorVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DataProductData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="resourceGuid"> The resource GUID property of the data product resource. </param>
        /// <param name="provisioningState"> Latest provisioning state  of data product. </param>
        /// <param name="publisher"> Data product publisher name. </param>
        /// <param name="product"> Product name of data product. </param>
        /// <param name="majorVersion"> Major version of data product. </param>
        /// <param name="owners"> List of name or email associated with data product resource deployment. </param>
        /// <param name="redundancy"> Flag to enable or disable redundancy for data product. </param>
        /// <param name="purviewAccount"> Purview account url for data product to connect to. </param>
        /// <param name="purviewCollection"> Purview collection url for data product to connect to. </param>
        /// <param name="privateLinksEnabled"> Flag to enable or disable private link for data product resource. </param>
        /// <param name="publicNetworkAccess"> Flag to enable or disable public access of data product resource. </param>
        /// <param name="customerManagedKeyEncryptionEnabled"> Flag to enable customer managed key encryption for data product. </param>
        /// <param name="customerEncryptionKey"> Customer managed encryption key details for data product. </param>
        /// <param name="networkacls"> Network rule set for data product. </param>
        /// <param name="managedResourceGroupConfiguration"> Managed resource group configuration. </param>
        /// <param name="availableMinorVersions"> List of available minor versions of the data product resource. </param>
        /// <param name="currentMinorVersion"> Current configured minor version of the data product resource. </param>
        /// <param name="documentation"> Documentation link for the data product based on definition file. </param>
        /// <param name="consumptionEndpoints"> Resource links which exposed to the customer to query the data. </param>
        /// <param name="keyVaultUri"> Key vault url. </param>
        internal DataProductData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string resourceGuid, NetworkAnalyticsProvisioningState? provisioningState, string publisher, string product, string majorVersion, IList<string> owners, DataProductControlState? redundancy, string purviewAccount, string purviewCollection, DataProductControlState? privateLinksEnabled, DataProductControlState? publicNetworkAccess, DataProductControlState? customerManagedKeyEncryptionEnabled, EncryptionKeyDetails customerEncryptionKey, DataProductNetworkAcls networkacls, NetworkAnalyticsManagedResourceGroupConfiguration managedResourceGroupConfiguration, IReadOnlyList<string> availableMinorVersions, string currentMinorVersion, string documentation, ConsumptionEndpointsProperties consumptionEndpoints, Uri keyVaultUri) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Publisher = publisher;
            Product = product;
            MajorVersion = majorVersion;
            Owners = owners;
            Redundancy = redundancy;
            PurviewAccount = purviewAccount;
            PurviewCollection = purviewCollection;
            PrivateLinksEnabled = privateLinksEnabled;
            PublicNetworkAccess = publicNetworkAccess;
            CustomerManagedKeyEncryptionEnabled = customerManagedKeyEncryptionEnabled;
            CustomerEncryptionKey = customerEncryptionKey;
            Networkacls = networkacls;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            AvailableMinorVersions = availableMinorVersions;
            CurrentMinorVersion = currentMinorVersion;
            Documentation = documentation;
            ConsumptionEndpoints = consumptionEndpoints;
            KeyVaultUri = keyVaultUri;
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The resource GUID property of the data product resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> Latest provisioning state  of data product. </summary>
        public NetworkAnalyticsProvisioningState? ProvisioningState { get; }
        /// <summary> Data product publisher name. </summary>
        public string Publisher { get; set; }
        /// <summary> Product name of data product. </summary>
        public string Product { get; set; }
        /// <summary> Major version of data product. </summary>
        public string MajorVersion { get; set; }
        /// <summary> List of name or email associated with data product resource deployment. </summary>
        public IList<string> Owners { get; }
        /// <summary> Flag to enable or disable redundancy for data product. </summary>
        public DataProductControlState? Redundancy { get; set; }
        /// <summary> Purview account url for data product to connect to. </summary>
        public string PurviewAccount { get; set; }
        /// <summary> Purview collection url for data product to connect to. </summary>
        public string PurviewCollection { get; set; }
        /// <summary> Flag to enable or disable private link for data product resource. </summary>
        public DataProductControlState? PrivateLinksEnabled { get; set; }
        /// <summary> Flag to enable or disable public access of data product resource. </summary>
        public DataProductControlState? PublicNetworkAccess { get; set; }
        /// <summary> Flag to enable customer managed key encryption for data product. </summary>
        public DataProductControlState? CustomerManagedKeyEncryptionEnabled { get; set; }
        /// <summary> Customer managed encryption key details for data product. </summary>
        public EncryptionKeyDetails CustomerEncryptionKey { get; set; }
        /// <summary> Network rule set for data product. </summary>
        public DataProductNetworkAcls Networkacls { get; set; }
        /// <summary> Managed resource group configuration. </summary>
        public NetworkAnalyticsManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> List of available minor versions of the data product resource. </summary>
        public IReadOnlyList<string> AvailableMinorVersions { get; }
        /// <summary> Current configured minor version of the data product resource. </summary>
        public string CurrentMinorVersion { get; set; }
        /// <summary> Documentation link for the data product based on definition file. </summary>
        public string Documentation { get; }
        /// <summary> Resource links which exposed to the customer to query the data. </summary>
        public ConsumptionEndpointsProperties ConsumptionEndpoints { get; }
        /// <summary> Key vault url. </summary>
        public Uri KeyVaultUri { get; }
    }
}
