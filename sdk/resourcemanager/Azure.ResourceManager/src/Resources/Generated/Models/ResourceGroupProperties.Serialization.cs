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

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ResourceGroupProperties : IUtf8JsonSerializable, IModelJsonSerializable<ResourceGroupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceGroupProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceGroupProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceGroupProperties>(this, options.Format);

            writer.WriteStartObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static ResourceGroupProperties DeserializeResourceGroupProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceGroupProperties(provisioningState.Value, serializedAdditionalRawData);
        }

        ResourceGroupProperties IModelJsonSerializable<ResourceGroupProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceGroupProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceGroupProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceGroupProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceGroupProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceGroupProperties IModelSerializable<ResourceGroupProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceGroupProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceGroupProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceGroupProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceGroupProperties"/> to convert. </param>
        public static implicit operator RequestContent(ResourceGroupProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceGroupProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceGroupProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceGroupProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
