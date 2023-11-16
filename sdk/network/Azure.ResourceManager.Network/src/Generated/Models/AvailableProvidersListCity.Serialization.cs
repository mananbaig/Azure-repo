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

namespace Azure.ResourceManager.Network.Models
{
    public partial class AvailableProvidersListCity : IUtf8JsonSerializable, IJsonModel<AvailableProvidersListCity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableProvidersListCity>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AvailableProvidersListCity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AvailableProvidersListCity>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AvailableProvidersListCity>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CityName))
            {
                writer.WritePropertyName("cityName"u8);
                writer.WriteStringValue(CityName);
            }
            if (Optional.IsCollectionDefined(Providers))
            {
                writer.WritePropertyName("providers"u8);
                writer.WriteStartArray();
                foreach (var item in Providers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AvailableProvidersListCity IJsonModel<AvailableProvidersListCity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailableProvidersListCity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableProvidersListCity(document.RootElement, options);
        }

        internal static AvailableProvidersListCity DeserializeAvailableProvidersListCity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cityName = default;
            Optional<IReadOnlyList<string>> providers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cityName"u8))
                {
                    cityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providers"u8))
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
                    providers = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailableProvidersListCity(cityName.Value, Optional.ToList(providers), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableProvidersListCity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailableProvidersListCity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvailableProvidersListCity IPersistableModel<AvailableProvidersListCity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailableProvidersListCity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvailableProvidersListCity(document.RootElement, options);
        }

        string IPersistableModel<AvailableProvidersListCity>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
