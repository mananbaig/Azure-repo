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

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class BudgetAssociatedNotification : IUtf8JsonSerializable, IModelJsonSerializable<BudgetAssociatedNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BudgetAssociatedNotification>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BudgetAssociatedNotification>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("threshold"u8);
            writer.WriteNumberValue(Threshold);
            writer.WritePropertyName("contactEmails"u8);
            writer.WriteStartArray();
            foreach (var item in ContactEmails)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ContactRoles))
            {
                writer.WritePropertyName("contactRoles"u8);
                writer.WriteStartArray();
                foreach (var item in ContactRoles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactGroups))
            {
                writer.WritePropertyName("contactGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ContactGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ThresholdType))
            {
                writer.WritePropertyName("thresholdType"u8);
                writer.WriteStringValue(ThresholdType.Value.ToString());
            }
            if (Optional.IsDefined(Locale))
            {
                writer.WritePropertyName("locale"u8);
                writer.WriteStringValue(Locale.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static BudgetAssociatedNotification DeserializeBudgetAssociatedNotification(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            NotificationAlertTriggerType @operator = default;
            decimal threshold = default;
            IList<string> contactEmails = default;
            Optional<IList<string>> contactRoles = default;
            Optional<IList<string>> contactGroups = default;
            Optional<NotificationThresholdType> thresholdType = default;
            Optional<RecipientNotificationLanguageCode> locale = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new NotificationAlertTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("contactEmails"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactEmails = array;
                    continue;
                }
                if (property.NameEquals("contactRoles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactRoles = array;
                    continue;
                }
                if (property.NameEquals("contactGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactGroups = array;
                    continue;
                }
                if (property.NameEquals("thresholdType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thresholdType = new NotificationThresholdType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locale = new RecipientNotificationLanguageCode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BudgetAssociatedNotification(enabled, @operator, threshold, contactEmails, Optional.ToList(contactRoles), Optional.ToList(contactGroups), Optional.ToNullable(thresholdType), Optional.ToNullable(locale), rawData);
        }

        BudgetAssociatedNotification IModelJsonSerializable<BudgetAssociatedNotification>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBudgetAssociatedNotification(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BudgetAssociatedNotification>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BudgetAssociatedNotification IModelSerializable<BudgetAssociatedNotification>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBudgetAssociatedNotification(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BudgetAssociatedNotification"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BudgetAssociatedNotification"/> to convert. </param>
        public static implicit operator RequestContent(BudgetAssociatedNotification model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BudgetAssociatedNotification"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BudgetAssociatedNotification(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBudgetAssociatedNotification(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
