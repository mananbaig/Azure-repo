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
    public partial class IotSecurityAggregatedAlertTopDevice : IUtf8JsonSerializable, IModelJsonSerializable<IotSecurityAggregatedAlertTopDevice>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotSecurityAggregatedAlertTopDevice>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotSecurityAggregatedAlertTopDevice>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertTopDevice>(this, options.Format);

            writer.WriteStartObject();
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

        internal static IotSecurityAggregatedAlertTopDevice DeserializeIotSecurityAggregatedAlertTopDevice(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<long> alertsCount = default;
            Optional<string> lastOccurrence = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastOccurrence"u8))
                {
                    lastOccurrence = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotSecurityAggregatedAlertTopDevice(deviceId.Value, Optional.ToNullable(alertsCount), lastOccurrence.Value, serializedAdditionalRawData);
        }

        IotSecurityAggregatedAlertTopDevice IModelJsonSerializable<IotSecurityAggregatedAlertTopDevice>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertTopDevice>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedAlertTopDevice(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotSecurityAggregatedAlertTopDevice>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertTopDevice>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotSecurityAggregatedAlertTopDevice IModelSerializable<IotSecurityAggregatedAlertTopDevice>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertTopDevice>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotSecurityAggregatedAlertTopDevice(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotSecurityAggregatedAlertTopDevice"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotSecurityAggregatedAlertTopDevice"/> to convert. </param>
        public static implicit operator RequestContent(IotSecurityAggregatedAlertTopDevice model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotSecurityAggregatedAlertTopDevice"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotSecurityAggregatedAlertTopDevice(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotSecurityAggregatedAlertTopDevice(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
