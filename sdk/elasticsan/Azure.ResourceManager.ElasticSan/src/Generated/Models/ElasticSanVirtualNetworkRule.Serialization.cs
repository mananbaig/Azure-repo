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

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanVirtualNetworkRule : IUtf8JsonSerializable, IModelJsonSerializable<ElasticSanVirtualNetworkRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ElasticSanVirtualNetworkRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ElasticSanVirtualNetworkRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVirtualNetworkRule>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(VirtualNetworkResourceId);
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
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

        internal static ElasticSanVirtualNetworkRule DeserializeElasticSanVirtualNetworkRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            Optional<ElasticSanVirtualNetworkRuleAction> action = default;
            Optional<ElasticSanVirtualNetworkRuleState> state = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new ElasticSanVirtualNetworkRuleAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToElasticSanVirtualNetworkRuleState();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ElasticSanVirtualNetworkRule(id, Optional.ToNullable(action), Optional.ToNullable(state), serializedAdditionalRawData);
        }

        ElasticSanVirtualNetworkRule IModelJsonSerializable<ElasticSanVirtualNetworkRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVirtualNetworkRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticSanVirtualNetworkRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ElasticSanVirtualNetworkRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVirtualNetworkRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ElasticSanVirtualNetworkRule IModelSerializable<ElasticSanVirtualNetworkRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVirtualNetworkRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeElasticSanVirtualNetworkRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ElasticSanVirtualNetworkRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ElasticSanVirtualNetworkRule"/> to convert. </param>
        public static implicit operator RequestContent(ElasticSanVirtualNetworkRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ElasticSanVirtualNetworkRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ElasticSanVirtualNetworkRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeElasticSanVirtualNetworkRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
