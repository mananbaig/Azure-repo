// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(PolicyInsightsPolicyStateChangedEventDataConverter))]
    public partial class PolicyInsightsPolicyStateChangedEventData : IUtf8JsonSerializable, IModelJsonSerializable<PolicyInsightsPolicyStateChangedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyInsightsPolicyStateChangedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyInsightsPolicyStateChangedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyInsightsPolicyStateChangedEventData>(this, options.Format);

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
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static PolicyInsightsPolicyStateChangedEventData DeserializePolicyInsightsPolicyStateChangedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

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
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolicyInsightsPolicyStateChangedEventData(Optional.ToNullable(timestamp), policyAssignmentId.Value, policyDefinitionId.Value, policyDefinitionReferenceId.Value, complianceState.Value, subscriptionId.Value, complianceReasonCode.Value, serializedAdditionalRawData);
        }

        PolicyInsightsPolicyStateChangedEventData IModelJsonSerializable<PolicyInsightsPolicyStateChangedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyInsightsPolicyStateChangedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyInsightsPolicyStateChangedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyInsightsPolicyStateChangedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyInsightsPolicyStateChangedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyInsightsPolicyStateChangedEventData IModelSerializable<PolicyInsightsPolicyStateChangedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyInsightsPolicyStateChangedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyInsightsPolicyStateChangedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyInsightsPolicyStateChangedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyInsightsPolicyStateChangedEventData"/> to convert. </param>
        public static implicit operator RequestContent(PolicyInsightsPolicyStateChangedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyInsightsPolicyStateChangedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyInsightsPolicyStateChangedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyInsightsPolicyStateChangedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

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
