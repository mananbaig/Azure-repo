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
    [JsonConverter(typeof(LinkTableStatusConverter))]
    public partial class LinkTableStatus : IUtf8JsonSerializable, IModelJsonSerializable<LinkTableStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkTableStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkTableStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkTableStatus>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteObjectValue(StartTime);
            }
            if (Optional.IsDefined(StopTime))
            {
                writer.WritePropertyName("stopTime"u8);
                writer.WriteObjectValue(StopTime);
            }
            if (Optional.IsDefined(LinkTableId))
            {
                writer.WritePropertyName("linkTableId"u8);
                writer.WriteStringValue(LinkTableId);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(LastProcessedData))
            {
                writer.WritePropertyName("lastProcessedData"u8);
                writer.WriteStringValue(LastProcessedData.Value, "O");
            }
            if (Optional.IsDefined(LastTransactionCommitTime))
            {
                writer.WritePropertyName("lastTransactionCommitTime"u8);
                writer.WriteStringValue(LastTransactionCommitTime.Value, "O");
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

        internal static LinkTableStatus DeserializeLinkTableStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> status = default;
            Optional<string> errorMessage = default;
            Optional<object> startTime = default;
            Optional<object> stopTime = default;
            Optional<string> linkTableId = default;
            Optional<string> errorCode = default;
            Optional<DateTimeOffset> lastProcessedData = default;
            Optional<DateTimeOffset> lastTransactionCommitTime = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("stopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkTableId"u8))
                {
                    linkTableId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastProcessedData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastProcessedData = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTransactionCommitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTransactionCommitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkTableStatus(id.Value, status.Value, errorMessage.Value, startTime.Value, stopTime.Value, linkTableId.Value, errorCode.Value, Optional.ToNullable(lastProcessedData), Optional.ToNullable(lastTransactionCommitTime), serializedAdditionalRawData);
        }

        LinkTableStatus IModelJsonSerializable<LinkTableStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkTableStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkTableStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkTableStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkTableStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkTableStatus IModelSerializable<LinkTableStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkTableStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkTableStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkTableStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkTableStatus"/> to convert. </param>
        public static implicit operator RequestContent(LinkTableStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkTableStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkTableStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkTableStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class LinkTableStatusConverter : JsonConverter<LinkTableStatus>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableStatus model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkTableStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableStatus(document.RootElement);
            }
        }
    }
}
