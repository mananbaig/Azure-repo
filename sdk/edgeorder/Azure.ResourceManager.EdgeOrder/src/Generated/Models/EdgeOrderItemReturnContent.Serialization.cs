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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemReturnContent : IUtf8JsonSerializable, IModelJsonSerializable<EdgeOrderItemReturnContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeOrderItemReturnContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeOrderItemReturnContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderItemReturnContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ReturnAddress))
            {
                writer.WritePropertyName("returnAddress"u8);
                if (ReturnAddress is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EdgeOrderItemAddressProperties>)ReturnAddress).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("returnReason"u8);
            writer.WriteStringValue(ReturnReason);
            if (Optional.IsDefined(ServiceTag))
            {
                writer.WritePropertyName("serviceTag"u8);
                writer.WriteStringValue(ServiceTag);
            }
            if (Optional.IsDefined(IsShippingBoxRequired))
            {
                writer.WritePropertyName("shippingBoxRequired"u8);
                writer.WriteBooleanValue(IsShippingBoxRequired.Value);
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

        internal static EdgeOrderItemReturnContent DeserializeEdgeOrderItemReturnContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeOrderItemAddressProperties> returnAddress = default;
            string returnReason = default;
            Optional<string> serviceTag = default;
            Optional<bool> shippingBoxRequired = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("returnAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnAddress = EdgeOrderItemAddressProperties.DeserializeEdgeOrderItemAddressProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("returnReason"u8))
                {
                    returnReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTag"u8))
                {
                    serviceTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shippingBoxRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingBoxRequired = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeOrderItemReturnContent(returnAddress.Value, returnReason, serviceTag.Value, Optional.ToNullable(shippingBoxRequired), serializedAdditionalRawData);
        }

        EdgeOrderItemReturnContent IModelJsonSerializable<EdgeOrderItemReturnContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderItemReturnContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderItemReturnContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeOrderItemReturnContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderItemReturnContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeOrderItemReturnContent IModelSerializable<EdgeOrderItemReturnContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderItemReturnContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeOrderItemReturnContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeOrderItemReturnContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeOrderItemReturnContent"/> to convert. </param>
        public static implicit operator RequestContent(EdgeOrderItemReturnContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeOrderItemReturnContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeOrderItemReturnContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeOrderItemReturnContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
