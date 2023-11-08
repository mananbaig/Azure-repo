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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class HnswParameters : IUtf8JsonSerializable, IJsonModel<HnswParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HnswParameters>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<HnswParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(M))
            {
                if (M != null)
                {
                    writer.WritePropertyName("m"u8);
                    writer.WriteNumberValue(M.Value);
                }
                else
                {
                    writer.WriteNull("m");
                }
            }
            if (Optional.IsDefined(EfConstruction))
            {
                if (EfConstruction != null)
                {
                    writer.WritePropertyName("efConstruction"u8);
                    writer.WriteNumberValue(EfConstruction.Value);
                }
                else
                {
                    writer.WriteNull("efConstruction");
                }
            }
            if (Optional.IsDefined(EfSearch))
            {
                if (EfSearch != null)
                {
                    writer.WritePropertyName("efSearch"u8);
                    writer.WriteNumberValue(EfSearch.Value);
                }
                else
                {
                    writer.WriteNull("efSearch");
                }
            }
            if (Optional.IsDefined(Metric))
            {
                if (Metric != null)
                {
                    writer.WritePropertyName("metric"u8);
                    writer.WriteStringValue(Metric.Value.ToString());
                }
                else
                {
                    writer.WriteNull("metric");
                }
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

        HnswParameters IJsonModel<HnswParameters>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HnswParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHnswParameters(document.RootElement, options);
        }

        internal static HnswParameters DeserializeHnswParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int?> m = default;
            Optional<int?> efConstruction = default;
            Optional<int?> efSearch = default;
            Optional<VectorSearchAlgorithmMetric?> metric = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("m"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        m = null;
                        continue;
                    }
                    m = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("efConstruction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        efConstruction = null;
                        continue;
                    }
                    efConstruction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("efSearch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        efSearch = null;
                        continue;
                    }
                    efSearch = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metric = null;
                        continue;
                    }
                    metric = new VectorSearchAlgorithmMetric(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HnswParameters(Optional.ToNullable(m), Optional.ToNullable(efConstruction), Optional.ToNullable(efSearch), Optional.ToNullable(metric), serializedAdditionalRawData);
        }

        BinaryData IModel<HnswParameters>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HnswParameters)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HnswParameters IModel<HnswParameters>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HnswParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHnswParameters(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<HnswParameters>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
