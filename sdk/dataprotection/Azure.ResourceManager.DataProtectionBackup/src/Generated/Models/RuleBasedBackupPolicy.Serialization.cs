// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RuleBasedBackupPolicy : IUtf8JsonSerializable, IJsonModel<RuleBasedBackupPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleBasedBackupPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RuleBasedBackupPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleBasedBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleBasedBackupPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("policyRules"u8);
            writer.WriteStartArray();
            foreach (var item in PolicyRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("datasourceTypes"u8);
            writer.WriteStartArray();
            foreach (var item in DataSourceTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        RuleBasedBackupPolicy IJsonModel<RuleBasedBackupPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleBasedBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleBasedBackupPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleBasedBackupPolicy(document.RootElement, options);
        }

        internal static RuleBasedBackupPolicy DeserializeRuleBasedBackupPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataProtectionBasePolicyRule> policyRules = default;
            IList<string> datasourceTypes = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyRules"u8))
                {
                    List<DataProtectionBasePolicyRule> array = new List<DataProtectionBasePolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBasePolicyRule.DeserializeDataProtectionBasePolicyRule(item, options));
                    }
                    policyRules = array;
                    continue;
                }
                if (property.NameEquals("datasourceTypes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    datasourceTypes = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RuleBasedBackupPolicy(datasourceTypes, objectType, serializedAdditionalRawData, policyRules);
        }

        BinaryData IPersistableModel<RuleBasedBackupPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleBasedBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RuleBasedBackupPolicy)} does not support '{options.Format}' format.");
            }
        }

        RuleBasedBackupPolicy IPersistableModel<RuleBasedBackupPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleBasedBackupPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRuleBasedBackupPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuleBasedBackupPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuleBasedBackupPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
