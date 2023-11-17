// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceNewKubernetesVersionAvailableEventDataConverter))]
    public partial class ContainerServiceNewKubernetesVersionAvailableEventData : IUtf8JsonSerializable, IJsonModel<ContainerServiceNewKubernetesVersionAvailableEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceNewKubernetesVersionAvailableEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceNewKubernetesVersionAvailableEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContainerServiceNewKubernetesVersionAvailableEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContainerServiceNewKubernetesVersionAvailableEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LatestSupportedKubernetesVersion))
            {
                writer.WritePropertyName("latestSupportedKubernetesVersion"u8);
                writer.WriteStringValue(LatestSupportedKubernetesVersion);
            }
            if (Optional.IsDefined(LatestStableKubernetesVersion))
            {
                writer.WritePropertyName("latestStableKubernetesVersion"u8);
                writer.WriteStringValue(LatestStableKubernetesVersion);
            }
            if (Optional.IsDefined(LowestMinorKubernetesVersion))
            {
                writer.WritePropertyName("lowestMinorKubernetesVersion"u8);
                writer.WriteStringValue(LowestMinorKubernetesVersion);
            }
            if (Optional.IsDefined(LatestPreviewKubernetesVersion))
            {
                writer.WritePropertyName("latestPreviewKubernetesVersion"u8);
                writer.WriteStringValue(LatestPreviewKubernetesVersion);
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

        ContainerServiceNewKubernetesVersionAvailableEventData IJsonModel<ContainerServiceNewKubernetesVersionAvailableEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerServiceNewKubernetesVersionAvailableEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceNewKubernetesVersionAvailableEventData(document.RootElement, options);
        }

        internal static ContainerServiceNewKubernetesVersionAvailableEventData DeserializeContainerServiceNewKubernetesVersionAvailableEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> latestSupportedKubernetesVersion = default;
            Optional<string> latestStableKubernetesVersion = default;
            Optional<string> lowestMinorKubernetesVersion = default;
            Optional<string> latestPreviewKubernetesVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latestSupportedKubernetesVersion"u8))
                {
                    latestSupportedKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestStableKubernetesVersion"u8))
                {
                    latestStableKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lowestMinorKubernetesVersion"u8))
                {
                    lowestMinorKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestPreviewKubernetesVersion"u8))
                {
                    latestPreviewKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceNewKubernetesVersionAvailableEventData(latestSupportedKubernetesVersion.Value, latestStableKubernetesVersion.Value, lowestMinorKubernetesVersion.Value, latestPreviewKubernetesVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceNewKubernetesVersionAvailableEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerServiceNewKubernetesVersionAvailableEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerServiceNewKubernetesVersionAvailableEventData IPersistableModel<ContainerServiceNewKubernetesVersionAvailableEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerServiceNewKubernetesVersionAvailableEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerServiceNewKubernetesVersionAvailableEventData(document.RootElement, options);
        }

        string IPersistableModel<ContainerServiceNewKubernetesVersionAvailableEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class ContainerServiceNewKubernetesVersionAvailableEventDataConverter : JsonConverter<ContainerServiceNewKubernetesVersionAvailableEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceNewKubernetesVersionAvailableEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ContainerServiceNewKubernetesVersionAvailableEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceNewKubernetesVersionAvailableEventData(document.RootElement);
            }
        }
    }
}
