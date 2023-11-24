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

namespace Azure.ResourceManager.Grafana.Models
{
    internal partial class GrafanaConfigurations : IUtf8JsonSerializable, IJsonModel<GrafanaConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GrafanaConfigurations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GrafanaConfigurations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(GrafanaConfigurations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Smtp))
            {
                writer.WritePropertyName("smtp"u8);
                writer.WriteObjectValue(Smtp);
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

        GrafanaConfigurations IJsonModel<GrafanaConfigurations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(GrafanaConfigurations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGrafanaConfigurations(document.RootElement, options);
        }

        internal static GrafanaConfigurations DeserializeGrafanaConfigurations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Smtp> smtp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("smtp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smtp = Smtp.DeserializeSmtp(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GrafanaConfigurations(smtp.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GrafanaConfigurations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(GrafanaConfigurations)} does not support '{options.Format}' format.");
            }
        }

        GrafanaConfigurations IPersistableModel<GrafanaConfigurations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGrafanaConfigurations(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(GrafanaConfigurations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GrafanaConfigurations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
