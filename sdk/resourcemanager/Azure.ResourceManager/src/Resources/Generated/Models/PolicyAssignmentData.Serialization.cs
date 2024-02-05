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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class PolicyAssignmentData : IUtf8JsonSerializable, IJsonModel<PolicyAssignmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyAssignmentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, ManagedIdentity);
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
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (options.Format != "W" && Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsCollectionDefined(ExcludedScopes))
            {
                writer.WritePropertyName("notScopes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(EnforcementMode))
            {
                writer.WritePropertyName("enforcementMode"u8);
                writer.WriteStringValue(EnforcementMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NonComplianceMessages))
            {
                writer.WritePropertyName("nonComplianceMessages"u8);
                writer.WriteStartArray();
                foreach (var item in NonComplianceMessages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceSelectors))
            {
                writer.WritePropertyName("resourceSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Overrides))
            {
                writer.WritePropertyName("overrides"u8);
                writer.WriteStartArray();
                foreach (var item in Overrides)
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

        PolicyAssignmentData IJsonModel<PolicyAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyAssignmentData(document.RootElement, options);
        }

        internal static PolicyAssignmentData DeserializePolicyAssignmentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<ManagedServiceIdentity> identity = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> policyDefinitionId = default;
            Optional<string> scope = default;
            Optional<IList<string>> notScopes = default;
            Optional<IDictionary<string, ArmPolicyParameterValue>> parameters = default;
            Optional<string> description = default;
            Optional<BinaryData> metadata = default;
            Optional<EnforcementMode> enforcementMode = default;
            Optional<IList<NonComplianceMessage>> nonComplianceMessages = default;
            Optional<IList<ResourceSelector>> resourceSelectors = default;
            Optional<IList<PolicyOverride>> overrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionId"u8))
                        {
                            policyDefinitionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notScopes"u8))
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
                            notScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ArmPolicyParameterValue> dictionary = new Dictionary<string, ArmPolicyParameterValue>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ArmPolicyParameterValue.DeserializeArmPolicyParameterValue(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enforcementMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enforcementMode = new EnforcementMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nonComplianceMessages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NonComplianceMessage> array = new List<NonComplianceMessage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NonComplianceMessage.DeserializeNonComplianceMessage(item));
                            }
                            nonComplianceMessages = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceSelector> array = new List<ResourceSelector>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceSelector.DeserializeResourceSelector(item));
                            }
                            resourceSelectors = array;
                            continue;
                        }
                        if (property0.NameEquals("overrides"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PolicyOverride> array = new List<PolicyOverride>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PolicyOverride.DeserializePolicyOverride(item));
                            }
                            overrides = array;
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
            return new PolicyAssignmentData(id, name, type, systemData.Value, Optional.ToNullable(location), identity, displayName.Value, policyDefinitionId.Value, scope.Value, Optional.ToList(notScopes), Optional.ToDictionary(parameters), description.Value, metadata.Value, Optional.ToNullable(enforcementMode), Optional.ToList(nonComplianceMessages), Optional.ToList(resourceSelectors), Optional.ToList(overrides), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.Value.ToString()}'");
            }

            if (Optional.IsDefined(ManagedIdentity))
            {
                builder.Append("  identity:");
                AppendChildObject(builder, ManagedIdentity, options, 2, false);
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
            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("    displayName:");
                builder.AppendLine($" '{DisplayName}'");
            }

            if (Optional.IsDefined(PolicyDefinitionId))
            {
                builder.Append("    policyDefinitionId:");
                builder.AppendLine($" '{PolicyDefinitionId}'");
            }

            if (Optional.IsDefined(Scope))
            {
                builder.Append("    scope:");
                builder.AppendLine($" '{Scope}'");
            }

            if (Optional.IsCollectionDefined(ExcludedScopes))
            {
                if (ExcludedScopes.Any())
                {
                    builder.Append("    notScopes:");
                    builder.AppendLine(" [");
                    foreach (var item in ExcludedScopes)
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

            if (Optional.IsCollectionDefined(Parameters))
            {
                if (Parameters.Any())
                {
                    builder.Append("    parameters:");
                    builder.AppendLine(" {");
                    foreach (var item in Parameters)
                    {
                        builder.Append($"        {item.Key}: ");
                        AppendChildObject(builder, item.Value, options, 6, false);
                    }
                    builder.AppendLine("    }");
                }
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("    description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(Metadata))
            {
                builder.Append("    metadata:");
                builder.AppendLine($" '{Metadata.ToString()}'");
            }

            if (Optional.IsDefined(EnforcementMode))
            {
                builder.Append("    enforcementMode:");
                builder.AppendLine($" '{EnforcementMode.ToString()}'");
            }

            if (Optional.IsCollectionDefined(NonComplianceMessages))
            {
                if (NonComplianceMessages.Any())
                {
                    builder.Append("    nonComplianceMessages:");
                    builder.AppendLine(" [");
                    foreach (var item in NonComplianceMessages)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(ResourceSelectors))
            {
                if (ResourceSelectors.Any())
                {
                    builder.Append("    resourceSelectors:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceSelectors)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Overrides))
            {
                if (Overrides.Any())
                {
                    builder.Append("    overrides:");
                    builder.AppendLine(" [");
                    foreach (var item in Overrides)
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

        BinaryData IPersistableModel<PolicyAssignmentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentData)} does not support '{options.Format}' format.");
            }
        }

        PolicyAssignmentData IPersistableModel<PolicyAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyAssignmentData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
