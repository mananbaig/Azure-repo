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
    public partial class ContainerAppAzureActiveDirectoryLoginConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppAzureActiveDirectoryLoginConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppAzureActiveDirectoryLoginConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppAzureActiveDirectoryLoginConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoginParameters))
            {
                writer.WritePropertyName("loginParameters"u8);
                writer.WriteStartArray();
                foreach (var item in LoginParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsWwwAuthenticationDisabled))
            {
                writer.WritePropertyName("disableWWWAuthenticate"u8);
                writer.WriteBooleanValue(IsWwwAuthenticationDisabled.Value);
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

        internal static ContainerAppAzureActiveDirectoryLoginConfiguration DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> loginParameters = default;
            Optional<bool> disableWWWAuthenticate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginParameters"u8))
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
                    loginParameters = array;
                    continue;
                }
                if (property.NameEquals("disableWWWAuthenticate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableWWWAuthenticate = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppAzureActiveDirectoryLoginConfiguration(Optional.ToList(loginParameters), Optional.ToNullable(disableWWWAuthenticate), rawData);
        }

        ContainerAppAzureActiveDirectoryLoginConfiguration IModelJsonSerializable<ContainerAppAzureActiveDirectoryLoginConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppAzureActiveDirectoryLoginConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppAzureActiveDirectoryLoginConfiguration IModelSerializable<ContainerAppAzureActiveDirectoryLoginConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppAzureActiveDirectoryLoginConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppAzureActiveDirectoryLoginConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppAzureActiveDirectoryLoginConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppAzureActiveDirectoryLoginConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppAzureActiveDirectoryLoginConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
