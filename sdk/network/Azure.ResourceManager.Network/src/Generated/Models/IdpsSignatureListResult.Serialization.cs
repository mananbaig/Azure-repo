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

namespace Azure.ResourceManager.Network.Models
{
    public partial class IdpsSignatureListResult : IUtf8JsonSerializable, IModelJsonSerializable<IdpsSignatureListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IdpsSignatureListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IdpsSignatureListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MatchingRecordsCount))
            {
                writer.WritePropertyName("matchingRecordsCount"u8);
                writer.WriteNumberValue(MatchingRecordsCount.Value);
            }
            if (Optional.IsCollectionDefined(Signatures))
            {
                writer.WritePropertyName("signatures"u8);
                writer.WriteStartArray();
                foreach (var item in Signatures)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IdpsSignatureResult>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static IdpsSignatureListResult DeserializeIdpsSignatureListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> matchingRecordsCount = default;
            Optional<IReadOnlyList<IdpsSignatureResult>> signatures = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchingRecordsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchingRecordsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("signatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdpsSignatureResult> array = new List<IdpsSignatureResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IdpsSignatureResult.DeserializeIdpsSignatureResult(item));
                    }
                    signatures = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IdpsSignatureListResult(Optional.ToNullable(matchingRecordsCount), Optional.ToList(signatures), rawData);
        }

        IdpsSignatureListResult IModelJsonSerializable<IdpsSignatureListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIdpsSignatureListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IdpsSignatureListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IdpsSignatureListResult IModelSerializable<IdpsSignatureListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIdpsSignatureListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IdpsSignatureListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IdpsSignatureListResult"/> to convert. </param>
        public static implicit operator RequestContent(IdpsSignatureListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IdpsSignatureListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IdpsSignatureListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIdpsSignatureListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
