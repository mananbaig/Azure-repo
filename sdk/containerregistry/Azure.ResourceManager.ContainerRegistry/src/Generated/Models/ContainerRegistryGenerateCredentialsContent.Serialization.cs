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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryGenerateCredentialsContent : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryGenerateCredentialsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryGenerateCredentialsContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryGenerateCredentialsContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TokenId))
            {
                writer.WritePropertyName("tokenId"u8);
                writer.WriteStringValue(TokenId);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
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

        internal static ContainerRegistryGenerateCredentialsContent DeserializeContainerRegistryGenerateCredentialsContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> tokenId = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<ContainerRegistryTokenPasswordName> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokenId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new ContainerRegistryTokenPasswordName(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryGenerateCredentialsContent(tokenId.Value, Optional.ToNullable(expiry), Optional.ToNullable(name), rawData);
        }

        ContainerRegistryGenerateCredentialsContent IModelJsonSerializable<ContainerRegistryGenerateCredentialsContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryGenerateCredentialsContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryGenerateCredentialsContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryGenerateCredentialsContent IModelSerializable<ContainerRegistryGenerateCredentialsContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryGenerateCredentialsContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryGenerateCredentialsContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryGenerateCredentialsContent"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryGenerateCredentialsContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryGenerateCredentialsContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryGenerateCredentialsContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryGenerateCredentialsContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
