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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ManagedInstancePrivateLinkListResult : IUtf8JsonSerializable, IModelJsonSerializable<ManagedInstancePrivateLinkListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedInstancePrivateLinkListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedInstancePrivateLinkListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateLinkListResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ManagedInstancePrivateLinkListResult DeserializeManagedInstancePrivateLinkListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ManagedInstancePrivateLinkData>> value = default;
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
                    List<ManagedInstancePrivateLinkData> array = new List<ManagedInstancePrivateLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstancePrivateLinkData.DeserializeManagedInstancePrivateLinkData(item));
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
            return new ManagedInstancePrivateLinkListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        ManagedInstancePrivateLinkListResult IModelJsonSerializable<ManagedInstancePrivateLinkListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateLinkListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstancePrivateLinkListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedInstancePrivateLinkListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateLinkListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedInstancePrivateLinkListResult IModelSerializable<ManagedInstancePrivateLinkListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateLinkListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedInstancePrivateLinkListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedInstancePrivateLinkListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedInstancePrivateLinkListResult"/> to convert. </param>
        public static implicit operator RequestContent(ManagedInstancePrivateLinkListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedInstancePrivateLinkListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedInstancePrivateLinkListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedInstancePrivateLinkListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
