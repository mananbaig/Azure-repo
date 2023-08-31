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
    public partial class MongoDBCollectionProgress : IUtf8JsonSerializable, IModelJsonSerializable<MongoDBCollectionProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MongoDBCollectionProgress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MongoDBCollectionProgress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBCollectionProgress>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("bytesCopied"u8);
            writer.WriteNumberValue(BytesCopied);
            writer.WritePropertyName("documentsCopied"u8);
            writer.WriteNumberValue(DocumentsCopied);
            writer.WritePropertyName("elapsedTime"u8);
            writer.WriteStringValue(ElapsedTime);
            writer.WritePropertyName("errors"u8);
            writer.WriteStartObject();
            foreach (var item in Errors)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MongoDBError>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            writer.WritePropertyName("eventsPending"u8);
            writer.WriteNumberValue(EventsPending);
            writer.WritePropertyName("eventsReplayed"u8);
            writer.WriteNumberValue(EventsReplayed);
            if (Optional.IsDefined(LastEventOn))
            {
                writer.WritePropertyName("lastEventTime"u8);
                writer.WriteStringValue(LastEventOn.Value, "O");
            }
            if (Optional.IsDefined(LastReplayOn))
            {
                writer.WritePropertyName("lastReplayTime"u8);
                writer.WriteStringValue(LastReplayOn.Value, "O");
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(QualifiedName))
            {
                writer.WritePropertyName("qualifiedName"u8);
                writer.WriteStringValue(QualifiedName);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType.ToString());
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToString());
            writer.WritePropertyName("totalBytes"u8);
            writer.WriteNumberValue(TotalBytes);
            writer.WritePropertyName("totalDocuments"u8);
            writer.WriteNumberValue(TotalDocuments);
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

        internal static MongoDBCollectionProgress DeserializeMongoDBCollectionProgress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long bytesCopied = default;
            long documentsCopied = default;
            string elapsedTime = default;
            IReadOnlyDictionary<string, MongoDBError> errors = default;
            long eventsPending = default;
            long eventsReplayed = default;
            Optional<DateTimeOffset> lastEventTime = default;
            Optional<DateTimeOffset> lastReplayTime = default;
            Optional<string> name = default;
            Optional<string> qualifiedName = default;
            MongoDBProgressResultType resultType = default;
            MongoDBMigrationState state = default;
            long totalBytes = default;
            long totalDocuments = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bytesCopied"u8))
                {
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentsCopied"u8))
                {
                    documentsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("elapsedTime"u8))
                {
                    elapsedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    Dictionary<string, MongoDBError> dictionary = new Dictionary<string, MongoDBError>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBError.DeserializeMongoDBError(property0.Value));
                    }
                    errors = dictionary;
                    continue;
                }
                if (property.NameEquals("eventsPending"u8))
                {
                    eventsPending = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("eventsReplayed"u8))
                {
                    eventsReplayed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastReplayTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplayTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = new MongoDBProgressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new MongoDBMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalBytes"u8))
                {
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDocuments"u8))
                {
                    totalDocuments = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MongoDBCollectionProgress(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, Optional.ToNullable(lastEventTime), Optional.ToNullable(lastReplayTime), name.Value, qualifiedName.Value, resultType, state, totalBytes, totalDocuments, rawData);
        }

        MongoDBCollectionProgress IModelJsonSerializable<MongoDBCollectionProgress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBCollectionProgress>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBCollectionProgress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MongoDBCollectionProgress>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBCollectionProgress>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MongoDBCollectionProgress IModelSerializable<MongoDBCollectionProgress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBCollectionProgress>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMongoDBCollectionProgress(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MongoDBCollectionProgress"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MongoDBCollectionProgress"/> to convert. </param>
        public static implicit operator RequestContent(MongoDBCollectionProgress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MongoDBCollectionProgress"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MongoDBCollectionProgress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMongoDBCollectionProgress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
