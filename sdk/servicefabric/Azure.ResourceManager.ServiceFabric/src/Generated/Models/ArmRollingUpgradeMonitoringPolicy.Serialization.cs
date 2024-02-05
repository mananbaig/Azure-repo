// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmRollingUpgradeMonitoringPolicy : IUtf8JsonSerializable, IJsonModel<ArmRollingUpgradeMonitoringPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmRollingUpgradeMonitoringPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmRollingUpgradeMonitoringPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FailureAction))
            {
                writer.WritePropertyName("failureAction"u8);
                writer.WriteStringValue(FailureAction.Value.ToString());
            }
            if (Optional.IsDefined(HealthCheckWaitDuration))
            {
                writer.WritePropertyName("healthCheckWaitDuration"u8);
                writer.WriteStringValue(HealthCheckWaitDuration.Value, "c");
            }
            if (Optional.IsDefined(HealthCheckStableDuration))
            {
                writer.WritePropertyName("healthCheckStableDuration"u8);
                writer.WriteStringValue(HealthCheckStableDuration.Value, "c");
            }
            if (Optional.IsDefined(HealthCheckRetryTimeout))
            {
                writer.WritePropertyName("healthCheckRetryTimeout"u8);
                writer.WriteStringValue(HealthCheckRetryTimeout.Value, "c");
            }
            if (Optional.IsDefined(UpgradeTimeout))
            {
                writer.WritePropertyName("upgradeTimeout"u8);
                writer.WriteStringValue(UpgradeTimeout.Value, "c");
            }
            if (Optional.IsDefined(UpgradeDomainTimeout))
            {
                writer.WritePropertyName("upgradeDomainTimeout"u8);
                writer.WriteStringValue(UpgradeDomainTimeout.Value, "c");
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

        ArmRollingUpgradeMonitoringPolicy IJsonModel<ArmRollingUpgradeMonitoringPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmRollingUpgradeMonitoringPolicy(document.RootElement, options);
        }

        internal static ArmRollingUpgradeMonitoringPolicy DeserializeArmRollingUpgradeMonitoringPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmUpgradeFailureAction> failureAction = default;
            Optional<TimeSpan> healthCheckWaitDuration = default;
            Optional<TimeSpan> healthCheckStableDuration = default;
            Optional<TimeSpan> healthCheckRetryTimeout = default;
            Optional<TimeSpan> upgradeTimeout = default;
            Optional<TimeSpan> upgradeDomainTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureAction = new ArmUpgradeFailureAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckRetryTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeDomainTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmRollingUpgradeMonitoringPolicy(Optional.ToNullable(failureAction), Optional.ToNullable(healthCheckWaitDuration), Optional.ToNullable(healthCheckStableDuration), Optional.ToNullable(healthCheckRetryTimeout), Optional.ToNullable(upgradeTimeout), Optional.ToNullable(upgradeDomainTimeout), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FailureAction))
            {
                builder.Append("  failureAction:");
                builder.AppendLine($" '{FailureAction.ToString()}'");
            }

            if (Optional.IsDefined(HealthCheckWaitDuration))
            {
                builder.Append("  healthCheckWaitDuration:");
                var formattedTimeSpan = TypeFormatters.ToString(HealthCheckWaitDuration.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(HealthCheckStableDuration))
            {
                builder.Append("  healthCheckStableDuration:");
                var formattedTimeSpan = TypeFormatters.ToString(HealthCheckStableDuration.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(HealthCheckRetryTimeout))
            {
                builder.Append("  healthCheckRetryTimeout:");
                var formattedTimeSpan = TypeFormatters.ToString(HealthCheckRetryTimeout.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(UpgradeTimeout))
            {
                builder.Append("  upgradeTimeout:");
                var formattedTimeSpan = TypeFormatters.ToString(UpgradeTimeout.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(UpgradeDomainTimeout))
            {
                builder.Append("  upgradeDomainTimeout:");
                var formattedTimeSpan = TypeFormatters.ToString(UpgradeDomainTimeout.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
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

        BinaryData IPersistableModel<ArmRollingUpgradeMonitoringPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support '{options.Format}' format.");
            }
        }

        ArmRollingUpgradeMonitoringPolicy IPersistableModel<ArmRollingUpgradeMonitoringPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmRollingUpgradeMonitoringPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmRollingUpgradeMonitoringPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
