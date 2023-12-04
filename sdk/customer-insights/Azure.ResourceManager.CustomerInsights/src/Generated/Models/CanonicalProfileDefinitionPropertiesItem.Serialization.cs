// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class CanonicalProfileDefinitionPropertiesItem : IUtf8JsonSerializable, IJsonModel<CanonicalProfileDefinitionPropertiesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CanonicalProfileDefinitionPropertiesItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CanonicalProfileDefinitionPropertiesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (Optional.IsDefined(ProfilePropertyName))
            {
                writer.WritePropertyName("profilePropertyName"u8);
                writer.WriteStringValue(ProfilePropertyName);
            }
            if (Optional.IsDefined(Rank))
            {
                writer.WritePropertyName("rank"u8);
                writer.WriteNumberValue(Rank.Value);
            }
            if (Optional.IsDefined(ValueType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ValueType.Value.ToString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        CanonicalProfileDefinitionPropertiesItem IJsonModel<CanonicalProfileDefinitionPropertiesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCanonicalProfileDefinitionPropertiesItem(document.RootElement, options);
        }

        internal static CanonicalProfileDefinitionPropertiesItem DeserializeCanonicalProfileDefinitionPropertiesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> profileName = default;
            Optional<string> profilePropertyName = default;
            Optional<int> rank = default;
            Optional<CanonicalPropertyValueType> type = default;
            Optional<string> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profilePropertyName"u8))
                {
                    profilePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rank"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rank = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new CanonicalPropertyValueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CanonicalProfileDefinitionPropertiesItem(profileName.Value, profilePropertyName.Value, Optional.ToNullable(rank), Optional.ToNullable(type), value.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CanonicalProfileDefinitionPropertiesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support '{options.Format}' format.");
            }
        }

        CanonicalProfileDefinitionPropertiesItem IPersistableModel<CanonicalProfileDefinitionPropertiesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCanonicalProfileDefinitionPropertiesItem(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CanonicalProfileDefinitionPropertiesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
