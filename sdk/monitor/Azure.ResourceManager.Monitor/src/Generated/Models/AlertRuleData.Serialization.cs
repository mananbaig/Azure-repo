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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class AlertRuleData : IUtf8JsonSerializable, IModelJsonSerializable<AlertRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AlertRuleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AlertRuleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(AlertRuleName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("condition"u8);
            if (Condition is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AlertRuleCondition>)Condition).Serialize(writer, options);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                if (Action is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AlertRuleAction>)Action).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AlertRuleAction>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static AlertRuleData DeserializeAlertRuleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string name0 = default;
            Optional<string> description = default;
            Optional<string> provisioningState = default;
            bool isEnabled = default;
            AlertRuleCondition condition = default;
            Optional<AlertRuleAction> action = default;
            Optional<IList<AlertRuleAction>> actions = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("condition"u8))
                        {
                            condition = AlertRuleCondition.DeserializeAlertRuleCondition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("action"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            action = AlertRuleAction.DeserializeAlertRuleAction(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AlertRuleAction> array = new List<AlertRuleAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AlertRuleAction.DeserializeAlertRuleAction(item));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AlertRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, name0, description.Value, provisioningState.Value, isEnabled, condition, action.Value, Optional.ToList(actions), Optional.ToNullable(lastUpdatedTime), rawData);
        }

        AlertRuleData IModelJsonSerializable<AlertRuleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertRuleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AlertRuleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AlertRuleData IModelSerializable<AlertRuleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAlertRuleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AlertRuleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AlertRuleData"/> to convert. </param>
        public static implicit operator RequestContent(AlertRuleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AlertRuleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AlertRuleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAlertRuleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
