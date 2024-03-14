// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearningCompute;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class ContainerServiceCredentials : IUtf8JsonSerializable, IJsonModel<ContainerServiceCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AcsKubeConfig))
            {
                writer.WritePropertyName("acsKubeConfig"u8);
                writer.WriteStringValue(AcsKubeConfig);
            }
            if (options.Format != "W" && Optional.IsDefined(ServicePrincipalConfiguration))
            {
                writer.WritePropertyName("servicePrincipalConfiguration"u8);
                writer.WriteObjectValue(ServicePrincipalConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(ImagePullSecretName))
            {
                writer.WritePropertyName("imagePullSecretName"u8);
                writer.WriteStringValue(ImagePullSecretName);
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

        ContainerServiceCredentials IJsonModel<ContainerServiceCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceCredentials(document.RootElement, options);
        }

        internal static ContainerServiceCredentials DeserializeContainerServiceCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string acsKubeConfig = default;
            ServicePrincipalProperties servicePrincipalConfiguration = default;
            string imagePullSecretName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acsKubeConfig"u8))
                {
                    acsKubeConfig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalConfiguration = ServicePrincipalProperties.DeserializeServicePrincipalProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("imagePullSecretName"u8))
                {
                    imagePullSecretName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceCredentials(acsKubeConfig, servicePrincipalConfiguration, imagePullSecretName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceCredentials)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceCredentials IPersistableModel<ContainerServiceCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
