// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrationValidationOptions : IUtf8JsonSerializable, IJsonModel<MigrationValidationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrationValidationOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrationValidationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationValidationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationValidationOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EnableSchemaValidation))
            {
                writer.WritePropertyName("enableSchemaValidation"u8);
                writer.WriteBooleanValue(EnableSchemaValidation.Value);
            }
            if (Optional.IsDefined(EnableDataIntegrityValidation))
            {
                writer.WritePropertyName("enableDataIntegrityValidation"u8);
                writer.WriteBooleanValue(EnableDataIntegrityValidation.Value);
            }
            if (Optional.IsDefined(EnableQueryAnalysisValidation))
            {
                writer.WritePropertyName("enableQueryAnalysisValidation"u8);
                writer.WriteBooleanValue(EnableQueryAnalysisValidation.Value);
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
        }

        MigrationValidationOptions IJsonModel<MigrationValidationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationValidationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationValidationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationValidationOptions(document.RootElement, options);
        }

        internal static MigrationValidationOptions DeserializeMigrationValidationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableSchemaValidation = default;
            bool? enableDataIntegrityValidation = default;
            bool? enableQueryAnalysisValidation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableSchemaValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableSchemaValidation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableDataIntegrityValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDataIntegrityValidation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableQueryAnalysisValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableQueryAnalysisValidation = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrationValidationOptions(enableSchemaValidation, enableDataIntegrityValidation, enableQueryAnalysisValidation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrationValidationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationValidationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrationValidationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        MigrationValidationOptions IPersistableModel<MigrationValidationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationValidationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrationValidationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrationValidationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrationValidationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
