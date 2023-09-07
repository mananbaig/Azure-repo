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

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class CsmUsageQuotaListResult : IUtf8JsonSerializable, IModelJsonSerializable<CsmUsageQuotaListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CsmUsageQuotaListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CsmUsageQuotaListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmUsageQuotaListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CsmUsageQuota>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static CsmUsageQuotaListResult DeserializeCsmUsageQuotaListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CsmUsageQuota> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<CsmUsageQuota> array = new List<CsmUsageQuota>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CsmUsageQuota.DeserializeCsmUsageQuota(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CsmUsageQuotaListResult(value, nextLink.Value, serializedAdditionalRawData);
        }

        CsmUsageQuotaListResult IModelJsonSerializable<CsmUsageQuotaListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmUsageQuotaListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCsmUsageQuotaListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CsmUsageQuotaListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmUsageQuotaListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CsmUsageQuotaListResult IModelSerializable<CsmUsageQuotaListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CsmUsageQuotaListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCsmUsageQuotaListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CsmUsageQuotaListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CsmUsageQuotaListResult"/> to convert. </param>
        public static implicit operator RequestContent(CsmUsageQuotaListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CsmUsageQuotaListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CsmUsageQuotaListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCsmUsageQuotaListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
