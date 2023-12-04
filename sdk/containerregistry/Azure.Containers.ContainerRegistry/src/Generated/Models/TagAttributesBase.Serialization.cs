// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class TagAttributesBase : IUtf8JsonSerializable, IJsonModel<TagAttributesBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TagAttributesBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TagAttributesBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TagAttributesBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TagAttributesBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("digest"u8);
                writer.WriteStringValue(Digest);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("lastUpdateTime"u8);
                writer.WriteStringValue(LastUpdatedOn, "O");
            }
            writer.WritePropertyName("changeableAttributes"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CanDelete))
            {
                writer.WritePropertyName("deleteEnabled"u8);
                writer.WriteBooleanValue(CanDelete.Value);
            }
            if (Optional.IsDefined(CanWrite))
            {
                writer.WritePropertyName("writeEnabled"u8);
                writer.WriteBooleanValue(CanWrite.Value);
            }
            if (Optional.IsDefined(CanList))
            {
                writer.WritePropertyName("listEnabled"u8);
                writer.WriteBooleanValue(CanList.Value);
            }
            if (Optional.IsDefined(CanRead))
            {
                writer.WritePropertyName("readEnabled"u8);
                writer.WriteBooleanValue(CanRead.Value);
            }
            writer.WriteEndObject();
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

        TagAttributesBase IJsonModel<TagAttributesBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TagAttributesBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TagAttributesBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTagAttributesBase(document.RootElement, options);
        }

        internal static TagAttributesBase DeserializeTagAttributesBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string digest = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            Optional<bool> deleteEnabled = default;
            Optional<bool> writeEnabled = default;
            Optional<bool> listEnabled = default;
            Optional<bool> readEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"u8))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("changeableAttributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("deleteEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("writeEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            writeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("listEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            listEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("readEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TagAttributesBase(name, digest, createdTime, lastUpdateTime, Optional.ToNullable(deleteEnabled), Optional.ToNullable(writeEnabled), Optional.ToNullable(listEnabled), Optional.ToNullable(readEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TagAttributesBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TagAttributesBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(TagAttributesBase)} does not support '{options.Format}' format.");
            }
        }

        TagAttributesBase IPersistableModel<TagAttributesBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TagAttributesBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTagAttributesBase(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(TagAttributesBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TagAttributesBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
