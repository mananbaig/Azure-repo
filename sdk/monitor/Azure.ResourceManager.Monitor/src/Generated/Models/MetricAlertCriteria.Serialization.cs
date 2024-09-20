// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricAlertCriteria : IUtf8JsonSerializable, IJsonModel<MetricAlertCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricAlertCriteria>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MetricAlertCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricAlertCriteria)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType.ToString());
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

        MetricAlertCriteria IJsonModel<MetricAlertCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricAlertCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricAlertCriteria(document.RootElement, options);
        }

        internal static MetricAlertCriteria DeserializeMetricAlertCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria": return MetricAlertMultipleResourceMultipleMetricCriteria.DeserializeMetricAlertMultipleResourceMultipleMetricCriteria(element, options);
                    case "Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria": return MetricAlertSingleResourceMultipleMetricCriteria.DeserializeMetricAlertSingleResourceMultipleMetricCriteria(element, options);
                    case "Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria": return WebtestLocationAvailabilityCriteria.DeserializeWebtestLocationAvailabilityCriteria(element, options);
                }
            }
            return UnknownMetricAlertCriteria.DeserializeUnknownMetricAlertCriteria(element, options);
        }

        BinaryData IPersistableModel<MetricAlertCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricAlertCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        MetricAlertCriteria IPersistableModel<MetricAlertCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricAlertCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricAlertCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricAlertCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
