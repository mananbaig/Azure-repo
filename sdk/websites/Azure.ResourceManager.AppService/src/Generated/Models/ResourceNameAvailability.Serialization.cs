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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ResourceNameAvailability : IUtf8JsonSerializable, IModelJsonSerializable<ResourceNameAvailability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceNameAvailability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceNameAvailability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceNameAvailability>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsNameAvailable))
            {
                writer.WritePropertyName("nameAvailable"u8);
                writer.WriteBooleanValue(IsNameAvailable.Value);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        internal static ResourceNameAvailability DeserializeResourceNameAvailability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> nameAvailable = default;
            Optional<InAvailabilityReasonType> reason = default;
            Optional<string> message = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = new InAvailabilityReasonType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceNameAvailability(Optional.ToNullable(nameAvailable), Optional.ToNullable(reason), message.Value, serializedAdditionalRawData);
        }

        ResourceNameAvailability IModelJsonSerializable<ResourceNameAvailability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceNameAvailability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceNameAvailability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceNameAvailability>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceNameAvailability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceNameAvailability IModelSerializable<ResourceNameAvailability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceNameAvailability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceNameAvailability(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceNameAvailability"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceNameAvailability"/> to convert. </param>
        public static implicit operator RequestContent(ResourceNameAvailability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceNameAvailability"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceNameAvailability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceNameAvailability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
