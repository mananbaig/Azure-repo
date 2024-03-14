// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class IntegrationServiceEnvironmentManagedApiDeploymentParameters : IUtf8JsonSerializable, IJsonModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiDeploymentParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContentLinkDefinition))
            {
                writer.WritePropertyName("contentLinkDefinition"u8);
                writer.WriteObjectValue(ContentLinkDefinition);
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

        IntegrationServiceEnvironmentManagedApiDeploymentParameters IJsonModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiDeploymentParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(document.RootElement, options);
        }

        internal static IntegrationServiceEnvironmentManagedApiDeploymentParameters DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LogicContentLink contentLinkDefinition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentLinkDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentLinkDefinition = LogicContentLink.DeserializeLogicContentLink(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationServiceEnvironmentManagedApiDeploymentParameters(contentLinkDefinition, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiDeploymentParameters)} does not support '{options.Format}' format.");
            }
        }

        IntegrationServiceEnvironmentManagedApiDeploymentParameters IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentManagedApiDeploymentParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
