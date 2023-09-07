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
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    internal partial class UsagesLimits : IUtf8JsonSerializable, IModelJsonSerializable<UsagesLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UsagesLimits>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UsagesLimits>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UsagesLimits>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
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
                        ((IModelJsonSerializable<CurrentUsagesBaseData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static UsagesLimits DeserializeUsagesLimits(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CurrentUsagesBaseData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CurrentUsagesBaseData> array = new List<CurrentUsagesBaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CurrentUsagesBaseData.DeserializeCurrentUsagesBaseData(item));
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
            return new UsagesLimits(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        UsagesLimits IModelJsonSerializable<UsagesLimits>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UsagesLimits>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUsagesLimits(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UsagesLimits>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UsagesLimits>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UsagesLimits IModelSerializable<UsagesLimits>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UsagesLimits>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUsagesLimits(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UsagesLimits"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UsagesLimits"/> to convert. </param>
        public static implicit operator RequestContent(UsagesLimits model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UsagesLimits"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UsagesLimits(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUsagesLimits(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
