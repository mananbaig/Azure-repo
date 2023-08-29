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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeliveryRuleIsDeviceCondition : IUtf8JsonSerializable, IModelJsonSerializable<DeliveryRuleIsDeviceCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeliveryRuleIsDeviceCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeliveryRuleIsDeviceCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleIsDeviceCondition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue(Properties);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
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

        internal static DeliveryRuleIsDeviceCondition DeserializeDeliveryRuleIsDeviceCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IsDeviceMatchCondition parameters = default;
            MatchVariable name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = IsDeviceMatchCondition.DeserializeIsDeviceMatchCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = new MatchVariable(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeliveryRuleIsDeviceCondition(name, parameters, rawData);
        }

        DeliveryRuleIsDeviceCondition IModelJsonSerializable<DeliveryRuleIsDeviceCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleIsDeviceCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryRuleIsDeviceCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeliveryRuleIsDeviceCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleIsDeviceCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeliveryRuleIsDeviceCondition IModelSerializable<DeliveryRuleIsDeviceCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleIsDeviceCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeliveryRuleIsDeviceCondition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DeliveryRuleIsDeviceCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DeliveryRuleIsDeviceCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeliveryRuleIsDeviceCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
