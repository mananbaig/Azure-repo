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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesOracleTaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<GetUserTablesOracleTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetUserTablesOracleTaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetUserTablesOracleTaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static GetUserTablesOracleTaskOutput DeserializeGetUserTablesOracleTaskOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> schemaName = default;
            Optional<IReadOnlyList<DatabaseTable>> tables = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseTable> array = new List<DatabaseTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseTable.DeserializeDatabaseTable(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetUserTablesOracleTaskOutput(schemaName.Value, Optional.ToList(tables), Optional.ToList(validationErrors), rawData);
        }

        GetUserTablesOracleTaskOutput IModelJsonSerializable<GetUserTablesOracleTaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetUserTablesOracleTaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetUserTablesOracleTaskOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetUserTablesOracleTaskOutput IModelSerializable<GetUserTablesOracleTaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetUserTablesOracleTaskOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetUserTablesOracleTaskOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetUserTablesOracleTaskOutput"/> to convert. </param>
        public static implicit operator RequestContent(GetUserTablesOracleTaskOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetUserTablesOracleTaskOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetUserTablesOracleTaskOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetUserTablesOracleTaskOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
