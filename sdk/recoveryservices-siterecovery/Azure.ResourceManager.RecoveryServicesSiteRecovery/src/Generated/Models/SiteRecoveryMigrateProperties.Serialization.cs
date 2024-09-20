// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryMigrateProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryMigrateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryMigrateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryMigrateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryMigrateProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("providerSpecificDetails"u8);
            writer.WriteObjectValue(ProviderSpecificDetails, options);
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

        SiteRecoveryMigrateProperties IJsonModel<SiteRecoveryMigrateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryMigrateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryMigrateProperties(document.RootElement, options);
        }

        internal static SiteRecoveryMigrateProperties DeserializeSiteRecoveryMigrateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MigrateProviderSpecificContent providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    providerSpecificDetails = MigrateProviderSpecificContent.DeserializeMigrateProviderSpecificContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryMigrateProperties(providerSpecificDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryMigrateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryMigrateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryMigrateProperties IPersistableModel<SiteRecoveryMigrateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryMigrateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryMigrateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryMigrateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryMigrateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
