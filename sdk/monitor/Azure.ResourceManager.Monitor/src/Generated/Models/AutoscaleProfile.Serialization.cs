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
    public partial class AutoscaleProfile : IUtf8JsonSerializable, IModelJsonSerializable<AutoscaleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutoscaleProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutoscaleProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("capacity"u8);
            if (Capacity is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<MonitorScaleCapacity>)Capacity).Serialize(writer, options);
            }
            writer.WritePropertyName("rules"u8);
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AutoscaleRule>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(FixedDate))
            {
                writer.WritePropertyName("fixedDate"u8);
                if (FixedDate is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MonitorTimeWindow>)FixedDate).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                if (Recurrence is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MonitorRecurrence>)Recurrence).Serialize(writer, options);
                }
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

        internal static AutoscaleProfile DeserializeAutoscaleProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            MonitorScaleCapacity capacity = default;
            IList<AutoscaleRule> rules = default;
            Optional<MonitorTimeWindow> fixedDate = default;
            Optional<MonitorRecurrence> recurrence = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = MonitorScaleCapacity.DeserializeMonitorScaleCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    List<AutoscaleRule> array = new List<AutoscaleRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutoscaleRule.DeserializeAutoscaleRule(item));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("fixedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fixedDate = MonitorTimeWindow.DeserializeMonitorTimeWindow(property.Value);
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = MonitorRecurrence.DeserializeMonitorRecurrence(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutoscaleProfile(name, capacity, rules, fixedDate.Value, recurrence.Value, rawData);
        }

        AutoscaleProfile IModelJsonSerializable<AutoscaleProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutoscaleProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutoscaleProfile IModelSerializable<AutoscaleProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutoscaleProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutoscaleProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutoscaleProfile"/> to convert. </param>
        public static implicit operator RequestContent(AutoscaleProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutoscaleProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutoscaleProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutoscaleProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
