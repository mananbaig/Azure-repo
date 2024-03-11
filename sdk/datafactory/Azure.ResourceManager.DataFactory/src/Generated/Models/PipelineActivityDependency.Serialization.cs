// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PipelineActivityDependency : IUtf8JsonSerializable, IJsonModel<PipelineActivityDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineActivityDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PipelineActivityDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivityDependency)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("activity"u8);
            writer.WriteStringValue(Activity);
            writer.WritePropertyName("dependencyConditions"u8);
            writer.WriteStartArray();
            foreach (var item in DependencyConditions)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
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

        PipelineActivityDependency IJsonModel<PipelineActivityDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivityDependency)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineActivityDependency(document.RootElement, options);
        }

        internal static PipelineActivityDependency DeserializePipelineActivityDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activity = default;
            IList<DependencyCondition> dependencyConditions = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activity"u8))
                {
                    activity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependencyConditions"u8))
                {
                    List<DependencyCondition> array = new List<DependencyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DependencyCondition(item.GetString()));
                    }
                    dependencyConditions = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineActivityDependency(activity, dependencyConditions, additionalProperties);
        }

        BinaryData IPersistableModel<PipelineActivityDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineActivityDependency)} does not support '{options.Format}' format.");
            }
        }

        PipelineActivityDependency IPersistableModel<PipelineActivityDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineActivityDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineActivityDependency)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineActivityDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
