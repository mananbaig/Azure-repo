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

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyRuleCollectionInfo : IUtf8JsonSerializable, IModelJsonSerializable<FirewallPolicyRuleCollectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirewallPolicyRuleCollectionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirewallPolicyRuleCollectionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("ruleCollectionType"u8);
            writer.WriteStringValue(RuleCollectionType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
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

        internal static FirewallPolicyRuleCollectionInfo DeserializeFirewallPolicyRuleCollectionInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleCollectionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FirewallPolicyFilterRuleCollection": return FirewallPolicyFilterRuleCollectionInfo.DeserializeFirewallPolicyFilterRuleCollectionInfo(element);
                    case "FirewallPolicyNatRuleCollection": return FirewallPolicyNatRuleCollectionInfo.DeserializeFirewallPolicyNatRuleCollectionInfo(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            FirewallPolicyRuleCollectionType ruleCollectionType = default;
            Optional<string> name = default;
            Optional<int> priority = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleCollectionType"u8))
                {
                    ruleCollectionType = new FirewallPolicyRuleCollectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownFirewallPolicyRuleCollection(ruleCollectionType, name.Value, Optional.ToNullable(priority), rawData);
        }

        FirewallPolicyRuleCollectionInfo IModelJsonSerializable<FirewallPolicyRuleCollectionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyRuleCollectionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirewallPolicyRuleCollectionInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirewallPolicyRuleCollectionInfo IModelSerializable<FirewallPolicyRuleCollectionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirewallPolicyRuleCollectionInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirewallPolicyRuleCollectionInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirewallPolicyRuleCollectionInfo"/> to convert. </param>
        public static implicit operator RequestContent(FirewallPolicyRuleCollectionInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirewallPolicyRuleCollectionInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirewallPolicyRuleCollectionInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirewallPolicyRuleCollectionInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
