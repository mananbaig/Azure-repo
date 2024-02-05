// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRulePropertyValuesCondition : IUtf8JsonSerializable, IJsonModel<AutomationRulePropertyValuesCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRulePropertyValuesCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationRulePropertyValuesCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyValuesCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRulePropertyValuesCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PropertyName))
            {
                writer.WritePropertyName("propertyName"u8);
                writer.WriteStringValue(PropertyName.Value.ToString());
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
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AutomationRulePropertyValuesCondition IJsonModel<AutomationRulePropertyValuesCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyValuesCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRulePropertyValuesCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRulePropertyValuesCondition(document.RootElement, options);
        }

        internal static AutomationRulePropertyValuesCondition DeserializeAutomationRulePropertyValuesCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRulePropertyConditionSupportedProperty> propertyName = default;
            Optional<AutomationRulePropertyConditionSupportedOperator> @operator = default;
            Optional<IList<string>> propertyValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyName = new AutomationRulePropertyConditionSupportedProperty(property.Value.GetString());
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationRulePropertyValuesCondition(Optional.ToNullable(propertyName), Optional.ToNullable(@operator), Optional.ToList(propertyValues), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(PropertyName))
            {
                builder.Append("  propertyName:");
                builder.AppendLine($" '{PropertyName.ToString()}'");
            }

            if (Optional.IsDefined(Operator))
            {
                builder.Append("  operator:");
                builder.AppendLine($" '{Operator.ToString()}'");
            }

            if (Optional.IsCollectionDefined(PropertyValues))
            {
                if (PropertyValues.Any())
                {
                    builder.Append("  propertyValues:");
                    builder.AppendLine(" [");
                    foreach (var item in PropertyValues)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<AutomationRulePropertyValuesCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyValuesCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AutomationRulePropertyValuesCondition)} does not support '{options.Format}' format.");
            }
        }

        AutomationRulePropertyValuesCondition IPersistableModel<AutomationRulePropertyValuesCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyValuesCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationRulePropertyValuesCondition(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AutomationRulePropertyValuesCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRulePropertyValuesCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
