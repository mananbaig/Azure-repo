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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class McasDataConnectorDataTypes : IUtf8JsonSerializable, IJsonModel<McasDataConnectorDataTypes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<McasDataConnectorDataTypes>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<McasDataConnectorDataTypes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiscoveryLogs))
            {
                writer.WritePropertyName("discoveryLogs"u8);
                writer.WriteObjectValue(DiscoveryLogs);
            }
            if (Optional.IsDefined(Alerts))
            {
                writer.WritePropertyName("alerts"u8);
                writer.WriteObjectValue(Alerts);
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

        McasDataConnectorDataTypes IJsonModel<McasDataConnectorDataTypes>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMcasDataConnectorDataTypes(document.RootElement, options);
        }

        internal static McasDataConnectorDataTypes DeserializeMcasDataConnectorDataTypes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataConnectorDataTypeCommon> discoveryLogs = default;
            Optional<DataConnectorDataTypeCommon> alerts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("discoveryLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discoveryLogs = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value);
                    continue;
                }
                if (property.NameEquals("alerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alerts = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new McasDataConnectorDataTypes(alerts.Value, serializedAdditionalRawData, discoveryLogs.Value);
        }

        BinaryData IModel<McasDataConnectorDataTypes>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        McasDataConnectorDataTypes IModel<McasDataConnectorDataTypes>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMcasDataConnectorDataTypes(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<McasDataConnectorDataTypes>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
