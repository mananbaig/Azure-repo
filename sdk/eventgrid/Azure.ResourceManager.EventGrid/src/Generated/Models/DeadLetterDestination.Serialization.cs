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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class DeadLetterDestination : IUtf8JsonSerializable, IModelJsonSerializable<DeadLetterDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeadLetterDestination>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeadLetterDestination>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeadLetterDestination>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
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

        internal static DeadLetterDestination DeserializeDeadLetterDestination(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageBlob": return StorageBlobDeadLetterDestination.DeserializeStorageBlobDeadLetterDestination(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DeadLetterEndPointType endpointType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new DeadLetterEndPointType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownDeadLetterDestination(endpointType, serializedAdditionalRawData);
        }

        DeadLetterDestination IModelJsonSerializable<DeadLetterDestination>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeadLetterDestination>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeadLetterDestination(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeadLetterDestination>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeadLetterDestination>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeadLetterDestination IModelSerializable<DeadLetterDestination>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeadLetterDestination>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeadLetterDestination(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeadLetterDestination"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeadLetterDestination"/> to convert. </param>
        public static implicit operator RequestContent(DeadLetterDestination model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeadLetterDestination"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeadLetterDestination(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeadLetterDestination(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
