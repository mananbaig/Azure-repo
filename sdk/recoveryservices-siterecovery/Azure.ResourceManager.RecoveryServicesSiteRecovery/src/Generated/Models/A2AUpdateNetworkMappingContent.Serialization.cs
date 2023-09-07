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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AUpdateNetworkMappingContent : IUtf8JsonSerializable, IModelJsonSerializable<A2AUpdateNetworkMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<A2AUpdateNetworkMappingContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<A2AUpdateNetworkMappingContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AUpdateNetworkMappingContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryNetworkId))
            {
                writer.WritePropertyName("primaryNetworkId"u8);
                writer.WriteStringValue(PrimaryNetworkId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static A2AUpdateNetworkMappingContent DeserializeA2AUpdateNetworkMappingContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> primaryNetworkId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new A2AUpdateNetworkMappingContent(instanceType, primaryNetworkId.Value, serializedAdditionalRawData);
        }

        A2AUpdateNetworkMappingContent IModelJsonSerializable<A2AUpdateNetworkMappingContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AUpdateNetworkMappingContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AUpdateNetworkMappingContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<A2AUpdateNetworkMappingContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AUpdateNetworkMappingContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        A2AUpdateNetworkMappingContent IModelSerializable<A2AUpdateNetworkMappingContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AUpdateNetworkMappingContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeA2AUpdateNetworkMappingContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="A2AUpdateNetworkMappingContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="A2AUpdateNetworkMappingContent"/> to convert. </param>
        public static implicit operator RequestContent(A2AUpdateNetworkMappingContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="A2AUpdateNetworkMappingContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator A2AUpdateNetworkMappingContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeA2AUpdateNetworkMappingContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
