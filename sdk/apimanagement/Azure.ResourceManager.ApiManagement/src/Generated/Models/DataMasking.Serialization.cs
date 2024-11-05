// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class DataMasking : IUtf8JsonSerializable, IJsonModel<DataMasking>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMasking>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataMasking>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMasking>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMasking)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(QueryParams))
            {
                writer.WritePropertyName("queryParams"u8);
                writer.WriteStartArray();
                foreach (var item in QueryParams)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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
        }

        DataMasking IJsonModel<DataMasking>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMasking>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMasking)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMasking(document.RootElement, options);
        }

        internal static DataMasking DeserializeDataMasking(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataMaskingEntity> queryParams = default;
            IList<DataMaskingEntity> headers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryParams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataMaskingEntity> array = new List<DataMaskingEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataMaskingEntity.DeserializeDataMaskingEntity(item, options));
                    }
                    queryParams = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataMaskingEntity> array = new List<DataMaskingEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataMaskingEntity.DeserializeDataMaskingEntity(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataMasking(queryParams ?? new ChangeTrackingList<DataMaskingEntity>(), headers ?? new ChangeTrackingList<DataMaskingEntity>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryParams), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryParams: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(QueryParams))
                {
                    if (QueryParams.Any())
                    {
                        builder.Append("  queryParams: ");
                        builder.AppendLine("[");
                        foreach (var item in QueryParams)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  queryParams: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Headers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  headers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Headers))
                {
                    if (Headers.Any())
                    {
                        builder.Append("  headers: ");
                        builder.AppendLine("[");
                        foreach (var item in Headers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  headers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DataMasking>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMasking>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataMasking)} does not support writing '{options.Format}' format.");
            }
        }

        DataMasking IPersistableModel<DataMasking>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMasking>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataMasking(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMasking)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMasking>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
