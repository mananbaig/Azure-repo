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

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class VaultMonitoringSummary : IUtf8JsonSerializable, IJsonModel<VaultMonitoringSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultMonitoringSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VaultMonitoringSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultMonitoringSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultMonitoringSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UnHealthyVmCount))
            {
                writer.WritePropertyName("unHealthyVmCount"u8);
                writer.WriteNumberValue(UnHealthyVmCount.Value);
            }
            if (Optional.IsDefined(UnHealthyProviderCount))
            {
                writer.WritePropertyName("unHealthyProviderCount"u8);
                writer.WriteNumberValue(UnHealthyProviderCount.Value);
            }
            if (Optional.IsDefined(EventsCount))
            {
                writer.WritePropertyName("eventsCount"u8);
                writer.WriteNumberValue(EventsCount.Value);
            }
            if (Optional.IsDefined(DeprecatedProviderCount))
            {
                writer.WritePropertyName("deprecatedProviderCount"u8);
                writer.WriteNumberValue(DeprecatedProviderCount.Value);
            }
            if (Optional.IsDefined(SupportedProviderCount))
            {
                writer.WritePropertyName("supportedProviderCount"u8);
                writer.WriteNumberValue(SupportedProviderCount.Value);
            }
            if (Optional.IsDefined(UnsupportedProviderCount))
            {
                writer.WritePropertyName("unsupportedProviderCount"u8);
                writer.WriteNumberValue(UnsupportedProviderCount.Value);
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

        VaultMonitoringSummary IJsonModel<VaultMonitoringSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultMonitoringSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultMonitoringSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultMonitoringSummary(document.RootElement, options);
        }

        internal static VaultMonitoringSummary DeserializeVaultMonitoringSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> unHealthyVmCount = default;
            Optional<int> unHealthyProviderCount = default;
            Optional<int> eventsCount = default;
            Optional<int> deprecatedProviderCount = default;
            Optional<int> supportedProviderCount = default;
            Optional<int> unsupportedProviderCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unHealthyVmCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unHealthyVmCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unHealthyProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unHealthyProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deprecatedProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deprecatedProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("supportedProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unsupportedProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unsupportedProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VaultMonitoringSummary(Optional.ToNullable(unHealthyVmCount), Optional.ToNullable(unHealthyProviderCount), Optional.ToNullable(eventsCount), Optional.ToNullable(deprecatedProviderCount), Optional.ToNullable(supportedProviderCount), Optional.ToNullable(unsupportedProviderCount), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(UnHealthyVmCount))
            {
                builder.Append("  unHealthyVmCount:");
                builder.AppendLine($" {UnHealthyVmCount.Value}");
            }

            if (Optional.IsDefined(UnHealthyProviderCount))
            {
                builder.Append("  unHealthyProviderCount:");
                builder.AppendLine($" {UnHealthyProviderCount.Value}");
            }

            if (Optional.IsDefined(EventsCount))
            {
                builder.Append("  eventsCount:");
                builder.AppendLine($" {EventsCount.Value}");
            }

            if (Optional.IsDefined(DeprecatedProviderCount))
            {
                builder.Append("  deprecatedProviderCount:");
                builder.AppendLine($" {DeprecatedProviderCount.Value}");
            }

            if (Optional.IsDefined(SupportedProviderCount))
            {
                builder.Append("  supportedProviderCount:");
                builder.AppendLine($" {SupportedProviderCount.Value}");
            }

            if (Optional.IsDefined(UnsupportedProviderCount))
            {
                builder.Append("  unsupportedProviderCount:");
                builder.AppendLine($" {UnsupportedProviderCount.Value}");
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

        BinaryData IPersistableModel<VaultMonitoringSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultMonitoringSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VaultMonitoringSummary)} does not support '{options.Format}' format.");
            }
        }

        VaultMonitoringSummary IPersistableModel<VaultMonitoringSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultMonitoringSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVaultMonitoringSummary(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VaultMonitoringSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VaultMonitoringSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
