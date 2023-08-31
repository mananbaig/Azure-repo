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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class CdnPeeringPrefix : IUtf8JsonSerializable, IModelJsonSerializable<CdnPeeringPrefix>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CdnPeeringPrefix>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CdnPeeringPrefix>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
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

        internal static CdnPeeringPrefix DeserializeCdnPeeringPrefix(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> prefix = default;
            Optional<AzureLocation> azureRegion = default;
            Optional<string> azureService = default;
            Optional<bool> isPrimaryRegion = default;
            Optional<string> bgpCommunity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("prefix"u8))
                        {
                            prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureRegion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureRegion = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureService"u8))
                        {
                            azureService = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isPrimaryRegion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrimaryRegion = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("bgpCommunity"u8))
                        {
                            bgpCommunity = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CdnPeeringPrefix(id, name, type, systemData.Value, prefix.Value, Optional.ToNullable(azureRegion), azureService.Value, Optional.ToNullable(isPrimaryRegion), bgpCommunity.Value, rawData);
        }

        CdnPeeringPrefix IModelJsonSerializable<CdnPeeringPrefix>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnPeeringPrefix(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CdnPeeringPrefix>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CdnPeeringPrefix IModelSerializable<CdnPeeringPrefix>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCdnPeeringPrefix(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CdnPeeringPrefix"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CdnPeeringPrefix"/> to convert. </param>
        public static implicit operator RequestContent(CdnPeeringPrefix model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CdnPeeringPrefix"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CdnPeeringPrefix(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCdnPeeringPrefix(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
