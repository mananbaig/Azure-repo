// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class TimeWindowCustomAlertRule : IUtf8JsonSerializable, IModelJsonSerializable<TimeWindowCustomAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeWindowCustomAlertRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeWindowCustomAlertRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeWindowCustomAlertRule>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("timeWindowSize"u8);
            writer.WriteStringValue(TimeWindowSize, "P");
            writer.WritePropertyName("minThreshold"u8);
            writer.WriteNumberValue(MinThreshold);
            writer.WritePropertyName("maxThreshold"u8);
            writer.WriteNumberValue(MaxThreshold);
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
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

        internal static TimeWindowCustomAlertRule DeserializeTimeWindowCustomAlertRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ActiveConnectionsNotInAllowedRange": return ActiveConnectionsNotInAllowedRange.DeserializeActiveConnectionsNotInAllowedRange(element);
                    case "AmqpC2DMessagesNotInAllowedRange": return AmqpC2DMessagesNotInAllowedRange.DeserializeAmqpC2DMessagesNotInAllowedRange(element);
                    case "AmqpC2DRejectedMessagesNotInAllowedRange": return AmqpC2DRejectedMessagesNotInAllowedRange.DeserializeAmqpC2DRejectedMessagesNotInAllowedRange(element);
                    case "AmqpD2CMessagesNotInAllowedRange": return AmqpD2CMessagesNotInAllowedRange.DeserializeAmqpD2CMessagesNotInAllowedRange(element);
                    case "DirectMethodInvokesNotInAllowedRange": return DirectMethodInvokesNotInAllowedRange.DeserializeDirectMethodInvokesNotInAllowedRange(element);
                    case "FailedLocalLoginsNotInAllowedRange": return FailedLocalLoginsNotInAllowedRange.DeserializeFailedLocalLoginsNotInAllowedRange(element);
                    case "FileUploadsNotInAllowedRange": return FileUploadsNotInAllowedRange.DeserializeFileUploadsNotInAllowedRange(element);
                    case "HttpC2DMessagesNotInAllowedRange": return HttpC2DMessagesNotInAllowedRange.DeserializeHttpC2DMessagesNotInAllowedRange(element);
                    case "HttpC2DRejectedMessagesNotInAllowedRange": return HttpC2DRejectedMessagesNotInAllowedRange.DeserializeHttpC2DRejectedMessagesNotInAllowedRange(element);
                    case "HttpD2CMessagesNotInAllowedRange": return HttpD2CMessagesNotInAllowedRange.DeserializeHttpD2CMessagesNotInAllowedRange(element);
                    case "MqttC2DMessagesNotInAllowedRange": return MqttC2DMessagesNotInAllowedRange.DeserializeMqttC2DMessagesNotInAllowedRange(element);
                    case "MqttC2DRejectedMessagesNotInAllowedRange": return MqttC2DRejectedMessagesNotInAllowedRange.DeserializeMqttC2DRejectedMessagesNotInAllowedRange(element);
                    case "MqttD2CMessagesNotInAllowedRange": return MqttD2CMessagesNotInAllowedRange.DeserializeMqttD2CMessagesNotInAllowedRange(element);
                    case "QueuePurgesNotInAllowedRange": return QueuePurgesNotInAllowedRange.DeserializeQueuePurgesNotInAllowedRange(element);
                    case "TwinUpdatesNotInAllowedRange": return TwinUpdatesNotInAllowedRange.DeserializeTwinUpdatesNotInAllowedRange(element);
                    case "UnauthorizedOperationsNotInAllowedRange": return UnauthorizedOperationsNotInAllowedRange.DeserializeUnauthorizedOperationsNotInAllowedRange(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            TimeSpan timeWindowSize = default;
            int minThreshold = default;
            int maxThreshold = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            bool isEnabled = default;
            string ruleType = "TimeWindowCustomAlertRule";
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeWindowSize"u8))
                {
                    timeWindowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("minThreshold"u8))
                {
                    minThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxThreshold"u8))
                {
                    maxThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TimeWindowCustomAlertRule(displayName.Value, description.Value, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize, serializedAdditionalRawData);
        }

        TimeWindowCustomAlertRule IModelJsonSerializable<TimeWindowCustomAlertRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeWindowCustomAlertRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeWindowCustomAlertRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeWindowCustomAlertRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeWindowCustomAlertRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeWindowCustomAlertRule IModelSerializable<TimeWindowCustomAlertRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeWindowCustomAlertRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeWindowCustomAlertRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TimeWindowCustomAlertRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TimeWindowCustomAlertRule"/> to convert. </param>
        public static implicit operator RequestContent(TimeWindowCustomAlertRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TimeWindowCustomAlertRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TimeWindowCustomAlertRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTimeWindowCustomAlertRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
