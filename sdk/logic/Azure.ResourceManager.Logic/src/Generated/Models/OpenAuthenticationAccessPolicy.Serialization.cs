// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class OpenAuthenticationAccessPolicy : IUtf8JsonSerializable, IJsonModel<OpenAuthenticationAccessPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenAuthenticationAccessPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OpenAuthenticationAccessPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Claims))
            {
                writer.WritePropertyName("claims"u8);
                writer.WriteStartArray();
                foreach (var item in Claims)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        OpenAuthenticationAccessPolicy IJsonModel<OpenAuthenticationAccessPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAuthenticationAccessPolicy(document.RootElement, options);
        }

        internal static OpenAuthenticationAccessPolicy DeserializeOpenAuthenticationAccessPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OpenAuthenticationProviderType? type = default;
            IList<OpenAuthenticationPolicyClaim> claims = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OpenAuthenticationProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OpenAuthenticationPolicyClaim> array = new List<OpenAuthenticationPolicyClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OpenAuthenticationPolicyClaim.DeserializeOpenAuthenticationPolicyClaim(item, options));
                    }
                    claims = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OpenAuthenticationAccessPolicy(type, claims ?? new ChangeTrackingList<OpenAuthenticationPolicyClaim>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenAuthenticationAccessPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support '{options.Format}' format.");
            }
        }

        OpenAuthenticationAccessPolicy IPersistableModel<OpenAuthenticationAccessPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOpenAuthenticationAccessPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenAuthenticationAccessPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
