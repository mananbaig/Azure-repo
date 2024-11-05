// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class IotHubDeviceConnectedEventData : IUtf8JsonSerializable, IJsonModel<IotHubDeviceConnectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubDeviceConnectedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubDeviceConnectedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubDeviceConnectedEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        IotHubDeviceConnectedEventData IJsonModel<IotHubDeviceConnectedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubDeviceConnectedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubDeviceConnectedEventData(document.RootElement, options);
        }

        internal static IotHubDeviceConnectedEventData DeserializeIotHubDeviceConnectedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deviceId = default;
            string moduleId = default;
            string hubName = default;
            DeviceConnectionStateEventInfo deviceConnectionStateEventInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionStateEventInfo"u8))
                {
                    deviceConnectionStateEventInfo = DeviceConnectionStateEventInfo.DeserializeDeviceConnectionStateEventInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubDeviceConnectedEventData(deviceId, moduleId, hubName, deviceConnectionStateEventInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubDeviceConnectedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubDeviceConnectedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubDeviceConnectedEventData IPersistableModel<IotHubDeviceConnectedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubDeviceConnectedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubDeviceConnectedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubDeviceConnectedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new IotHubDeviceConnectedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeIotHubDeviceConnectedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
