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

namespace Azure.ResourceManager.Network.Models
{
    internal partial class TrafficAnalyticsProperties : IUtf8JsonSerializable, IModelJsonSerializable<TrafficAnalyticsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrafficAnalyticsProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrafficAnalyticsProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TrafficAnalyticsConfiguration))
            {
                writer.WritePropertyName("networkWatcherFlowAnalyticsConfiguration"u8);
                if (TrafficAnalyticsConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TrafficAnalyticsConfigurationProperties>)TrafficAnalyticsConfiguration).Serialize(writer, options);
                }
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

        internal static TrafficAnalyticsProperties DeserializeTrafficAnalyticsProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TrafficAnalyticsConfigurationProperties> networkWatcherFlowAnalyticsConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkWatcherFlowAnalyticsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkWatcherFlowAnalyticsConfiguration = TrafficAnalyticsConfigurationProperties.DeserializeTrafficAnalyticsConfigurationProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrafficAnalyticsProperties(networkWatcherFlowAnalyticsConfiguration.Value, rawData);
        }

        TrafficAnalyticsProperties IModelJsonSerializable<TrafficAnalyticsProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficAnalyticsProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrafficAnalyticsProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrafficAnalyticsProperties IModelSerializable<TrafficAnalyticsProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrafficAnalyticsProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TrafficAnalyticsProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TrafficAnalyticsProperties"/> to convert. </param>
        public static implicit operator RequestContent(TrafficAnalyticsProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TrafficAnalyticsProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TrafficAnalyticsProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrafficAnalyticsProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
