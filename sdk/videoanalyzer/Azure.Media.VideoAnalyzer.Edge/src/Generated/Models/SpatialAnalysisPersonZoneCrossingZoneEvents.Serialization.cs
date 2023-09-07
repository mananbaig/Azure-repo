// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonZoneCrossingZoneEvents : IUtf8JsonSerializable, IModelJsonSerializable<SpatialAnalysisPersonZoneCrossingZoneEvents>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SpatialAnalysisPersonZoneCrossingZoneEvents>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SpatialAnalysisPersonZoneCrossingZoneEvents>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonZoneCrossingZoneEvents>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("zone"u8);
            if (Zone is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<NamedPolygonBase>)Zone).Serialize(writer, options);
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SpatialAnalysisPersonZoneCrossingEvent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonZoneCrossingZoneEvents DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NamedPolygonBase zone = default;
            Optional<IList<SpatialAnalysisPersonZoneCrossingEvent>> events = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"u8))
                {
                    zone = NamedPolygonBase.DeserializeNamedPolygonBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialAnalysisPersonZoneCrossingEvent> array = new List<SpatialAnalysisPersonZoneCrossingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonZoneCrossingEvent.DeserializeSpatialAnalysisPersonZoneCrossingEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SpatialAnalysisPersonZoneCrossingZoneEvents(zone, Optional.ToList(events), serializedAdditionalRawData);
        }

        SpatialAnalysisPersonZoneCrossingZoneEvents IModelJsonSerializable<SpatialAnalysisPersonZoneCrossingZoneEvents>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonZoneCrossingZoneEvents>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SpatialAnalysisPersonZoneCrossingZoneEvents>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonZoneCrossingZoneEvents>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SpatialAnalysisPersonZoneCrossingZoneEvents IModelSerializable<SpatialAnalysisPersonZoneCrossingZoneEvents>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonZoneCrossingZoneEvents>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SpatialAnalysisPersonZoneCrossingZoneEvents"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SpatialAnalysisPersonZoneCrossingZoneEvents"/> to convert. </param>
        public static implicit operator RequestContent(SpatialAnalysisPersonZoneCrossingZoneEvents model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SpatialAnalysisPersonZoneCrossingZoneEvents"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SpatialAnalysisPersonZoneCrossingZoneEvents(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
