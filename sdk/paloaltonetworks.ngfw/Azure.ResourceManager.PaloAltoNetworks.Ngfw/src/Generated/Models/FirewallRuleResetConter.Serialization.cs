// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallRuleResetConter : IUtf8JsonSerializable, IJsonModel<FirewallRuleResetConter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallRuleResetConter>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FirewallRuleResetConter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FirewallRuleResetConter>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FirewallRuleResetConter>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Priority))
                {
                    writer.WritePropertyName("priority"u8);
                    writer.WriteStringValue(Priority);
                }
            }
            if (Optional.IsDefined(RuleStackName))
            {
                writer.WritePropertyName("ruleStackName"u8);
                writer.WriteStringValue(RuleStackName);
            }
            if (Optional.IsDefined(RuleListName))
            {
                writer.WritePropertyName("ruleListName"u8);
                writer.WriteStringValue(RuleListName);
            }
            if (Optional.IsDefined(FirewallName))
            {
                writer.WritePropertyName("firewallName"u8);
                writer.WriteStringValue(FirewallName);
            }
            if (Optional.IsDefined(RuleName))
            {
                writer.WritePropertyName("ruleName"u8);
                writer.WriteStringValue(RuleName);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        FirewallRuleResetConter IJsonModel<FirewallRuleResetConter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallRuleResetConter(document.RootElement, options);
        }

        internal static FirewallRuleResetConter DeserializeFirewallRuleResetConter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> priority = default;
            Optional<string> ruleStackName = default;
            Optional<string> ruleListName = default;
            Optional<string> firewallName = default;
            Optional<string> ruleName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleStackName"u8))
                {
                    ruleStackName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleListName"u8))
                {
                    ruleListName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firewallName"u8))
                {
                    firewallName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleName"u8))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallRuleResetConter(priority.Value, ruleStackName.Value, ruleListName.Value, firewallName.Value, ruleName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallRuleResetConter>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirewallRuleResetConter IPersistableModel<FirewallRuleResetConter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirewallRuleResetConter(document.RootElement, options);
        }

        string IPersistableModel<FirewallRuleResetConter>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
