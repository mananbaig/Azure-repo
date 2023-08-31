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
    public partial class DatabaseAccountKeysMetadata : IUtf8JsonSerializable, IModelJsonSerializable<DatabaseAccountKeysMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatabaseAccountKeysMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatabaseAccountKeysMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static DatabaseAccountKeysMetadata DeserializeDatabaseAccountKeysMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AccountKeyMetadata> primaryMasterKey = default;
            Optional<AccountKeyMetadata> secondaryMasterKey = default;
            Optional<AccountKeyMetadata> primaryReadonlyMasterKey = default;
            Optional<AccountKeyMetadata> secondaryReadonlyMasterKey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("secondaryMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryReadonlyMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryReadonlyMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("secondaryReadonlyMasterKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryReadonlyMasterKey = AccountKeyMetadata.DeserializeAccountKeyMetadata(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DatabaseAccountKeysMetadata(primaryMasterKey.Value, secondaryMasterKey.Value, primaryReadonlyMasterKey.Value, secondaryReadonlyMasterKey.Value, rawData);
        }

        DatabaseAccountKeysMetadata IModelJsonSerializable<DatabaseAccountKeysMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseAccountKeysMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatabaseAccountKeysMetadata>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatabaseAccountKeysMetadata IModelSerializable<DatabaseAccountKeysMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatabaseAccountKeysMetadata(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DatabaseAccountKeysMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DatabaseAccountKeysMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatabaseAccountKeysMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
