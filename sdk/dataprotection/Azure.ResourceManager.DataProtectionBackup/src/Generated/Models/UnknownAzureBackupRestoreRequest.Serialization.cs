// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class UnknownAzureBackupRestoreRequest : IUtf8JsonSerializable, IJsonModel<BackupRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRestoreContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRestoreContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("restoreTargetInfo"u8);
            writer.WriteObjectValue(RestoreTargetInfo, options);
            writer.WritePropertyName("sourceDataStoreType"u8);
            writer.WriteStringValue(SourceDataStoreType.ToString());
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IdentityDetails))
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BackupRestoreContent IJsonModel<BackupRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRestoreContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRestoreContent(document.RootElement, options);
        }

        internal static UnknownAzureBackupRestoreRequest DeserializeUnknownAzureBackupRestoreRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string objectType = "Unknown";
            RestoreTargetInfoBase restoreTargetInfo = default;
            SourceDataStoreType sourceDataStoreType = default;
            ResourceIdentifier sourceResourceId = default;
            IList<string> resourceGuardOperationRequests = default;
            DataProtectionIdentityDetails identityDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTargetInfo"u8))
                {
                    restoreTargetInfo = RestoreTargetInfoBase.DeserializeRestoreTargetInfoBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDataStoreType"u8))
                {
                    sourceDataStoreType = new SourceDataStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("identityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityDetails = DataProtectionIdentityDetails.DeserializeDataProtectionIdentityDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownAzureBackupRestoreRequest(
                objectType,
                restoreTargetInfo,
                sourceDataStoreType,
                sourceResourceId,
                resourceGuardOperationRequests ?? new ChangeTrackingList<string>(),
                identityDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupRestoreContent)} does not support writing '{options.Format}' format.");
            }
        }

        BackupRestoreContent IPersistableModel<BackupRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupRestoreContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
