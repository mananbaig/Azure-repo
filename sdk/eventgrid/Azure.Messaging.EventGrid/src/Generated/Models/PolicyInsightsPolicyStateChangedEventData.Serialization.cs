// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(PolicyInsightsPolicyStateChangedEventDataConverter))]
    public partial class PolicyInsightsPolicyStateChangedEventData : IUtf8JsonSerializable, IJsonModel<PolicyInsightsPolicyStateChangedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyInsightsPolicyStateChangedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyInsightsPolicyStateChangedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(PolicyAssignmentId))
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
            }
            if (Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ComplianceReasonCode))
            {
                writer.WritePropertyName("complianceReasonCode"u8);
                writer.WriteStringValue(ComplianceReasonCode);
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

        PolicyInsightsPolicyStateChangedEventData IJsonModel<PolicyInsightsPolicyStateChangedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement, options);
        }

        internal static PolicyInsightsPolicyStateChangedEventData DeserializePolicyInsightsPolicyStateChangedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> policyAssignmentId = default;
            Optional<string> policyDefinitionId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<string> complianceState = default;
            Optional<string> subscriptionId = default;
            Optional<string> complianceReasonCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    policyAssignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    policyDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceReasonCode"u8))
                {
                    complianceReasonCode = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyInsightsPolicyStateChangedEventData(Optional.ToNullable(timestamp), policyAssignmentId.Value, policyDefinitionId.Value, policyDefinitionReferenceId.Value, complianceState.Value, subscriptionId.Value, complianceReasonCode.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyInsightsPolicyStateChangedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support '{options.Format}' format.");
            }
        }

        PolicyInsightsPolicyStateChangedEventData IPersistableModel<PolicyInsightsPolicyStateChangedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyInsightsPolicyStateChangedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class PolicyInsightsPolicyStateChangedEventDataConverter : JsonConverter<PolicyInsightsPolicyStateChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, PolicyInsightsPolicyStateChangedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PolicyInsightsPolicyStateChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement);
            }
        }
    }
}
