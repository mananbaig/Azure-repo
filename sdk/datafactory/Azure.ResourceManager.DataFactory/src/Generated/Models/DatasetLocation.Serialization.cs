// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownDatasetLocation))]
    public partial class DatasetLocation : IUtf8JsonSerializable, IJsonModel<DatasetLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatasetLocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatasetLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetLocation)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetLocationType);
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                JsonSerializer.Serialize(writer, FolderPath);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                JsonSerializer.Serialize(writer, FileName);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }

        DatasetLocation IJsonModel<DatasetLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetLocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetLocation(document.RootElement, options);
        }

        internal static DatasetLocation DeserializeDatasetLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3CompatibleLocation": return AmazonS3CompatibleLocation.DeserializeAmazonS3CompatibleLocation(element, options);
                    case "AmazonS3Location": return AmazonS3Location.DeserializeAmazonS3Location(element, options);
                    case "AzureBlobFSLocation": return AzureBlobFSLocation.DeserializeAzureBlobFSLocation(element, options);
                    case "AzureBlobStorageLocation": return AzureBlobStorageLocation.DeserializeAzureBlobStorageLocation(element, options);
                    case "AzureDataLakeStoreLocation": return AzureDataLakeStoreLocation.DeserializeAzureDataLakeStoreLocation(element, options);
                    case "AzureFileStorageLocation": return AzureFileStorageLocation.DeserializeAzureFileStorageLocation(element, options);
                    case "FileServerLocation": return FileServerLocation.DeserializeFileServerLocation(element, options);
                    case "FtpServerLocation": return FtpServerLocation.DeserializeFtpServerLocation(element, options);
                    case "GoogleCloudStorageLocation": return GoogleCloudStorageLocation.DeserializeGoogleCloudStorageLocation(element, options);
                    case "HdfsLocation": return HdfsLocation.DeserializeHdfsLocation(element, options);
                    case "HttpServerLocation": return HttpServerLocation.DeserializeHttpServerLocation(element, options);
                    case "LakeHouseLocation": return LakeHouseLocation.DeserializeLakeHouseLocation(element, options);
                    case "OracleCloudStorageLocation": return OracleCloudStorageLocation.DeserializeOracleCloudStorageLocation(element, options);
                    case "SftpLocation": return SftpLocation.DeserializeSftpLocation(element, options);
                }
            }
            return UnknownDatasetLocation.DeserializeUnknownDatasetLocation(element, options);
        }

        BinaryData IPersistableModel<DatasetLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatasetLocation)} does not support writing '{options.Format}' format.");
            }
        }

        DatasetLocation IPersistableModel<DatasetLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatasetLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatasetLocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatasetLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
