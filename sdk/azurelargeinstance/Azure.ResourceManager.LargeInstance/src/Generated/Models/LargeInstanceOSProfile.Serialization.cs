// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    public partial class LargeInstanceOSProfile : IUtf8JsonSerializable, IJsonModel<LargeInstanceOSProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LargeInstanceOSProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LargeInstanceOSProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceOSProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceOSProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ComputerName))
            {
                writer.WritePropertyName("computerName"u8);
                writer.WriteStringValue(ComputerName);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(SshPublicKey))
            {
                writer.WritePropertyName("sshPublicKey"u8);
                writer.WriteStringValue(SshPublicKey);
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
        }

        LargeInstanceOSProfile IJsonModel<LargeInstanceOSProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceOSProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceOSProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLargeInstanceOSProfile(document.RootElement, options);
        }

        internal static LargeInstanceOSProfile DeserializeLargeInstanceOSProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string computerName = default;
            string osType = default;
            string version = default;
            string sshPublicKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computerName"u8))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPublicKey"u8))
                {
                    sshPublicKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LargeInstanceOSProfile(computerName, osType, version, sshPublicKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LargeInstanceOSProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceOSProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceOSProfile)} does not support writing '{options.Format}' format.");
            }
        }

        LargeInstanceOSProfile IPersistableModel<LargeInstanceOSProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceOSProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLargeInstanceOSProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceOSProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LargeInstanceOSProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
