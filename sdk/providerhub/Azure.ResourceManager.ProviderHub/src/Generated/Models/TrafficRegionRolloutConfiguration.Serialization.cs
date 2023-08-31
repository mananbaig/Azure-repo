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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class TrafficRegionRolloutConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<TrafficRegionRolloutConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrafficRegionRolloutConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrafficRegionRolloutConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficRegionRolloutConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(WaitDuration))
            {
                writer.WritePropertyName("waitDuration"u8);
                writer.WriteStringValue(WaitDuration.Value, "P");
            }
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static TrafficRegionRolloutConfiguration DeserializeTrafficRegionRolloutConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> waitDuration = default;
            Optional<IList<AzureLocation>> regions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("waitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    regions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrafficRegionRolloutConfiguration(Optional.ToList(regions), Optional.ToNullable(waitDuration), rawData);
        }

        TrafficRegionRolloutConfiguration IModelJsonSerializable<TrafficRegionRolloutConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficRegionRolloutConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficRegionRolloutConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrafficRegionRolloutConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficRegionRolloutConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrafficRegionRolloutConfiguration IModelSerializable<TrafficRegionRolloutConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TrafficRegionRolloutConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrafficRegionRolloutConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TrafficRegionRolloutConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TrafficRegionRolloutConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(TrafficRegionRolloutConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TrafficRegionRolloutConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TrafficRegionRolloutConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrafficRegionRolloutConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
