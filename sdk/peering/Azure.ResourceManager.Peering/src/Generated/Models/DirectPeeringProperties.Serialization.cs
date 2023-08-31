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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class DirectPeeringProperties : IUtf8JsonSerializable, IModelJsonSerializable<DirectPeeringProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DirectPeeringProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DirectPeeringProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections"u8);
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PeeringDirectConnection>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerAsn"u8);
                JsonSerializer.Serialize(writer, PeerAsn);
            }
            if (Optional.IsDefined(DirectPeeringType))
            {
                writer.WritePropertyName("directPeeringType"u8);
                writer.WriteStringValue(DirectPeeringType.Value.ToString());
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

        internal static DirectPeeringProperties DeserializeDirectPeeringProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PeeringDirectConnection>> connections = default;
            Optional<bool> useForPeeringService = default;
            Optional<WritableSubResource> peerAsn = default;
            Optional<DirectPeeringType> directPeeringType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringDirectConnection> array = new List<PeeringDirectConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringDirectConnection.DeserializePeeringDirectConnection(item));
                    }
                    connections = array;
                    continue;
                }
                if (property.NameEquals("useForPeeringService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useForPeeringService = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("directPeeringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directPeeringType = new DirectPeeringType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DirectPeeringProperties(Optional.ToList(connections), Optional.ToNullable(useForPeeringService), peerAsn, Optional.ToNullable(directPeeringType), rawData);
        }

        DirectPeeringProperties IModelJsonSerializable<DirectPeeringProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectPeeringProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DirectPeeringProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DirectPeeringProperties IModelSerializable<DirectPeeringProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDirectPeeringProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DirectPeeringProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DirectPeeringProperties"/> to convert. </param>
        public static implicit operator RequestContent(DirectPeeringProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DirectPeeringProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DirectPeeringProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDirectPeeringProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
