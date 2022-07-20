// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the BlobContainer data model. </summary>
    public partial class BlobContainerData : ResourceData
    {
        /// <summary> Initializes a new instance of BlobContainerData. </summary>
        public BlobContainerData()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of BlobContainerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="version"> The version of the deleted blob container. </param>
        /// <param name="isDeleted"> Indicates whether the blob container was deleted. </param>
        /// <param name="deletedOn"> Blob container deletion time. </param>
        /// <param name="remainingRetentionDays"> Remaining retention days for soft deleted blob container. </param>
        /// <param name="defaultEncryptionScope"> Default the container to use specified encryption scope for all writes. </param>
        /// <param name="denyEncryptionScopeOverride"> Block override of encryption scope from the container default. </param>
        /// <param name="publicAccess"> Specifies whether data in the container may be accessed publicly and the level of access. </param>
        /// <param name="lastModifiedOn"> Returns the date and time the container was last modified. </param>
        /// <param name="leaseStatus"> The lease status of the container. </param>
        /// <param name="leaseState"> Lease state of the container. </param>
        /// <param name="leaseDuration"> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </param>
        /// <param name="metadata"> A name-value pair to associate with the container as metadata. </param>
        /// <param name="immutabilityPolicy"> The ImmutabilityPolicy property of the container. </param>
        /// <param name="legalHold"> The LegalHold property of the container. </param>
        /// <param name="hasLegalHold"> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </param>
        /// <param name="hasImmutabilityPolicy"> The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container. </param>
        /// <param name="immutableStorageWithVersioning"> The object level immutability property of the container. The property is immutable and can only be set to true at the container creation time. Existing containers must undergo a migration process. </param>
        /// <param name="enableNfsV3RootSquash"> Enable NFSv3 root squash on blob container. </param>
        /// <param name="enableNfsV3AllSquash"> Enable NFSv3 all squash on blob container. </param>
        /// <param name="etag"> Resource Etag. </param>
        internal BlobContainerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string version, bool? isDeleted, DateTimeOffset? deletedOn, int? remainingRetentionDays, string defaultEncryptionScope, bool? denyEncryptionScopeOverride, StoragePublicAccess? publicAccess, DateTimeOffset? lastModifiedOn, LeaseStatus? leaseStatus, LeaseState? leaseState, LeaseDuration? leaseDuration, IDictionary<string, string> metadata, ImmutabilityPolicyProperties immutabilityPolicy, LegalHoldProperties legalHold, bool? hasLegalHold, bool? hasImmutabilityPolicy, ImmutableStorageWithVersioning immutableStorageWithVersioning, bool? enableNfsV3RootSquash, bool? enableNfsV3AllSquash, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Version = version;
            IsDeleted = isDeleted;
            DeletedOn = deletedOn;
            RemainingRetentionDays = remainingRetentionDays;
            DefaultEncryptionScope = defaultEncryptionScope;
            DenyEncryptionScopeOverride = denyEncryptionScopeOverride;
            PublicAccess = publicAccess;
            LastModifiedOn = lastModifiedOn;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            Metadata = metadata;
            ImmutabilityPolicy = immutabilityPolicy;
            LegalHold = legalHold;
            HasLegalHold = hasLegalHold;
            HasImmutabilityPolicy = hasImmutabilityPolicy;
            ImmutableStorageWithVersioning = immutableStorageWithVersioning;
            EnableNfsV3RootSquash = enableNfsV3RootSquash;
            EnableNfsV3AllSquash = enableNfsV3AllSquash;
            ETag = etag;
        }

        /// <summary> The version of the deleted blob container. </summary>
        public string Version { get; }
        /// <summary> Indicates whether the blob container was deleted. </summary>
        public bool? IsDeleted { get; }
        /// <summary> Blob container deletion time. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> Remaining retention days for soft deleted blob container. </summary>
        public int? RemainingRetentionDays { get; }
        /// <summary> Default the container to use specified encryption scope for all writes. </summary>
        public string DefaultEncryptionScope { get; set; }
        /// <summary> Block override of encryption scope from the container default. </summary>
        public bool? DenyEncryptionScopeOverride { get; set; }
        /// <summary> Specifies whether data in the container may be accessed publicly and the level of access. </summary>
        public StoragePublicAccess? PublicAccess { get; set; }
        /// <summary> Returns the date and time the container was last modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The lease status of the container. </summary>
        public LeaseStatus? LeaseStatus { get; }
        /// <summary> Lease state of the container. </summary>
        public LeaseState? LeaseState { get; }
        /// <summary> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </summary>
        public LeaseDuration? LeaseDuration { get; }
        /// <summary> A name-value pair to associate with the container as metadata. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The ImmutabilityPolicy property of the container. </summary>
        public ImmutabilityPolicyProperties ImmutabilityPolicy { get; }
        /// <summary> The LegalHold property of the container. </summary>
        public LegalHoldProperties LegalHold { get; }
        /// <summary> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </summary>
        public bool? HasLegalHold { get; }
        /// <summary> The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container. </summary>
        public bool? HasImmutabilityPolicy { get; }
        /// <summary> The object level immutability property of the container. The property is immutable and can only be set to true at the container creation time. Existing containers must undergo a migration process. </summary>
        public ImmutableStorageWithVersioning ImmutableStorageWithVersioning { get; set; }
        /// <summary> Enable NFSv3 root squash on blob container. </summary>
        public bool? EnableNfsV3RootSquash { get; set; }
        /// <summary> Enable NFSv3 all squash on blob container. </summary>
        public bool? EnableNfsV3AllSquash { get; set; }
        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
    }
}
