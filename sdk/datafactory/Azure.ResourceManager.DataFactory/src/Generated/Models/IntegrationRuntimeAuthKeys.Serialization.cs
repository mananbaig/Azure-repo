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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeAuthKeys : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationRuntimeAuthKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationRuntimeAuthKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationRuntimeAuthKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthKey1))
            {
                writer.WritePropertyName("authKey1"u8);
                writer.WriteStringValue(AuthKey1);
            }
            if (Optional.IsDefined(AuthKey2))
            {
                writer.WritePropertyName("authKey2"u8);
                writer.WriteStringValue(AuthKey2);
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

        internal static IntegrationRuntimeAuthKeys DeserializeIntegrationRuntimeAuthKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> authKey1 = default;
            Optional<string> authKey2 = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authKey1"u8))
                {
                    authKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authKey2"u8))
                {
                    authKey2 = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationRuntimeAuthKeys(authKey1.Value, authKey2.Value, rawData);
        }

        IntegrationRuntimeAuthKeys IModelJsonSerializable<IntegrationRuntimeAuthKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeAuthKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationRuntimeAuthKeys>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationRuntimeAuthKeys IModelSerializable<IntegrationRuntimeAuthKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationRuntimeAuthKeys(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IntegrationRuntimeAuthKeys"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IntegrationRuntimeAuthKeys"/> to convert. </param>
        public static implicit operator RequestContent(IntegrationRuntimeAuthKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IntegrationRuntimeAuthKeys"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IntegrationRuntimeAuthKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationRuntimeAuthKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
