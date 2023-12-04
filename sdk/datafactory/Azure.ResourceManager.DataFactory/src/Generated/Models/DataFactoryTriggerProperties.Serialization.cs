// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryTriggerProperties : IUtf8JsonSerializable, IJsonModel<DataFactoryTriggerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryTriggerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryTriggerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataFactoryTriggerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(RuntimeState))
            {
                writer.WritePropertyName("runtimeState"u8);
                writer.WriteStringValue(RuntimeState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryTriggerProperties IJsonModel<DataFactoryTriggerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataFactoryTriggerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryTriggerProperties(document.RootElement, options);
        }

        internal static DataFactoryTriggerProperties DeserializeDataFactoryTriggerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BlobEventsTrigger": return DataFactoryBlobEventsTrigger.DeserializeDataFactoryBlobEventsTrigger(element);
                    case "BlobTrigger": return DataFactoryBlobTrigger.DeserializeDataFactoryBlobTrigger(element);
                    case "ChainingTrigger": return ChainingTrigger.DeserializeChainingTrigger(element);
                    case "CustomEventsTrigger": return CustomEventsTrigger.DeserializeCustomEventsTrigger(element);
                    case "MultiplePipelineTrigger": return MultiplePipelineTrigger.DeserializeMultiplePipelineTrigger(element);
                    case "RerunTumblingWindowTrigger": return RerunTumblingWindowTrigger.DeserializeRerunTumblingWindowTrigger(element);
                    case "ScheduleTrigger": return DataFactoryScheduleTrigger.DeserializeDataFactoryScheduleTrigger(element);
                    case "TumblingWindowTrigger": return TumblingWindowTrigger.DeserializeTumblingWindowTrigger(element);
                }
            }
            return UnknownTrigger.DeserializeUnknownTrigger(element);
        }

        BinaryData IPersistableModel<DataFactoryTriggerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataFactoryTriggerProperties)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryTriggerProperties IPersistableModel<DataFactoryTriggerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryTriggerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryTriggerProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataFactoryTriggerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryTriggerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
