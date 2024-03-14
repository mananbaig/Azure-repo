// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsServiceBusProperties : IUtf8JsonSerializable, IJsonModel<DigitalTwinsServiceBusProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigitalTwinsServiceBusProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DigitalTwinsServiceBusProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryConnectionString))
            {
                if (PrimaryConnectionString != null)
                {
                    writer.WritePropertyName("primaryConnectionString"u8);
                    writer.WriteStringValue(PrimaryConnectionString);
                }
                else
                {
                    writer.WriteNull("primaryConnectionString");
                }
            }
            if (Optional.IsDefined(SecondaryConnectionString))
            {
                if (SecondaryConnectionString != null)
                {
                    writer.WritePropertyName("secondaryConnectionString"u8);
                    writer.WriteStringValue(SecondaryConnectionString);
                }
                else
                {
                    writer.WriteNull("secondaryConnectionString");
                }
            }
            if (Optional.IsDefined(EndpointUri))
            {
                if (EndpointUri != null)
                {
                    writer.WritePropertyName("endpointUri"u8);
                    writer.WriteStringValue(EndpointUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("endpointUri");
                }
            }
            if (Optional.IsDefined(EntityPath))
            {
                if (EntityPath != null)
                {
                    writer.WritePropertyName("entityPath"u8);
                    writer.WriteStringValue(EntityPath);
                }
                else
                {
                    writer.WriteNull("entityPath");
                }
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                if (ProvisioningState != null)
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
                else
                {
                    writer.WriteNull("provisioningState");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                if (CreatedOn != null)
                {
                    writer.WritePropertyName("createdTime"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("createdTime");
                }
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(DeadLetterSecret))
            {
                if (DeadLetterSecret != null)
                {
                    writer.WritePropertyName("deadLetterSecret"u8);
                    writer.WriteStringValue(DeadLetterSecret);
                }
                else
                {
                    writer.WriteNull("deadLetterSecret");
                }
            }
            if (Optional.IsDefined(DeadLetterUri))
            {
                if (DeadLetterUri != null)
                {
                    writer.WritePropertyName("deadLetterUri"u8);
                    writer.WriteStringValue(DeadLetterUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("deadLetterUri");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
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

        DigitalTwinsServiceBusProperties IJsonModel<DigitalTwinsServiceBusProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsServiceBusProperties(document.RootElement, options);
        }

        internal static DigitalTwinsServiceBusProperties DeserializeDigitalTwinsServiceBusProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryConnectionString = default;
            string secondaryConnectionString = default;
            Uri endpointUri = default;
            string entityPath = default;
            EndpointType endpointType = default;
            DigitalTwinsEndpointProvisioningState? provisioningState = default;
            DateTimeOffset? createdTime = default;
            DigitalTwinsAuthenticationType? authenticationType = default;
            string deadLetterSecret = default;
            Uri deadLetterUri = default;
            DigitalTwinsManagedIdentityReference identity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryConnectionString = null;
                        continue;
                    }
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secondaryConnectionString = null;
                        continue;
                    }
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpointUri = null;
                        continue;
                    }
                    endpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("entityPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entityPath = null;
                        continue;
                    }
                    entityPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new DigitalTwinsEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdTime = null;
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new DigitalTwinsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deadLetterSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterSecret = null;
                        continue;
                    }
                    deadLetterSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterUri = null;
                        continue;
                    }
                    deadLetterUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DigitalTwinsServiceBusProperties(
                endpointType,
                provisioningState,
                createdTime,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData,
                primaryConnectionString,
                secondaryConnectionString,
                endpointUri,
                entityPath);
        }

        BinaryData IPersistableModel<DigitalTwinsServiceBusProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support '{options.Format}' format.");
            }
        }

        DigitalTwinsServiceBusProperties IPersistableModel<DigitalTwinsServiceBusProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsServiceBusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDigitalTwinsServiceBusProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsServiceBusProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigitalTwinsServiceBusProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
