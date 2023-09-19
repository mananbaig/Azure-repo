// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningWorkspace data model.
    /// An object that represents a machine learning workspace.
    /// </summary>
    public partial class MachineLearningWorkspaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceData. </summary>
        /// <param name="location"> The location. </param>
        public MachineLearningWorkspaceData(AzureLocation location) : base(location)
        {
            AssociatedWorkspaces = new ChangeTrackingList<string>();
            ContainerRegistries = new ChangeTrackingList<string>();
            ExistingWorkspaces = new ChangeTrackingList<string>();
            KeyVaults = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<MachineLearningPrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<MachineLearningSharedPrivateLinkResource>();
            StorageAccounts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="kind"></param>
        /// <param name="sku"> Optional. This field is required to be implemented by the RP because AML is supporting more than one tier. </param>
        /// <param name="allowPublicAccessWhenBehindVnet"> The flag to indicate whether to allow public access when behind VNet. </param>
        /// <param name="applicationInsights"> ARM id of the application insights associated with this workspace. </param>
        /// <param name="associatedWorkspaces"></param>
        /// <param name="containerRegistries"></param>
        /// <param name="containerRegistry"> ARM id of the container registry associated with this workspace. </param>
        /// <param name="description"> The description of this workspace. </param>
        /// <param name="discoveryUri"> Url for the discovery service to identify regional endpoints for machine learning experimentation services. </param>
        /// <param name="enableDataIsolation"></param>
        /// <param name="encryption"></param>
        /// <param name="existingWorkspaces"></param>
        /// <param name="featureStoreSettings"> Settings for feature store type workspace. </param>
        /// <param name="friendlyName"> The friendly name for this workspace. This name in mutable. </param>
        /// <param name="isHbiWorkspace"> The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service. </param>
        /// <param name="hubResourceId"></param>
        /// <param name="imageBuildCompute"> The compute name for image build. </param>
        /// <param name="keyVault"> ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created. </param>
        /// <param name="keyVaults"></param>
        /// <param name="managedNetwork"> Managed Network settings for a machine learning workspace. </param>
        /// <param name="mlFlowTrackingUri"> The URI associated with this workspace that machine learning flow must point at to set up tracking. </param>
        /// <param name="notebookInfo"> The notebook info of Azure ML workspace. </param>
        /// <param name="primaryUserAssignedIdentity"> The user assigned identity resource id that represents the workspace identity. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections in the workspace. </param>
        /// <param name="privateLinkCount"> Count of private connections in the workspace. </param>
        /// <param name="provisioningState"> The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="serviceManagedResourcesSettings"> The service managed resource settings. </param>
        /// <param name="serviceProvisionedResourceGroup"> The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources in this workspace. </param>
        /// <param name="softDeleteRetentionInDays"> Retention time in days after workspace get soft deleted. </param>
        /// <param name="storageAccount"> ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created. </param>
        /// <param name="storageAccounts"></param>
        /// <param name="isStorageHnsEnabled"> If the storage associated with the workspace has hierarchical namespace(HNS) enabled. </param>
        /// <param name="systemDatastoresAuthMode"> The auth mode used for accessing the system datastores of the workspace. </param>
        /// <param name="tenantId"> The tenant id associated with this workspace. </param>
        /// <param name="isV1LegacyMode"> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </param>
        /// <param name="workspaceHubConfig"> WorkspaceHub's configuration object. </param>
        /// <param name="workspaceId"> The immutable id associated with this workspace. </param>
        internal MachineLearningWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string kind, MachineLearningSku sku, bool? allowPublicAccessWhenBehindVnet, string applicationInsights, IList<string> associatedWorkspaces, IList<string> containerRegistries, string containerRegistry, string description, Uri discoveryUri, bool? enableDataIsolation, MachineLearningEncryptionSetting encryption, IList<string> existingWorkspaces, FeatureStoreSettings featureStoreSettings, string friendlyName, bool? isHbiWorkspace, string hubResourceId, string imageBuildCompute, string keyVault, IList<string> keyVaults, ManagedNetworkSettings managedNetwork, Uri mlFlowTrackingUri, MachineLearningNotebookResourceInfo notebookInfo, string primaryUserAssignedIdentity, IReadOnlyList<MachineLearningPrivateEndpointConnectionData> privateEndpointConnections, int? privateLinkCount, MachineLearningProvisioningState? provisioningState, MachineLearningPublicNetworkAccessType? publicNetworkAccess, ServiceManagedResourcesSettings serviceManagedResourcesSettings, string serviceProvisionedResourceGroup, IList<MachineLearningSharedPrivateLinkResource> sharedPrivateLinkResources, int? softDeleteRetentionInDays, string storageAccount, IList<string> storageAccounts, bool? isStorageHnsEnabled, string systemDatastoresAuthMode, Guid? tenantId, bool? isV1LegacyMode, WorkspaceHubConfig workspaceHubConfig, string workspaceId) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Kind = kind;
            Sku = sku;
            AllowPublicAccessWhenBehindVnet = allowPublicAccessWhenBehindVnet;
            ApplicationInsights = applicationInsights;
            AssociatedWorkspaces = associatedWorkspaces;
            ContainerRegistries = containerRegistries;
            ContainerRegistry = containerRegistry;
            Description = description;
            DiscoveryUri = discoveryUri;
            EnableDataIsolation = enableDataIsolation;
            Encryption = encryption;
            ExistingWorkspaces = existingWorkspaces;
            FeatureStoreSettings = featureStoreSettings;
            FriendlyName = friendlyName;
            IsHbiWorkspace = isHbiWorkspace;
            HubResourceId = hubResourceId;
            ImageBuildCompute = imageBuildCompute;
            KeyVault = keyVault;
            KeyVaults = keyVaults;
            ManagedNetwork = managedNetwork;
            MlFlowTrackingUri = mlFlowTrackingUri;
            NotebookInfo = notebookInfo;
            PrimaryUserAssignedIdentity = primaryUserAssignedIdentity;
            PrivateEndpointConnections = privateEndpointConnections;
            PrivateLinkCount = privateLinkCount;
            ProvisioningState = provisioningState;
            PublicNetworkAccess = publicNetworkAccess;
            ServiceManagedResourcesSettings = serviceManagedResourcesSettings;
            ServiceProvisionedResourceGroup = serviceProvisionedResourceGroup;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            StorageAccount = storageAccount;
            StorageAccounts = storageAccounts;
            IsStorageHnsEnabled = isStorageHnsEnabled;
            SystemDatastoresAuthMode = systemDatastoresAuthMode;
            TenantId = tenantId;
            IsV1LegacyMode = isV1LegacyMode;
            WorkspaceHubConfig = workspaceHubConfig;
            WorkspaceId = workspaceId;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the kind. </summary>
        public string Kind { get; set; }
        /// <summary> Optional. This field is required to be implemented by the RP because AML is supporting more than one tier. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> The flag to indicate whether to allow public access when behind VNet. </summary>
        public bool? AllowPublicAccessWhenBehindVnet { get; set; }
        /// <summary> ARM id of the application insights associated with this workspace. </summary>
        public string ApplicationInsights { get; set; }
        /// <summary> Gets the associated workspaces. </summary>
        public IList<string> AssociatedWorkspaces { get; }
        /// <summary> Gets the container registries. </summary>
        public IList<string> ContainerRegistries { get; }
        /// <summary> ARM id of the container registry associated with this workspace. </summary>
        public string ContainerRegistry { get; set; }
        /// <summary> The description of this workspace. </summary>
        public string Description { get; set; }
        /// <summary> Url for the discovery service to identify regional endpoints for machine learning experimentation services. </summary>
        public Uri DiscoveryUri { get; set; }
        /// <summary> Gets or sets the enable data isolation. </summary>
        public bool? EnableDataIsolation { get; set; }
        /// <summary> Gets or sets the encryption. </summary>
        public MachineLearningEncryptionSetting Encryption { get; set; }
        /// <summary> Gets the existing workspaces. </summary>
        public IList<string> ExistingWorkspaces { get; }
        /// <summary> Settings for feature store type workspace. </summary>
        public FeatureStoreSettings FeatureStoreSettings { get; set; }
        /// <summary> The friendly name for this workspace. This name in mutable. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service. </summary>
        public bool? IsHbiWorkspace { get; set; }
        /// <summary> Gets or sets the hub resource id. </summary>
        public string HubResourceId { get; set; }
        /// <summary> The compute name for image build. </summary>
        public string ImageBuildCompute { get; set; }
        /// <summary> ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created. </summary>
        public string KeyVault { get; set; }
        /// <summary> Gets the key vaults. </summary>
        public IList<string> KeyVaults { get; }
        /// <summary> Managed Network settings for a machine learning workspace. </summary>
        public ManagedNetworkSettings ManagedNetwork { get; set; }
        /// <summary> The URI associated with this workspace that machine learning flow must point at to set up tracking. </summary>
        public Uri MlFlowTrackingUri { get; }
        /// <summary> The notebook info of Azure ML workspace. </summary>
        public MachineLearningNotebookResourceInfo NotebookInfo { get; }
        /// <summary> The user assigned identity resource id that represents the workspace identity. </summary>
        public string PrimaryUserAssignedIdentity { get; set; }
        /// <summary> The list of private endpoint connections in the workspace. </summary>
        public IReadOnlyList<MachineLearningPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Count of private connections in the workspace. </summary>
        public int? PrivateLinkCount { get; }
        /// <summary> The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning. </summary>
        public MachineLearningProvisioningState? ProvisioningState { get; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public MachineLearningPublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> The service managed resource settings. </summary>
        internal ServiceManagedResourcesSettings ServiceManagedResourcesSettings { get; set; }
        /// <summary> Gets or sets the cosmos db collections throughput. </summary>
        public int? CosmosDbCollectionsThroughput
        {
            get => ServiceManagedResourcesSettings is null ? default : ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput;
            set
            {
                if (ServiceManagedResourcesSettings is null)
                    ServiceManagedResourcesSettings = new ServiceManagedResourcesSettings();
                ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput = value;
            }
        }

        /// <summary> The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace. </summary>
        public string ServiceProvisionedResourceGroup { get; }
        /// <summary> The list of shared private link resources in this workspace. </summary>
        public IList<MachineLearningSharedPrivateLinkResource> SharedPrivateLinkResources { get; }
        /// <summary> Retention time in days after workspace get soft deleted. </summary>
        public int? SoftDeleteRetentionInDays { get; set; }
        /// <summary> ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created. </summary>
        public string StorageAccount { get; set; }
        /// <summary> Gets the storage accounts. </summary>
        public IList<string> StorageAccounts { get; }
        /// <summary> If the storage associated with the workspace has hierarchical namespace(HNS) enabled. </summary>
        public bool? IsStorageHnsEnabled { get; }
        /// <summary> The auth mode used for accessing the system datastores of the workspace. </summary>
        public string SystemDatastoresAuthMode { get; set; }
        /// <summary> The tenant id associated with this workspace. </summary>
        public Guid? TenantId { get; }
        /// <summary> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </summary>
        public bool? IsV1LegacyMode { get; set; }
        /// <summary> WorkspaceHub's configuration object. </summary>
        public WorkspaceHubConfig WorkspaceHubConfig { get; set; }
        /// <summary> The immutable id associated with this workspace. </summary>
        public string WorkspaceId { get; }
    }
}
