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
    public partial class RestoreTargetInfo : IUtf8JsonSerializable, IJsonModel<RestoreTargetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreTargetInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RestoreTargetInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreTargetInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("datasourceInfo"u8);
            writer.WriteObjectValue(DataSourceInfo, options);
            if (Optional.IsDefined(DataSourceSetInfo))
            {
                writer.WritePropertyName("datasourceSetInfo"u8);
                writer.WriteObjectValue(DataSourceSetInfo, options);
            }
            if (Optional.IsDefined(DataSourceAuthCredentials))
            {
                writer.WritePropertyName("datasourceAuthCredentials"u8);
                writer.WriteObjectValue(DataSourceAuthCredentials, options);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("recoveryOption"u8);
            writer.WriteStringValue(RecoverySetting.ToString());
            if (Optional.IsDefined(RestoreLocation))
            {
                writer.WritePropertyName("restoreLocation"u8);
                writer.WriteStringValue(RestoreLocation.Value);
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

        RestoreTargetInfo IJsonModel<RestoreTargetInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreTargetInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreTargetInfo(document.RootElement, options);
        }

        internal static RestoreTargetInfo DeserializeRestoreTargetInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSourceInfo datasourceInfo = default;
            DataSourceSetInfo datasourceSetInfo = default;
            DataProtectionBackupAuthCredentials datasourceAuthCredentials = default;
            string objectType = default;
            RecoverySetting recoveryOption = default;
            AzureLocation? restoreLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasourceInfo"u8))
                {
                    datasourceInfo = DataSourceInfo.DeserializeDataSourceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datasourceSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasourceSetInfo = DataSourceSetInfo.DeserializeDataSourceSetInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datasourceAuthCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasourceAuthCredentials = DataProtectionBackupAuthCredentials.DeserializeDataProtectionBackupAuthCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryOption"u8))
                {
                    recoveryOption = new RecoverySetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RestoreTargetInfo(
                objectType,
                recoveryOption,
                restoreLocation,
                serializedAdditionalRawData,
                datasourceInfo,
                datasourceSetInfo,
                datasourceAuthCredentials);
        }

        BinaryData IPersistableModel<RestoreTargetInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreTargetInfo)} does not support writing '{options.Format}' format.");
            }
        }

        RestoreTargetInfo IPersistableModel<RestoreTargetInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreTargetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreTargetInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreTargetInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreTargetInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
