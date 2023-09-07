// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> An object that defines the blob inventory rule. </summary>
    public partial class BlobInventoryPolicyDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyDefinition"/>. </summary>
        /// <param name="format"> This is a required field, it specifies the format for the inventory files. </param>
        /// <param name="schedule"> This is a required field. This field is used to schedule an inventory formation. </param>
        /// <param name="objectType"> This is a required field. This field specifies the scope of the inventory created either at the blob or container level. </param>
        /// <param name="schemaFields"> This is a required field. This field specifies the fields and properties of the object to be included in the inventory. The Schema field value 'Name' is always required. The valid values for this field for the 'Blob' definition.objectType include 'Name, Creation-Time, Last-Modified, Content-Length, Content-MD5, BlobType, AccessTier, AccessTierChangeTime, AccessTierInferred, Tags, Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, Snapshot, VersionId, IsCurrentVersion, Metadata, LastAccessTime, Tags, Etag, ContentType, ContentEncoding, ContentLanguage, ContentCRC64, CacheControl, ContentDisposition, LeaseStatus, LeaseState, LeaseDuration, ServerEncrypted, Deleted, DeletionId, DeletedTime, RemainingRetentionDays, ImmutabilityPolicyUntilDate, ImmutabilityPolicyMode, LegalHold, CopyId, CopyStatus, CopySource, CopyProgress, CopyCompletionTime, CopyStatusDescription, CustomerProvidedKeySha256, RehydratePriority, ArchiveStatus, XmsBlobSequenceNumber, EncryptionScope, IncrementalCopy, TagCount'. For Blob object type schema field value 'DeletedTime' is applicable only for Hns enabled accounts. The valid values for 'Container' definition.objectType include 'Name, Last-Modified, Metadata, LeaseStatus, LeaseState, LeaseDuration, PublicAccess, HasImmutabilityPolicy, HasLegalHold, Etag, DefaultEncryptionScope, DenyEncryptionScopeOverride, ImmutableStorageWithVersioningEnabled, Deleted, Version, DeletedTime, RemainingRetentionDays'. Schema field values 'Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, DeletionId' are valid only for Hns enabled accounts.Schema field values 'Tags, TagCount' are only valid for Non-Hns accounts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaFields"/> is null. </exception>
        public BlobInventoryPolicyDefinition(BlobInventoryPolicyFormat format, BlobInventoryPolicySchedule schedule, BlobInventoryPolicyObjectType objectType, IEnumerable<string> schemaFields)
        {
            Argument.AssertNotNull(schemaFields, nameof(schemaFields));

            Format = format;
            Schedule = schedule;
            ObjectType = objectType;
            SchemaFields = schemaFields.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyDefinition"/>. </summary>
        /// <param name="filters"> An object that defines the filter set. </param>
        /// <param name="format"> This is a required field, it specifies the format for the inventory files. </param>
        /// <param name="schedule"> This is a required field. This field is used to schedule an inventory formation. </param>
        /// <param name="objectType"> This is a required field. This field specifies the scope of the inventory created either at the blob or container level. </param>
        /// <param name="schemaFields"> This is a required field. This field specifies the fields and properties of the object to be included in the inventory. The Schema field value 'Name' is always required. The valid values for this field for the 'Blob' definition.objectType include 'Name, Creation-Time, Last-Modified, Content-Length, Content-MD5, BlobType, AccessTier, AccessTierChangeTime, AccessTierInferred, Tags, Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, Snapshot, VersionId, IsCurrentVersion, Metadata, LastAccessTime, Tags, Etag, ContentType, ContentEncoding, ContentLanguage, ContentCRC64, CacheControl, ContentDisposition, LeaseStatus, LeaseState, LeaseDuration, ServerEncrypted, Deleted, DeletionId, DeletedTime, RemainingRetentionDays, ImmutabilityPolicyUntilDate, ImmutabilityPolicyMode, LegalHold, CopyId, CopyStatus, CopySource, CopyProgress, CopyCompletionTime, CopyStatusDescription, CustomerProvidedKeySha256, RehydratePriority, ArchiveStatus, XmsBlobSequenceNumber, EncryptionScope, IncrementalCopy, TagCount'. For Blob object type schema field value 'DeletedTime' is applicable only for Hns enabled accounts. The valid values for 'Container' definition.objectType include 'Name, Last-Modified, Metadata, LeaseStatus, LeaseState, LeaseDuration, PublicAccess, HasImmutabilityPolicy, HasLegalHold, Etag, DefaultEncryptionScope, DenyEncryptionScopeOverride, ImmutableStorageWithVersioningEnabled, Deleted, Version, DeletedTime, RemainingRetentionDays'. Schema field values 'Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, DeletionId' are valid only for Hns enabled accounts.Schema field values 'Tags, TagCount' are only valid for Non-Hns accounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobInventoryPolicyDefinition(BlobInventoryPolicyFilter filters, BlobInventoryPolicyFormat format, BlobInventoryPolicySchedule schedule, BlobInventoryPolicyObjectType objectType, IList<string> schemaFields, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Filters = filters;
            Format = format;
            Schedule = schedule;
            ObjectType = objectType;
            SchemaFields = schemaFields;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyDefinition"/> for deserialization. </summary>
        internal BlobInventoryPolicyDefinition()
        {
        }

        /// <summary> An object that defines the filter set. </summary>
        public BlobInventoryPolicyFilter Filters { get; set; }
        /// <summary> This is a required field, it specifies the format for the inventory files. </summary>
        public BlobInventoryPolicyFormat Format { get; set; }
        /// <summary> This is a required field. This field is used to schedule an inventory formation. </summary>
        public BlobInventoryPolicySchedule Schedule { get; set; }
        /// <summary> This is a required field. This field specifies the scope of the inventory created either at the blob or container level. </summary>
        public BlobInventoryPolicyObjectType ObjectType { get; set; }
        /// <summary> This is a required field. This field specifies the fields and properties of the object to be included in the inventory. The Schema field value 'Name' is always required. The valid values for this field for the 'Blob' definition.objectType include 'Name, Creation-Time, Last-Modified, Content-Length, Content-MD5, BlobType, AccessTier, AccessTierChangeTime, AccessTierInferred, Tags, Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, Snapshot, VersionId, IsCurrentVersion, Metadata, LastAccessTime, Tags, Etag, ContentType, ContentEncoding, ContentLanguage, ContentCRC64, CacheControl, ContentDisposition, LeaseStatus, LeaseState, LeaseDuration, ServerEncrypted, Deleted, DeletionId, DeletedTime, RemainingRetentionDays, ImmutabilityPolicyUntilDate, ImmutabilityPolicyMode, LegalHold, CopyId, CopyStatus, CopySource, CopyProgress, CopyCompletionTime, CopyStatusDescription, CustomerProvidedKeySha256, RehydratePriority, ArchiveStatus, XmsBlobSequenceNumber, EncryptionScope, IncrementalCopy, TagCount'. For Blob object type schema field value 'DeletedTime' is applicable only for Hns enabled accounts. The valid values for 'Container' definition.objectType include 'Name, Last-Modified, Metadata, LeaseStatus, LeaseState, LeaseDuration, PublicAccess, HasImmutabilityPolicy, HasLegalHold, Etag, DefaultEncryptionScope, DenyEncryptionScopeOverride, ImmutableStorageWithVersioningEnabled, Deleted, Version, DeletedTime, RemainingRetentionDays'. Schema field values 'Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, DeletionId' are valid only for Hns enabled accounts.Schema field values 'Tags, TagCount' are only valid for Non-Hns accounts. </summary>
        public IList<string> SchemaFields { get; }
    }
}
