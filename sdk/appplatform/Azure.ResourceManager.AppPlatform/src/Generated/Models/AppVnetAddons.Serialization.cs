// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppVnetAddons : IUtf8JsonSerializable, IJsonModel<AppVnetAddons>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppVnetAddons>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppVnetAddons>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppVnetAddons>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppVnetAddons)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsPublicEndpoint))
            {
                writer.WritePropertyName("publicEndpoint"u8);
                writer.WriteBooleanValue(IsPublicEndpoint.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicEndpointUri))
            {
                writer.WritePropertyName("publicEndpointUrl"u8);
                writer.WriteStringValue(PublicEndpointUri.AbsoluteUri);
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

        AppVnetAddons IJsonModel<AppVnetAddons>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppVnetAddons>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppVnetAddons)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppVnetAddons(document.RootElement, options);
        }

        internal static AppVnetAddons DeserializeAppVnetAddons(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? publicEndpoint = default;
            Uri publicEndpointUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicEndpointUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppVnetAddons(publicEndpoint, publicEndpointUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppVnetAddons>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppVnetAddons>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppVnetAddons)} does not support writing '{options.Format}' format.");
            }
        }

        AppVnetAddons IPersistableModel<AppVnetAddons>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppVnetAddons>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppVnetAddons(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppVnetAddons)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppVnetAddons>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
