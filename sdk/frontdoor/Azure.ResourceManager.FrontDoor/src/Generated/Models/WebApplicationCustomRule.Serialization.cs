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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class WebApplicationCustomRule : IUtf8JsonSerializable, IJsonModel<WebApplicationCustomRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationCustomRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebApplicationCustomRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationCustomRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WebApplicationCustomRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(RateLimitDurationInMinutes))
            {
                writer.WritePropertyName("rateLimitDurationInMinutes"u8);
                writer.WriteNumberValue(RateLimitDurationInMinutes.Value);
            }
            if (Optional.IsDefined(RateLimitThreshold))
            {
                writer.WritePropertyName("rateLimitThreshold"u8);
                writer.WriteNumberValue(RateLimitThreshold.Value);
            }
            writer.WritePropertyName("matchConditions"u8);
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
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

        WebApplicationCustomRule IJsonModel<WebApplicationCustomRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationCustomRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WebApplicationCustomRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationCustomRule(document.RootElement, options);
        }

        internal static WebApplicationCustomRule DeserializeWebApplicationCustomRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            int priority = default;
            Optional<CustomRuleEnabledState> enabledState = default;
            WebApplicationRuleType ruleType = default;
            Optional<int> rateLimitDurationInMinutes = default;
            Optional<int> rateLimitThreshold = default;
            IList<WebApplicationRuleMatchCondition> matchConditions = default;
            RuleMatchActionType action = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabledState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledState = new CustomRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new WebApplicationRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitDurationInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitDurationInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rateLimitThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    List<WebApplicationRuleMatchCondition> array = new List<WebApplicationRuleMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebApplicationRuleMatchCondition.DeserializeWebApplicationRuleMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new RuleMatchActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebApplicationCustomRule(name.Value, priority, Optional.ToNullable(enabledState), ruleType, Optional.ToNullable(rateLimitDurationInMinutes), Optional.ToNullable(rateLimitThreshold), matchConditions, action, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebApplicationCustomRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationCustomRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(WebApplicationCustomRule)} does not support '{options.Format}' format.");
            }
        }

        WebApplicationCustomRule IPersistableModel<WebApplicationCustomRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationCustomRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebApplicationCustomRule(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(WebApplicationCustomRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationCustomRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
