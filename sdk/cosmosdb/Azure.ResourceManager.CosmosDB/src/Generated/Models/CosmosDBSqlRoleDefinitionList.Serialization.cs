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
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBSqlRoleDefinitionList : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBSqlRoleDefinitionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBSqlRoleDefinitionList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBSqlRoleDefinitionList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static CosmosDBSqlRoleDefinitionList DeserializeCosmosDBSqlRoleDefinitionList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CosmosDBSqlRoleDefinitionData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBSqlRoleDefinitionData> array = new List<CosmosDBSqlRoleDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBSqlRoleDefinitionData.DeserializeCosmosDBSqlRoleDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBSqlRoleDefinitionList(Optional.ToList(value), rawData);
        }

        CosmosDBSqlRoleDefinitionList IModelJsonSerializable<CosmosDBSqlRoleDefinitionList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlRoleDefinitionList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBSqlRoleDefinitionList>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBSqlRoleDefinitionList IModelSerializable<CosmosDBSqlRoleDefinitionList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBSqlRoleDefinitionList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBSqlRoleDefinitionList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBSqlRoleDefinitionList"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBSqlRoleDefinitionList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBSqlRoleDefinitionList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBSqlRoleDefinitionList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBSqlRoleDefinitionList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
