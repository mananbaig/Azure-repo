// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Storage.Blobs.Models
{
    internal partial class BlobPropertiesInternal : IXmlSerializable, IModelSerializable<BlobPropertiesInternal>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Properties");
            if (Optional.IsDefined(CreationTime))
            {
                writer.WriteStartElement("Creation-Time");
                writer.WriteValue(CreationTime.Value, "R");
                writer.WriteEndElement();
            }
            writer.WriteStartElement("Last-Modified");
            writer.WriteValue(LastModified, "R");
            writer.WriteEndElement();
            writer.WriteStartElement("Etag");
            writer.WriteValue(Etag);
            writer.WriteEndElement();
            if (Optional.IsDefined(ContentLength))
            {
                writer.WriteStartElement("Content-Length");
                writer.WriteValue(ContentLength.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WriteStartElement("Content-Type");
                writer.WriteValue(ContentType);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ContentEncoding))
            {
                writer.WriteStartElement("Content-Encoding");
                writer.WriteValue(ContentEncoding);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ContentLanguage))
            {
                writer.WriteStartElement("Content-Language");
                writer.WriteValue(ContentLanguage);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ContentMD5))
            {
                writer.WriteStartElement("Content-MD5");
                writer.WriteValue(ContentMD5, "D");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ContentDisposition))
            {
                writer.WriteStartElement("Content-Disposition");
                writer.WriteValue(ContentDisposition);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CacheControl))
            {
                writer.WriteStartElement("Cache-Control");
                writer.WriteValue(CacheControl);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(BlobSequenceNumber))
            {
                writer.WriteStartElement("x-ms-blob-sequence-number");
                writer.WriteValue(BlobSequenceNumber.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(BlobType))
            {
                writer.WriteStartElement("BlobType");
                writer.WriteValue(BlobType.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LeaseStatus))
            {
                writer.WriteStartElement("LeaseStatus");
                writer.WriteValue(LeaseStatus.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LeaseState))
            {
                writer.WriteStartElement("LeaseState");
                writer.WriteValue(LeaseState.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LeaseDuration))
            {
                writer.WriteStartElement("LeaseDuration");
                writer.WriteValue(LeaseDuration.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CopyId))
            {
                writer.WriteStartElement("CopyId");
                writer.WriteValue(CopyId);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CopyStatus))
            {
                writer.WriteStartElement("CopyStatus");
                writer.WriteValue(CopyStatus.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CopySource))
            {
                writer.WriteStartElement("CopySource");
                writer.WriteValue(CopySource);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CopyProgress))
            {
                writer.WriteStartElement("CopyProgress");
                writer.WriteValue(CopyProgress);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CopyCompletionTime))
            {
                writer.WriteStartElement("CopyCompletionTime");
                writer.WriteValue(CopyCompletionTime.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CopyStatusDescription))
            {
                writer.WriteStartElement("CopyStatusDescription");
                writer.WriteValue(CopyStatusDescription);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ServerEncrypted))
            {
                writer.WriteStartElement("ServerEncrypted");
                writer.WriteValue(ServerEncrypted.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(IncrementalCopy))
            {
                writer.WriteStartElement("IncrementalCopy");
                writer.WriteValue(IncrementalCopy.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(DestinationSnapshot))
            {
                writer.WriteStartElement("DestinationSnapshot");
                writer.WriteValue(DestinationSnapshot);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(DeletedTime))
            {
                writer.WriteStartElement("DeletedTime");
                writer.WriteValue(DeletedTime.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(RemainingRetentionDays))
            {
                writer.WriteStartElement("RemainingRetentionDays");
                writer.WriteValue(RemainingRetentionDays.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WriteStartElement("AccessTier");
                writer.WriteValue(AccessTier.Value.ToString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(AccessTierInferred))
            {
                writer.WriteStartElement("AccessTierInferred");
                writer.WriteValue(AccessTierInferred.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ArchiveStatus))
            {
                writer.WriteStartElement("ArchiveStatus");
                writer.WriteValue(ArchiveStatus.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(CustomerProvidedKeySha256))
            {
                writer.WriteStartElement("CustomerProvidedKeySha256");
                writer.WriteValue(CustomerProvidedKeySha256);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(EncryptionScope))
            {
                writer.WriteStartElement("EncryptionScope");
                writer.WriteValue(EncryptionScope);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(AccessTierChangeTime))
            {
                writer.WriteStartElement("AccessTierChangeTime");
                writer.WriteValue(AccessTierChangeTime.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(TagCount))
            {
                writer.WriteStartElement("TagCount");
                writer.WriteValue(TagCount.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WriteStartElement("Expiry-Time");
                writer.WriteValue(ExpiresOn.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(IsSealed))
            {
                writer.WriteStartElement("Sealed");
                writer.WriteValue(IsSealed.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(RehydratePriority))
            {
                writer.WriteStartElement("RehydratePriority");
                writer.WriteValue(RehydratePriority.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LastAccessedOn))
            {
                writer.WriteStartElement("LastAccessTime");
                writer.WriteValue(LastAccessedOn.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ImmutabilityPolicyExpiresOn))
            {
                writer.WriteStartElement("ImmutabilityPolicyUntilDate");
                writer.WriteValue(ImmutabilityPolicyExpiresOn.Value, "R");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ImmutabilityPolicyMode))
            {
                writer.WriteStartElement("ImmutabilityPolicyMode");
                writer.WriteValue(ImmutabilityPolicyMode.Value.ToSerialString());
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(LegalHold))
            {
                writer.WriteStartElement("LegalHold");
                writer.WriteValue(LegalHold.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobPropertiesInternal DeserializeBlobPropertiesInternal(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            DateTimeOffset? creationTime = default;
            DateTimeOffset lastModified = default;
            string etag = default;
            long? contentLength = default;
            string contentType = default;
            string contentEncoding = default;
            string contentLanguage = default;
            byte[] contentMD5 = default;
            string contentDisposition = default;
            string cacheControl = default;
            long? blobSequenceNumber = default;
            BlobType? blobType = default;
            LeaseStatus? leaseStatus = default;
            LeaseState? leaseState = default;
            LeaseDurationType? leaseDuration = default;
            string copyId = default;
            CopyStatus? copyStatus = default;
            string copySource = default;
            string copyProgress = default;
            DateTimeOffset? copyCompletionTime = default;
            string copyStatusDescription = default;
            bool? serverEncrypted = default;
            bool? incrementalCopy = default;
            string destinationSnapshot = default;
            DateTimeOffset? deletedTime = default;
            int? remainingRetentionDays = default;
            AccessTier? accessTier = default;
            bool? accessTierInferred = default;
            ArchiveStatus? archiveStatus = default;
            string customerProvidedKeySha256 = default;
            string encryptionScope = default;
            DateTimeOffset? accessTierChangeTime = default;
            int? tagCount = default;
            DateTimeOffset? expiresOn = default;
            bool? isSealed = default;
            RehydratePriority? rehydratePriority = default;
            DateTimeOffset? lastAccessedOn = default;
            DateTimeOffset? immutabilityPolicyExpiresOn = default;
            BlobImmutabilityPolicyMode? immutabilityPolicyMode = default;
            bool? legalHold = default;
            if (element.Element("Creation-Time") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                etag = (string)etagElement;
            }
            if (element.Element("Content-Length") is XElement contentLengthElement)
            {
                contentLength = (long?)contentLengthElement;
            }
            if (element.Element("Content-Type") is XElement contentTypeElement)
            {
                contentType = (string)contentTypeElement;
            }
            if (element.Element("Content-Encoding") is XElement contentEncodingElement)
            {
                contentEncoding = (string)contentEncodingElement;
            }
            if (element.Element("Content-Language") is XElement contentLanguageElement)
            {
                contentLanguage = (string)contentLanguageElement;
            }
            if (element.Element("Content-MD5") is XElement contentMD5Element)
            {
                contentMD5 = contentMD5Element.GetBytesFromBase64Value("D");
            }
            if (element.Element("Content-Disposition") is XElement contentDispositionElement)
            {
                contentDisposition = (string)contentDispositionElement;
            }
            if (element.Element("Cache-Control") is XElement cacheControlElement)
            {
                cacheControl = (string)cacheControlElement;
            }
            if (element.Element("x-ms-blob-sequence-number") is XElement xMsBlobSequenceNumberElement)
            {
                blobSequenceNumber = (long?)xMsBlobSequenceNumberElement;
            }
            if (element.Element("BlobType") is XElement blobTypeElement)
            {
                blobType = blobTypeElement.Value.ToBlobType();
            }
            if (element.Element("LeaseStatus") is XElement leaseStatusElement)
            {
                leaseStatus = leaseStatusElement.Value.ToLeaseStatus();
            }
            if (element.Element("LeaseState") is XElement leaseStateElement)
            {
                leaseState = leaseStateElement.Value.ToLeaseState();
            }
            if (element.Element("LeaseDuration") is XElement leaseDurationElement)
            {
                leaseDuration = leaseDurationElement.Value.ToLeaseDurationType();
            }
            if (element.Element("CopyId") is XElement copyIdElement)
            {
                copyId = (string)copyIdElement;
            }
            if (element.Element("CopyStatus") is XElement copyStatusElement)
            {
                copyStatus = copyStatusElement.Value.ToCopyStatus();
            }
            if (element.Element("CopySource") is XElement copySourceElement)
            {
                copySource = (string)copySourceElement;
            }
            if (element.Element("CopyProgress") is XElement copyProgressElement)
            {
                copyProgress = (string)copyProgressElement;
            }
            if (element.Element("CopyCompletionTime") is XElement copyCompletionTimeElement)
            {
                copyCompletionTime = copyCompletionTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("CopyStatusDescription") is XElement copyStatusDescriptionElement)
            {
                copyStatusDescription = (string)copyStatusDescriptionElement;
            }
            if (element.Element("ServerEncrypted") is XElement serverEncryptedElement)
            {
                serverEncrypted = (bool?)serverEncryptedElement;
            }
            if (element.Element("IncrementalCopy") is XElement incrementalCopyElement)
            {
                incrementalCopy = (bool?)incrementalCopyElement;
            }
            if (element.Element("DestinationSnapshot") is XElement destinationSnapshotElement)
            {
                destinationSnapshot = (string)destinationSnapshotElement;
            }
            if (element.Element("DeletedTime") is XElement deletedTimeElement)
            {
                deletedTime = deletedTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("RemainingRetentionDays") is XElement remainingRetentionDaysElement)
            {
                remainingRetentionDays = (int?)remainingRetentionDaysElement;
            }
            if (element.Element("AccessTier") is XElement accessTierElement)
            {
                accessTier = new AccessTier(accessTierElement.Value);
            }
            if (element.Element("AccessTierInferred") is XElement accessTierInferredElement)
            {
                accessTierInferred = (bool?)accessTierInferredElement;
            }
            if (element.Element("ArchiveStatus") is XElement archiveStatusElement)
            {
                archiveStatus = archiveStatusElement.Value.ToArchiveStatus();
            }
            if (element.Element("CustomerProvidedKeySha256") is XElement customerProvidedKeySha256Element)
            {
                customerProvidedKeySha256 = (string)customerProvidedKeySha256Element;
            }
            if (element.Element("EncryptionScope") is XElement encryptionScopeElement)
            {
                encryptionScope = (string)encryptionScopeElement;
            }
            if (element.Element("AccessTierChangeTime") is XElement accessTierChangeTimeElement)
            {
                accessTierChangeTime = accessTierChangeTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("TagCount") is XElement tagCountElement)
            {
                tagCount = (int?)tagCountElement;
            }
            if (element.Element("Expiry-Time") is XElement expiryTimeElement)
            {
                expiresOn = expiryTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Sealed") is XElement sealedElement)
            {
                isSealed = (bool?)sealedElement;
            }
            if (element.Element("RehydratePriority") is XElement rehydratePriorityElement)
            {
                rehydratePriority = rehydratePriorityElement.Value.ToRehydratePriority();
            }
            if (element.Element("LastAccessTime") is XElement lastAccessTimeElement)
            {
                lastAccessedOn = lastAccessTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("ImmutabilityPolicyUntilDate") is XElement immutabilityPolicyUntilDateElement)
            {
                immutabilityPolicyExpiresOn = immutabilityPolicyUntilDateElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("ImmutabilityPolicyMode") is XElement immutabilityPolicyModeElement)
            {
                immutabilityPolicyMode = immutabilityPolicyModeElement.Value.ToBlobImmutabilityPolicyMode();
            }
            if (element.Element("LegalHold") is XElement legalHoldElement)
            {
                legalHold = (bool?)legalHoldElement;
            }
            return new BlobPropertiesInternal(creationTime, lastModified, etag, contentLength, contentType, contentEncoding, contentLanguage, contentMD5, contentDisposition, cacheControl, blobSequenceNumber, blobType, leaseStatus, leaseState, leaseDuration, copyId, copyStatus, copySource, copyProgress, copyCompletionTime, copyStatusDescription, serverEncrypted, incrementalCopy, destinationSnapshot, deletedTime, remainingRetentionDays, accessTier, accessTierInferred, archiveStatus, customerProvidedKeySha256, encryptionScope, accessTierChangeTime, tagCount, expiresOn, isSealed, rehydratePriority, lastAccessedOn, immutabilityPolicyExpiresOn, immutabilityPolicyMode, legalHold, default);
        }

        BinaryData IModelSerializable<BlobPropertiesInternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobPropertiesInternal>(this, options.Format);

            options ??= ModelSerializerOptions.DefaultWireOptions;
            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            Serialize(writer, null, options);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        BlobPropertiesInternal IModelSerializable<BlobPropertiesInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobPropertiesInternal>(this, options.Format);

            return DeserializeBlobPropertiesInternal(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="BlobPropertiesInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BlobPropertiesInternal"/> to convert. </param>
        public static implicit operator RequestContent(BlobPropertiesInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BlobPropertiesInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BlobPropertiesInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobPropertiesInternal(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
