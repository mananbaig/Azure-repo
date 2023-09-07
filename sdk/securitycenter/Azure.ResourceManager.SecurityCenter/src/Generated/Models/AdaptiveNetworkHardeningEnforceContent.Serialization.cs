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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AdaptiveNetworkHardeningEnforceContent : IUtf8JsonSerializable, IModelJsonSerializable<AdaptiveNetworkHardeningEnforceContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AdaptiveNetworkHardeningEnforceContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AdaptiveNetworkHardeningEnforceContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdaptiveNetworkHardeningEnforceContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("rules"u8);
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RecommendedSecurityRule>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("networkSecurityGroups"u8);
            writer.WriteStartArray();
            foreach (var item in NetworkSecurityGroups)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static AdaptiveNetworkHardeningEnforceContent DeserializeAdaptiveNetworkHardeningEnforceContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RecommendedSecurityRule> rules = default;
            IList<string> networkSecurityGroups = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"u8))
                {
                    List<RecommendedSecurityRule> array = new List<RecommendedSecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecommendedSecurityRule.DeserializeRecommendedSecurityRule(item));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("networkSecurityGroups"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    networkSecurityGroups = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AdaptiveNetworkHardeningEnforceContent(rules, networkSecurityGroups, serializedAdditionalRawData);
        }

        AdaptiveNetworkHardeningEnforceContent IModelJsonSerializable<AdaptiveNetworkHardeningEnforceContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdaptiveNetworkHardeningEnforceContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAdaptiveNetworkHardeningEnforceContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AdaptiveNetworkHardeningEnforceContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdaptiveNetworkHardeningEnforceContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AdaptiveNetworkHardeningEnforceContent IModelSerializable<AdaptiveNetworkHardeningEnforceContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdaptiveNetworkHardeningEnforceContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAdaptiveNetworkHardeningEnforceContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AdaptiveNetworkHardeningEnforceContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AdaptiveNetworkHardeningEnforceContent"/> to convert. </param>
        public static implicit operator RequestContent(AdaptiveNetworkHardeningEnforceContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AdaptiveNetworkHardeningEnforceContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AdaptiveNetworkHardeningEnforceContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAdaptiveNetworkHardeningEnforceContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
