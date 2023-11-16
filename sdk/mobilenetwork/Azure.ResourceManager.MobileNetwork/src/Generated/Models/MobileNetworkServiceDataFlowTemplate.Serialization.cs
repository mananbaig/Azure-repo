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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkServiceDataFlowTemplate : IUtf8JsonSerializable, IJsonModel<MobileNetworkServiceDataFlowTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkServiceDataFlowTemplate>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MobileNetworkServiceDataFlowTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MobileNetworkServiceDataFlowTemplate>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MobileNetworkServiceDataFlowTemplate>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("templateName"u8);
            writer.WriteStringValue(TemplateName);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol"u8);
            writer.WriteStartArray();
            foreach (var item in Protocol)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("remoteIpList"u8);
            writer.WriteStartArray();
            foreach (var item in RemoteIPList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        MobileNetworkServiceDataFlowTemplate IJsonModel<MobileNetworkServiceDataFlowTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkServiceDataFlowTemplate(document.RootElement, options);
        }

        internal static MobileNetworkServiceDataFlowTemplate DeserializeMobileNetworkServiceDataFlowTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string templateName = default;
            MobileNetworkSdfDirectionS direction = default;
            IList<string> protocol = default;
            IList<string> remoteIPList = default;
            Optional<IList<string>> ports = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateName"u8))
                {
                    templateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new MobileNetworkSdfDirectionS(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protocol = array;
                    continue;
                }
                if (property.NameEquals("remoteIpList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    remoteIPList = array;
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkServiceDataFlowTemplate(templateName, direction, protocol, remoteIPList, Optional.ToList(ports), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkServiceDataFlowTemplate>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MobileNetworkServiceDataFlowTemplate IPersistableModel<MobileNetworkServiceDataFlowTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkServiceDataFlowTemplate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMobileNetworkServiceDataFlowTemplate(document.RootElement, options);
        }

        string IPersistableModel<MobileNetworkServiceDataFlowTemplate>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
