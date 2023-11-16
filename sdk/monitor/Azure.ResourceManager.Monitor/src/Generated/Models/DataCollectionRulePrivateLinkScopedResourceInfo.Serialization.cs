// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRulePrivateLinkScopedResourceInfo : IUtf8JsonSerializable, IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ScopeId))
            {
                writer.WritePropertyName("scopeId"u8);
                writer.WriteStringValue(ScopeId);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        DataCollectionRulePrivateLinkScopedResourceInfo IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(document.RootElement, options);
        }

        internal static DataCollectionRulePrivateLinkScopedResourceInfo DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> scopeId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scopeId"u8))
                {
                    scopeId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRulePrivateLinkScopedResourceInfo(resourceId.Value, scopeId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataCollectionRulePrivateLinkScopedResourceInfo IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(document.RootElement, options);
        }

        string IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
