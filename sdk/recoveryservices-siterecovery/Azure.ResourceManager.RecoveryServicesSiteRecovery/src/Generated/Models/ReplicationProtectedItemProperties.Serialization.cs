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
    public partial class ReplicationProtectedItemProperties : IUtf8JsonSerializable, IJsonModel<ReplicationProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProtectedItemProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProtectedItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectedItemType))
            {
                writer.WritePropertyName("protectedItemType"u8);
                writer.WriteStringValue(ProtectedItemType);
            }
            if (Optional.IsDefined(ProtectableItemId))
            {
                writer.WritePropertyName("protectableItemId"u8);
                writer.WriteStringValue(ProtectableItemId);
            }
            if (Optional.IsDefined(RecoveryServicesProviderId))
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (Optional.IsDefined(PrimaryFabricFriendlyName))
            {
                writer.WritePropertyName("primaryFabricFriendlyName"u8);
                writer.WriteStringValue(PrimaryFabricFriendlyName);
            }
            if (Optional.IsDefined(PrimaryFabricProvider))
            {
                writer.WritePropertyName("primaryFabricProvider"u8);
                writer.WriteStringValue(PrimaryFabricProvider);
            }
            if (Optional.IsDefined(RecoveryFabricFriendlyName))
            {
                writer.WritePropertyName("recoveryFabricFriendlyName"u8);
                writer.WriteStringValue(RecoveryFabricFriendlyName);
            }
            if (Optional.IsDefined(RecoveryFabricId))
            {
                writer.WritePropertyName("recoveryFabricId"u8);
                writer.WriteStringValue(RecoveryFabricId);
            }
            if (Optional.IsDefined(PrimaryProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("primaryProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(PrimaryProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(RecoveryProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("recoveryProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(RecoveryProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState);
            }
            if (Optional.IsDefined(ProtectionStateDescription))
            {
                writer.WritePropertyName("protectionStateDescription"u8);
                writer.WriteStringValue(ProtectionStateDescription);
            }
            if (Optional.IsDefined(ActiveLocation))
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation);
            }
            if (Optional.IsDefined(TestFailoverState))
            {
                writer.WritePropertyName("testFailoverState"u8);
                writer.WriteStringValue(TestFailoverState);
            }
            if (Optional.IsDefined(TestFailoverStateDescription))
            {
                writer.WritePropertyName("testFailoverStateDescription"u8);
                writer.WriteStringValue(TestFailoverStateDescription);
            }
            if (Optional.IsDefined(SwitchProviderState))
            {
                writer.WritePropertyName("switchProviderState"u8);
                writer.WriteStringValue(SwitchProviderState);
            }
            if (Optional.IsDefined(SwitchProviderStateDescription))
            {
                writer.WritePropertyName("switchProviderStateDescription"u8);
                writer.WriteStringValue(SwitchProviderStateDescription);
            }
            if (Optional.IsCollectionDefined(AllowedOperations))
            {
                writer.WritePropertyName("allowedOperations"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedOperations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicationHealth))
            {
                writer.WritePropertyName("replicationHealth"u8);
                writer.WriteStringValue(ReplicationHealth);
            }
            if (Optional.IsDefined(FailoverHealth))
            {
                writer.WritePropertyName("failoverHealth"u8);
                writer.WriteStringValue(FailoverHealth);
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
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(PolicyFriendlyName))
            {
                writer.WritePropertyName("policyFriendlyName"u8);
                writer.WriteStringValue(PolicyFriendlyName);
            }
            if (Optional.IsDefined(LastSuccessfulFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(LastSuccessfulTestFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulTestFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulTestFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(CurrentScenario))
            {
                writer.WritePropertyName("currentScenario"u8);
                writer.WriteObjectValue(CurrentScenario);
            }
            if (Optional.IsDefined(FailoverRecoveryPointId))
            {
                writer.WritePropertyName("failoverRecoveryPointId"u8);
                writer.WriteStringValue(FailoverRecoveryPointId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            if (Optional.IsDefined(RecoveryContainerId))
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (Optional.IsDefined(EventCorrelationId))
            {
                writer.WritePropertyName("eventCorrelationId"u8);
                writer.WriteStringValue(EventCorrelationId.Value);
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

        ReplicationProtectedItemProperties IJsonModel<ReplicationProtectedItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProtectedItemProperties(document.RootElement, options);
        }

        internal static ReplicationProtectedItemProperties DeserializeReplicationProtectedItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<string> protectedItemType = default;
            Optional<ResourceIdentifier> protectableItemId = default;
            Optional<string> recoveryServicesProviderId = default;
            Optional<string> primaryFabricFriendlyName = default;
            Optional<string> primaryFabricProvider = default;
            Optional<string> recoveryFabricFriendlyName = default;
            Optional<ResourceIdentifier> recoveryFabricId = default;
            Optional<string> primaryProtectionContainerFriendlyName = default;
            Optional<string> recoveryProtectionContainerFriendlyName = default;
            Optional<string> protectionState = default;
            Optional<string> protectionStateDescription = default;
            Optional<string> activeLocation = default;
            Optional<string> testFailoverState = default;
            Optional<string> testFailoverStateDescription = default;
            Optional<string> switchProviderState = default;
            Optional<string> switchProviderStateDescription = default;
            Optional<IReadOnlyList<string>> allowedOperations = default;
            Optional<string> replicationHealth = default;
            Optional<string> failoverHealth = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<string> policyFriendlyName = default;
            Optional<DateTimeOffset> lastSuccessfulFailoverTime = default;
            Optional<DateTimeOffset> lastSuccessfulTestFailoverTime = default;
            Optional<CurrentScenarioDetails> currentScenario = default;
            Optional<ResourceIdentifier> failoverRecoveryPointId = default;
            Optional<ReplicationProviderSpecificSettings> providerSpecificDetails = default;
            Optional<ResourceIdentifier> recoveryContainerId = default;
            Optional<Guid> eventCorrelationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectableItemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    recoveryServicesProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricProvider"u8))
                {
                    primaryFabricProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryProtectionContainerFriendlyName"u8))
                {
                    primaryProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryProtectionContainerFriendlyName"u8))
                {
                    recoveryProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    protectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStateDescription"u8))
                {
                    protectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activeLocation"u8))
                {
                    activeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverState"u8))
                {
                    testFailoverState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverStateDescription"u8))
                {
                    testFailoverStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("switchProviderState"u8))
                {
                    switchProviderState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("switchProviderStateDescription"u8))
                {
                    switchProviderStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedOperations"u8))
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
                    allowedOperations = array;
                    continue;
                }
                if (property.NameEquals("replicationHealth"u8))
                {
                    replicationHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverHealth"u8))
                {
                    failoverHealth = property.Value.GetString();
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
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyFriendlyName"u8))
                {
                    policyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSuccessfulFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSuccessfulTestFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulTestFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentScenario"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentScenario = CurrentScenarioDetails.DeserializeCurrentScenarioDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = ReplicationProviderSpecificSettings.DeserializeReplicationProviderSpecificSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventCorrelationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventCorrelationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplicationProtectedItemProperties(friendlyName.Value, protectedItemType.Value, protectableItemId.Value, recoveryServicesProviderId.Value, primaryFabricFriendlyName.Value, primaryFabricProvider.Value, recoveryFabricFriendlyName.Value, recoveryFabricId.Value, primaryProtectionContainerFriendlyName.Value, recoveryProtectionContainerFriendlyName.Value, protectionState.Value, protectionStateDescription.Value, activeLocation.Value, testFailoverState.Value, testFailoverStateDescription.Value, switchProviderState.Value, switchProviderStateDescription.Value, Optional.ToList(allowedOperations), replicationHealth.Value, failoverHealth.Value, Optional.ToList(healthErrors), policyId.Value, policyFriendlyName.Value, Optional.ToNullable(lastSuccessfulFailoverTime), Optional.ToNullable(lastSuccessfulTestFailoverTime), currentScenario.Value, failoverRecoveryPointId.Value, providerSpecificDetails.Value, recoveryContainerId.Value, Optional.ToNullable(eventCorrelationId), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("  friendlyName:");
                builder.AppendLine($" '{FriendlyName}'");
            }

            if (Optional.IsDefined(ProtectedItemType))
            {
                builder.Append("  protectedItemType:");
                builder.AppendLine($" '{ProtectedItemType}'");
            }

            if (Optional.IsDefined(ProtectableItemId))
            {
                builder.Append("  protectableItemId:");
                builder.AppendLine($" '{ProtectableItemId.ToString()}'");
            }

            if (Optional.IsDefined(RecoveryServicesProviderId))
            {
                builder.Append("  recoveryServicesProviderId:");
                builder.AppendLine($" '{RecoveryServicesProviderId}'");
            }

            if (Optional.IsDefined(PrimaryFabricFriendlyName))
            {
                builder.Append("  primaryFabricFriendlyName:");
                builder.AppendLine($" '{PrimaryFabricFriendlyName}'");
            }

            if (Optional.IsDefined(PrimaryFabricProvider))
            {
                builder.Append("  primaryFabricProvider:");
                builder.AppendLine($" '{PrimaryFabricProvider}'");
            }

            if (Optional.IsDefined(RecoveryFabricFriendlyName))
            {
                builder.Append("  recoveryFabricFriendlyName:");
                builder.AppendLine($" '{RecoveryFabricFriendlyName}'");
            }

            if (Optional.IsDefined(RecoveryFabricId))
            {
                builder.Append("  recoveryFabricId:");
                builder.AppendLine($" '{RecoveryFabricId.ToString()}'");
            }

            if (Optional.IsDefined(PrimaryProtectionContainerFriendlyName))
            {
                builder.Append("  primaryProtectionContainerFriendlyName:");
                builder.AppendLine($" '{PrimaryProtectionContainerFriendlyName}'");
            }

            if (Optional.IsDefined(RecoveryProtectionContainerFriendlyName))
            {
                builder.Append("  recoveryProtectionContainerFriendlyName:");
                builder.AppendLine($" '{RecoveryProtectionContainerFriendlyName}'");
            }

            if (Optional.IsDefined(ProtectionState))
            {
                builder.Append("  protectionState:");
                builder.AppendLine($" '{ProtectionState}'");
            }

            if (Optional.IsDefined(ProtectionStateDescription))
            {
                builder.Append("  protectionStateDescription:");
                builder.AppendLine($" '{ProtectionStateDescription}'");
            }

            if (Optional.IsDefined(ActiveLocation))
            {
                builder.Append("  activeLocation:");
                builder.AppendLine($" '{ActiveLocation}'");
            }

            if (Optional.IsDefined(TestFailoverState))
            {
                builder.Append("  testFailoverState:");
                builder.AppendLine($" '{TestFailoverState}'");
            }

            if (Optional.IsDefined(TestFailoverStateDescription))
            {
                builder.Append("  testFailoverStateDescription:");
                builder.AppendLine($" '{TestFailoverStateDescription}'");
            }

            if (Optional.IsDefined(SwitchProviderState))
            {
                builder.Append("  switchProviderState:");
                builder.AppendLine($" '{SwitchProviderState}'");
            }

            if (Optional.IsDefined(SwitchProviderStateDescription))
            {
                builder.Append("  switchProviderStateDescription:");
                builder.AppendLine($" '{SwitchProviderStateDescription}'");
            }

            if (Optional.IsCollectionDefined(AllowedOperations))
            {
                if (AllowedOperations.Any())
                {
                    builder.Append("  allowedOperations:");
                    builder.AppendLine(" [");
                    foreach (var item in AllowedOperations)
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

            if (Optional.IsDefined(ReplicationHealth))
            {
                builder.Append("  replicationHealth:");
                builder.AppendLine($" '{ReplicationHealth}'");
            }

            if (Optional.IsDefined(FailoverHealth))
            {
                builder.Append("  failoverHealth:");
                builder.AppendLine($" '{FailoverHealth}'");
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

            if (Optional.IsDefined(PolicyId))
            {
                builder.Append("  policyId:");
                builder.AppendLine($" '{PolicyId.ToString()}'");
            }

            if (Optional.IsDefined(PolicyFriendlyName))
            {
                builder.Append("  policyFriendlyName:");
                builder.AppendLine($" '{PolicyFriendlyName}'");
            }

            if (Optional.IsDefined(LastSuccessfulFailoverOn))
            {
                builder.Append("  lastSuccessfulFailoverTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastSuccessfulFailoverOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastSuccessfulTestFailoverOn))
            {
                builder.Append("  lastSuccessfulTestFailoverTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastSuccessfulTestFailoverOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(CurrentScenario))
            {
                builder.Append("  currentScenario:");
                AppendChildObject(builder, CurrentScenario, options, 2, false);
            }

            if (Optional.IsDefined(FailoverRecoveryPointId))
            {
                builder.Append("  failoverRecoveryPointId:");
                builder.AppendLine($" '{FailoverRecoveryPointId.ToString()}'");
            }

            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                builder.Append("  providerSpecificDetails:");
                AppendChildObject(builder, ProviderSpecificDetails, options, 2, false);
            }

            if (Optional.IsDefined(RecoveryContainerId))
            {
                builder.Append("  recoveryContainerId:");
                builder.AppendLine($" '{RecoveryContainerId.ToString()}'");
            }

            if (Optional.IsDefined(EventCorrelationId))
            {
                builder.Append("  eventCorrelationId:");
                builder.AppendLine($" '{EventCorrelationId.Value.ToString()}'");
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

        BinaryData IPersistableModel<ReplicationProtectedItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        ReplicationProtectedItemProperties IPersistableModel<ReplicationProtectedItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationProtectedItemProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationProtectedItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
