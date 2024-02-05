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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MicrosoftSecurityIncidentCreationAlertRuleTemplate : IUtf8JsonSerializable, IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
            {
                writer.WritePropertyName("alertRulesCreatedByTemplateCount"u8);
                writer.WriteNumberValue(AlertRulesCreatedByTemplateCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDateUTC"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedDateUTC"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                writer.WritePropertyName("requiredDataConnectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DisplayNamesFilter))
            {
                writer.WritePropertyName("displayNamesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNamesFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DisplayNamesExcludeFilter))
            {
                writer.WritePropertyName("displayNamesExcludeFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNamesExcludeFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProductFilter))
            {
                writer.WritePropertyName("productFilter"u8);
                writer.WriteStringValue(ProductFilter.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SeveritiesFilter))
            {
                writer.WritePropertyName("severitiesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in SeveritiesFilter)
                {
                    writer.WriteStringValue(item.ToString());
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

        MicrosoftSecurityIncidentCreationAlertRuleTemplate IJsonModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftSecurityIncidentCreationAlertRuleTemplate(document.RootElement, options);
        }

        internal static MicrosoftSecurityIncidentCreationAlertRuleTemplate DeserializeMicrosoftSecurityIncidentCreationAlertRuleTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> alertRulesCreatedByTemplateCount = default;
            Optional<DateTimeOffset> createdDateUTC = default;
            Optional<DateTimeOffset> lastUpdatedDateUTC = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<IList<AlertRuleTemplateDataSource>> requiredDataConnectors = default;
            Optional<SecurityInsightsAlertRuleTemplateStatus> status = default;
            Optional<IList<string>> displayNamesFilter = default;
            Optional<IList<string>> displayNamesExcludeFilter = default;
            Optional<MicrosoftSecurityProductName> productFilter = default;
            Optional<IList<SecurityInsightsAlertSeverity>> severitiesFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("alertRulesCreatedByTemplateCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertRulesCreatedByTemplateCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("createdDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AlertRuleTemplateDataSource> array = new List<AlertRuleTemplateDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AlertRuleTemplateDataSource.DeserializeAlertRuleTemplateDataSource(item));
                            }
                            requiredDataConnectors = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertRuleTemplateStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayNamesFilter"u8))
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
                            displayNamesFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("displayNamesExcludeFilter"u8))
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
                            displayNamesExcludeFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("productFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productFilter = new MicrosoftSecurityProductName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severitiesFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertSeverity> array = new List<SecurityInsightsAlertSeverity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAlertSeverity(item.GetString()));
                            }
                            severitiesFilter = array;
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
            return new MicrosoftSecurityIncidentCreationAlertRuleTemplate(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToNullable(alertRulesCreatedByTemplateCount), Optional.ToNullable(createdDateUTC), Optional.ToNullable(lastUpdatedDateUTC), description.Value, displayName.Value, Optional.ToList(requiredDataConnectors), Optional.ToNullable(status), Optional.ToList(displayNamesFilter), Optional.ToList(displayNamesExcludeFilter), Optional.ToNullable(productFilter), Optional.ToList(severitiesFilter));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
            }

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
            if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
            {
                builder.Append("    alertRulesCreatedByTemplateCount:");
                builder.AppendLine($" {AlertRulesCreatedByTemplateCount.Value}");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("    createdDateUTC:");
                var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastUpdatedOn))
            {
                builder.Append("    lastUpdatedDateUTC:");
                var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("    description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("    displayName:");
                builder.AppendLine($" '{DisplayName}'");
            }

            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                if (RequiredDataConnectors.Any())
                {
                    builder.Append("    requiredDataConnectors:");
                    builder.AppendLine(" [");
                    foreach (var item in RequiredDataConnectors)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("    status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsCollectionDefined(DisplayNamesFilter))
            {
                if (DisplayNamesFilter.Any())
                {
                    builder.Append("    displayNamesFilter:");
                    builder.AppendLine(" [");
                    foreach (var item in DisplayNamesFilter)
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

            if (Optional.IsCollectionDefined(DisplayNamesExcludeFilter))
            {
                if (DisplayNamesExcludeFilter.Any())
                {
                    builder.Append("    displayNamesExcludeFilter:");
                    builder.AppendLine(" [");
                    foreach (var item in DisplayNamesExcludeFilter)
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

            if (Optional.IsDefined(ProductFilter))
            {
                builder.Append("    productFilter:");
                builder.AppendLine($" '{ProductFilter.ToString()}'");
            }

            if (Optional.IsCollectionDefined(SeveritiesFilter))
            {
                if (SeveritiesFilter.Any())
                {
                    builder.Append("    severitiesFilter:");
                    builder.AppendLine(" [");
                    foreach (var item in SeveritiesFilter)
                    {
                        builder.AppendLine($"      '{item.ToString()}'");
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

        BinaryData IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support '{options.Format}' format.");
            }
        }

        MicrosoftSecurityIncidentCreationAlertRuleTemplate IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMicrosoftSecurityIncidentCreationAlertRuleTemplate(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MicrosoftSecurityIncidentCreationAlertRuleTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MicrosoftSecurityIncidentCreationAlertRuleTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
