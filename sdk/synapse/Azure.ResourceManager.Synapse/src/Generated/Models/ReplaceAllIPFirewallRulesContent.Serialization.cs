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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class ReplaceAllIPFirewallRulesContent : IUtf8JsonSerializable, IModelJsonSerializable<ReplaceAllIPFirewallRulesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReplaceAllIPFirewallRulesContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReplaceAllIPFirewallRulesContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplaceAllIPFirewallRulesContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPFirewallRules))
            {
                writer.WritePropertyName("ipFirewallRules"u8);
                writer.WriteStartObject();
                foreach (var item in IPFirewallRules)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SynapseIPFirewallRuleProperties>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static ReplaceAllIPFirewallRulesContent DeserializeReplaceAllIPFirewallRulesContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, SynapseIPFirewallRuleProperties>> ipFirewallRules = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipFirewallRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SynapseIPFirewallRuleProperties> dictionary = new Dictionary<string, SynapseIPFirewallRuleProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SynapseIPFirewallRuleProperties.DeserializeSynapseIPFirewallRuleProperties(property0.Value));
                    }
                    ipFirewallRules = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReplaceAllIPFirewallRulesContent(Optional.ToDictionary(ipFirewallRules), serializedAdditionalRawData);
        }

        ReplaceAllIPFirewallRulesContent IModelJsonSerializable<ReplaceAllIPFirewallRulesContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplaceAllIPFirewallRulesContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReplaceAllIPFirewallRulesContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReplaceAllIPFirewallRulesContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplaceAllIPFirewallRulesContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReplaceAllIPFirewallRulesContent IModelSerializable<ReplaceAllIPFirewallRulesContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplaceAllIPFirewallRulesContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReplaceAllIPFirewallRulesContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReplaceAllIPFirewallRulesContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReplaceAllIPFirewallRulesContent"/> to convert. </param>
        public static implicit operator RequestContent(ReplaceAllIPFirewallRulesContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReplaceAllIPFirewallRulesContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReplaceAllIPFirewallRulesContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReplaceAllIPFirewallRulesContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
