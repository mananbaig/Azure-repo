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
    public partial class MobileNetworkLocalDiagnosticsAccessConfiguration : IUtf8JsonSerializable, IJsonModel<MobileNetworkLocalDiagnosticsAccessConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkLocalDiagnosticsAccessConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MobileNetworkLocalDiagnosticsAccessConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MobileNetworkLocalDiagnosticsAccessConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MobileNetworkLocalDiagnosticsAccessConfiguration>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(HttpsServerCertificate))
            {
                writer.WritePropertyName("httpsServerCertificate"u8);
                writer.WriteObjectValue(HttpsServerCertificate);
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

        MobileNetworkLocalDiagnosticsAccessConfiguration IJsonModel<MobileNetworkLocalDiagnosticsAccessConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkLocalDiagnosticsAccessConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkLocalDiagnosticsAccessConfiguration(document.RootElement, options);
        }

        internal static MobileNetworkLocalDiagnosticsAccessConfiguration DeserializeMobileNetworkLocalDiagnosticsAccessConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MobileNetworkAuthenticationType authenticationType = default;
            Optional<MobileNetworkHttpsServerCertificate> httpsServerCertificate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new MobileNetworkAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpsServerCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsServerCertificate = MobileNetworkHttpsServerCertificate.DeserializeMobileNetworkHttpsServerCertificate(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkLocalDiagnosticsAccessConfiguration(authenticationType, httpsServerCertificate.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkLocalDiagnosticsAccessConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkLocalDiagnosticsAccessConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MobileNetworkLocalDiagnosticsAccessConfiguration IPersistableModel<MobileNetworkLocalDiagnosticsAccessConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkLocalDiagnosticsAccessConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMobileNetworkLocalDiagnosticsAccessConfiguration(document.RootElement, options);
        }

        string IPersistableModel<MobileNetworkLocalDiagnosticsAccessConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
