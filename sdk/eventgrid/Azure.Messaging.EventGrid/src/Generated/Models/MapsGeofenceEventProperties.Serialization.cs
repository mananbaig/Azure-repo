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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MapsGeofenceEventProperties : IUtf8JsonSerializable, IJsonModel<MapsGeofenceEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsGeofenceEventProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MapsGeofenceEventProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MapsGeofenceEventProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MapsGeofenceEventProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExpiredGeofenceGeometryId))
            {
                writer.WritePropertyName("expiredGeofenceGeometryId"u8);
                writer.WriteStartArray();
                foreach (var item in ExpiredGeofenceGeometryId)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Geometries))
            {
                writer.WritePropertyName("geometries"u8);
                writer.WriteStartArray();
                foreach (var item in Geometries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InvalidPeriodGeofenceGeometryId))
            {
                writer.WritePropertyName("invalidPeriodGeofenceGeometryId"u8);
                writer.WriteStartArray();
                foreach (var item in InvalidPeriodGeofenceGeometryId)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsEventPublished))
            {
                writer.WritePropertyName("isEventPublished"u8);
                writer.WriteBooleanValue(IsEventPublished.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        MapsGeofenceEventProperties IJsonModel<MapsGeofenceEventProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsGeofenceEventProperties(document.RootElement, options);
        }

        internal static MapsGeofenceEventProperties DeserializeMapsGeofenceEventProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> expiredGeofenceGeometryId = default;
            Optional<IReadOnlyList<MapsGeofenceGeometry>> geometries = default;
            Optional<IReadOnlyList<string>> invalidPeriodGeofenceGeometryId = default;
            Optional<bool> isEventPublished = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiredGeofenceGeometryId"u8))
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
                    expiredGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("geometries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsGeofenceGeometry> array = new List<MapsGeofenceGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsGeofenceGeometry.DeserializeMapsGeofenceGeometry(item));
                    }
                    geometries = array;
                    continue;
                }
                if (property.NameEquals("invalidPeriodGeofenceGeometryId"u8))
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
                    invalidPeriodGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("isEventPublished"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEventPublished = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MapsGeofenceEventProperties(Optional.ToList(expiredGeofenceGeometryId), Optional.ToList(geometries), Optional.ToList(invalidPeriodGeofenceGeometryId), Optional.ToNullable(isEventPublished), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsGeofenceEventProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MapsGeofenceEventProperties IPersistableModel<MapsGeofenceEventProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMapsGeofenceEventProperties(document.RootElement, options);
        }

        string IPersistableModel<MapsGeofenceEventProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
