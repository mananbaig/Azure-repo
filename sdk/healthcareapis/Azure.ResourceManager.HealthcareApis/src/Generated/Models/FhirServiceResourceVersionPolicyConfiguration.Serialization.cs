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

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class FhirServiceResourceVersionPolicyConfiguration : IUtf8JsonSerializable, IJsonModel<FhirServiceResourceVersionPolicyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirServiceResourceVersionPolicyConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirServiceResourceVersionPolicyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FhirServiceResourceVersionPolicyConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteStringValue(Default.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceTypeOverrides))
            {
                writer.WritePropertyName("resourceTypeOverrides"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceTypeOverrides)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value.ToString());
                }
                writer.WriteEndObject();
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

        FhirServiceResourceVersionPolicyConfiguration IJsonModel<FhirServiceResourceVersionPolicyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirServiceResourceVersionPolicyConfiguration(document.RootElement, options);
        }

        internal static FhirServiceResourceVersionPolicyConfiguration DeserializeFhirServiceResourceVersionPolicyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FhirResourceVersionPolicy> @default = default;
            Optional<IDictionary<string, FhirResourceVersionPolicy>> resourceTypeOverrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = new FhirResourceVersionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceTypeOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, FhirResourceVersionPolicy> dictionary = new Dictionary<string, FhirResourceVersionPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, new FhirResourceVersionPolicy(property0.Value.GetString()));
                    }
                    resourceTypeOverrides = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FhirServiceResourceVersionPolicyConfiguration(Optional.ToNullable(@default), Optional.ToDictionary(resourceTypeOverrides), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FhirServiceResourceVersionPolicyConfiguration IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFhirServiceResourceVersionPolicyConfiguration(document.RootElement, options);
        }

        string IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
