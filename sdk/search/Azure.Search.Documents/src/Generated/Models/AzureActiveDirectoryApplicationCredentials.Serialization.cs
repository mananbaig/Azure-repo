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

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class AzureActiveDirectoryApplicationCredentials : IUtf8JsonSerializable, IModelJsonSerializable<AzureActiveDirectoryApplicationCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureActiveDirectoryApplicationCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureActiveDirectoryApplicationCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureActiveDirectoryApplicationCredentials>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("applicationId"u8);
            writer.WriteStringValue(ApplicationId);
            if (Optional.IsDefined(ApplicationSecret))
            {
                writer.WritePropertyName("applicationSecret"u8);
                writer.WriteStringValue(ApplicationSecret);
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

        internal static AzureActiveDirectoryApplicationCredentials DeserializeAzureActiveDirectoryApplicationCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string applicationId = default;
            Optional<string> applicationSecret = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationSecret"u8))
                {
                    applicationSecret = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureActiveDirectoryApplicationCredentials(applicationId, applicationSecret.Value, serializedAdditionalRawData);
        }

        AzureActiveDirectoryApplicationCredentials IModelJsonSerializable<AzureActiveDirectoryApplicationCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureActiveDirectoryApplicationCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureActiveDirectoryApplicationCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureActiveDirectoryApplicationCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureActiveDirectoryApplicationCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureActiveDirectoryApplicationCredentials IModelSerializable<AzureActiveDirectoryApplicationCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureActiveDirectoryApplicationCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureActiveDirectoryApplicationCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureActiveDirectoryApplicationCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureActiveDirectoryApplicationCredentials"/> to convert. </param>
        public static implicit operator RequestContent(AzureActiveDirectoryApplicationCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureActiveDirectoryApplicationCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureActiveDirectoryApplicationCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureActiveDirectoryApplicationCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
