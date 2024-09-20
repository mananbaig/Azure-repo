// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class HelmMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<HelmMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmMappingRuleProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HelmMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReleaseNamespace))
            {
                writer.WritePropertyName("releaseNamespace"u8);
                writer.WriteStringValue(ReleaseNamespace);
            }
            if (Optional.IsDefined(ReleaseName))
            {
                writer.WritePropertyName("releaseName"u8);
                writer.WriteStringValue(ReleaseName);
            }
            if (Optional.IsDefined(HelmPackageVersion))
            {
                writer.WritePropertyName("helmPackageVersion"u8);
                writer.WriteStringValue(HelmPackageVersion);
            }
            if (Optional.IsDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStringValue(Values);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteObjectValue(Options, options);
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

        HelmMappingRuleProfile IJsonModel<HelmMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmMappingRuleProfile(document.RootElement, options);
        }

        internal static HelmMappingRuleProfile DeserializeHelmMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string releaseNamespace = default;
            string releaseName = default;
            string helmPackageVersion = default;
            string values = default;
            HelmMappingRuleProfileConfig options0 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("releaseNamespace"u8))
                {
                    releaseNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("releaseName"u8))
                {
                    releaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("helmPackageVersion"u8))
                {
                    helmPackageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    values = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    options0 = HelmMappingRuleProfileConfig.DeserializeHelmMappingRuleProfileConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HelmMappingRuleProfile(
                releaseNamespace,
                releaseName,
                helmPackageVersion,
                values,
                options0,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support writing '{options.Format}' format.");
            }
        }

        HelmMappingRuleProfile IPersistableModel<HelmMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHelmMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HelmMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
