// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    [PersistableModelProxy(typeof(UnknownTaskStepProperties))]
    public partial class ContainerRegistryTaskStepProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTaskStepProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTaskStepProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryTaskStepProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerRegistryTaskStepType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(BaseImageDependencies))
            {
                writer.WritePropertyName("baseImageDependencies"u8);
                writer.WriteStartArray();
                foreach (var item in BaseImageDependencies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        ContainerRegistryTaskStepProperties IJsonModel<ContainerRegistryTaskStepProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTaskStepProperties(document.RootElement, options);
        }

        internal static ContainerRegistryTaskStepProperties DeserializeContainerRegistryTaskStepProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Docker": return ContainerRegistryDockerBuildStep.DeserializeContainerRegistryDockerBuildStep(element);
                    case "EncodedTask": return ContainerRegistryEncodedTaskStep.DeserializeContainerRegistryEncodedTaskStep(element);
                    case "FileTask": return ContainerRegistryFileTaskStep.DeserializeContainerRegistryFileTaskStep(element);
                }
            }
            return UnknownTaskStepProperties.DeserializeUnknownTaskStepProperties(element);
        }

        BinaryData IPersistableModel<ContainerRegistryTaskStepProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryTaskStepProperties IPersistableModel<ContainerRegistryTaskStepProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryTaskStepProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryTaskStepProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
