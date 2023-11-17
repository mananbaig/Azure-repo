// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightApplicationHttpsEndpoint : IUtf8JsonSerializable, IJsonModel<HDInsightApplicationHttpsEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightApplicationHttpsEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightApplicationHttpsEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HDInsightApplicationHttpsEndpoint>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HDInsightApplicationHttpsEndpoint>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AccessModes))
            {
                writer.WritePropertyName("accessModes"u8);
                writer.WriteStartArray();
                foreach (var item in AccessModes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(EndpointLocation))
                {
                    writer.WritePropertyName("location"u8);
                    writer.WriteStringValue(EndpointLocation);
                }
            }
            if (Optional.IsDefined(DestinationPort))
            {
                writer.WritePropertyName("destinationPort"u8);
                writer.WriteNumberValue(DestinationPort.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PublicPort))
                {
                    writer.WritePropertyName("publicPort"u8);
                    writer.WriteNumberValue(PublicPort.Value);
                }
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (Optional.IsDefined(SubDomainSuffix))
            {
                writer.WritePropertyName("subDomainSuffix"u8);
                writer.WriteStringValue(SubDomainSuffix);
            }
            if (Optional.IsDefined(DisableGatewayAuth))
            {
                writer.WritePropertyName("disableGatewayAuth"u8);
                writer.WriteBooleanValue(DisableGatewayAuth.Value);
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

        HDInsightApplicationHttpsEndpoint IJsonModel<HDInsightApplicationHttpsEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightApplicationHttpsEndpoint(document.RootElement, options);
        }

        internal static HDInsightApplicationHttpsEndpoint DeserializeHDInsightApplicationHttpsEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> accessModes = default;
            Optional<string> location = default;
            Optional<int> destinationPort = default;
            Optional<int> publicPort = default;
            Optional<IPAddress> privateIPAddress = default;
            Optional<string> subDomainSuffix = default;
            Optional<bool> disableGatewayAuth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessModes"u8))
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
                    accessModes = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("publicPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("privateIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subDomainSuffix"u8))
                {
                    subDomainSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableGatewayAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableGatewayAuth = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightApplicationHttpsEndpoint(Optional.ToList(accessModes), location.Value, Optional.ToNullable(destinationPort), Optional.ToNullable(publicPort), privateIPAddress.Value, subDomainSuffix.Value, Optional.ToNullable(disableGatewayAuth), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightApplicationHttpsEndpoint>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HDInsightApplicationHttpsEndpoint IPersistableModel<HDInsightApplicationHttpsEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHDInsightApplicationHttpsEndpoint(document.RootElement, options);
        }

        string IPersistableModel<HDInsightApplicationHttpsEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
