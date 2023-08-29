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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ActivityLogAlertAnyOfOrLeafCondition : IUtf8JsonSerializable, IModelJsonSerializable<ActivityLogAlertAnyOfOrLeafCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ActivityLogAlertAnyOfOrLeafCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ActivityLogAlertAnyOfOrLeafCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ActivityLogAlertAnyOfOrLeafCondition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AnyOf))
            {
                writer.WritePropertyName("anyOf"u8);
                writer.WriteStartArray();
                foreach (var item in AnyOf)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Field))
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field);
            }
            if (Optional.IsDefined(EqualsValue))
            {
                writer.WritePropertyName("equals"u8);
                writer.WriteStringValue(EqualsValue);
            }
            if (Optional.IsCollectionDefined(ContainsAny))
            {
                writer.WritePropertyName("containsAny"u8);
                writer.WriteStartArray();
                foreach (var item in ContainsAny)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static ActivityLogAlertAnyOfOrLeafCondition DeserializeActivityLogAlertAnyOfOrLeafCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AlertRuleLeafCondition>> anyOf = default;
            Optional<string> field = default;
            Optional<string> @equals = default;
            Optional<IList<string>> containsAny = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anyOf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlertRuleLeafCondition> array = new List<AlertRuleLeafCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeAlertRuleLeafCondition(item));
                    }
                    anyOf = array;
                    continue;
                }
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("equals"u8))
                {
                    @equals = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containsAny"u8))
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
                    containsAny = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ActivityLogAlertAnyOfOrLeafCondition(field.Value, @equals.Value, Optional.ToList(containsAny), Optional.ToList(anyOf), rawData);
        }

        ActivityLogAlertAnyOfOrLeafCondition IModelJsonSerializable<ActivityLogAlertAnyOfOrLeafCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ActivityLogAlertAnyOfOrLeafCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeActivityLogAlertAnyOfOrLeafCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ActivityLogAlertAnyOfOrLeafCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ActivityLogAlertAnyOfOrLeafCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ActivityLogAlertAnyOfOrLeafCondition IModelSerializable<ActivityLogAlertAnyOfOrLeafCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ActivityLogAlertAnyOfOrLeafCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeActivityLogAlertAnyOfOrLeafCondition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ActivityLogAlertAnyOfOrLeafCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ActivityLogAlertAnyOfOrLeafCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeActivityLogAlertAnyOfOrLeafCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
