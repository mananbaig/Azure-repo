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
    public partial class AutomationRulePropertyValuesChangedCondition : IUtf8JsonSerializable, IModelJsonSerializable<AutomationRulePropertyValuesChangedCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationRulePropertyValuesChangedCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationRulePropertyValuesChangedCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationRulePropertyValuesChangedCondition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PropertyName))
            {
                writer.WritePropertyName("propertyName"u8);
                writer.WriteStringValue(PropertyName.Value.ToString());
            }
            if (Optional.IsDefined(ChangeType))
            {
                writer.WritePropertyName("changeType"u8);
                writer.WriteStringValue(ChangeType.Value.ToString());
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PropertyValues))
            {
                writer.WritePropertyName("propertyValues"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyValues)
                {
                    writer.WriteStringValue(item);
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

        internal static AutomationRulePropertyValuesChangedCondition DeserializeAutomationRulePropertyValuesChangedCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRulePropertyChangedConditionSupportedPropertyType> propertyName = default;
            Optional<AutomationRulePropertyChangedConditionSupportedChangedType> changeType = default;
            Optional<AutomationRulePropertyConditionSupportedOperator> @operator = default;
            Optional<IList<string>> propertyValues = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyName = new AutomationRulePropertyChangedConditionSupportedPropertyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeType = new AutomationRulePropertyChangedConditionSupportedChangedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = new AutomationRulePropertyConditionSupportedOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyValues"u8))
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
                    propertyValues = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomationRulePropertyValuesChangedCondition(Optional.ToNullable(propertyName), Optional.ToNullable(changeType), Optional.ToNullable(@operator), Optional.ToList(propertyValues), serializedAdditionalRawData);
        }

        AutomationRulePropertyValuesChangedCondition IModelJsonSerializable<AutomationRulePropertyValuesChangedCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationRulePropertyValuesChangedCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRulePropertyValuesChangedCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationRulePropertyValuesChangedCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationRulePropertyValuesChangedCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationRulePropertyValuesChangedCondition IModelSerializable<AutomationRulePropertyValuesChangedCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutomationRulePropertyValuesChangedCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationRulePropertyValuesChangedCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomationRulePropertyValuesChangedCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomationRulePropertyValuesChangedCondition"/> to convert. </param>
        public static implicit operator RequestContent(AutomationRulePropertyValuesChangedCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomationRulePropertyValuesChangedCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomationRulePropertyValuesChangedCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationRulePropertyValuesChangedCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
