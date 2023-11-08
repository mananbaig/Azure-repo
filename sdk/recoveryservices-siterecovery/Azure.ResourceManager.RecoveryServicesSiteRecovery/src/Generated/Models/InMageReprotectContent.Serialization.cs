// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageReprotectContent : IUtf8JsonSerializable, IJsonModel<InMageReprotectContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageReprotectContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<InMageReprotectContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("masterTargetId"u8);
            writer.WriteStringValue(MasterTargetId);
            writer.WritePropertyName("processServerId"u8);
            writer.WriteStringValue(ProcessServerId);
            writer.WritePropertyName("retentionDrive"u8);
            writer.WriteStringValue(RetentionDrive);
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            if (Optional.IsDefined(DatastoreName))
            {
                writer.WritePropertyName("datastoreName"u8);
                writer.WriteStringValue(DatastoreName);
            }
            if (Optional.IsDefined(DiskExclusionContent))
            {
                writer.WritePropertyName("diskExclusionInput"u8);
                writer.WriteObjectValue(DiskExclusionContent);
            }
            writer.WritePropertyName("profileId"u8);
            writer.WriteStringValue(ProfileId);
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        InMageReprotectContent IJsonModel<InMageReprotectContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageReprotectContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageReprotectContent(document.RootElement, options);
        }

        internal static InMageReprotectContent DeserializeInMageReprotectContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string masterTargetId = default;
            Guid processServerId = default;
            string retentionDrive = default;
            Optional<string> runAsAccountId = default;
            Optional<string> datastoreName = default;
            Optional<InMageDiskExclusionContent> diskExclusionContent = default;
            string profileId = default;
            Optional<IList<string>> disksToInclude = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("masterTargetId"u8))
                {
                    masterTargetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("retentionDrive"u8))
                {
                    retentionDrive = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastoreName"u8))
                {
                    datastoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskExclusionInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskExclusionContent = InMageDiskExclusionContent.DeserializeInMageDiskExclusionContent(property.Value);
                    continue;
                }
                if (property.NameEquals("profileId"u8))
                {
                    profileId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
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
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageReprotectContent(instanceType, serializedAdditionalRawData, masterTargetId, processServerId, retentionDrive, runAsAccountId.Value, datastoreName.Value, diskExclusionContent.Value, profileId, Optional.ToList(disksToInclude));
        }

        BinaryData IModel<InMageReprotectContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageReprotectContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InMageReprotectContent IModel<InMageReprotectContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageReprotectContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInMageReprotectContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<InMageReprotectContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
