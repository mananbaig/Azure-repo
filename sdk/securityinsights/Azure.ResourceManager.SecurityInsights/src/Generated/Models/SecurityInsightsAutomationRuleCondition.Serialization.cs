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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAutomationRuleCondition : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsAutomationRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsAutomationRuleCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsAutomationRuleCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleCondition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("conditionType"u8);
            writer.WriteStringValue(ConditionType.ToString());
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

        internal static SecurityInsightsAutomationRuleCondition DeserializeSecurityInsightsAutomationRuleCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("conditionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Property": return SecurityInsightsPropertyConditionProperties.DeserializeSecurityInsightsPropertyConditionProperties(element);
                    case "PropertyArrayChanged": return SecurityInsightsPropertyArrayChangedConditionProperties.DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(element);
                    case "PropertyChanged": return SecurityInsightsPropertyChangedConditionProperties.DeserializeSecurityInsightsPropertyChangedConditionProperties(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            ConditionType conditionType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionType"u8))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownAutomationRuleCondition(conditionType, serializedAdditionalRawData);
        }

        SecurityInsightsAutomationRuleCondition IModelJsonSerializable<SecurityInsightsAutomationRuleCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAutomationRuleCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsAutomationRuleCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsAutomationRuleCondition IModelSerializable<SecurityInsightsAutomationRuleCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAutomationRuleCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsAutomationRuleCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsAutomationRuleCondition"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsAutomationRuleCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsAutomationRuleCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsAutomationRuleCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsAutomationRuleCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
