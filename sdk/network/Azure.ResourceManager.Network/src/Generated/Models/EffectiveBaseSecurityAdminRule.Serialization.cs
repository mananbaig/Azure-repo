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
    public partial class EffectiveBaseSecurityAdminRule : IUtf8JsonSerializable, IModelJsonSerializable<EffectiveBaseSecurityAdminRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EffectiveBaseSecurityAdminRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EffectiveBaseSecurityAdminRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ConfigurationDescription))
            {
                writer.WritePropertyName("configurationDescription"u8);
                writer.WriteStringValue(ConfigurationDescription);
            }
            if (Optional.IsDefined(RuleCollectionDescription))
            {
                writer.WritePropertyName("ruleCollectionDescription"u8);
                writer.WriteStringValue(RuleCollectionDescription);
            }
            if (Optional.IsCollectionDefined(RuleCollectionAppliesToGroups))
            {
                writer.WritePropertyName("ruleCollectionAppliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionAppliesToGroups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkManagerSecurityGroupItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkConfigurationGroup>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static EffectiveBaseSecurityAdminRule DeserializeEffectiveBaseSecurityAdminRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return EffectiveSecurityAdminRule.DeserializeEffectiveSecurityAdminRule(element);
                    case "Default": return EffectiveDefaultSecurityAdminRule.DeserializeEffectiveDefaultSecurityAdminRule(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<ResourceIdentifier> id = default;
            Optional<string> configurationDescription = default;
            Optional<string> ruleCollectionDescription = default;
            Optional<IReadOnlyList<NetworkManagerSecurityGroupItem>> ruleCollectionAppliesToGroups = default;
            Optional<IReadOnlyList<NetworkConfigurationGroup>> ruleGroups = default;
            EffectiveAdminRuleKind kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationDescription"u8))
                {
                    configurationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionDescription"u8))
                {
                    ruleCollectionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionAppliesToGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkManagerSecurityGroupItem> array = new List<NetworkManagerSecurityGroupItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkManagerSecurityGroupItem.DeserializeNetworkManagerSecurityGroupItem(item));
                    }
                    ruleCollectionAppliesToGroups = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EffectiveAdminRuleKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownEffectiveBaseSecurityAdminRule(id.Value, configurationDescription.Value, ruleCollectionDescription.Value, Optional.ToList(ruleCollectionAppliesToGroups), Optional.ToList(ruleGroups), kind, rawData);
        }

        EffectiveBaseSecurityAdminRule IModelJsonSerializable<EffectiveBaseSecurityAdminRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveBaseSecurityAdminRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EffectiveBaseSecurityAdminRule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EffectiveBaseSecurityAdminRule IModelSerializable<EffectiveBaseSecurityAdminRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEffectiveBaseSecurityAdminRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EffectiveBaseSecurityAdminRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EffectiveBaseSecurityAdminRule"/> to convert. </param>
        public static implicit operator RequestContent(EffectiveBaseSecurityAdminRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EffectiveBaseSecurityAdminRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EffectiveBaseSecurityAdminRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEffectiveBaseSecurityAdminRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
