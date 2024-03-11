// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class SecurityGroupNetworkInterface : IUtf8JsonSerializable, IJsonModel<SecurityGroupNetworkInterface>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityGroupNetworkInterface>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityGroupNetworkInterface>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityGroupNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityGroupNetworkInterface)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SecurityRuleAssociations))
            {
                writer.WritePropertyName("securityRuleAssociations"u8);
                writer.WriteObjectValue(SecurityRuleAssociations);
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

        SecurityGroupNetworkInterface IJsonModel<SecurityGroupNetworkInterface>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityGroupNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityGroupNetworkInterface)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityGroupNetworkInterface(document.RootElement, options);
        }

        internal static SecurityGroupNetworkInterface DeserializeSecurityGroupNetworkInterface(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            SecurityRuleAssociations securityRuleAssociations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityRuleAssociations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityRuleAssociations = SecurityRuleAssociations.DeserializeSecurityRuleAssociations(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityGroupNetworkInterface(id, securityRuleAssociations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityGroupNetworkInterface>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityGroupNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityGroupNetworkInterface)} does not support '{options.Format}' format.");
            }
        }

        SecurityGroupNetworkInterface IPersistableModel<SecurityGroupNetworkInterface>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityGroupNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityGroupNetworkInterface(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityGroupNetworkInterface)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityGroupNetworkInterface>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
