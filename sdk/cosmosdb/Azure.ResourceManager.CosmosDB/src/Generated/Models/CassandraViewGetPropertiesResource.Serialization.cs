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
    public partial class CassandraViewGetPropertiesResource : IUtf8JsonSerializable, IModelJsonSerializable<CassandraViewGetPropertiesResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CassandraViewGetPropertiesResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CassandraViewGetPropertiesResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CassandraViewGetPropertiesResource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("viewDefinition"u8);
            writer.WriteStringValue(ViewDefinition);
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

        internal static CassandraViewGetPropertiesResource DeserializeCassandraViewGetPropertiesResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            string viewDefinition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("viewDefinition"u8))
                {
                    viewDefinition = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CassandraViewGetPropertiesResource(id, viewDefinition, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag), rawData);
        }

        CassandraViewGetPropertiesResource IModelJsonSerializable<CassandraViewGetPropertiesResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CassandraViewGetPropertiesResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraViewGetPropertiesResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CassandraViewGetPropertiesResource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CassandraViewGetPropertiesResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CassandraViewGetPropertiesResource IModelSerializable<CassandraViewGetPropertiesResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CassandraViewGetPropertiesResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCassandraViewGetPropertiesResource(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CassandraViewGetPropertiesResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CassandraViewGetPropertiesResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCassandraViewGetPropertiesResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
