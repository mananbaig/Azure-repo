// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class PartnerDestinationData : IUtf8JsonSerializable, IModelJsonSerializable<PartnerDestinationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartnerDestinationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartnerDestinationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PartnerRegistrationImmutableId))
            {
                writer.WritePropertyName("partnerRegistrationImmutableId"u8);
                writer.WriteStringValue(PartnerRegistrationImmutableId.Value);
            }
            if (Optional.IsDefined(EndpointServiceContext))
            {
                writer.WritePropertyName("endpointServiceContext"u8);
                writer.WriteStringValue(EndpointServiceContext);
            }
            if (Optional.IsDefined(ExpirationTimeIfNotActivatedUtc))
            {
                writer.WritePropertyName("expirationTimeIfNotActivatedUtc"u8);
                writer.WriteStringValue(ExpirationTimeIfNotActivatedUtc.Value, "O");
            }
            if (Optional.IsDefined(ActivationState))
            {
                writer.WritePropertyName("activationState"u8);
                writer.WriteStringValue(ActivationState.Value.ToString());
            }
            if (Optional.IsDefined(EndpointBaseUri))
            {
                writer.WritePropertyName("endpointBaseUrl"u8);
                writer.WriteStringValue(EndpointBaseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MessageForActivation))
            {
                writer.WritePropertyName("messageForActivation"u8);
                writer.WriteStringValue(MessageForActivation);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static PartnerDestinationData DeserializePartnerDestinationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> partnerRegistrationImmutableId = default;
            Optional<string> endpointServiceContext = default;
            Optional<DateTimeOffset> expirationTimeIfNotActivatedUtc = default;
            Optional<PartnerDestinationProvisioningState> provisioningState = default;
            Optional<PartnerDestinationActivationState> activationState = default;
            Optional<Uri> endpointBaseUri = default;
            Optional<string> messageForActivation = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("partnerRegistrationImmutableId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRegistrationImmutableId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("endpointServiceContext"u8))
                        {
                            endpointServiceContext = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expirationTimeIfNotActivatedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTimeIfNotActivatedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PartnerDestinationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            activationState = new PartnerDestinationActivationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointBaseUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("messageForActivation"u8))
                        {
                            messageForActivation = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PartnerDestinationData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(partnerRegistrationImmutableId), endpointServiceContext.Value, Optional.ToNullable(expirationTimeIfNotActivatedUtc), Optional.ToNullable(provisioningState), Optional.ToNullable(activationState), endpointBaseUri.Value, messageForActivation.Value, serializedAdditionalRawData);
        }

        PartnerDestinationData IModelJsonSerializable<PartnerDestinationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerDestinationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartnerDestinationData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartnerDestinationData IModelSerializable<PartnerDestinationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartnerDestinationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PartnerDestinationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PartnerDestinationData"/> to convert. </param>
        public static implicit operator RequestContent(PartnerDestinationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PartnerDestinationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PartnerDestinationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartnerDestinationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
