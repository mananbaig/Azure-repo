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
    [JsonConverter(typeof(SqlScriptsListResponseConverter))]
    internal partial class SqlScriptsListResponse : IUtf8JsonSerializable, IModelJsonSerializable<SqlScriptsListResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlScriptsListResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlScriptsListResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScriptsListResponse>(this, options.Format);

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
                    ((IModelJsonSerializable<SqlScriptResource>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static SqlScriptsListResponse DeserializeSqlScriptsListResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SqlScriptResource> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SqlScriptResource> array = new List<SqlScriptResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlScriptResource.DeserializeSqlScriptResource(item));
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
            return new SqlScriptsListResponse(value, nextLink.Value, serializedAdditionalRawData);
        }

        SqlScriptsListResponse IModelJsonSerializable<SqlScriptsListResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScriptsListResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlScriptsListResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlScriptsListResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScriptsListResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlScriptsListResponse IModelSerializable<SqlScriptsListResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScriptsListResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlScriptsListResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlScriptsListResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlScriptsListResponse"/> to convert. </param>
        public static implicit operator RequestContent(SqlScriptsListResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlScriptsListResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlScriptsListResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlScriptsListResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SqlScriptsListResponseConverter : JsonConverter<SqlScriptsListResponse>
        {
            public override void Write(Utf8JsonWriter writer, SqlScriptsListResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlScriptsListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlScriptsListResponse(document.RootElement);
            }
        }
    }
}
