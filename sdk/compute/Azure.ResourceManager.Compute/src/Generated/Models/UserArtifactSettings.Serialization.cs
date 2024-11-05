// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UserArtifactSettings : IUtf8JsonSerializable, IJsonModel<UserArtifactSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserArtifactSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserArtifactSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserArtifactSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PackageFileName))
            {
                writer.WritePropertyName("packageFileName"u8);
                writer.WriteStringValue(PackageFileName);
            }
            if (Optional.IsDefined(ConfigFileName))
            {
                writer.WritePropertyName("configFileName"u8);
                writer.WriteStringValue(ConfigFileName);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
        }

        UserArtifactSettings IJsonModel<UserArtifactSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserArtifactSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserArtifactSettings(document.RootElement, options);
        }

        internal static UserArtifactSettings DeserializeUserArtifactSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string packageFileName = default;
            string configFileName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packageFileName"u8))
                {
                    packageFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configFileName"u8))
                {
                    configFileName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserArtifactSettings(packageFileName, configFileName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserArtifactSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserArtifactSettings)} does not support writing '{options.Format}' format.");
            }
        }

        UserArtifactSettings IPersistableModel<UserArtifactSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserArtifactSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserArtifactSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserArtifactSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
