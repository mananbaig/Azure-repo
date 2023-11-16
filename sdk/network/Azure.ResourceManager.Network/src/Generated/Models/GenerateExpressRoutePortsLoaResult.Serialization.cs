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

namespace Azure.ResourceManager.Network.Models
{
    public partial class GenerateExpressRoutePortsLoaResult : IUtf8JsonSerializable, IJsonModel<GenerateExpressRoutePortsLoaResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GenerateExpressRoutePortsLoaResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<GenerateExpressRoutePortsLoaResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<GenerateExpressRoutePortsLoaResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<GenerateExpressRoutePortsLoaResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncodedContent))
            {
                writer.WritePropertyName("encodedContent"u8);
                writer.WriteStringValue(EncodedContent);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        GenerateExpressRoutePortsLoaResult IJsonModel<GenerateExpressRoutePortsLoaResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGenerateExpressRoutePortsLoaResult(document.RootElement, options);
        }

        internal static GenerateExpressRoutePortsLoaResult DeserializeGenerateExpressRoutePortsLoaResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> encodedContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedContent"u8))
                {
                    encodedContent = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GenerateExpressRoutePortsLoaResult(encodedContent.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GenerateExpressRoutePortsLoaResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        GenerateExpressRoutePortsLoaResult IPersistableModel<GenerateExpressRoutePortsLoaResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeGenerateExpressRoutePortsLoaResult(document.RootElement, options);
        }

        string IPersistableModel<GenerateExpressRoutePortsLoaResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
