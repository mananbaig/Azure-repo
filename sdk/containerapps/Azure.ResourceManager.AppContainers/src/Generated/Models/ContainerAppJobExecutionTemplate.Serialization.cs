// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobExecutionTemplate : IUtf8JsonSerializable, IJsonModel<ContainerAppJobExecutionTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobExecutionTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJobExecutionTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobExecutionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobExecutionTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Containers is ChangeTrackingList<JobExecutionContainer> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InitContainers is ChangeTrackingList<JobExecutionContainer> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppJobExecutionTemplate IJsonModel<ContainerAppJobExecutionTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobExecutionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobExecutionTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobExecutionTemplate(document.RootElement, options);
        }

        internal static ContainerAppJobExecutionTemplate DeserializeContainerAppJobExecutionTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<JobExecutionContainer>> containers = default;
            Optional<IList<JobExecutionContainer>> initContainers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobExecutionContainer> array = new List<JobExecutionContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobExecutionContainer.DeserializeJobExecutionContainer(item, options));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("initContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobExecutionContainer> array = new List<JobExecutionContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobExecutionContainer.DeserializeJobExecutionContainer(item, options));
                    }
                    initContainers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppJobExecutionTemplate(Optional.ToList(containers), Optional.ToList(initContainers), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppJobExecutionTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobExecutionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobExecutionTemplate)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJobExecutionTemplate IPersistableModel<ContainerAppJobExecutionTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobExecutionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobExecutionTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobExecutionTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobExecutionTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
