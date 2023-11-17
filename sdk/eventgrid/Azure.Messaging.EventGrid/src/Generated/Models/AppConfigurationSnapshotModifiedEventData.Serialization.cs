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
    [JsonConverter(typeof(AppConfigurationSnapshotModifiedEventDataConverter))]
    public partial class AppConfigurationSnapshotModifiedEventData : IUtf8JsonSerializable, IJsonModel<AppConfigurationSnapshotModifiedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppConfigurationSnapshotModifiedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppConfigurationSnapshotModifiedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppConfigurationSnapshotModifiedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppConfigurationSnapshotModifiedEventData>)} interface");
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

        AppConfigurationSnapshotModifiedEventData IJsonModel<AppConfigurationSnapshotModifiedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppConfigurationSnapshotModifiedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppConfigurationSnapshotModifiedEventData(document.RootElement, options);
        }

        internal static AppConfigurationSnapshotModifiedEventData DeserializeAppConfigurationSnapshotModifiedEventData(JsonElement element, ModelReaderWriterOptions options = null)
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
            return new AppConfigurationSnapshotModifiedEventData(name.Value, etag.Value, syncToken.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppConfigurationSnapshotModifiedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppConfigurationSnapshotModifiedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppConfigurationSnapshotModifiedEventData IPersistableModel<AppConfigurationSnapshotModifiedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppConfigurationSnapshotModifiedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppConfigurationSnapshotModifiedEventData(document.RootElement, options);
        }

        string IPersistableModel<AppConfigurationSnapshotModifiedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class AppConfigurationSnapshotModifiedEventDataConverter : JsonConverter<AppConfigurationSnapshotModifiedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AppConfigurationSnapshotModifiedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AppConfigurationSnapshotModifiedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAppConfigurationSnapshotModifiedEventData(document.RootElement);
            }
        }
    }
}
