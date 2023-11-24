// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceVmExtensionPayload : IUtf8JsonSerializable, IJsonModel<DynatraceVmExtensionPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceVmExtensionPayload>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynatraceVmExtensionPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DynatraceVmExtensionPayload)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IngestionKey))
            {
                writer.WritePropertyName("ingestionKey"u8);
                writer.WriteStringValue(IngestionKey);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DynatraceVmExtensionPayload IJsonModel<DynatraceVmExtensionPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DynatraceVmExtensionPayload)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceVmExtensionPayload(document.RootElement, options);
        }

        internal static DynatraceVmExtensionPayload DeserializeDynatraceVmExtensionPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ingestionKey = default;
            Optional<string> environmentId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestionKey"u8))
                {
                    ingestionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynatraceVmExtensionPayload(ingestionKey.Value, environmentId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceVmExtensionPayload>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DynatraceVmExtensionPayload)} does not support '{options.Format}' format.");
            }
        }

        DynatraceVmExtensionPayload IPersistableModel<DynatraceVmExtensionPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceVmExtensionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceVmExtensionPayload(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DynatraceVmExtensionPayload)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceVmExtensionPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
