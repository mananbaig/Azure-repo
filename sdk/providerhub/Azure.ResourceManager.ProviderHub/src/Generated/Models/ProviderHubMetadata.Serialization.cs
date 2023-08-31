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
    public partial class ProviderHubMetadata : IUtf8JsonSerializable, IModelJsonSerializable<ProviderHubMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderHubMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProviderHubMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ResourceProviderAuthorization>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                if (ProviderAuthentication is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceProviderAuthentication>)ProviderAuthentication).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ThirdPartyProviderAuthorization))
            {
                writer.WritePropertyName("thirdPartyProviderAuthorization"u8);
                if (ThirdPartyProviderAuthorization is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ThirdPartyProviderAuthorization>)ThirdPartyProviderAuthorization).Serialize(writer, options);
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

        internal static ProviderHubMetadata DeserializeProviderHubMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ResourceProviderAuthorization>> providerAuthorizations = default;
            Optional<ResourceProviderAuthentication> providerAuthentication = default;
            Optional<ThirdPartyProviderAuthorization> thirdPartyProviderAuthorization = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthentication = ResourceProviderAuthentication.DeserializeResourceProviderAuthentication(property.Value);
                    continue;
                }
                if (property.NameEquals("thirdPartyProviderAuthorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thirdPartyProviderAuthorization = ThirdPartyProviderAuthorization.DeserializeThirdPartyProviderAuthorization(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProviderHubMetadata(Optional.ToList(providerAuthorizations), providerAuthentication.Value, thirdPartyProviderAuthorization.Value, rawData);
        }

        ProviderHubMetadata IModelJsonSerializable<ProviderHubMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderHubMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderHubMetadata>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProviderHubMetadata IModelSerializable<ProviderHubMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderHubMetadata(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProviderHubMetadata"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProviderHubMetadata"/> to convert. </param>
        public static implicit operator RequestContent(ProviderHubMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProviderHubMetadata"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProviderHubMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProviderHubMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
