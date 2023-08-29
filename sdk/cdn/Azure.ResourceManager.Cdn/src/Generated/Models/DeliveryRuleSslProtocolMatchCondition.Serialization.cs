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
    public partial class DeliveryRuleSslProtocolMatchCondition : IUtf8JsonSerializable, IModelJsonSerializable<DeliveryRuleSslProtocolMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeliveryRuleSslProtocolMatchCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeliveryRuleSslProtocolMatchCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(SslProtocolMatchConditionType.ToString());
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(SslProtocolOperator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (Optional.IsCollectionDefined(MatchValues))
            {
                writer.WritePropertyName("matchValues"u8);
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
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

        internal static DeliveryRuleSslProtocolMatchCondition DeserializeDeliveryRuleSslProtocolMatchCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SslProtocolMatchConditionType typeName = default;
            SslProtocolOperator @operator = default;
            Optional<bool> negateCondition = default;
            Optional<IList<DeliveryRuleSslProtocol>> matchValues = default;
            Optional<IList<PreTransformCategory>> transforms = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new SslProtocolMatchConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new SslProtocolOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeliveryRuleSslProtocol> array = new List<DeliveryRuleSslProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DeliveryRuleSslProtocol(item.GetString()));
                    }
                    matchValues = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PreTransformCategory> array = new List<PreTransformCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreTransformCategory(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeliveryRuleSslProtocolMatchCondition(typeName, @operator, Optional.ToNullable(negateCondition), Optional.ToList(matchValues), Optional.ToList(transforms), rawData);
        }

        DeliveryRuleSslProtocolMatchCondition IModelJsonSerializable<DeliveryRuleSslProtocolMatchCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryRuleSslProtocolMatchCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeliveryRuleSslProtocolMatchCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeliveryRuleSslProtocolMatchCondition IModelSerializable<DeliveryRuleSslProtocolMatchCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeliveryRuleSslProtocolMatchCondition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DeliveryRuleSslProtocolMatchCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DeliveryRuleSslProtocolMatchCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeliveryRuleSslProtocolMatchCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
