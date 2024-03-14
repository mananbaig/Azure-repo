// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class PeriodicTimerEventTrigger : IUtf8JsonSerializable, IJsonModel<PeriodicTimerEventTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeriodicTimerEventTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeriodicTimerEventTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicTimerEventTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeriodicTimerEventTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("sourceInfo"u8);
            writer.WriteObjectValue(SourceInfo);
            writer.WritePropertyName("sinkInfo"u8);
            writer.WriteObjectValue(SinkInfo);
            if (Optional.IsDefined(CustomContextTag))
            {
                writer.WritePropertyName("customContextTag"u8);
                writer.WriteStringValue(CustomContextTag);
            }
            writer.WriteEndObject();
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

        PeriodicTimerEventTrigger IJsonModel<PeriodicTimerEventTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicTimerEventTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeriodicTimerEventTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeriodicTimerEventTrigger(document.RootElement, options);
        }

        internal static PeriodicTimerEventTrigger DeserializePeriodicTimerEventTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerEventType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            PeriodicTimerSourceInfo sourceInfo = default;
            DataBoxEdgeRoleSinkInfo sinkInfo = default;
            string customContextTag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new TriggerEventType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceInfo"u8))
                        {
                            sourceInfo = PeriodicTimerSourceInfo.DeserializePeriodicTimerSourceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sinkInfo"u8))
                        {
                            sinkInfo = DataBoxEdgeRoleSinkInfo.DeserializeDataBoxEdgeRoleSinkInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customContextTag"u8))
                        {
                            customContextTag = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeriodicTimerEventTrigger(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                sourceInfo,
                sinkInfo,
                customContextTag);
        }

        BinaryData IPersistableModel<PeriodicTimerEventTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicTimerEventTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeriodicTimerEventTrigger)} does not support '{options.Format}' format.");
            }
        }

        PeriodicTimerEventTrigger IPersistableModel<PeriodicTimerEventTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeriodicTimerEventTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeriodicTimerEventTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeriodicTimerEventTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeriodicTimerEventTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
