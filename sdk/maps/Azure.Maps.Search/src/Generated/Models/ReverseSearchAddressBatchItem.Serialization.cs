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

namespace Azure.Maps.Search.Models
{
    internal partial class ReverseSearchAddressBatchItem : IUtf8JsonSerializable, IModelJsonSerializable<ReverseSearchAddressBatchItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReverseSearchAddressBatchItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReverseSearchAddressBatchItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItem>(this, options.Format);

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

        internal static ReverseSearchAddressBatchItem DeserializeReverseSearchAddressBatchItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReverseSearchAddressBatchItemResponse> response = default;
            Optional<int> statusCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = ReverseSearchAddressBatchItemResponse.DeserializeReverseSearchAddressBatchItemResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReverseSearchAddressBatchItem(Optional.ToNullable(statusCode), response.Value, rawData);
        }

        ReverseSearchAddressBatchItem IModelJsonSerializable<ReverseSearchAddressBatchItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseSearchAddressBatchItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReverseSearchAddressBatchItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReverseSearchAddressBatchItem IModelSerializable<ReverseSearchAddressBatchItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReverseSearchAddressBatchItem(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ReverseSearchAddressBatchItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ReverseSearchAddressBatchItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReverseSearchAddressBatchItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
