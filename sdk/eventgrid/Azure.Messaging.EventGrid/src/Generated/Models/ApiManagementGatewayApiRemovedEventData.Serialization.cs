// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementGatewayApiRemovedEventDataConverter))]
    public partial class ApiManagementGatewayApiRemovedEventData : IUtf8JsonSerializable, IModelJsonSerializable<ApiManagementGatewayApiRemovedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApiManagementGatewayApiRemovedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApiManagementGatewayApiRemovedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementGatewayApiRemovedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUri);
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

        internal static ApiManagementGatewayApiRemovedEventData DeserializeApiManagementGatewayApiRemovedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceUri = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApiManagementGatewayApiRemovedEventData(resourceUri.Value, serializedAdditionalRawData);
        }

        ApiManagementGatewayApiRemovedEventData IModelJsonSerializable<ApiManagementGatewayApiRemovedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementGatewayApiRemovedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementGatewayApiRemovedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApiManagementGatewayApiRemovedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementGatewayApiRemovedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApiManagementGatewayApiRemovedEventData IModelSerializable<ApiManagementGatewayApiRemovedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApiManagementGatewayApiRemovedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApiManagementGatewayApiRemovedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApiManagementGatewayApiRemovedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApiManagementGatewayApiRemovedEventData"/> to convert. </param>
        public static implicit operator RequestContent(ApiManagementGatewayApiRemovedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApiManagementGatewayApiRemovedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApiManagementGatewayApiRemovedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApiManagementGatewayApiRemovedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ApiManagementGatewayApiRemovedEventDataConverter : JsonConverter<ApiManagementGatewayApiRemovedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementGatewayApiRemovedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ApiManagementGatewayApiRemovedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementGatewayApiRemovedEventData(document.RootElement);
            }
        }
    }
}
