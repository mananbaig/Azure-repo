// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountAssemblyProperties : IUtf8JsonSerializable, IJsonModel<IntegrationAccountAssemblyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountAssemblyProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationAccountAssemblyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAssemblyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assemblyName"u8);
            writer.WriteStringValue(AssemblyName);
            if (Optional.IsDefined(AssemblyVersion))
            {
                writer.WritePropertyName("assemblyVersion"u8);
                writer.WriteStringValue(AssemblyVersion);
            }
            if (Optional.IsDefined(AssemblyCulture))
            {
                writer.WritePropertyName("assemblyCulture"u8);
                writer.WriteStringValue(AssemblyCulture);
            }
            if (Optional.IsDefined(AssemblyPublicKeyToken))
            {
                writer.WritePropertyName("assemblyPublicKeyToken"u8);
                writer.WriteStringValue(AssemblyPublicKeyToken);
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Content);
#else
                using (JsonDocument document = JsonDocument.Parse(Content))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType.Value.ToString());
            }
            if (Optional.IsDefined(ContentLink))
            {
                writer.WritePropertyName("contentLink"u8);
                writer.WriteObjectValue(ContentLink, options);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ChangedOn))
            {
                writer.WritePropertyName("changedTime"u8);
                writer.WriteStringValue(ChangedOn.Value, "O");
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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
            writer.WriteEndObject();
        }

        IntegrationAccountAssemblyProperties IJsonModel<IntegrationAccountAssemblyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAssemblyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountAssemblyProperties(document.RootElement, options);
        }

        internal static IntegrationAccountAssemblyProperties DeserializeIntegrationAccountAssemblyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assemblyName = default;
            string assemblyVersion = default;
            string assemblyCulture = default;
            string assemblyPublicKeyToken = default;
            BinaryData content = default;
            ContentType? contentType = default;
            LogicContentLink contentLink = default;
            DateTimeOffset? createdTime = default;
            DateTimeOffset? changedTime = default;
            BinaryData metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assemblyName"u8))
                {
                    assemblyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyVersion"u8))
                {
                    assemblyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyCulture"u8))
                {
                    assemblyCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyPublicKeyToken"u8))
                {
                    assemblyPublicKeyToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentType = new ContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentLink = LogicContentLink.DeserializeLogicContentLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("changedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationAccountAssemblyProperties(
                createdTime,
                changedTime,
                metadata,
                serializedAdditionalRawData,
                content,
                contentType,
                contentLink,
                assemblyName,
                assemblyVersion,
                assemblyCulture,
                assemblyPublicKeyToken);
        }

        BinaryData IPersistableModel<IntegrationAccountAssemblyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAssemblyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationAccountAssemblyProperties IPersistableModel<IntegrationAccountAssemblyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountAssemblyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountAssemblyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountAssemblyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountAssemblyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
