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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorValidateCustomDomainResult : IUtf8JsonSerializable, IJsonModel<FrontDoorValidateCustomDomainResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorValidateCustomDomainResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorValidateCustomDomainResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FrontDoorValidateCustomDomainResult>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FrontDoorValidateCustomDomainResult>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsCustomDomainValidated))
                {
                    writer.WritePropertyName("customDomainValidated"u8);
                    writer.WriteBooleanValue(IsCustomDomainValidated.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Reason))
                {
                    writer.WritePropertyName("reason"u8);
                    writer.WriteStringValue(Reason);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Message))
                {
                    writer.WritePropertyName("message"u8);
                    writer.WriteStringValue(Message);
                }
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

        FrontDoorValidateCustomDomainResult IJsonModel<FrontDoorValidateCustomDomainResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FrontDoorValidateCustomDomainResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorValidateCustomDomainResult(document.RootElement, options);
        }

        internal static FrontDoorValidateCustomDomainResult DeserializeFrontDoorValidateCustomDomainResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> customDomainValidated = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customDomainValidated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainValidated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FrontDoorValidateCustomDomainResult(Optional.ToNullable(customDomainValidated), reason.Value, message.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorValidateCustomDomainResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FrontDoorValidateCustomDomainResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FrontDoorValidateCustomDomainResult IPersistableModel<FrontDoorValidateCustomDomainResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FrontDoorValidateCustomDomainResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFrontDoorValidateCustomDomainResult(document.RootElement, options);
        }

        string IPersistableModel<FrontDoorValidateCustomDomainResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
