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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryValidationConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppAzureActiveDirectoryValidationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppAzureActiveDirectoryValidationConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppAzureActiveDirectoryValidationConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JwtClaimChecks))
            {
                writer.WritePropertyName("jwtClaimChecks"u8);
                if (JwtClaimChecks is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppJwtClaimChecks>)JwtClaimChecks).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AllowedAudiences))
            {
                writer.WritePropertyName("allowedAudiences"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAudiences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultAuthorizationPolicy))
            {
                writer.WritePropertyName("defaultAuthorizationPolicy"u8);
                if (DefaultAuthorizationPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppDefaultAuthorizationPolicy>)DefaultAuthorizationPolicy).Serialize(writer, options);
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

        internal static ContainerAppAzureActiveDirectoryValidationConfiguration DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppJwtClaimChecks> jwtClaimChecks = default;
            Optional<IList<string>> allowedAudiences = default;
            Optional<ContainerAppDefaultAuthorizationPolicy> defaultAuthorizationPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jwtClaimChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jwtClaimChecks = ContainerAppJwtClaimChecks.DeserializeContainerAppJwtClaimChecks(property.Value);
                    continue;
                }
                if (property.NameEquals("allowedAudiences"u8))
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
                    allowedAudiences = array;
                    continue;
                }
                if (property.NameEquals("defaultAuthorizationPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAuthorizationPolicy = ContainerAppDefaultAuthorizationPolicy.DeserializeContainerAppDefaultAuthorizationPolicy(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppAzureActiveDirectoryValidationConfiguration(jwtClaimChecks.Value, Optional.ToList(allowedAudiences), defaultAuthorizationPolicy.Value, rawData);
        }

        ContainerAppAzureActiveDirectoryValidationConfiguration IModelJsonSerializable<ContainerAppAzureActiveDirectoryValidationConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppAzureActiveDirectoryValidationConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppAzureActiveDirectoryValidationConfiguration IModelSerializable<ContainerAppAzureActiveDirectoryValidationConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppAzureActiveDirectoryValidationConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppAzureActiveDirectoryValidationConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppAzureActiveDirectoryValidationConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppAzureActiveDirectoryValidationConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppAzureActiveDirectoryValidationConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
