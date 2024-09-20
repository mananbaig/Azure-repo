// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class CustomerSubscriptionRegisteredFeatures : IUtf8JsonSerializable, IJsonModel<CustomerSubscriptionRegisteredFeatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomerSubscriptionRegisteredFeatures>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomerSubscriptionRegisteredFeatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionRegisteredFeatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerSubscriptionRegisteredFeatures)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        CustomerSubscriptionRegisteredFeatures IJsonModel<CustomerSubscriptionRegisteredFeatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionRegisteredFeatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerSubscriptionRegisteredFeatures)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerSubscriptionRegisteredFeatures(document.RootElement, options);
        }

        internal static CustomerSubscriptionRegisteredFeatures DeserializeCustomerSubscriptionRegisteredFeatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomerSubscriptionRegisteredFeatures(name, state, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomerSubscriptionRegisteredFeatures>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionRegisteredFeatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomerSubscriptionRegisteredFeatures)} does not support writing '{options.Format}' format.");
            }
        }

        CustomerSubscriptionRegisteredFeatures IPersistableModel<CustomerSubscriptionRegisteredFeatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerSubscriptionRegisteredFeatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomerSubscriptionRegisteredFeatures(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomerSubscriptionRegisteredFeatures)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomerSubscriptionRegisteredFeatures>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
