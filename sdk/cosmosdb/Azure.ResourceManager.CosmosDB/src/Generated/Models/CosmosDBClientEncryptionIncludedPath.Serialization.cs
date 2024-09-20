// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBClientEncryptionIncludedPath : IUtf8JsonSerializable, IJsonModel<CosmosDBClientEncryptionIncludedPath>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBClientEncryptionIncludedPath>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBClientEncryptionIncludedPath>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionIncludedPath>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBClientEncryptionIncludedPath)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("path"u8);
            writer.WriteStringValue(Path);
            writer.WritePropertyName("clientEncryptionKeyId"u8);
            writer.WriteStringValue(ClientEncryptionKeyId);
            writer.WritePropertyName("encryptionType"u8);
            writer.WriteStringValue(EncryptionType);
            writer.WritePropertyName("encryptionAlgorithm"u8);
            writer.WriteStringValue(EncryptionAlgorithm);
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
            writer.WriteEndObject();
        }

        CosmosDBClientEncryptionIncludedPath IJsonModel<CosmosDBClientEncryptionIncludedPath>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionIncludedPath>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBClientEncryptionIncludedPath)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBClientEncryptionIncludedPath(document.RootElement, options);
        }

        internal static CosmosDBClientEncryptionIncludedPath DeserializeCosmosDBClientEncryptionIncludedPath(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            string clientEncryptionKeyId = default;
            string encryptionType = default;
            string encryptionAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientEncryptionKeyId"u8))
                {
                    clientEncryptionKeyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionType"u8))
                {
                    encryptionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBClientEncryptionIncludedPath(path, clientEncryptionKeyId, encryptionType, encryptionAlgorithm, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Path), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  path: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Path))
                {
                    builder.Append("  path: ");
                    if (Path.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Path}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Path}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientEncryptionKeyId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientEncryptionKeyId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientEncryptionKeyId))
                {
                    builder.Append("  clientEncryptionKeyId: ");
                    if (ClientEncryptionKeyId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientEncryptionKeyId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientEncryptionKeyId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EncryptionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  encryptionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EncryptionType))
                {
                    builder.Append("  encryptionType: ");
                    if (EncryptionType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EncryptionType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EncryptionType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EncryptionAlgorithm), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  encryptionAlgorithm: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EncryptionAlgorithm))
                {
                    builder.Append("  encryptionAlgorithm: ");
                    if (EncryptionAlgorithm.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EncryptionAlgorithm}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EncryptionAlgorithm}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBClientEncryptionIncludedPath>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionIncludedPath>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBClientEncryptionIncludedPath)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBClientEncryptionIncludedPath IPersistableModel<CosmosDBClientEncryptionIncludedPath>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBClientEncryptionIncludedPath>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBClientEncryptionIncludedPath(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBClientEncryptionIncludedPath)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBClientEncryptionIncludedPath>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
