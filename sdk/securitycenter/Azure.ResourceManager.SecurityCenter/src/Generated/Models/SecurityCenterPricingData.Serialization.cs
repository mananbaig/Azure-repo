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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityCenterPricingData : IUtf8JsonSerializable, IJsonModel<SecurityCenterPricingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityCenterPricingData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityCenterPricingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPricingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterPricingData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PricingTier))
            {
                writer.WritePropertyName("pricingTier"u8);
                writer.WriteStringValue(PricingTier.Value.ToString());
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan"u8);
                writer.WriteStringValue(SubPlan);
            }
            if (options.Format != "W" && Optional.IsDefined(FreeTrialRemainingTime))
            {
                writer.WritePropertyName("freeTrialRemainingTime"u8);
                writer.WriteStringValue(FreeTrialRemainingTime.Value, "P");
            }
            if (options.Format != "W" && Optional.IsDefined(EnabledOn))
            {
                writer.WritePropertyName("enablementTime"u8);
                writer.WriteStringValue(EnabledOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsDeprecated))
            {
                writer.WritePropertyName("deprecated"u8);
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReplacedBy))
            {
                writer.WritePropertyName("replacedBy"u8);
                writer.WriteStartArray();
                foreach (var item in ReplacedBy)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        SecurityCenterPricingData IJsonModel<SecurityCenterPricingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPricingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterPricingData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityCenterPricingData(document.RootElement, options);
        }

        internal static SecurityCenterPricingData DeserializeSecurityCenterPricingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SecurityCenterPricingTier> pricingTier = default;
            Optional<string> subPlan = default;
            Optional<TimeSpan> freeTrialRemainingTime = default;
            Optional<DateTimeOffset> enablementTime = default;
            Optional<bool> deprecated = default;
            Optional<IReadOnlyList<string>> replacedBy = default;
            Optional<IList<PlanExtension>> extensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("pricingTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pricingTier = new SecurityCenterPricingTier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subPlan"u8))
                        {
                            subPlan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("freeTrialRemainingTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            freeTrialRemainingTime = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("enablementTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablementTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("deprecated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deprecated = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replacedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            replacedBy = array;
                            continue;
                        }
                        if (property0.NameEquals("extensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PlanExtension> array = new List<PlanExtension>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PlanExtension.DeserializePlanExtension(item));
                            }
                            extensions = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityCenterPricingData(id, name, type, systemData.Value, Optional.ToNullable(pricingTier), subPlan.Value, Optional.ToNullable(freeTrialRemainingTime), Optional.ToNullable(enablementTime), Optional.ToNullable(deprecated), Optional.ToList(replacedBy), Optional.ToList(extensions), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(PricingTier))
            {
                builder.Append("    pricingTier:");
                builder.AppendLine($" '{PricingTier.ToString()}'");
            }

            if (Optional.IsDefined(SubPlan))
            {
                builder.Append("    subPlan:");
                builder.AppendLine($" '{SubPlan}'");
            }

            if (Optional.IsDefined(FreeTrialRemainingTime))
            {
                builder.Append("    freeTrialRemainingTime:");
                var formattedTimeSpan = TypeFormatters.ToString(FreeTrialRemainingTime.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(EnabledOn))
            {
                builder.Append("    enablementTime:");
                var formattedDateTimeString = TypeFormatters.ToString(EnabledOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(IsDeprecated))
            {
                builder.Append("    deprecated:");
                var boolValue = IsDeprecated.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(ReplacedBy))
            {
                if (ReplacedBy.Any())
                {
                    builder.Append("    replacedBy:");
                    builder.AppendLine(" [");
                    foreach (var item in ReplacedBy)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Extensions))
            {
                if (Extensions.Any())
                {
                    builder.Append("    extensions:");
                    builder.AppendLine(" [");
                    foreach (var item in Extensions)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SecurityCenterPricingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPricingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterPricingData)} does not support '{options.Format}' format.");
            }
        }

        SecurityCenterPricingData IPersistableModel<SecurityCenterPricingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPricingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityCenterPricingData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterPricingData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityCenterPricingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
