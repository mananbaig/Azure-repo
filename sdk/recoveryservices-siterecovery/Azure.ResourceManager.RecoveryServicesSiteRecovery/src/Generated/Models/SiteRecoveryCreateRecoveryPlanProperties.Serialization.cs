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
    public partial class SiteRecoveryCreateRecoveryPlanProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryCreateRecoveryPlanProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryCreateRecoveryPlanProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SiteRecoveryCreateRecoveryPlanProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("primaryFabricId"u8);
            writer.WriteStringValue(PrimaryFabricId);
            writer.WritePropertyName("recoveryFabricId"u8);
            writer.WriteStringValue(RecoveryFabricId);
            if (Optional.IsDefined(FailoverDeploymentModel))
            {
                writer.WritePropertyName("failoverDeploymentModel"u8);
                writer.WriteStringValue(FailoverDeploymentModel.Value.ToString());
            }
            writer.WritePropertyName("groups"u8);
            writer.WriteStartArray();
            foreach (var item in Groups)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ProviderSpecificContent))
            {
                writer.WritePropertyName("providerSpecificInput"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificContent)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SiteRecoveryCreateRecoveryPlanProperties IJsonModel<SiteRecoveryCreateRecoveryPlanProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryCreateRecoveryPlanProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryCreateRecoveryPlanProperties(document.RootElement, options);
        }

        internal static SiteRecoveryCreateRecoveryPlanProperties DeserializeSiteRecoveryCreateRecoveryPlanProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier primaryFabricId = default;
            ResourceIdentifier recoveryFabricId = default;
            Optional<FailoverDeploymentModel> failoverDeploymentModel = default;
            IList<SiteRecoveryPlanGroup> groups = default;
            Optional<IList<RecoveryPlanProviderSpecificContent>> providerSpecificContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryFabricId"u8))
                {
                    primaryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricId"u8))
                {
                    recoveryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverDeploymentModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverDeploymentModel = new FailoverDeploymentModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    List<SiteRecoveryPlanGroup> array = new List<SiteRecoveryPlanGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryPlanGroup.DeserializeSiteRecoveryPlanGroup(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("providerSpecificInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificContent> array = new List<RecoveryPlanProviderSpecificContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificContent.DeserializeRecoveryPlanProviderSpecificContent(item));
                    }
                    providerSpecificContent = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryCreateRecoveryPlanProperties(primaryFabricId, recoveryFabricId, Optional.ToNullable(failoverDeploymentModel), groups, Optional.ToList(providerSpecificContent), serializedAdditionalRawData);
        }

        BinaryData IModel<SiteRecoveryCreateRecoveryPlanProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryCreateRecoveryPlanProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SiteRecoveryCreateRecoveryPlanProperties IModel<SiteRecoveryCreateRecoveryPlanProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryCreateRecoveryPlanProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryCreateRecoveryPlanProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SiteRecoveryCreateRecoveryPlanProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
