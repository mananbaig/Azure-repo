// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSupportedSku : IUtf8JsonSerializable, IJsonModel<SapSupportedSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSupportedSku>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapSupportedSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSupportedSku)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VmSku))
            {
                writer.WritePropertyName("vmSku"u8);
                writer.WriteStringValue(VmSku);
            }
            if (Optional.IsDefined(IsAppServerCertified))
            {
                writer.WritePropertyName("isAppServerCertified"u8);
                writer.WriteBooleanValue(IsAppServerCertified.Value);
            }
            if (Optional.IsDefined(IsDatabaseCertified))
            {
                writer.WritePropertyName("isDatabaseCertified"u8);
                writer.WriteBooleanValue(IsDatabaseCertified.Value);
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

        SapSupportedSku IJsonModel<SapSupportedSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSupportedSku)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSupportedSku(document.RootElement, options);
        }

        internal static SapSupportedSku DeserializeSapSupportedSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmSku = default;
            bool? isAppServerCertified = default;
            bool? isDatabaseCertified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSku"u8))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAppServerCertified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAppServerCertified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDatabaseCertified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDatabaseCertified = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SapSupportedSku(vmSku, isAppServerCertified, isDatabaseCertified, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapSupportedSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapSupportedSku)} does not support writing '{options.Format}' format.");
            }
        }

        SapSupportedSku IPersistableModel<SapSupportedSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapSupportedSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapSupportedSku)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapSupportedSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
