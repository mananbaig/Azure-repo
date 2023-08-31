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
    public partial class ExpressRoutePortsLocationBandwidths : IUtf8JsonSerializable, IModelJsonSerializable<ExpressRoutePortsLocationBandwidths>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExpressRoutePortsLocationBandwidths>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExpressRoutePortsLocationBandwidths>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ExpressRoutePortsLocationBandwidths DeserializeExpressRoutePortsLocationBandwidths(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> offerName = default;
            Optional<int> valueInGbps = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerName"u8))
                {
                    offerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueInGbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInGbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExpressRoutePortsLocationBandwidths(offerName.Value, Optional.ToNullable(valueInGbps), rawData);
        }

        ExpressRoutePortsLocationBandwidths IModelJsonSerializable<ExpressRoutePortsLocationBandwidths>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRoutePortsLocationBandwidths(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExpressRoutePortsLocationBandwidths>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExpressRoutePortsLocationBandwidths IModelSerializable<ExpressRoutePortsLocationBandwidths>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExpressRoutePortsLocationBandwidths(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExpressRoutePortsLocationBandwidths"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExpressRoutePortsLocationBandwidths"/> to convert. </param>
        public static implicit operator RequestContent(ExpressRoutePortsLocationBandwidths model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExpressRoutePortsLocationBandwidths"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExpressRoutePortsLocationBandwidths(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExpressRoutePortsLocationBandwidths(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
