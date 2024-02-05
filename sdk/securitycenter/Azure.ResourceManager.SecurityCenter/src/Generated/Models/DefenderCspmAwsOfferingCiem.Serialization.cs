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
    public partial class DefenderCspmAwsOfferingCiem : IUtf8JsonSerializable, IJsonModel<DefenderCspmAwsOfferingCiem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmAwsOfferingCiem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderCspmAwsOfferingCiem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CiemDiscovery))
            {
                writer.WritePropertyName("ciemDiscovery"u8);
                writer.WriteObjectValue(CiemDiscovery);
            }
            if (Optional.IsDefined(CiemOidc))
            {
                writer.WritePropertyName("ciemOidc"u8);
                writer.WriteObjectValue(CiemOidc);
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

        DefenderCspmAwsOfferingCiem IJsonModel<DefenderCspmAwsOfferingCiem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmAwsOfferingCiem(document.RootElement, options);
        }

        internal static DefenderCspmAwsOfferingCiem DeserializeDefenderCspmAwsOfferingCiem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderCspmAwsOfferingCiemDiscovery> ciemDiscovery = default;
            Optional<DefenderCspmAwsOfferingCiemOidc> ciemOidc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ciemDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciemDiscovery = DefenderCspmAwsOfferingCiemDiscovery.DeserializeDefenderCspmAwsOfferingCiemDiscovery(property.Value);
                    continue;
                }
                if (property.NameEquals("ciemOidc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciemOidc = DefenderCspmAwsOfferingCiemOidc.DeserializeDefenderCspmAwsOfferingCiemOidc(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderCspmAwsOfferingCiem(ciemDiscovery.Value, ciemOidc.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CiemDiscovery))
            {
                builder.Append("  ciemDiscovery:");
                AppendChildObject(builder, CiemDiscovery, options, 2, false);
            }

            if (Optional.IsDefined(CiemOidc))
            {
                builder.Append("  ciemOidc:");
                AppendChildObject(builder, CiemOidc, options, 2, false);
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

        BinaryData IPersistableModel<DefenderCspmAwsOfferingCiem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support '{options.Format}' format.");
            }
        }

        DefenderCspmAwsOfferingCiem IPersistableModel<DefenderCspmAwsOfferingCiem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmAwsOfferingCiem(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmAwsOfferingCiem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
