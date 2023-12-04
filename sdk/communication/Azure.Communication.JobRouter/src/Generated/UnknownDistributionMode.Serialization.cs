// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    internal partial class UnknownDistributionMode : IUtf8JsonSerializable, IJsonModel<DistributionMode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DistributionMode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DistributionMode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DistributionMode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinConcurrentOffers))
            {
                writer.WritePropertyName("minConcurrentOffers"u8);
                writer.WriteNumberValue(MinConcurrentOffers);
            }
            if (Optional.IsDefined(MaxConcurrentOffers))
            {
                writer.WritePropertyName("maxConcurrentOffers"u8);
                writer.WriteNumberValue(MaxConcurrentOffers);
            }
            if (Optional.IsDefined(BypassSelectors))
            {
                writer.WritePropertyName("bypassSelectors"u8);
                writer.WriteBooleanValue(BypassSelectors.Value);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        DistributionMode IJsonModel<DistributionMode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DistributionMode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownDistributionMode(document.RootElement, options);
        }

        internal static UnknownDistributionMode DeserializeUnknownDistributionMode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minConcurrentOffers = default;
            Optional<int> maxConcurrentOffers = default;
            Optional<bool> bypassSelectors = default;
            DistributionModeKind kind = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bypassSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassSelectors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DistributionModeKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownDistributionMode(minConcurrentOffers, maxConcurrentOffers, Optional.ToNullable(bypassSelectors), kind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DistributionMode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DistributionMode)} does not support '{options.Format}' format.");
            }
        }

        DistributionMode IPersistableModel<DistributionMode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownDistributionMode(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DistributionMode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DistributionMode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownDistributionMode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownDistributionMode(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
