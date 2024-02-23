// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ResourceGuardProxyBase : IUtf8JsonSerializable, IJsonModel<ResourceGuardProxyBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceGuardProxyBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceGuardProxyBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardProxyBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceGuardResourceId != null)
            {
                writer.WritePropertyName("resourceGuardResourceId"u8);
                writer.WriteStringValue(ResourceGuardResourceId);
            }
            if (!(ResourceGuardOperationDetails is ChangeTrackingList<ResourceGuardOperationDetail> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resourceGuardOperationDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LastUpdatedTime != null)
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedTime);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ResourceGuardProxyBase IJsonModel<ResourceGuardProxyBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardProxyBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceGuardProxyBase(document.RootElement, options);
        }

        internal static ResourceGuardProxyBase DeserializeResourceGuardProxyBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceGuardResourceId = default;
            Optional<IList<ResourceGuardOperationDetail>> resourceGuardOperationDetails = default;
            Optional<string> lastUpdatedTime = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGuardResourceId"u8))
                {
                    resourceGuardResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceGuardOperationDetail> array = new List<ResourceGuardOperationDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceGuardOperationDetail.DeserializeResourceGuardOperationDetail(item, options));
                    }
                    resourceGuardOperationDetails = array;
                    continue;
                }
                if (property.NameEquals("lastUpdatedTime"u8))
                {
                    lastUpdatedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceGuardProxyBase(resourceGuardResourceId.Value, Optional.ToList(resourceGuardOperationDetails), lastUpdatedTime.Value, description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceGuardProxyBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardProxyBase)} does not support '{options.Format}' format.");
            }
        }

        ResourceGuardProxyBase IPersistableModel<ResourceGuardProxyBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceGuardProxyBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardProxyBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceGuardProxyBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
