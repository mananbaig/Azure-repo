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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecureScoreControlDefinitionList : IUtf8JsonSerializable, IModelJsonSerializable<SecureScoreControlDefinitionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecureScoreControlDefinitionList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecureScoreControlDefinitionList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDefinitionList>(this, options.Format);

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

        internal static SecureScoreControlDefinitionList DeserializeSecureScoreControlDefinitionList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SecureScoreControlDefinitionItem>> value = default;
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
                    List<SecureScoreControlDefinitionItem> array = new List<SecureScoreControlDefinitionItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecureScoreControlDefinitionItem.DeserializeSecureScoreControlDefinitionItem(item));
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
            return new SecureScoreControlDefinitionList(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        SecureScoreControlDefinitionList IModelJsonSerializable<SecureScoreControlDefinitionList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDefinitionList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecureScoreControlDefinitionList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecureScoreControlDefinitionList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDefinitionList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecureScoreControlDefinitionList IModelSerializable<SecureScoreControlDefinitionList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDefinitionList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecureScoreControlDefinitionList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecureScoreControlDefinitionList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecureScoreControlDefinitionList"/> to convert. </param>
        public static implicit operator RequestContent(SecureScoreControlDefinitionList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecureScoreControlDefinitionList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecureScoreControlDefinitionList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecureScoreControlDefinitionList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
