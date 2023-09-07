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

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(StoredProcedureParameterConverter))]
    public partial class StoredProcedureParameter : IUtf8JsonSerializable, IModelJsonSerializable<StoredProcedureParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StoredProcedureParameter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StoredProcedureParameter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoredProcedureParameter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                if (Value != null)
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteObjectValue(Value);
                }
                else
                {
                    writer.WriteNull("value");
                }
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
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

        internal static StoredProcedureParameter DeserializeStoredProcedureParameter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> value = default;
            Optional<StoredProcedureParameterType> type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new StoredProcedureParameterType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StoredProcedureParameter(value.Value, Optional.ToNullable(type), serializedAdditionalRawData);
        }

        StoredProcedureParameter IModelJsonSerializable<StoredProcedureParameter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoredProcedureParameter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStoredProcedureParameter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StoredProcedureParameter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoredProcedureParameter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StoredProcedureParameter IModelSerializable<StoredProcedureParameter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StoredProcedureParameter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStoredProcedureParameter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StoredProcedureParameter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StoredProcedureParameter"/> to convert. </param>
        public static implicit operator RequestContent(StoredProcedureParameter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StoredProcedureParameter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StoredProcedureParameter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStoredProcedureParameter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class StoredProcedureParameterConverter : JsonConverter<StoredProcedureParameter>
        {
            public override void Write(Utf8JsonWriter writer, StoredProcedureParameter model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StoredProcedureParameter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStoredProcedureParameter(document.RootElement);
            }
        }
    }
}
