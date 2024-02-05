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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryEventProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryEventProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryEventProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EventCode))
            {
                writer.WritePropertyName("eventCode"u8);
                writer.WriteStringValue(EventCode);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (Optional.IsDefined(AffectedObjectFriendlyName))
            {
                writer.WritePropertyName("affectedObjectFriendlyName"u8);
                writer.WriteStringValue(AffectedObjectFriendlyName);
            }
            if (Optional.IsDefined(AffectedObjectCorrelationId))
            {
                writer.WritePropertyName("affectedObjectCorrelationId"u8);
                writer.WriteStringValue(AffectedObjectCorrelationId);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (Optional.IsDefined(OccurredOn))
            {
                writer.WritePropertyName("timeOfOccurrence"u8);
                writer.WriteStringValue(OccurredOn.Value, "O");
            }
            if (Optional.IsDefined(FabricId))
            {
                writer.WritePropertyName("fabricId"u8);
                writer.WriteStringValue(FabricId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            if (Optional.IsDefined(EventSpecificDetails))
            {
                writer.WritePropertyName("eventSpecificDetails"u8);
                writer.WriteObjectValue(EventSpecificDetails);
            }
            if (Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
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

        SiteRecoveryEventProperties IJsonModel<SiteRecoveryEventProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryEventProperties(document.RootElement, options);
        }

        internal static SiteRecoveryEventProperties DeserializeSiteRecoveryEventProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eventCode = default;
            Optional<string> description = default;
            Optional<string> eventType = default;
            Optional<string> affectedObjectFriendlyName = default;
            Optional<string> affectedObjectCorrelationId = default;
            Optional<string> severity = default;
            Optional<DateTimeOffset> timeOfOccurrence = default;
            Optional<ResourceIdentifier> fabricId = default;
            Optional<SiteRecoveryEventProviderSpecificDetails> providerSpecificDetails = default;
            Optional<SiteRecoveryEventSpecificDetails> eventSpecificDetails = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventCode"u8))
                {
                    eventCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectFriendlyName"u8))
                {
                    affectedObjectFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectCorrelationId"u8))
                {
                    affectedObjectCorrelationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeOfOccurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfOccurrence = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = SiteRecoveryEventProviderSpecificDetails.DeserializeSiteRecoveryEventProviderSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("eventSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventSpecificDetails = SiteRecoveryEventSpecificDetails.DeserializeSiteRecoveryEventSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryEventProperties(eventCode.Value, description.Value, eventType.Value, affectedObjectFriendlyName.Value, affectedObjectCorrelationId.Value, severity.Value, Optional.ToNullable(timeOfOccurrence), fabricId.Value, providerSpecificDetails.Value, eventSpecificDetails.Value, Optional.ToList(healthErrors), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(EventCode))
            {
                builder.Append("  eventCode:");
                builder.AppendLine($" '{EventCode}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(EventType))
            {
                builder.Append("  eventType:");
                builder.AppendLine($" '{EventType}'");
            }

            if (Optional.IsDefined(AffectedObjectFriendlyName))
            {
                builder.Append("  affectedObjectFriendlyName:");
                builder.AppendLine($" '{AffectedObjectFriendlyName}'");
            }

            if (Optional.IsDefined(AffectedObjectCorrelationId))
            {
                builder.Append("  affectedObjectCorrelationId:");
                builder.AppendLine($" '{AffectedObjectCorrelationId}'");
            }

            if (Optional.IsDefined(Severity))
            {
                builder.Append("  severity:");
                builder.AppendLine($" '{Severity}'");
            }

            if (Optional.IsDefined(OccurredOn))
            {
                builder.Append("  timeOfOccurrence:");
                var formattedDateTimeString = TypeFormatters.ToString(OccurredOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(FabricId))
            {
                builder.Append("  fabricId:");
                builder.AppendLine($" '{FabricId.ToString()}'");
            }

            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                builder.Append("  providerSpecificDetails:");
                AppendChildObject(builder, ProviderSpecificDetails, options, 2, false);
            }

            if (Optional.IsDefined(EventSpecificDetails))
            {
                builder.Append("  eventSpecificDetails:");
                AppendChildObject(builder, EventSpecificDetails, options, 2, false);
            }

            if (Optional.IsCollectionDefined(HealthErrors))
            {
                if (HealthErrors.Any())
                {
                    builder.Append("  healthErrors:");
                    builder.AppendLine(" [");
                    foreach (var item in HealthErrors)
                    {
                        AppendChildObject(builder, item, options, 4, true);
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

        BinaryData IPersistableModel<SiteRecoveryEventProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryEventProperties IPersistableModel<SiteRecoveryEventProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryEventProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryEventProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
