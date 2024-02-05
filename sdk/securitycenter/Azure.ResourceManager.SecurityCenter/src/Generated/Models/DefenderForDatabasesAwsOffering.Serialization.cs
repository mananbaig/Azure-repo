// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForDatabasesAwsOffering : IUtf8JsonSerializable, IJsonModel<DefenderForDatabasesAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForDatabasesAwsOffering>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForDatabasesAwsOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                writer.WriteObjectValue(ArcAutoProvisioning);
            }
            if (Optional.IsDefined(Rds))
            {
                writer.WritePropertyName("rds"u8);
                writer.WriteObjectValue(Rds);
            }
            if (Optional.IsDefined(DatabasesDspm))
            {
                writer.WritePropertyName("databasesDspm"u8);
                writer.WriteObjectValue(DatabasesDspm);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        DefenderForDatabasesAwsOffering IJsonModel<DefenderForDatabasesAwsOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForDatabasesAwsOffering(document.RootElement, options);
        }

        internal static DefenderForDatabasesAwsOffering DeserializeDefenderForDatabasesAwsOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderForDatabasesAwsOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForDatabasesAwsOfferingRds> rds = default;
            Optional<DefenderFoDatabasesAwsOfferingDatabasesDspm> databasesDspm = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForDatabasesAwsOfferingArcAutoProvisioning.DeserializeDefenderForDatabasesAwsOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("rds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rds = DefenderForDatabasesAwsOfferingRds.DeserializeDefenderForDatabasesAwsOfferingRds(property.Value);
                    continue;
                }
                if (property.NameEquals("databasesDspm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databasesDspm = DefenderFoDatabasesAwsOfferingDatabasesDspm.DeserializeDefenderFoDatabasesAwsOfferingDatabasesDspm(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForDatabasesAwsOffering(offeringType, description.Value, serializedAdditionalRawData, arcAutoProvisioning.Value, rds.Value, databasesDspm.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                builder.Append("  arcAutoProvisioning:");
                AppendChildObject(builder, ArcAutoProvisioning, options, 2, false);
            }

            if (Optional.IsDefined(Rds))
            {
                builder.Append("  rds:");
                AppendChildObject(builder, Rds, options, 2, false);
            }

            if (Optional.IsDefined(DatabasesDspm))
            {
                builder.Append("  databasesDspm:");
                AppendChildObject(builder, DatabasesDspm, options, 2, false);
            }

            if (Optional.IsDefined(OfferingType))
            {
                builder.Append("  offeringType:");
                builder.AppendLine($" '{OfferingType.ToString()}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<DefenderForDatabasesAwsOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support '{options.Format}' format.");
            }
        }

        DefenderForDatabasesAwsOffering IPersistableModel<DefenderForDatabasesAwsOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForDatabasesAwsOffering(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DefenderForDatabasesAwsOffering)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForDatabasesAwsOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
