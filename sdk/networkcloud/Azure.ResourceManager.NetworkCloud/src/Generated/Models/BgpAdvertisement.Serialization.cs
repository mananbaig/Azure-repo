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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BgpAdvertisement : IUtf8JsonSerializable, IModelJsonSerializable<BgpAdvertisement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BgpAdvertisement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BgpAdvertisement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AdvertiseToFabric))
            {
                writer.WritePropertyName("advertiseToFabric"u8);
                writer.WriteStringValue(AdvertiseToFabric.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Communities))
            {
                writer.WritePropertyName("communities"u8);
                writer.WriteStartArray();
                foreach (var item in Communities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("ipAddressPools"u8);
            writer.WriteStartArray();
            foreach (var item in IPAddressPools)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Peers))
            {
                writer.WritePropertyName("peers"u8);
                writer.WriteStartArray();
                foreach (var item in Peers)
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

        internal static BgpAdvertisement DeserializeBgpAdvertisement(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AdvertiseToFabric> advertiseToFabric = default;
            Optional<IList<string>> communities = default;
            IList<string> ipAddressPools = default;
            Optional<IList<string>> peers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advertiseToFabric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advertiseToFabric = new AdvertiseToFabric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("communities"u8))
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
                    communities = array;
                    continue;
                }
                if (property.NameEquals("ipAddressPools"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipAddressPools = array;
                    continue;
                }
                if (property.NameEquals("peers"u8))
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
                    peers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BgpAdvertisement(Optional.ToNullable(advertiseToFabric), Optional.ToList(communities), ipAddressPools, Optional.ToList(peers), rawData);
        }

        BgpAdvertisement IModelJsonSerializable<BgpAdvertisement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpAdvertisement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BgpAdvertisement>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BgpAdvertisement IModelSerializable<BgpAdvertisement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBgpAdvertisement(doc.RootElement, options);
        }

        public static implicit operator RequestContent(BgpAdvertisement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BgpAdvertisement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBgpAdvertisement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
