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
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class IotSecurityAggregatedAlertList : IUtf8JsonSerializable, IModelJsonSerializable<IotSecurityAggregatedAlertList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotSecurityAggregatedAlertList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotSecurityAggregatedAlertList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertList>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IotSecurityAggregatedAlertData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static IotSecurityAggregatedAlertList DeserializeIotSecurityAggregatedAlertList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IotSecurityAggregatedAlertData> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IotSecurityAggregatedAlertData> array = new List<IotSecurityAggregatedAlertData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotSecurityAggregatedAlertData.DeserializeIotSecurityAggregatedAlertData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotSecurityAggregatedAlertList(value, nextLink.Value, serializedAdditionalRawData);
        }

        IotSecurityAggregatedAlertList IModelJsonSerializable<IotSecurityAggregatedAlertList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedAlertList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotSecurityAggregatedAlertList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotSecurityAggregatedAlertList IModelSerializable<IotSecurityAggregatedAlertList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotSecurityAggregatedAlertList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotSecurityAggregatedAlertList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotSecurityAggregatedAlertList"/> to convert. </param>
        public static implicit operator RequestContent(IotSecurityAggregatedAlertList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotSecurityAggregatedAlertList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotSecurityAggregatedAlertList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotSecurityAggregatedAlertList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
