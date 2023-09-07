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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class DiagnosticsStorageAccountConfig : IUtf8JsonSerializable, IModelJsonSerializable<DiagnosticsStorageAccountConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiagnosticsStorageAccountConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiagnosticsStorageAccountConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticsStorageAccountConfig>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountName"u8);
            writer.WriteStringValue(StorageAccountName);
            writer.WritePropertyName("protectedAccountKeyName"u8);
            writer.WriteStringValue(ProtectedAccountKeyName);
            if (Optional.IsDefined(ProtectedAccountKeyName2))
            {
                writer.WritePropertyName("protectedAccountKeyName2"u8);
                writer.WriteStringValue(ProtectedAccountKeyName2);
            }
            writer.WritePropertyName("blobEndpoint"u8);
            writer.WriteStringValue(BlobEndpoint.AbsoluteUri);
            writer.WritePropertyName("queueEndpoint"u8);
            writer.WriteStringValue(QueueEndpoint.AbsoluteUri);
            writer.WritePropertyName("tableEndpoint"u8);
            writer.WriteStringValue(TableEndpoint.AbsoluteUri);
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

        internal static DiagnosticsStorageAccountConfig DeserializeDiagnosticsStorageAccountConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccountName = default;
            string protectedAccountKeyName = default;
            Optional<string> protectedAccountKeyName2 = default;
            Uri blobEndpoint = default;
            Uri queueEndpoint = default;
            Uri tableEndpoint = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedAccountKeyName"u8))
                {
                    protectedAccountKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedAccountKeyName2"u8))
                {
                    protectedAccountKeyName2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobEndpoint"u8))
                {
                    blobEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queueEndpoint"u8))
                {
                    queueEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tableEndpoint"u8))
                {
                    tableEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiagnosticsStorageAccountConfig(storageAccountName, protectedAccountKeyName, protectedAccountKeyName2.Value, blobEndpoint, queueEndpoint, tableEndpoint, serializedAdditionalRawData);
        }

        DiagnosticsStorageAccountConfig IModelJsonSerializable<DiagnosticsStorageAccountConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticsStorageAccountConfig>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticsStorageAccountConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiagnosticsStorageAccountConfig>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticsStorageAccountConfig>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiagnosticsStorageAccountConfig IModelSerializable<DiagnosticsStorageAccountConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticsStorageAccountConfig>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiagnosticsStorageAccountConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiagnosticsStorageAccountConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiagnosticsStorageAccountConfig"/> to convert. </param>
        public static implicit operator RequestContent(DiagnosticsStorageAccountConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiagnosticsStorageAccountConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiagnosticsStorageAccountConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiagnosticsStorageAccountConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
