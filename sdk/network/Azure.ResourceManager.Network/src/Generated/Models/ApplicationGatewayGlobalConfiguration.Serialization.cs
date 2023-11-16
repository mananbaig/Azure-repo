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
    public partial class ApplicationGatewayGlobalConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayGlobalConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayGlobalConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApplicationGatewayGlobalConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApplicationGatewayGlobalConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApplicationGatewayGlobalConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableRequestBuffering))
            {
                writer.WritePropertyName("enableRequestBuffering"u8);
                writer.WriteBooleanValue(EnableRequestBuffering.Value);
            }
            if (Optional.IsDefined(EnableResponseBuffering))
            {
                writer.WritePropertyName("enableResponseBuffering"u8);
                writer.WriteBooleanValue(EnableResponseBuffering.Value);
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

        ApplicationGatewayGlobalConfiguration IJsonModel<ApplicationGatewayGlobalConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayGlobalConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayGlobalConfiguration(document.RootElement, options);
        }

        internal static ApplicationGatewayGlobalConfiguration DeserializeApplicationGatewayGlobalConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enableRequestBuffering = default;
            Optional<bool> enableResponseBuffering = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableRequestBuffering"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableRequestBuffering = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableResponseBuffering"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableResponseBuffering = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayGlobalConfiguration(Optional.ToNullable(enableRequestBuffering), Optional.ToNullable(enableResponseBuffering), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayGlobalConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayGlobalConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplicationGatewayGlobalConfiguration IPersistableModel<ApplicationGatewayGlobalConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayGlobalConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayGlobalConfiguration(document.RootElement, options);
        }

        string IPersistableModel<ApplicationGatewayGlobalConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
