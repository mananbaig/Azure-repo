// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Dynatrace;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceTagRulePatch : IUtf8JsonSerializable, IJsonModel<DynatraceTagRulePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceTagRulePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynatraceTagRulePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceTagRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceTagRulePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LogRules))
            {
                writer.WritePropertyName("logRules"u8);
                writer.WriteObjectValue(LogRules);
            }
            if (Optional.IsDefined(MetricRules))
            {
                writer.WritePropertyName("metricRules"u8);
                writer.WriteObjectValue(MetricRules);
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

        DynatraceTagRulePatch IJsonModel<DynatraceTagRulePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceTagRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceTagRulePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceTagRulePatch(document.RootElement, options);
        }

        internal static DynatraceTagRulePatch DeserializeDynatraceTagRulePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DynatraceMonitorResourceLogRules logRules = default;
            DynatraceMonitorResourceMetricRules metricRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logRules = DynatraceMonitorResourceLogRules.DeserializeDynatraceMonitorResourceLogRules(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metricRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metricRules = DynatraceMonitorResourceMetricRules.DeserializeDynatraceMonitorResourceMetricRules(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynatraceTagRulePatch(logRules, metricRules, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceTagRulePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceTagRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceTagRulePatch)} does not support '{options.Format}' format.");
            }
        }

        DynatraceTagRulePatch IPersistableModel<DynatraceTagRulePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceTagRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceTagRulePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceTagRulePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceTagRulePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
