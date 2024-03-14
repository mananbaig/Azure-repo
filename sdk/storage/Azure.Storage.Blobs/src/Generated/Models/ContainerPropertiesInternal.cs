// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Storage.Common;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Properties of a container. </summary>
    internal partial class ContainerPropertiesInternal
    {
        /// <summary> Initializes a new instance of <see cref="ContainerPropertiesInternal"/>. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="etag"/> is null. </exception>
        internal ContainerPropertiesInternal(DateTimeOffset lastModified, string etag)
        {
            Argument.AssertNotNull(etag, nameof(etag));

            LastModified = lastModified;
            Etag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerPropertiesInternal"/>. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="leaseStatus"></param>
        /// <param name="leaseState"></param>
        /// <param name="leaseDuration"></param>
        /// <param name="publicAccess"></param>
        /// <param name="hasImmutabilityPolicy"></param>
        /// <param name="hasLegalHold"></param>
        /// <param name="defaultEncryptionScope"></param>
        /// <param name="preventEncryptionScopeOverride"></param>
        /// <param name="deletedTime"></param>
        /// <param name="remainingRetentionDays"></param>
        /// <param name="isImmutableStorageWithVersioningEnabled"> Indicates if version level worm is enabled on this container. </param>
        internal ContainerPropertiesInternal(DateTimeOffset lastModified, string etag, LeaseStatus? leaseStatus, LeaseState? leaseState, LeaseDurationType? leaseDuration, PublicAccessType? publicAccess, bool? hasImmutabilityPolicy, bool? hasLegalHold, string defaultEncryptionScope, bool? preventEncryptionScopeOverride, DateTimeOffset? deletedTime, int? remainingRetentionDays, bool? isImmutableStorageWithVersioningEnabled)
        {
            LastModified = lastModified;
            Etag = etag;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            PublicAccess = publicAccess;
            HasImmutabilityPolicy = hasImmutabilityPolicy;
            HasLegalHold = hasLegalHold;
            DefaultEncryptionScope = defaultEncryptionScope;
            PreventEncryptionScopeOverride = preventEncryptionScopeOverride;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            IsImmutableStorageWithVersioningEnabled = isImmutableStorageWithVersioningEnabled;
        }

        /// <summary> Gets the last modified. </summary>
        public DateTimeOffset LastModified { get; }
        /// <summary> Gets the etag. </summary>
        public string Etag { get; }
        /// <summary> Gets the lease status. </summary>
        public LeaseStatus? LeaseStatus { get; }
        /// <summary> Gets the lease state. </summary>
        public LeaseState? LeaseState { get; }
        /// <summary> Gets the lease duration. </summary>
        public LeaseDurationType? LeaseDuration { get; }
        /// <summary> Gets the public access. </summary>
        public PublicAccessType? PublicAccess { get; }
        /// <summary> Gets the has immutability policy. </summary>
        public bool? HasImmutabilityPolicy { get; }
        /// <summary> Gets the has legal hold. </summary>
        public bool? HasLegalHold { get; }
        /// <summary> Gets the default encryption scope. </summary>
        public string DefaultEncryptionScope { get; }
        /// <summary> Gets the prevent encryption scope override. </summary>
        public bool? PreventEncryptionScopeOverride { get; }
        /// <summary> Gets the deleted time. </summary>
        public DateTimeOffset? DeletedTime { get; }
        /// <summary> Gets the remaining retention days. </summary>
        public int? RemainingRetentionDays { get; }
        /// <summary> Indicates if version level worm is enabled on this container. </summary>
        public bool? IsImmutableStorageWithVersioningEnabled { get; }
    }
}
