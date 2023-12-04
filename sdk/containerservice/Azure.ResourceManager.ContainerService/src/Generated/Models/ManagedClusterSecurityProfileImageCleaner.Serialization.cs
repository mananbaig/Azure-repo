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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfileImageCleaner : IUtf8JsonSerializable, IJsonModel<ManagedClusterSecurityProfileImageCleaner>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSecurityProfileImageCleaner>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterSecurityProfileImageCleaner>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileImageCleaner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedClusterSecurityProfileImageCleaner)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(IntervalHours))
            {
                writer.WritePropertyName("intervalHours"u8);
                writer.WriteNumberValue(IntervalHours.Value);
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

        ManagedClusterSecurityProfileImageCleaner IJsonModel<ManagedClusterSecurityProfileImageCleaner>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileImageCleaner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ManagedClusterSecurityProfileImageCleaner)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfileImageCleaner(document.RootElement, options);
        }

        internal static ManagedClusterSecurityProfileImageCleaner DeserializeManagedClusterSecurityProfileImageCleaner(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<int> intervalHours = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("intervalHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalHours = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterSecurityProfileImageCleaner(Optional.ToNullable(enabled), Optional.ToNullable(intervalHours), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterSecurityProfileImageCleaner>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileImageCleaner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedClusterSecurityProfileImageCleaner)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterSecurityProfileImageCleaner IPersistableModel<ManagedClusterSecurityProfileImageCleaner>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileImageCleaner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSecurityProfileImageCleaner(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ManagedClusterSecurityProfileImageCleaner)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSecurityProfileImageCleaner>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
