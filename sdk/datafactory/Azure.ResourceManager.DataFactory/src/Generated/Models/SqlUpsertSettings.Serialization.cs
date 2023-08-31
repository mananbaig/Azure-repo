// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlUpsertSettings : IUtf8JsonSerializable, IModelJsonSerializable<SqlUpsertSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlUpsertSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlUpsertSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UseTempDB))
            {
                writer.WritePropertyName("useTempDB"u8);
                JsonSerializer.Serialize(writer, UseTempDB);
            }
            if (Optional.IsDefined(InterimSchemaName))
            {
                writer.WritePropertyName("interimSchemaName"u8);
                JsonSerializer.Serialize(writer, InterimSchemaName);
            }
            if (Optional.IsDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                JsonSerializer.Serialize(writer, Keys);
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

        internal static SqlUpsertSettings DeserializeSqlUpsertSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<bool>> useTempDB = default;
            Optional<DataFactoryElement<string>> interimSchemaName = default;
            Optional<DataFactoryElement<IList<string>>> keys = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("useTempDB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useTempDB = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("interimSchemaName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interimSchemaName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keys = JsonSerializer.Deserialize<DataFactoryElement<IList<string>>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlUpsertSettings(useTempDB.Value, interimSchemaName.Value, keys.Value, rawData);
        }

        SqlUpsertSettings IModelJsonSerializable<SqlUpsertSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlUpsertSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlUpsertSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlUpsertSettings IModelSerializable<SqlUpsertSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlUpsertSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlUpsertSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlUpsertSettings"/> to convert. </param>
        public static implicit operator RequestContent(SqlUpsertSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlUpsertSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlUpsertSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlUpsertSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
