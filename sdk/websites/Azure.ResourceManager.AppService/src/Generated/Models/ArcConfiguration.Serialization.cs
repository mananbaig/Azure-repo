// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ArcConfiguration : IUtf8JsonSerializable, IJsonModel<ArcConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArcConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArcConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactsStorageType))
            {
                writer.WritePropertyName("artifactsStorageType"u8);
                writer.WriteStringValue(ArtifactsStorageType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ArtifactStorageClassName))
            {
                writer.WritePropertyName("artifactStorageClassName"u8);
                writer.WriteStringValue(ArtifactStorageClassName);
            }
            if (Optional.IsDefined(ArtifactStorageMountPath))
            {
                writer.WritePropertyName("artifactStorageMountPath"u8);
                writer.WriteStringValue(ArtifactStorageMountPath);
            }
            if (Optional.IsDefined(ArtifactStorageNodeName))
            {
                writer.WritePropertyName("artifactStorageNodeName"u8);
                writer.WriteStringValue(ArtifactStorageNodeName);
            }
            if (Optional.IsDefined(ArtifactStorageAccessMode))
            {
                writer.WritePropertyName("artifactStorageAccessMode"u8);
                writer.WriteStringValue(ArtifactStorageAccessMode);
            }
            if (Optional.IsDefined(FrontEndServiceConfiguration))
            {
                writer.WritePropertyName("frontEndServiceConfiguration"u8);
                writer.WriteObjectValue(FrontEndServiceConfiguration);
            }
            if (Optional.IsDefined(KubeConfig))
            {
                writer.WritePropertyName("kubeConfig"u8);
                writer.WriteStringValue(KubeConfig);
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

        ArcConfiguration IJsonModel<ArcConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArcConfiguration(document.RootElement, options);
        }

        internal static ArcConfiguration DeserializeArcConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArtifactStorageType? artifactsStorageType = default;
            string artifactStorageClassName = default;
            string artifactStorageMountPath = default;
            string artifactStorageNodeName = default;
            string artifactStorageAccessMode = default;
            FrontEndConfiguration frontEndServiceConfiguration = default;
            string kubeConfig = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactsStorageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactsStorageType = property.Value.GetString().ToArtifactStorageType();
                    continue;
                }
                if (property.NameEquals("artifactStorageClassName"u8))
                {
                    artifactStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageMountPath"u8))
                {
                    artifactStorageMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageNodeName"u8))
                {
                    artifactStorageNodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageAccessMode"u8))
                {
                    artifactStorageAccessMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontEndServiceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontEndServiceConfiguration = FrontEndConfiguration.DeserializeFrontEndConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kubeConfig"u8))
                {
                    kubeConfig = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArcConfiguration(
                artifactsStorageType,
                artifactStorageClassName,
                artifactStorageMountPath,
                artifactStorageNodeName,
                artifactStorageAccessMode,
                frontEndServiceConfiguration,
                kubeConfig,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArcConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArcConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ArcConfiguration IPersistableModel<ArcConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArcConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArcConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArcConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
