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
    public partial class SecurityInsightsAutomationRuleTriggeringLogic : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsAutomationRuleTriggeringLogic>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsAutomationRuleTriggeringLogic>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsAutomationRuleTriggeringLogic>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleTriggeringLogic>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeUtc"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WritePropertyName("triggersOn"u8);
            writer.WriteStringValue(TriggersOn.ToString());
            writer.WritePropertyName("triggersWhen"u8);
            writer.WriteStringValue(TriggersWhen.ToString());
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SecurityInsightsAutomationRuleCondition>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static SecurityInsightsAutomationRuleTriggeringLogic DeserializeSecurityInsightsAutomationRuleTriggeringLogic(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isEnabled = default;
            Optional<DateTimeOffset> expirationTimeUtc = default;
            TriggersOn triggersOn = default;
            TriggersWhen triggersWhen = default;
            Optional<IList<SecurityInsightsAutomationRuleCondition>> conditions = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("expirationTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("triggersOn"u8))
                {
                    triggersOn = new TriggersOn(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggersWhen"u8))
                {
                    triggersWhen = new TriggersWhen(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAutomationRuleCondition> array = new List<SecurityInsightsAutomationRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsAutomationRuleCondition.DeserializeSecurityInsightsAutomationRuleCondition(item));
                    }
                    conditions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsAutomationRuleTriggeringLogic(isEnabled, Optional.ToNullable(expirationTimeUtc), triggersOn, triggersWhen, Optional.ToList(conditions), serializedAdditionalRawData);
        }

        SecurityInsightsAutomationRuleTriggeringLogic IModelJsonSerializable<SecurityInsightsAutomationRuleTriggeringLogic>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleTriggeringLogic>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAutomationRuleTriggeringLogic(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsAutomationRuleTriggeringLogic>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleTriggeringLogic>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsAutomationRuleTriggeringLogic IModelSerializable<SecurityInsightsAutomationRuleTriggeringLogic>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAutomationRuleTriggeringLogic>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAutomationRuleTriggeringLogic(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsAutomationRuleTriggeringLogic"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsAutomationRuleTriggeringLogic"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsAutomationRuleTriggeringLogic model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsAutomationRuleTriggeringLogic"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsAutomationRuleTriggeringLogic(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsAutomationRuleTriggeringLogic(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
