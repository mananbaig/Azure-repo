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
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsScheduledAlertRule : IUtf8JsonSerializable, IJsonModel<SecurityInsightsScheduledAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsScheduledAlertRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsScheduledAlertRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(QueryFrequency))
            {
                writer.WritePropertyName("queryFrequency"u8);
                writer.WriteStringValue(QueryFrequency.Value, "P");
            }
            if (Optional.IsDefined(QueryPeriod))
            {
                writer.WritePropertyName("queryPeriod"u8);
                writer.WriteStringValue(QueryPeriod.Value, "P");
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(TriggerOperator))
            {
                writer.WritePropertyName("triggerOperator"u8);
                writer.WriteStringValue(TriggerOperator.Value.ToSerialString());
            }
            if (Optional.IsDefined(TriggerThreshold))
            {
                writer.WritePropertyName("triggerThreshold"u8);
                writer.WriteNumberValue(TriggerThreshold.Value);
            }
            if (Optional.IsDefined(EventGroupingSettings))
            {
                writer.WritePropertyName("eventGroupingSettings"u8);
                writer.WriteObjectValue(EventGroupingSettings);
            }
            if (Optional.IsCollectionDefined(CustomDetails))
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteStartObject();
                foreach (var item in CustomDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(EntityMappings))
            {
                writer.WritePropertyName("entityMappings"u8);
                writer.WriteStartArray();
                foreach (var item in EntityMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlertDetailsOverride))
            {
                writer.WritePropertyName("alertDetailsOverride"u8);
                writer.WriteObjectValue(AlertDetailsOverride);
            }
            if (Optional.IsDefined(AlertRuleTemplateName))
            {
                writer.WritePropertyName("alertRuleTemplateName"u8);
                writer.WriteStringValue(AlertRuleTemplateName);
            }
            if (Optional.IsDefined(TemplateVersion))
            {
                writer.WritePropertyName("templateVersion"u8);
                writer.WriteStringValue(TemplateVersion);
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
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedUtc"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(SuppressionDuration))
            {
                writer.WritePropertyName("suppressionDuration"u8);
                writer.WriteStringValue(SuppressionDuration.Value, "P");
            }
            if (Optional.IsDefined(IsSuppressionEnabled))
            {
                writer.WritePropertyName("suppressionEnabled"u8);
                writer.WriteBooleanValue(IsSuppressionEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IncidentConfiguration))
            {
                writer.WritePropertyName("incidentConfiguration"u8);
                writer.WriteObjectValue(IncidentConfiguration);
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

        SecurityInsightsScheduledAlertRule IJsonModel<SecurityInsightsScheduledAlertRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsScheduledAlertRule(document.RootElement, options);
        }

        internal static SecurityInsightsScheduledAlertRule DeserializeSecurityInsightsScheduledAlertRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> query = default;
            Optional<TimeSpan> queryFrequency = default;
            Optional<TimeSpan> queryPeriod = default;
            Optional<SecurityInsightsAlertSeverity> severity = default;
            Optional<SecurityInsightsAlertRuleTriggerOperator> triggerOperator = default;
            Optional<int> triggerThreshold = default;
            Optional<EventGroupingSettings> eventGroupingSettings = default;
            Optional<IDictionary<string, string>> customDetails = default;
            Optional<IList<SecurityInsightsAlertRuleEntityMapping>> entityMappings = default;
            Optional<SecurityInsightsAlertDetailsOverride> alertDetailsOverride = default;
            Optional<string> alertRuleTemplateName = default;
            Optional<string> templateVersion = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> lastModifiedUtc = default;
            Optional<TimeSpan> suppressionDuration = default;
            Optional<bool> suppressionEnabled = default;
            Optional<IList<SecurityInsightsAttackTactic>> tactics = default;
            Optional<IList<string>> techniques = default;
            Optional<SecurityInsightsIncidentConfiguration> incidentConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryFrequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryFrequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("queryPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryPeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerOperator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerOperator = property0.Value.GetString().ToSecurityInsightsAlertRuleTriggerOperator();
                            continue;
                        }
                        if (property0.NameEquals("triggerThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerThreshold = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("eventGroupingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventGroupingSettings = EventGroupingSettings.DeserializeEventGroupingSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customDetails = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("entityMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertRuleEntityMapping> array = new List<SecurityInsightsAlertRuleEntityMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAlertRuleEntityMapping.DeserializeSecurityInsightsAlertRuleEntityMapping(item));
                            }
                            entityMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("alertDetailsOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertDetailsOverride = SecurityInsightsAlertDetailsOverride.DeserializeSecurityInsightsAlertDetailsOverride(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("alertRuleTemplateName"u8))
                        {
                            alertRuleTemplateName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("templateVersion"u8))
                        {
                            templateVersion = property0.Value.GetString();
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
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("suppressionDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suppressionDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("suppressionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suppressionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
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
                            techniques = array;
                            continue;
                        }
                        if (property0.NameEquals("incidentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            incidentConfiguration = SecurityInsightsIncidentConfiguration.DeserializeSecurityInsightsIncidentConfiguration(property0.Value);
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
            return new SecurityInsightsScheduledAlertRule(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), serializedAdditionalRawData, query.Value, Optional.ToNullable(queryFrequency), Optional.ToNullable(queryPeriod), Optional.ToNullable(severity), Optional.ToNullable(triggerOperator), Optional.ToNullable(triggerThreshold), eventGroupingSettings.Value, Optional.ToDictionary(customDetails), Optional.ToList(entityMappings), alertDetailsOverride.Value, alertRuleTemplateName.Value, templateVersion.Value, description.Value, displayName.Value, Optional.ToNullable(enabled), Optional.ToNullable(lastModifiedUtc), Optional.ToNullable(suppressionDuration), Optional.ToNullable(suppressionEnabled), Optional.ToList(tactics), Optional.ToList(techniques), incidentConfiguration.Value);
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

            if (Optional.IsDefined(ETag))
            {
                builder.Append("  etag:");
                builder.AppendLine($" '{ETag.Value.ToString()}'");
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
            if (Optional.IsDefined(Query))
            {
                builder.Append("    query:");
                builder.AppendLine($" '{Query}'");
            }

            if (Optional.IsDefined(QueryFrequency))
            {
                builder.Append("    queryFrequency:");
                var formattedTimeSpan = TypeFormatters.ToString(QueryFrequency.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(QueryPeriod))
            {
                builder.Append("    queryPeriod:");
                var formattedTimeSpan = TypeFormatters.ToString(QueryPeriod.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(Severity))
            {
                builder.Append("    severity:");
                builder.AppendLine($" '{Severity.ToString()}'");
            }

            if (Optional.IsDefined(TriggerOperator))
            {
                builder.Append("    triggerOperator:");
                builder.AppendLine($" '{TriggerOperator.ToString()}'");
            }

            if (Optional.IsDefined(TriggerThreshold))
            {
                builder.Append("    triggerThreshold:");
                builder.AppendLine($" {TriggerThreshold.Value}");
            }

            if (Optional.IsDefined(EventGroupingSettings))
            {
                builder.Append("    eventGroupingSettings:");
                AppendChildObject(builder, EventGroupingSettings, options, 4, false);
            }

            if (Optional.IsCollectionDefined(CustomDetails))
            {
                if (CustomDetails.Any())
                {
                    builder.Append("    customDetails:");
                    builder.AppendLine(" {");
                    foreach (var item in CustomDetails)
                    {
                        builder.Append($"        {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("    }");
                }
            }

            if (Optional.IsCollectionDefined(EntityMappings))
            {
                if (EntityMappings.Any())
                {
                    builder.Append("    entityMappings:");
                    builder.AppendLine(" [");
                    foreach (var item in EntityMappings)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(AlertDetailsOverride))
            {
                builder.Append("    alertDetailsOverride:");
                AppendChildObject(builder, AlertDetailsOverride, options, 4, false);
            }

            if (Optional.IsDefined(AlertRuleTemplateName))
            {
                builder.Append("    alertRuleTemplateName:");
                builder.AppendLine($" '{AlertRuleTemplateName}'");
            }

            if (Optional.IsDefined(TemplateVersion))
            {
                builder.Append("    templateVersion:");
                builder.AppendLine($" '{TemplateVersion}'");
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

            if (Optional.IsDefined(IsEnabled))
            {
                builder.Append("    enabled:");
                var boolValue = IsEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(LastModifiedOn))
            {
                builder.Append("    lastModifiedUtc:");
                var formattedDateTimeString = TypeFormatters.ToString(LastModifiedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(SuppressionDuration))
            {
                builder.Append("    suppressionDuration:");
                var formattedTimeSpan = TypeFormatters.ToString(SuppressionDuration.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(IsSuppressionEnabled))
            {
                builder.Append("    suppressionEnabled:");
                var boolValue = IsSuppressionEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(Tactics))
            {
                if (Tactics.Any())
                {
                    builder.Append("    tactics:");
                    builder.AppendLine(" [");
                    foreach (var item in Tactics)
                    {
                        builder.AppendLine($"      '{item.ToString()}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Techniques))
            {
                if (Techniques.Any())
                {
                    builder.Append("    techniques:");
                    builder.AppendLine(" [");
                    foreach (var item in Techniques)
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

            if (Optional.IsDefined(IncidentConfiguration))
            {
                builder.Append("    incidentConfiguration:");
                AppendChildObject(builder, IncidentConfiguration, options, 4, false);
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

        BinaryData IPersistableModel<SecurityInsightsScheduledAlertRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsScheduledAlertRule IPersistableModel<SecurityInsightsScheduledAlertRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsScheduledAlertRule(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsScheduledAlertRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
