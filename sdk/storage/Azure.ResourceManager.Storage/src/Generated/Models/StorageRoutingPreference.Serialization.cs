// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageRoutingPreference : IUtf8JsonSerializable, IJsonModel<StorageRoutingPreference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageRoutingPreference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageRoutingPreference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingChoice))
            {
                writer.WritePropertyName("routingChoice"u8);
                writer.WriteStringValue(RoutingChoice.Value.ToString());
            }
            if (Optional.IsDefined(IsMicrosoftEndpointsPublished))
            {
                writer.WritePropertyName("publishMicrosoftEndpoints"u8);
                writer.WriteBooleanValue(IsMicrosoftEndpointsPublished.Value);
            }
            if (Optional.IsDefined(IsInternetEndpointsPublished))
            {
                writer.WritePropertyName("publishInternetEndpoints"u8);
                writer.WriteBooleanValue(IsInternetEndpointsPublished.Value);
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

        StorageRoutingPreference IJsonModel<StorageRoutingPreference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageRoutingPreference(document.RootElement, options);
        }

        internal static StorageRoutingPreference DeserializeStorageRoutingPreference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageRoutingChoice? routingChoice = default;
            bool? publishMicrosoftEndpoints = default;
            bool? publishInternetEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingChoice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingChoice = new StorageRoutingChoice(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publishMicrosoftEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishMicrosoftEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishInternetEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishInternetEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageRoutingPreference(routingChoice, publishMicrosoftEndpoints, publishInternetEndpoints, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RoutingChoice), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  routingChoice: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RoutingChoice))
                {
                    builder.Append("  routingChoice: ");
                    builder.AppendLine($"'{RoutingChoice.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsMicrosoftEndpointsPublished), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publishMicrosoftEndpoints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsMicrosoftEndpointsPublished))
                {
                    builder.Append("  publishMicrosoftEndpoints: ");
                    var boolValue = IsMicrosoftEndpointsPublished.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsInternetEndpointsPublished), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publishInternetEndpoints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsInternetEndpointsPublished))
                {
                    builder.Append("  publishInternetEndpoints: ");
                    var boolValue = IsInternetEndpointsPublished.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageRoutingPreference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support writing '{options.Format}' format.");
            }
        }

        StorageRoutingPreference IPersistableModel<StorageRoutingPreference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageRoutingPreference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageRoutingPreference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
