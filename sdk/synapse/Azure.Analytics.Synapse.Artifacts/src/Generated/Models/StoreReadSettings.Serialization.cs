// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(StoreReadSettingsConverter))]
    public partial class StoreReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue<object>(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static StoreReadSettings DeserializeStoreReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3ReadSettings": return AmazonS3ReadSettings.DeserializeAmazonS3ReadSettings(element);
                    case "AzureBlobFSReadSettings": return AzureBlobFSReadSettings.DeserializeAzureBlobFSReadSettings(element);
                    case "AzureBlobStorageReadSettings": return AzureBlobStorageReadSettings.DeserializeAzureBlobStorageReadSettings(element);
                    case "AzureDataLakeStoreReadSettings": return AzureDataLakeStoreReadSettings.DeserializeAzureDataLakeStoreReadSettings(element);
                    case "AzureFileStorageReadSettings": return AzureFileStorageReadSettings.DeserializeAzureFileStorageReadSettings(element);
                    case "FileServerReadSettings": return FileServerReadSettings.DeserializeFileServerReadSettings(element);
                    case "FtpReadSettings": return FtpReadSettings.DeserializeFtpReadSettings(element);
                    case "GoogleCloudStorageReadSettings": return GoogleCloudStorageReadSettings.DeserializeGoogleCloudStorageReadSettings(element);
                    case "HdfsReadSettings": return HdfsReadSettings.DeserializeHdfsReadSettings(element);
                    case "HttpReadSettings": return HttpReadSettings.DeserializeHttpReadSettings(element);
                    case "LakeHouseReadSettings": return LakeHouseReadSettings.DeserializeLakeHouseReadSettings(element);
                    case "SftpReadSettings": return SftpReadSettings.DeserializeSftpReadSettings(element);
                }
            }
            return UnknownStoreReadSettings.DeserializeUnknownStoreReadSettings(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StoreReadSettings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStoreReadSettings(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class StoreReadSettingsConverter : JsonConverter<StoreReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, StoreReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override StoreReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStoreReadSettings(document.RootElement);
            }
        }
    }
}
