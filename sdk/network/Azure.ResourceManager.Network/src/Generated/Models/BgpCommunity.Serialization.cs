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
    public partial class BgpCommunity : IUtf8JsonSerializable, IJsonModel<BgpCommunity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BgpCommunity>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BgpCommunity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BgpCommunity>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BgpCommunity>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceSupportedRegion))
            {
                writer.WritePropertyName("serviceSupportedRegion"u8);
                writer.WriteStringValue(ServiceSupportedRegion);
            }
            if (Optional.IsDefined(CommunityName))
            {
                writer.WritePropertyName("communityName"u8);
                writer.WriteStringValue(CommunityName);
            }
            if (Optional.IsDefined(CommunityValue))
            {
                writer.WritePropertyName("communityValue"u8);
                writer.WriteStringValue(CommunityValue);
            }
            if (Optional.IsCollectionDefined(CommunityPrefixes))
            {
                writer.WritePropertyName("communityPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in CommunityPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsAuthorizedToUse))
            {
                writer.WritePropertyName("isAuthorizedToUse"u8);
                writer.WriteBooleanValue(IsAuthorizedToUse.Value);
            }
            if (Optional.IsDefined(ServiceGroup))
            {
                writer.WritePropertyName("serviceGroup"u8);
                writer.WriteStringValue(ServiceGroup);
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

        BgpCommunity IJsonModel<BgpCommunity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpCommunity(document.RootElement, options);
        }

        internal static BgpCommunity DeserializeBgpCommunity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceSupportedRegion = default;
            Optional<string> communityName = default;
            Optional<string> communityValue = default;
            Optional<IList<string>> communityPrefixes = default;
            Optional<bool> isAuthorizedToUse = default;
            Optional<string> serviceGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceSupportedRegion"u8))
                {
                    serviceSupportedRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityName"u8))
                {
                    communityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityValue"u8))
                {
                    communityValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityPrefixes"u8))
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
                    communityPrefixes = array;
                    continue;
                }
                if (property.NameEquals("isAuthorizedToUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAuthorizedToUse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("serviceGroup"u8))
                {
                    serviceGroup = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BgpCommunity(serviceSupportedRegion.Value, communityName.Value, communityValue.Value, Optional.ToList(communityPrefixes), Optional.ToNullable(isAuthorizedToUse), serviceGroup.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BgpCommunity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BgpCommunity IPersistableModel<BgpCommunity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBgpCommunity(document.RootElement, options);
        }

        string IPersistableModel<BgpCommunity>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
