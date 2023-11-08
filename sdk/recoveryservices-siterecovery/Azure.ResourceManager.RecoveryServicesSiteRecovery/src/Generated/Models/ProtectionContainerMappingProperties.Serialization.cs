// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ProtectionContainerMappingProperties : IUtf8JsonSerializable, IJsonModel<ProtectionContainerMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectionContainerMappingProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ProtectionContainerMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetProtectionContainerId))
            {
                writer.WritePropertyName("targetProtectionContainerId"u8);
                writer.WriteStringValue(TargetProtectionContainerId);
            }
            if (Optional.IsDefined(TargetProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("targetProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(TargetProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            if (Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health);
            }
            if (Optional.IsCollectionDefined(HealthErrorDetails))
            {
                writer.WritePropertyName("healthErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrorDetails)
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
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(SourceProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("sourceProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(SourceProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(SourceFabricFriendlyName))
            {
                writer.WritePropertyName("sourceFabricFriendlyName"u8);
                writer.WriteStringValue(SourceFabricFriendlyName);
            }
            if (Optional.IsDefined(TargetFabricFriendlyName))
            {
                writer.WritePropertyName("targetFabricFriendlyName"u8);
                writer.WriteStringValue(TargetFabricFriendlyName);
            }
            if (Optional.IsDefined(PolicyFriendlyName))
            {
                writer.WritePropertyName("policyFriendlyName"u8);
                writer.WriteStringValue(PolicyFriendlyName);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ProtectionContainerMappingProperties IJsonModel<ProtectionContainerMappingProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectionContainerMappingProperties(document.RootElement, options);
        }

        internal static ProtectionContainerMappingProperties DeserializeProtectionContainerMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> targetProtectionContainerId = default;
            Optional<string> targetProtectionContainerFriendlyName = default;
            Optional<ProtectionContainerMappingProviderSpecificDetails> providerSpecificDetails = default;
            Optional<string> health = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrorDetails = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<string> state = default;
            Optional<string> sourceProtectionContainerFriendlyName = default;
            Optional<string> sourceFabricFriendlyName = default;
            Optional<string> targetFabricFriendlyName = default;
            Optional<string> policyFriendlyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetProtectionContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProtectionContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetProtectionContainerFriendlyName"u8))
                {
                    targetProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = ProtectionContainerMappingProviderSpecificDetails.DeserializeProtectionContainerMappingProviderSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    health = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrorDetails"u8))
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
                    healthErrorDetails = array;
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
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceProtectionContainerFriendlyName"u8))
                {
                    sourceProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFabricFriendlyName"u8))
                {
                    sourceFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFabricFriendlyName"u8))
                {
                    targetFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyFriendlyName"u8))
                {
                    policyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProtectionContainerMappingProperties(targetProtectionContainerId.Value, targetProtectionContainerFriendlyName.Value, providerSpecificDetails.Value, health.Value, Optional.ToList(healthErrorDetails), policyId.Value, state.Value, sourceProtectionContainerFriendlyName.Value, sourceFabricFriendlyName.Value, targetFabricFriendlyName.Value, policyFriendlyName.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ProtectionContainerMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProtectionContainerMappingProperties IModel<ProtectionContainerMappingProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProtectionContainerMappingProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ProtectionContainerMappingProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
