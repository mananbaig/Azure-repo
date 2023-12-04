// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.Identity;
using Azure.Core;

namespace Azure.Communication.Identity.Models
{
    internal partial class CommunicationIdentityCreateRequest : IUtf8JsonSerializable, IJsonModel<CommunicationIdentityCreateRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunicationIdentityCreateRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommunicationIdentityCreateRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationIdentityCreateRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CommunicationIdentityCreateRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CreateTokenWithScopes))
            {
                writer.WritePropertyName("createTokenWithScopes"u8);
                writer.WriteStartArray();
                foreach (var item in CreateTokenWithScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExpiresInMinutes))
            {
                writer.WritePropertyName("expiresInMinutes"u8);
                writer.WriteNumberValue(ExpiresInMinutes.Value);
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

        CommunicationIdentityCreateRequest IJsonModel<CommunicationIdentityCreateRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationIdentityCreateRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CommunicationIdentityCreateRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationIdentityCreateRequest(document.RootElement, options);
        }

        internal static CommunicationIdentityCreateRequest DeserializeCommunicationIdentityCreateRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<CommunicationTokenScope>> createTokenWithScopes = default;
            Optional<int> expiresInMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createTokenWithScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationTokenScope> array = new List<CommunicationTokenScope>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CommunicationTokenScope(item.GetString()));
                    }
                    createTokenWithScopes = array;
                    continue;
                }
                if (property.NameEquals("expiresInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommunicationIdentityCreateRequest(Optional.ToList(createTokenWithScopes), Optional.ToNullable(expiresInMinutes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommunicationIdentityCreateRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationIdentityCreateRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CommunicationIdentityCreateRequest)} does not support '{options.Format}' format.");
            }
        }

        CommunicationIdentityCreateRequest IPersistableModel<CommunicationIdentityCreateRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunicationIdentityCreateRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunicationIdentityCreateRequest(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CommunicationIdentityCreateRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunicationIdentityCreateRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
