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
    public partial class VpnConnectionPacketCaptureStopContent : IUtf8JsonSerializable, IModelJsonSerializable<VpnConnectionPacketCaptureStopContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VpnConnectionPacketCaptureStopContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VpnConnectionPacketCaptureStopContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SasUri))
            {
                writer.WritePropertyName("sasUrl"u8);
                writer.WriteStringValue(SasUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(LinkConnectionNames))
            {
                writer.WritePropertyName("linkConnectionNames"u8);
                writer.WriteStartArray();
                foreach (var item in LinkConnectionNames)
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

        internal static VpnConnectionPacketCaptureStopContent DeserializeVpnConnectionPacketCaptureStopContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> sasUrl = default;
            Optional<IList<string>> linkConnectionNames = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("linkConnectionNames"u8))
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
                    linkConnectionNames = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VpnConnectionPacketCaptureStopContent(sasUrl.Value, Optional.ToList(linkConnectionNames), rawData);
        }

        VpnConnectionPacketCaptureStopContent IModelJsonSerializable<VpnConnectionPacketCaptureStopContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConnectionPacketCaptureStopContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VpnConnectionPacketCaptureStopContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VpnConnectionPacketCaptureStopContent IModelSerializable<VpnConnectionPacketCaptureStopContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVpnConnectionPacketCaptureStopContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VpnConnectionPacketCaptureStopContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VpnConnectionPacketCaptureStopContent"/> to convert. </param>
        public static implicit operator RequestContent(VpnConnectionPacketCaptureStopContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VpnConnectionPacketCaptureStopContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VpnConnectionPacketCaptureStopContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVpnConnectionPacketCaptureStopContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
