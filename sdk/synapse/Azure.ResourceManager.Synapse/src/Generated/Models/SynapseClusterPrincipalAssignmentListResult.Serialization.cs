// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseClusterPrincipalAssignmentListResult : IUtf8JsonSerializable, IJsonModel<SynapseClusterPrincipalAssignmentListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseClusterPrincipalAssignmentListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseClusterPrincipalAssignmentListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseClusterPrincipalAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseClusterPrincipalAssignmentListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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
            writer.WriteEndObject();
        }

        SynapseClusterPrincipalAssignmentListResult IJsonModel<SynapseClusterPrincipalAssignmentListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseClusterPrincipalAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseClusterPrincipalAssignmentListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseClusterPrincipalAssignmentListResult(document.RootElement, options);
        }

        internal static SynapseClusterPrincipalAssignmentListResult DeserializeSynapseClusterPrincipalAssignmentListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseClusterPrincipalAssignmentData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseClusterPrincipalAssignmentData> array = new List<SynapseClusterPrincipalAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseClusterPrincipalAssignmentData.DeserializeSynapseClusterPrincipalAssignmentData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseClusterPrincipalAssignmentListResult(value ?? new ChangeTrackingList<SynapseClusterPrincipalAssignmentData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseClusterPrincipalAssignmentListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseClusterPrincipalAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseClusterPrincipalAssignmentListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseClusterPrincipalAssignmentListResult IPersistableModel<SynapseClusterPrincipalAssignmentListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseClusterPrincipalAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseClusterPrincipalAssignmentListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseClusterPrincipalAssignmentListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseClusterPrincipalAssignmentListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
