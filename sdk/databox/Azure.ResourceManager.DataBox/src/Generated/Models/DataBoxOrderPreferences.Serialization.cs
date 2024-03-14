// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxOrderPreferences : IUtf8JsonSerializable, IJsonModel<DataBoxOrderPreferences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxOrderPreferences>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxOrderPreferences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxOrderPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxOrderPreferences)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PreferredDataCenterRegion))
            {
                writer.WritePropertyName("preferredDataCenterRegion"u8);
                writer.WriteStartArray();
                foreach (var item in PreferredDataCenterRegion)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TransportPreferences))
            {
                writer.WritePropertyName("transportPreferences"u8);
                writer.WriteObjectValue(TransportPreferences);
            }
            if (Optional.IsDefined(ReverseTransportPreferences))
            {
                writer.WritePropertyName("reverseTransportPreferences"u8);
                writer.WriteObjectValue(ReverseTransportPreferences);
            }
            if (Optional.IsDefined(EncryptionPreferences))
            {
                writer.WritePropertyName("encryptionPreferences"u8);
                writer.WriteObjectValue(EncryptionPreferences);
            }
            if (Optional.IsCollectionDefined(StorageAccountAccessTierPreferences))
            {
                writer.WritePropertyName("storageAccountAccessTierPreferences"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccountAccessTierPreferences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        DataBoxOrderPreferences IJsonModel<DataBoxOrderPreferences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxOrderPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxOrderPreferences)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxOrderPreferences(document.RootElement, options);
        }

        internal static DataBoxOrderPreferences DeserializeDataBoxOrderPreferences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> preferredDataCenterRegion = default;
            TransportPreferences transportPreferences = default;
            TransportPreferences reverseTransportPreferences = default;
            DataBoxEncryptionPreferences encryptionPreferences = default;
            IList<string> storageAccountAccessTierPreferences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preferredDataCenterRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    preferredDataCenterRegion = array;
                    continue;
                }
                if (property.NameEquals("transportPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportPreferences = TransportPreferences.DeserializeTransportPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reverseTransportPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseTransportPreferences = TransportPreferences.DeserializeTransportPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encryptionPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionPreferences = DataBoxEncryptionPreferences.DeserializeDataBoxEncryptionPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageAccountAccessTierPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    storageAccountAccessTierPreferences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxOrderPreferences(
                preferredDataCenterRegion ?? new ChangeTrackingList<string>(),
                transportPreferences,
                reverseTransportPreferences,
                encryptionPreferences,
                storageAccountAccessTierPreferences ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxOrderPreferences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxOrderPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxOrderPreferences)} does not support '{options.Format}' format.");
            }
        }

        DataBoxOrderPreferences IPersistableModel<DataBoxOrderPreferences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxOrderPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxOrderPreferences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxOrderPreferences)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxOrderPreferences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
