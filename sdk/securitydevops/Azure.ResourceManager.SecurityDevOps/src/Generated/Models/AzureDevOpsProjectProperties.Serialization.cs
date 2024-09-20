// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class AzureDevOpsProjectProperties : IUtf8JsonSerializable, IJsonModel<AzureDevOpsProjectProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDevOpsProjectProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureDevOpsProjectProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDevOpsProjectProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteStringValue(ProjectId);
            }
            if (Optional.IsDefined(OrgName))
            {
                writer.WritePropertyName("orgName"u8);
                writer.WriteStringValue(OrgName);
            }
            if (Optional.IsDefined(AutoDiscovery))
            {
                writer.WritePropertyName("autoDiscovery"u8);
                writer.WriteStringValue(AutoDiscovery.Value.ToString());
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

        AzureDevOpsProjectProperties IJsonModel<AzureDevOpsProjectProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDevOpsProjectProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDevOpsProjectProperties(document.RootElement, options);
        }

        internal static AzureDevOpsProjectProperties DeserializeAzureDevOpsProjectProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            string projectId = default;
            string orgName = default;
            AutoDiscovery? autoDiscovery = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    projectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orgName"u8))
                {
                    orgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoDiscovery = new AutoDiscovery(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureDevOpsProjectProperties(provisioningState, projectId, orgName, autoDiscovery, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureDevOpsProjectProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureDevOpsProjectProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AzureDevOpsProjectProperties IPersistableModel<AzureDevOpsProjectProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDevOpsProjectProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDevOpsProjectProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDevOpsProjectProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDevOpsProjectProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
