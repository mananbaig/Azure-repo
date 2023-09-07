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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class DocumentDbOutputDataSource : IUtf8JsonSerializable, IModelJsonSerializable<DocumentDbOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentDbOutputDataSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentDbOutputDataSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentDbOutputDataSource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(CollectionNamePattern))
            {
                writer.WritePropertyName("collectionNamePattern"u8);
                writer.WriteStringValue(CollectionNamePattern);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteStringValue(PartitionKey);
            }
            if (Optional.IsDefined(DocumentId))
            {
                writer.WritePropertyName("documentId"u8);
                writer.WriteStringValue(DocumentId);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static DocumentDbOutputDataSource DeserializeDocumentDbOutputDataSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> accountId = default;
            Optional<string> accountKey = default;
            Optional<string> database = default;
            Optional<string> collectionNamePattern = default;
            Optional<string> partitionKey = default;
            Optional<string> documentId = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accountId"u8))
                        {
                            accountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountKey"u8))
                        {
                            accountKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("collectionNamePattern"u8))
                        {
                            collectionNamePattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partitionKey"u8))
                        {
                            partitionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentId"u8))
                        {
                            documentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentDbOutputDataSource(type, accountId.Value, accountKey.Value, database.Value, collectionNamePattern.Value, partitionKey.Value, documentId.Value, Optional.ToNullable(authenticationMode), serializedAdditionalRawData);
        }

        DocumentDbOutputDataSource IModelJsonSerializable<DocumentDbOutputDataSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentDbOutputDataSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentDbOutputDataSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentDbOutputDataSource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentDbOutputDataSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentDbOutputDataSource IModelSerializable<DocumentDbOutputDataSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentDbOutputDataSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentDbOutputDataSource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentDbOutputDataSource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentDbOutputDataSource"/> to convert. </param>
        public static implicit operator RequestContent(DocumentDbOutputDataSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentDbOutputDataSource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentDbOutputDataSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentDbOutputDataSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
