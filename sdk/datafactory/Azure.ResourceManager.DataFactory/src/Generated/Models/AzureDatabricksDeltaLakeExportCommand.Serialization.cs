// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureDatabricksDeltaLakeExportCommand : IUtf8JsonSerializable, IJsonModel<AzureDatabricksDeltaLakeExportCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDatabricksDeltaLakeExportCommand>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureDatabricksDeltaLakeExportCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeExportCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                JsonSerializer.Serialize(writer, DateFormat);
            }
            if (Optional.IsDefined(TimestampFormat))
            {
                writer.WritePropertyName("timestampFormat"u8);
                JsonSerializer.Serialize(writer, TimestampFormat);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ExportSettingsType);
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

        AzureDatabricksDeltaLakeExportCommand IJsonModel<AzureDatabricksDeltaLakeExportCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeExportCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDatabricksDeltaLakeExportCommand(document.RootElement, options);
        }

        internal static AzureDatabricksDeltaLakeExportCommand DeserializeAzureDatabricksDeltaLakeExportCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> dateFormat = default;
            DataFactoryElement<string> timestampFormat = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormat = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("timestampFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestampFormat = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksDeltaLakeExportCommand(type, additionalProperties, dateFormat, timestampFormat);
        }

        BinaryData IPersistableModel<AzureDatabricksDeltaLakeExportCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeExportCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support writing '{options.Format}' format.");
            }
        }

        AzureDatabricksDeltaLakeExportCommand IPersistableModel<AzureDatabricksDeltaLakeExportCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeExportCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDatabricksDeltaLakeExportCommand(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDatabricksDeltaLakeExportCommand)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDatabricksDeltaLakeExportCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
