// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Properties of the managed HSM Pool. </summary>
    public partial class ManagedHsmProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmProperties"/>. </summary>
        public ManagedHsmProperties()
        {
            InitialAdminObjectIds = new ChangeTrackingList<string>();
            Regions = new ChangeTrackingList<ManagedHsmGeoReplicatedRegion>();
            PrivateEndpointConnections = new ChangeTrackingList<ManagedHsmPrivateEndpointConnectionItemData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmProperties"/>. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the managed HSM pool. </param>
        /// <param name="initialAdminObjectIds"> Array of initial administrators object ids for this managed hsm pool. </param>
        /// <param name="hsmUri"> The URI of the managed hsm pool for performing operations on keys. </param>
        /// <param name="enableSoftDelete"> Property to specify whether the 'soft delete' functionality is enabled for this managed HSM pool. Soft delete is enabled by default for all managed HSMs and is immutable. </param>
        /// <param name="softDeleteRetentionInDays"> Soft deleted data retention days. When you delete an HSM or a key, it will remain recoverable for the configured retention period or for a default period of 90 days. It accepts values between 7 and 90. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this managed HSM pool. Setting this property to true activates protection against purge for this managed HSM pool and its content - only the Managed HSM service may initiate a hard, irrecoverable deletion. Enabling this functionality is irreversible. </param>
        /// <param name="createMode"> The create mode to indicate whether the resource is being created or is being recovered from a deleted resource. </param>
        /// <param name="statusMessage"> Resource Status Message. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="networkRuleSet"> Rules governing the accessibility of the key vault from specific network locations. </param>
        /// <param name="regions"> List of all regions associated with the managed hsm pool. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the managed hsm pool. </param>
        /// <param name="publicNetworkAccess"> Control permission to the managed HSM from public networks. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purge date in UTC. </param>
        /// <param name="securityDomainProperties"> Managed HSM security domain properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedHsmProperties(Guid? tenantId, IList<string> initialAdminObjectIds, Uri hsmUri, bool? enableSoftDelete, int? softDeleteRetentionInDays, bool? enablePurgeProtection, ManagedHsmCreateMode? createMode, string statusMessage, ManagedHsmProvisioningState? provisioningState, ManagedHsmNetworkRuleSet networkRuleSet, IList<ManagedHsmGeoReplicatedRegion> regions, IReadOnlyList<ManagedHsmPrivateEndpointConnectionItemData> privateEndpointConnections, ManagedHsmPublicNetworkAccess? publicNetworkAccess, DateTimeOffset? scheduledPurgeOn, ManagedHSMSecurityDomainProperties securityDomainProperties, Dictionary<string, BinaryData> rawData)
        {
            TenantId = tenantId;
            InitialAdminObjectIds = initialAdminObjectIds;
            HsmUri = hsmUri;
            EnableSoftDelete = enableSoftDelete;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            EnablePurgeProtection = enablePurgeProtection;
            CreateMode = createMode;
            StatusMessage = statusMessage;
            ProvisioningState = provisioningState;
            NetworkRuleSet = networkRuleSet;
            Regions = regions;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            ScheduledPurgeOn = scheduledPurgeOn;
            SecurityDomainProperties = securityDomainProperties;
            _rawData = rawData;
        }

        /// <summary> The Azure Active Directory tenant ID that should be used for authenticating requests to the managed HSM pool. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Array of initial administrators object ids for this managed hsm pool. </summary>
        public IList<string> InitialAdminObjectIds { get; }
        /// <summary> The URI of the managed hsm pool for performing operations on keys. </summary>
        public Uri HsmUri { get; }
        /// <summary> Property to specify whether the 'soft delete' functionality is enabled for this managed HSM pool. Soft delete is enabled by default for all managed HSMs and is immutable. </summary>
        public bool? EnableSoftDelete { get; set; }
        /// <summary> Soft deleted data retention days. When you delete an HSM or a key, it will remain recoverable for the configured retention period or for a default period of 90 days. It accepts values between 7 and 90. </summary>
        public int? SoftDeleteRetentionInDays { get; set; }
        /// <summary> Property specifying whether protection against purge is enabled for this managed HSM pool. Setting this property to true activates protection against purge for this managed HSM pool and its content - only the Managed HSM service may initiate a hard, irrecoverable deletion. Enabling this functionality is irreversible. </summary>
        public bool? EnablePurgeProtection { get; set; }
        /// <summary> The create mode to indicate whether the resource is being created or is being recovered from a deleted resource. </summary>
        public ManagedHsmCreateMode? CreateMode { get; set; }
        /// <summary> Resource Status Message. </summary>
        public string StatusMessage { get; }
        /// <summary> Provisioning state. </summary>
        public ManagedHsmProvisioningState? ProvisioningState { get; }
        /// <summary> Rules governing the accessibility of the key vault from specific network locations. </summary>
        public ManagedHsmNetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> List of all regions associated with the managed hsm pool. </summary>
        public IList<ManagedHsmGeoReplicatedRegion> Regions { get; }
        /// <summary> List of private endpoint connections associated with the managed hsm pool. </summary>
        public IReadOnlyList<ManagedHsmPrivateEndpointConnectionItemData> PrivateEndpointConnections { get; }
        /// <summary> Control permission to the managed HSM from public networks. </summary>
        public ManagedHsmPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The scheduled purge date in UTC. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
        /// <summary> Managed HSM security domain properties. </summary>
        public ManagedHSMSecurityDomainProperties SecurityDomainProperties { get; }
    }
}
