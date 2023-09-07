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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NamespaceSharedAccessKeys : IUtf8JsonSerializable, IModelJsonSerializable<NamespaceSharedAccessKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NamespaceSharedAccessKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NamespaceSharedAccessKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamespaceSharedAccessKeys>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Key1))
            {
                writer.WritePropertyName("key1"u8);
                writer.WriteStringValue(Key1);
            }
            if (Optional.IsDefined(Key2))
            {
                writer.WritePropertyName("key2"u8);
                writer.WriteStringValue(Key2);
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

        internal static NamespaceSharedAccessKeys DeserializeNamespaceSharedAccessKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key1 = default;
            Optional<string> key2 = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"u8))
                {
                    key1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NamespaceSharedAccessKeys(key1.Value, key2.Value, serializedAdditionalRawData);
        }

        NamespaceSharedAccessKeys IModelJsonSerializable<NamespaceSharedAccessKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamespaceSharedAccessKeys>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNamespaceSharedAccessKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NamespaceSharedAccessKeys>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamespaceSharedAccessKeys>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NamespaceSharedAccessKeys IModelSerializable<NamespaceSharedAccessKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamespaceSharedAccessKeys>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNamespaceSharedAccessKeys(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NamespaceSharedAccessKeys"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NamespaceSharedAccessKeys"/> to convert. </param>
        public static implicit operator RequestContent(NamespaceSharedAccessKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NamespaceSharedAccessKeys"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NamespaceSharedAccessKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNamespaceSharedAccessKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
