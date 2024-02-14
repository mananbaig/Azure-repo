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
    public partial class OSSapConfiguration : IUtf8JsonSerializable, IJsonModel<OSSapConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OSSapConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OSSapConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSSapConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSSapConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeployerVmPackages))
            {
                writer.WritePropertyName("deployerVmPackages"u8);
                writer.WriteObjectValue(DeployerVmPackages);
            }
            if (Optional.IsDefined(SapFqdn))
            {
                writer.WritePropertyName("sapFqdn"u8);
                writer.WriteStringValue(SapFqdn);
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

        OSSapConfiguration IJsonModel<OSSapConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSSapConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSSapConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOSSapConfiguration(document.RootElement, options);
        }

        internal static OSSapConfiguration DeserializeOSSapConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeployerVmPackages> deployerVmPackages = default;
            Optional<string> sapFqdn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deployerVmPackages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deployerVmPackages = DeployerVmPackages.DeserializeDeployerVmPackages(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sapFqdn"u8))
                {
                    sapFqdn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OSSapConfiguration(deployerVmPackages.Value, sapFqdn.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OSSapConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSSapConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OSSapConfiguration)} does not support '{options.Format}' format.");
            }
        }

        OSSapConfiguration IPersistableModel<OSSapConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSSapConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOSSapConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OSSapConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OSSapConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
