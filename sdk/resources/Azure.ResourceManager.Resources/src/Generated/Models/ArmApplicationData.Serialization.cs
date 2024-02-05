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
    public partial class ArmApplicationData : IUtf8JsonSerializable, IJsonModel<ArmApplicationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmApplicationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmApplicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                JsonSerializer.Serialize(writer, Plan);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(ManagedResourceGroupId))
            {
                writer.WritePropertyName("managedResourceGroupId"u8);
                writer.WriteStringValue(ManagedResourceGroupId);
            }
            if (Optional.IsDefined(ApplicationDefinitionId))
            {
                writer.WritePropertyName("applicationDefinitionId"u8);
                writer.WriteStringValue(ApplicationDefinitionId);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Outputs);
#else
                using (JsonDocument document = JsonDocument.Parse(Outputs))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BillingDetails))
            {
                writer.WritePropertyName("billingDetails"u8);
                writer.WriteObjectValue(BillingDetails);
            }
            if (Optional.IsDefined(JitAccessPolicy))
            {
                writer.WritePropertyName("jitAccessPolicy"u8);
                writer.WriteObjectValue(JitAccessPolicy);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherTenantId))
            {
                writer.WritePropertyName("publisherTenantId"u8);
                writer.WriteStringValue(PublisherTenantId.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations"u8);
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ManagementMode))
            {
                writer.WritePropertyName("managementMode"u8);
                writer.WriteStringValue(ManagementMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CustomerSupport))
            {
                writer.WritePropertyName("customerSupport"u8);
                writer.WriteObjectValue(CustomerSupport);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportUris))
            {
                writer.WritePropertyName("supportUrls"u8);
                writer.WriteObjectValue(SupportUris);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteObjectValue(CreatedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteObjectValue(UpdatedBy);
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

        ArmApplicationData IJsonModel<ArmApplicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationData(document.RootElement, options);
        }

        internal static ArmApplicationData DeserializeArmApplicationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmPlan> plan = default;
            string kind = default;
            Optional<ArmApplicationManagedIdentity> identity = default;
            Optional<string> managedBy = default;
            Optional<ArmApplicationSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> managedResourceGroupId = default;
            Optional<ResourceIdentifier> applicationDefinitionId = default;
            Optional<BinaryData> parameters = default;
            Optional<BinaryData> outputs = default;
            Optional<ResourcesProvisioningState> provisioningState = default;
            Optional<ArmApplicationBillingDetails> billingDetails = default;
            Optional<ArmApplicationJitAccessPolicy> jitAccessPolicy = default;
            Optional<Guid> publisherTenantId = default;
            Optional<IReadOnlyList<ArmApplicationAuthorization>> authorizations = default;
            Optional<ArmApplicationManagementMode> managementMode = default;
            Optional<ArmApplicationPackageContact> customerSupport = default;
            Optional<ArmApplicationPackageSupportUris> supportUris = default;
            Optional<IReadOnlyList<ArmApplicationArtifact>> artifacts = default;
            Optional<ArmApplicationDetails> createdBy = default;
            Optional<ArmApplicationDetails> updatedBy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = JsonSerializer.Deserialize<ArmPlan>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ArmApplicationManagedIdentity.DeserializeArmApplicationManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ArmApplicationSku.DeserializeArmApplicationSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("managedResourceGroupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parameters = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputs = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourcesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingDetails = ArmApplicationBillingDetails.DeserializeArmApplicationBillingDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("jitAccessPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jitAccessPolicy = ArmApplicationJitAccessPolicy.DeserializeArmApplicationJitAccessPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publisherTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publisherTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationAuthorization> array = new List<ArmApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationAuthorization.DeserializeArmApplicationAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("managementMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementMode = new ArmApplicationManagementMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerSupport"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerSupport = ArmApplicationPackageContact.DeserializeArmApplicationPackageContact(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportUris = ArmApplicationPackageSupportUris.DeserializeArmApplicationPackageSupportUris(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationArtifact> array = new List<ArmApplicationArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationArtifact.DeserializeArmApplicationArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = ArmApplicationDetails.DeserializeArmApplicationDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedBy = ArmApplicationDetails.DeserializeArmApplicationDetails(property0.Value);
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
            return new ArmApplicationData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, managedBy.Value, sku.Value, serializedAdditionalRawData, plan, kind, identity.Value, managedResourceGroupId.Value, applicationDefinitionId.Value, parameters.Value, outputs.Value, Optional.ToNullable(provisioningState), billingDetails.Value, jitAccessPolicy.Value, Optional.ToNullable(publisherTenantId), Optional.ToList(authorizations), Optional.ToNullable(managementMode), customerSupport.Value, supportUris.Value, Optional.ToList(artifacts), createdBy.Value, updatedBy.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Plan))
            {
                builder.Append("  plan:");
                AppendChildObject(builder, Plan, options, 2, false);
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsDefined(Identity))
            {
                builder.Append("  identity:");
                AppendChildObject(builder, Identity, options, 2, false);
            }

            if (Optional.IsDefined(ManagedBy))
            {
                builder.Append("  managedBy:");
                builder.AppendLine($" '{ManagedBy}'");
            }

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
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
            if (Optional.IsDefined(ManagedResourceGroupId))
            {
                builder.Append("    managedResourceGroupId:");
                builder.AppendLine($" '{ManagedResourceGroupId.ToString()}'");
            }

            if (Optional.IsDefined(ApplicationDefinitionId))
            {
                builder.Append("    applicationDefinitionId:");
                builder.AppendLine($" '{ApplicationDefinitionId.ToString()}'");
            }

            if (Optional.IsDefined(Parameters))
            {
                builder.Append("    parameters:");
                builder.AppendLine($" '{Parameters.ToString()}'");
            }

            if (Optional.IsDefined(Outputs))
            {
                builder.Append("    outputs:");
                builder.AppendLine($" '{Outputs.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(BillingDetails))
            {
                builder.Append("    billingDetails:");
                AppendChildObject(builder, BillingDetails, options, 4, false);
            }

            if (Optional.IsDefined(JitAccessPolicy))
            {
                builder.Append("    jitAccessPolicy:");
                AppendChildObject(builder, JitAccessPolicy, options, 4, false);
            }

            if (Optional.IsDefined(PublisherTenantId))
            {
                builder.Append("    publisherTenantId:");
                builder.AppendLine($" '{PublisherTenantId.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Authorizations))
            {
                if (Authorizations.Any())
                {
                    builder.Append("    authorizations:");
                    builder.AppendLine(" [");
                    foreach (var item in Authorizations)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(ManagementMode))
            {
                builder.Append("    managementMode:");
                builder.AppendLine($" '{ManagementMode.ToString()}'");
            }

            if (Optional.IsDefined(CustomerSupport))
            {
                builder.Append("    customerSupport:");
                AppendChildObject(builder, CustomerSupport, options, 4, false);
            }

            if (Optional.IsDefined(SupportUris))
            {
                builder.Append("    supportUrls:");
                AppendChildObject(builder, SupportUris, options, 4, false);
            }

            if (Optional.IsCollectionDefined(Artifacts))
            {
                if (Artifacts.Any())
                {
                    builder.Append("    artifacts:");
                    builder.AppendLine(" [");
                    foreach (var item in Artifacts)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(CreatedBy))
            {
                builder.Append("    createdBy:");
                AppendChildObject(builder, CreatedBy, options, 4, false);
            }

            if (Optional.IsDefined(UpdatedBy))
            {
                builder.Append("    updatedBy:");
                AppendChildObject(builder, UpdatedBy, options, 4, false);
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

        BinaryData IPersistableModel<ArmApplicationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationData)} does not support '{options.Format}' format.");
            }
        }

        ArmApplicationData IPersistableModel<ArmApplicationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmApplicationData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmApplicationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
