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
    public partial class ExpressRouteLinkMacSecConfig : IUtf8JsonSerializable, IJsonModel<ExpressRouteLinkMacSecConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteLinkMacSecConfig>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ExpressRouteLinkMacSecConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ExpressRouteLinkMacSecConfig>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ExpressRouteLinkMacSecConfig>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CknSecretIdentifier))
            {
                writer.WritePropertyName("cknSecretIdentifier"u8);
                writer.WriteStringValue(CknSecretIdentifier);
            }
            if (Optional.IsDefined(CakSecretIdentifier))
            {
                writer.WritePropertyName("cakSecretIdentifier"u8);
                writer.WriteStringValue(CakSecretIdentifier);
            }
            if (Optional.IsDefined(Cipher))
            {
                writer.WritePropertyName("cipher"u8);
                writer.WriteStringValue(Cipher.Value.ToString());
            }
            if (Optional.IsDefined(SciState))
            {
                writer.WritePropertyName("sciState"u8);
                writer.WriteStringValue(SciState.Value.ToString());
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

        ExpressRouteLinkMacSecConfig IJsonModel<ExpressRouteLinkMacSecConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExpressRouteLinkMacSecConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteLinkMacSecConfig(document.RootElement, options);
        }

        internal static ExpressRouteLinkMacSecConfig DeserializeExpressRouteLinkMacSecConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cknSecretIdentifier = default;
            Optional<string> cakSecretIdentifier = default;
            Optional<ExpressRouteLinkMacSecCipher> cipher = default;
            Optional<ExpressRouteLinkMacSecSciState> sciState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cknSecretIdentifier"u8))
                {
                    cknSecretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cakSecretIdentifier"u8))
                {
                    cakSecretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cipher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cipher = new ExpressRouteLinkMacSecCipher(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sciState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sciState = new ExpressRouteLinkMacSecSciState(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteLinkMacSecConfig(cknSecretIdentifier.Value, cakSecretIdentifier.Value, Optional.ToNullable(cipher), Optional.ToNullable(sciState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteLinkMacSecConfig>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExpressRouteLinkMacSecConfig)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ExpressRouteLinkMacSecConfig IPersistableModel<ExpressRouteLinkMacSecConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExpressRouteLinkMacSecConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeExpressRouteLinkMacSecConfig(document.RootElement, options);
        }

        string IPersistableModel<ExpressRouteLinkMacSecConfig>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
