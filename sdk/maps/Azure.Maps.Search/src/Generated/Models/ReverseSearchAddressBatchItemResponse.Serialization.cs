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
    public partial class ReverseSearchAddressBatchItemResponse : IUtf8JsonSerializable, IModelJsonSerializable<ReverseSearchAddressBatchItemResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReverseSearchAddressBatchItemResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReverseSearchAddressBatchItemResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItemResponse>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorDetail))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(ErrorDetail);
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

        internal static ReverseSearchAddressBatchItemResponse DeserializeReverseSearchAddressBatchItemResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ErrorDetail> error = default;
            Optional<SearchSummary> summary = default;
            Optional<IReadOnlyList<ReverseSearchAddressItem>> addresses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = Models.ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = SearchSummary.DeserializeSearchSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReverseSearchAddressItem> array = new List<ReverseSearchAddressItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReverseSearchAddressItem.DeserializeReverseSearchAddressItem(item));
                    }
                    addresses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReverseSearchAddressBatchItemResponse(summary.Value, Optional.ToList(addresses), error.Value, rawData);
        }

        ReverseSearchAddressBatchItemResponse IModelJsonSerializable<ReverseSearchAddressBatchItemResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItemResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseSearchAddressBatchItemResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReverseSearchAddressBatchItemResponse>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItemResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReverseSearchAddressBatchItemResponse IModelSerializable<ReverseSearchAddressBatchItemResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReverseSearchAddressBatchItemResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReverseSearchAddressBatchItemResponse(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ReverseSearchAddressBatchItemResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ReverseSearchAddressBatchItemResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReverseSearchAddressBatchItemResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
