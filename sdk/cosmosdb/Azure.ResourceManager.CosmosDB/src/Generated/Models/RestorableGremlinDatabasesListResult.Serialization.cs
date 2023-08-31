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

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableGremlinDatabasesListResult : IUtf8JsonSerializable, IModelJsonSerializable<RestorableGremlinDatabasesListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RestorableGremlinDatabasesListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RestorableGremlinDatabasesListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static RestorableGremlinDatabasesListResult DeserializeRestorableGremlinDatabasesListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RestorableGremlinDatabase>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorableGremlinDatabase> array = new List<RestorableGremlinDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableGremlinDatabase.DeserializeRestorableGremlinDatabase(item));
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
            return new RestorableGremlinDatabasesListResult(Optional.ToList(value), rawData);
        }

        RestorableGremlinDatabasesListResult IModelJsonSerializable<RestorableGremlinDatabasesListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableGremlinDatabasesListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RestorableGremlinDatabasesListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RestorableGremlinDatabasesListResult IModelSerializable<RestorableGremlinDatabasesListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRestorableGremlinDatabasesListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RestorableGremlinDatabasesListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RestorableGremlinDatabasesListResult"/> to convert. </param>
        public static implicit operator RequestContent(RestorableGremlinDatabasesListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RestorableGremlinDatabasesListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RestorableGremlinDatabasesListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRestorableGremlinDatabasesListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
