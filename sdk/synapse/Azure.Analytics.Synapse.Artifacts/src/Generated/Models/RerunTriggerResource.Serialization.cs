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
    [JsonConverter(typeof(RerunTriggerResourceConverter))]
    public partial class RerunTriggerResource : IUtf8JsonSerializable, IModelJsonSerializable<RerunTriggerResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RerunTriggerResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RerunTriggerResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RerunTriggerResource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<RerunTumblingWindowTrigger>)Properties).Serialize(writer, options);
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

        internal static RerunTriggerResource DeserializeRerunTriggerResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RerunTumblingWindowTrigger properties = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = RerunTumblingWindowTrigger.DeserializeRerunTumblingWindowTrigger(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RerunTriggerResource(id.Value, name.Value, type.Value, etag.Value, properties, serializedAdditionalRawData);
        }

        RerunTriggerResource IModelJsonSerializable<RerunTriggerResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RerunTriggerResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRerunTriggerResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RerunTriggerResource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RerunTriggerResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RerunTriggerResource IModelSerializable<RerunTriggerResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RerunTriggerResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRerunTriggerResource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RerunTriggerResource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RerunTriggerResource"/> to convert. </param>
        public static implicit operator RequestContent(RerunTriggerResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RerunTriggerResource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RerunTriggerResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRerunTriggerResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class RerunTriggerResourceConverter : JsonConverter<RerunTriggerResource>
        {
            public override void Write(Utf8JsonWriter writer, RerunTriggerResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RerunTriggerResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRerunTriggerResource(document.RootElement);
            }
        }
    }
}
