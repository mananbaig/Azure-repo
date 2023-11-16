// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalContactEndpoint : IUtf8JsonSerializable, IJsonModel<OrbitalContactEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalContactEndpoint>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<OrbitalContactEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<OrbitalContactEndpoint>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<OrbitalContactEndpoint>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ipAddress"u8);
            writer.WriteStringValue(IPAddress.ToString());
            writer.WritePropertyName("endPointName"u8);
            writer.WriteStringValue(EndPointName);
            writer.WritePropertyName("port"u8);
            writer.WriteStringValue(Port);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
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

        OrbitalContactEndpoint IJsonModel<OrbitalContactEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalContactEndpoint(document.RootElement, options);
        }

        internal static OrbitalContactEndpoint DeserializeOrbitalContactEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress ipAddress = default;
            string endPointName = default;
            string port = default;
            OrbitalContactProtocol protocol = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endPointName"u8))
                {
                    endPointName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new OrbitalContactProtocol(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OrbitalContactEndpoint(ipAddress, endPointName, port, protocol, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrbitalContactEndpoint>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OrbitalContactEndpoint IPersistableModel<OrbitalContactEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OrbitalContactEndpoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOrbitalContactEndpoint(document.RootElement, options);
        }

        string IPersistableModel<OrbitalContactEndpoint>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
