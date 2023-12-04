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

namespace Azure.Containers.ContainerRegistry
{
    public partial class OciDescriptor : IUtf8JsonSerializable, IJsonModel<OciDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OciDescriptor>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OciDescriptor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OciDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(OciDescriptor)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType"u8);
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsDefined(SizeInBytes))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(SizeInBytes.Value);
            }
            if (Optional.IsDefined(Digest))
            {
                writer.WritePropertyName("digest"u8);
                writer.WriteStringValue(Digest);
            }
            if (Optional.IsCollectionDefined(Urls))
            {
                writer.WritePropertyName("urls"u8);
                writer.WriteStartArray();
                foreach (var item in Urls)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations"u8);
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
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

        OciDescriptor IJsonModel<OciDescriptor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OciDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(OciDescriptor)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOciDescriptor(document.RootElement, options);
        }

        internal static OciDescriptor DeserializeOciDescriptor(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            Optional<long> size = default;
            Optional<string> digest = default;
            Optional<IList<Uri>> urls = default;
            Optional<OciAnnotations> annotations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    urls = array;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = OciAnnotations.DeserializeOciAnnotations(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OciDescriptor(mediaType.Value, Optional.ToNullable(size), digest.Value, Optional.ToList(urls), annotations.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OciDescriptor>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OciDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(OciDescriptor)} does not support '{options.Format}' format.");
            }
        }

        OciDescriptor IPersistableModel<OciDescriptor>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OciDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOciDescriptor(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(OciDescriptor)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OciDescriptor>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
