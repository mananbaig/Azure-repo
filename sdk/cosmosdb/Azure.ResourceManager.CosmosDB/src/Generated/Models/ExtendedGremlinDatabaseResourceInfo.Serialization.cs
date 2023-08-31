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
    public partial class ExtendedGremlinDatabaseResourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<ExtendedGremlinDatabaseResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExtendedGremlinDatabaseResourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExtendedGremlinDatabaseResourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExtendedGremlinDatabaseResourceInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(DatabaseName);
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                if (RestoreParameters is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceRestoreParameters>)RestoreParameters).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
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

        internal static ExtendedGremlinDatabaseResourceInfo DeserializeExtendedGremlinDatabaseResourceInfo(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<ResourceRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
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
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExtendedGremlinDatabaseResourceInfo(id, restoreParameters.Value, Optional.ToNullable(createMode), rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag), rawData);
        }

        ExtendedGremlinDatabaseResourceInfo IModelJsonSerializable<ExtendedGremlinDatabaseResourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExtendedGremlinDatabaseResourceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedGremlinDatabaseResourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExtendedGremlinDatabaseResourceInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExtendedGremlinDatabaseResourceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExtendedGremlinDatabaseResourceInfo IModelSerializable<ExtendedGremlinDatabaseResourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExtendedGremlinDatabaseResourceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExtendedGremlinDatabaseResourceInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExtendedGremlinDatabaseResourceInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExtendedGremlinDatabaseResourceInfo"/> to convert. </param>
        public static implicit operator RequestContent(ExtendedGremlinDatabaseResourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExtendedGremlinDatabaseResourceInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExtendedGremlinDatabaseResourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExtendedGremlinDatabaseResourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
