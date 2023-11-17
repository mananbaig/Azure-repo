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
    [JsonConverter(typeof(AppConfigurationSnapshotCreatedEventDataConverter))]
    public partial class AppConfigurationSnapshotCreatedEventData : IUtf8JsonSerializable, IJsonModel<AppConfigurationSnapshotCreatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppConfigurationSnapshotCreatedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppConfigurationSnapshotCreatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppConfigurationSnapshotCreatedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppConfigurationSnapshotCreatedEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag);
            }
            if (Optional.IsDefined(SyncToken))
            {
                writer.WritePropertyName("syncToken"u8);
                writer.WriteStringValue(SyncToken);
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

        AppConfigurationSnapshotCreatedEventData IJsonModel<AppConfigurationSnapshotCreatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppConfigurationSnapshotCreatedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppConfigurationSnapshotCreatedEventData(document.RootElement, options);
        }

        internal static AppConfigurationSnapshotCreatedEventData DeserializeAppConfigurationSnapshotCreatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> syncToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("syncToken"u8))
                {
                    syncToken = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppConfigurationSnapshotCreatedEventData(name.Value, etag.Value, syncToken.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppConfigurationSnapshotCreatedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppConfigurationSnapshotCreatedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppConfigurationSnapshotCreatedEventData IPersistableModel<AppConfigurationSnapshotCreatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppConfigurationSnapshotCreatedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppConfigurationSnapshotCreatedEventData(document.RootElement, options);
        }

        string IPersistableModel<AppConfigurationSnapshotCreatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class AppConfigurationSnapshotCreatedEventDataConverter : JsonConverter<AppConfigurationSnapshotCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AppConfigurationSnapshotCreatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AppConfigurationSnapshotCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAppConfigurationSnapshotCreatedEventData(document.RootElement);
            }
        }
    }
}
