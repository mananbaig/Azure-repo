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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeEndpoint : IUtf8JsonSerializable, IJsonModel<ResourceTypeEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeEndpoint>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ResourceTypeEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ResourceTypeEndpoint>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ResourceTypeEndpoint>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
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

        ResourceTypeEndpoint IJsonModel<ResourceTypeEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceTypeEndpoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeEndpoint(document.RootElement, options);
        }

        internal static ResourceTypeEndpoint DeserializeResourceTypeEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<IList<string>> apiVersions = default;
            Optional<IList<AzureLocation>> locations = default;
            Optional<IList<string>> requiredFeatures = default;
            Optional<FeaturesRule> featuresRule = default;
            Optional<IList<ResourceTypeExtension>> extensions = default;
            Optional<TimeSpan> timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeExtension> array = new List<ResourceTypeExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeExtension.DeserializeResourceTypeExtension(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceTypeEndpoint(Optional.ToNullable(enabled), Optional.ToList(apiVersions), Optional.ToList(locations), Optional.ToList(requiredFeatures), featuresRule.Value, Optional.ToList(extensions), Optional.ToNullable(timeout), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceTypeEndpoint>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceTypeEndpoint)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ResourceTypeEndpoint IPersistableModel<ResourceTypeEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceTypeEndpoint)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeResourceTypeEndpoint(document.RootElement, options);
        }

        string IPersistableModel<ResourceTypeEndpoint>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
