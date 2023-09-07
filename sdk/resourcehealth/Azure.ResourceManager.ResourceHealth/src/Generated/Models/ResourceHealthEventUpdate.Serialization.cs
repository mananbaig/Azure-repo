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

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventUpdate : IUtf8JsonSerializable, IModelJsonSerializable<ResourceHealthEventUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceHealthEventUpdate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceHealthEventUpdate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventUpdate>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updateDateTime"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
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

        internal static ResourceHealthEventUpdate DeserializeResourceHealthEventUpdate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> summary = default;
            Optional<DateTimeOffset> updateDateTime = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceHealthEventUpdate(summary.Value, Optional.ToNullable(updateDateTime), serializedAdditionalRawData);
        }

        ResourceHealthEventUpdate IModelJsonSerializable<ResourceHealthEventUpdate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventUpdate>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventUpdate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceHealthEventUpdate>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventUpdate>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceHealthEventUpdate IModelSerializable<ResourceHealthEventUpdate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventUpdate>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceHealthEventUpdate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceHealthEventUpdate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceHealthEventUpdate"/> to convert. </param>
        public static implicit operator RequestContent(ResourceHealthEventUpdate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceHealthEventUpdate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceHealthEventUpdate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceHealthEventUpdate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
