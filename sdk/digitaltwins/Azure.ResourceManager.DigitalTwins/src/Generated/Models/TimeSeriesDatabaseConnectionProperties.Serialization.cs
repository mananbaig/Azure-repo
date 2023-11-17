// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    [PersistableModelProxy(typeof(UnknownTimeSeriesDatabaseConnectionProperties))]
    public partial class TimeSeriesDatabaseConnectionProperties : IUtf8JsonSerializable, IJsonModel<TimeSeriesDatabaseConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TimeSeriesDatabaseConnectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TimeSeriesDatabaseConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TimeSeriesDatabaseConnectionProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TimeSeriesDatabaseConnectionProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("connectionType"u8);
            writer.WriteStringValue(ConnectionType.ToString());
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
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

        TimeSeriesDatabaseConnectionProperties IJsonModel<TimeSeriesDatabaseConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TimeSeriesDatabaseConnectionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesDatabaseConnectionProperties(document.RootElement, options);
        }

        internal static TimeSeriesDatabaseConnectionProperties DeserializeTimeSeriesDatabaseConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("connectionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureDataExplorer": return DataExplorerConnectionProperties.DeserializeDataExplorerConnectionProperties(element);
                }
            }
            return UnknownTimeSeriesDatabaseConnectionProperties.DeserializeUnknownTimeSeriesDatabaseConnectionProperties(element);
        }

        BinaryData IPersistableModel<TimeSeriesDatabaseConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TimeSeriesDatabaseConnectionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TimeSeriesDatabaseConnectionProperties IPersistableModel<TimeSeriesDatabaseConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TimeSeriesDatabaseConnectionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTimeSeriesDatabaseConnectionProperties(document.RootElement, options);
        }

        string IPersistableModel<TimeSeriesDatabaseConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
