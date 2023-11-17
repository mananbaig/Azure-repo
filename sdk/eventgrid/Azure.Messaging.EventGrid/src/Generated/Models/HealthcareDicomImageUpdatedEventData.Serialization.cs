// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(HealthcareDicomImageUpdatedEventDataConverter))]
    public partial class HealthcareDicomImageUpdatedEventData : IUtf8JsonSerializable, IJsonModel<HealthcareDicomImageUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareDicomImageUpdatedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HealthcareDicomImageUpdatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HealthcareDicomImageUpdatedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HealthcareDicomImageUpdatedEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionName))
            {
                writer.WritePropertyName("partitionName"u8);
                writer.WriteStringValue(PartitionName);
            }
            if (Optional.IsDefined(ImageStudyInstanceUid))
            {
                writer.WritePropertyName("imageStudyInstanceUid"u8);
                writer.WriteStringValue(ImageStudyInstanceUid);
            }
            if (Optional.IsDefined(ImageSeriesInstanceUid))
            {
                writer.WritePropertyName("imageSeriesInstanceUid"u8);
                writer.WriteStringValue(ImageSeriesInstanceUid);
            }
            if (Optional.IsDefined(ImageSopInstanceUid))
            {
                writer.WritePropertyName("imageSopInstanceUid"u8);
                writer.WriteStringValue(ImageSopInstanceUid);
            }
            if (Optional.IsDefined(ServiceHostName))
            {
                writer.WritePropertyName("serviceHostName"u8);
                writer.WriteStringValue(ServiceHostName);
            }
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
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

        HealthcareDicomImageUpdatedEventData IJsonModel<HealthcareDicomImageUpdatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageUpdatedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareDicomImageUpdatedEventData(document.RootElement, options);
        }

        internal static HealthcareDicomImageUpdatedEventData DeserializeHealthcareDicomImageUpdatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> partitionName = default;
            Optional<string> imageStudyInstanceUid = default;
            Optional<string> imageSeriesInstanceUid = default;
            Optional<string> imageSopInstanceUid = default;
            Optional<string> serviceHostName = default;
            Optional<long> sequenceNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionName"u8))
                {
                    partitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageStudyInstanceUid"u8))
                {
                    imageStudyInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSeriesInstanceUid"u8))
                {
                    imageSeriesInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSopInstanceUid"u8))
                {
                    imageSopInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceHostName"u8))
                {
                    serviceHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HealthcareDicomImageUpdatedEventData(partitionName.Value, imageStudyInstanceUid.Value, imageSeriesInstanceUid.Value, imageSopInstanceUid.Value, serviceHostName.Value, Optional.ToNullable(sequenceNumber), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareDicomImageUpdatedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageUpdatedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HealthcareDicomImageUpdatedEventData IPersistableModel<HealthcareDicomImageUpdatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageUpdatedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHealthcareDicomImageUpdatedEventData(document.RootElement, options);
        }

        string IPersistableModel<HealthcareDicomImageUpdatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class HealthcareDicomImageUpdatedEventDataConverter : JsonConverter<HealthcareDicomImageUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareDicomImageUpdatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HealthcareDicomImageUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareDicomImageUpdatedEventData(document.RootElement);
            }
        }
    }
}
