// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class FacebookChannelProperties : IUtf8JsonSerializable, IJsonModel<FacebookChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FacebookChannelProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FacebookChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacebookChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(VerifyToken))
            {
                writer.WritePropertyName("verifyToken"u8);
                writer.WriteStringValue(VerifyToken);
            }
            if (Optional.IsCollectionDefined(Pages))
            {
                writer.WritePropertyName("pages"u8);
                writer.WriteStartArray();
                foreach (var item in Pages)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            if (Optional.IsDefined(AppSecret))
            {
                writer.WritePropertyName("appSecret"u8);
                writer.WriteStringValue(AppSecret);
            }
            if (options.Format != "W" && Optional.IsDefined(CallbackUri))
            {
                writer.WritePropertyName("callbackUrl"u8);
                writer.WriteStringValue(CallbackUri.AbsoluteUri);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
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

        FacebookChannelProperties IJsonModel<FacebookChannelProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacebookChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFacebookChannelProperties(document.RootElement, options);
        }

        internal static FacebookChannelProperties DeserializeFacebookChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string verifyToken = default;
            IList<FacebookPage> pages = default;
            string appId = default;
            string appSecret = default;
            Uri callbackUrl = default;
            bool isEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verifyToken"u8))
                {
                    verifyToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FacebookPage> array = new List<FacebookPage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FacebookPage.DeserializeFacebookPage(item, options));
                    }
                    pages = array;
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appSecret"u8))
                {
                    appSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callbackUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FacebookChannelProperties(
                verifyToken,
                pages ?? new ChangeTrackingList<FacebookPage>(),
                appId,
                appSecret,
                callbackUrl,
                isEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FacebookChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacebookChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support writing '{options.Format}' format.");
            }
        }

        FacebookChannelProperties IPersistableModel<FacebookChannelProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FacebookChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFacebookChannelProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FacebookChannelProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FacebookChannelProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
