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
    internal partial class AzureFirewallRCAction : IUtf8JsonSerializable, IJsonModel<AzureFirewallRCAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureFirewallRCAction>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureFirewallRCAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureFirewallRCAction>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureFirewallRCAction>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ActionType.Value.ToString());
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

        AzureFirewallRCAction IJsonModel<AzureFirewallRCAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureFirewallRCAction)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFirewallRCAction(document.RootElement, options);
        }

        internal static AzureFirewallRCAction DeserializeAzureFirewallRCAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureFirewallRCActionType> type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AzureFirewallRCActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureFirewallRCAction(Optional.ToNullable(type), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureFirewallRCAction>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureFirewallRCAction)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureFirewallRCAction IPersistableModel<AzureFirewallRCAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureFirewallRCAction)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureFirewallRCAction(document.RootElement, options);
        }

        string IPersistableModel<AzureFirewallRCAction>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
