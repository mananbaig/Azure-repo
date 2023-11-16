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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorPrivateLinkAccessModeSettingsExclusion : IUtf8JsonSerializable, IJsonModel<MonitorPrivateLinkAccessModeSettingsExclusion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorPrivateLinkAccessModeSettingsExclusion>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MonitorPrivateLinkAccessModeSettingsExclusion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MonitorPrivateLinkAccessModeSettingsExclusion>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MonitorPrivateLinkAccessModeSettingsExclusion>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpointConnectionName))
            {
                writer.WritePropertyName("privateEndpointConnectionName"u8);
                writer.WriteStringValue(PrivateEndpointConnectionName);
            }
            if (Optional.IsDefined(QueryAccessMode))
            {
                writer.WritePropertyName("queryAccessMode"u8);
                writer.WriteStringValue(QueryAccessMode.Value.ToString());
            }
            if (Optional.IsDefined(IngestionAccessMode))
            {
                writer.WritePropertyName("ingestionAccessMode"u8);
                writer.WriteStringValue(IngestionAccessMode.Value.ToString());
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

        MonitorPrivateLinkAccessModeSettingsExclusion IJsonModel<MonitorPrivateLinkAccessModeSettingsExclusion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettingsExclusion)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorPrivateLinkAccessModeSettingsExclusion(document.RootElement, options);
        }

        internal static MonitorPrivateLinkAccessModeSettingsExclusion DeserializeMonitorPrivateLinkAccessModeSettingsExclusion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> privateEndpointConnectionName = default;
            Optional<MonitorPrivateLinkAccessMode> queryAccessMode = default;
            Optional<MonitorPrivateLinkAccessMode> ingestionAccessMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpointConnectionName"u8))
                {
                    privateEndpointConnectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryAccessMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryAccessMode = new MonitorPrivateLinkAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingestionAccessMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionAccessMode = new MonitorPrivateLinkAccessMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorPrivateLinkAccessModeSettingsExclusion(privateEndpointConnectionName.Value, Optional.ToNullable(queryAccessMode), Optional.ToNullable(ingestionAccessMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorPrivateLinkAccessModeSettingsExclusion>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettingsExclusion)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MonitorPrivateLinkAccessModeSettingsExclusion IPersistableModel<MonitorPrivateLinkAccessModeSettingsExclusion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkAccessModeSettingsExclusion)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMonitorPrivateLinkAccessModeSettingsExclusion(document.RootElement, options);
        }

        string IPersistableModel<MonitorPrivateLinkAccessModeSettingsExclusion>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
