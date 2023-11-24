// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanVolumeDataSourceInfo : IUtf8JsonSerializable, IJsonModel<ElasticSanVolumeDataSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticSanVolumeDataSourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticSanVolumeDataSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeDataSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ElasticSanVolumeDataSourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CreateSource))
            {
                writer.WritePropertyName("createSource"u8);
                writer.WriteStringValue(CreateSource.Value.ToString());
            }
            if (Optional.IsDefined(SourceId))
            {
                writer.WritePropertyName("sourceId"u8);
                writer.WriteStringValue(SourceId);
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

        ElasticSanVolumeDataSourceInfo IJsonModel<ElasticSanVolumeDataSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeDataSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ElasticSanVolumeDataSourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticSanVolumeDataSourceInfo(document.RootElement, options);
        }

        internal static ElasticSanVolumeDataSourceInfo DeserializeElasticSanVolumeDataSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ElasticSanVolumeCreateOption> createSource = default;
            Optional<ResourceIdentifier> sourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createSource = new ElasticSanVolumeCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ElasticSanVolumeDataSourceInfo(Optional.ToNullable(createSource), sourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticSanVolumeDataSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeDataSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ElasticSanVolumeDataSourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ElasticSanVolumeDataSourceInfo IPersistableModel<ElasticSanVolumeDataSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeDataSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticSanVolumeDataSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ElasticSanVolumeDataSourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticSanVolumeDataSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
