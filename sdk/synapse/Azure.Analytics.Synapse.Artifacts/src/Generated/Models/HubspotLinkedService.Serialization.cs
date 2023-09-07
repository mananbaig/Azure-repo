// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(HubspotLinkedServiceConverter))]
    public partial class HubspotLinkedService : IUtf8JsonSerializable, IModelJsonSerializable<HubspotLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HubspotLinkedService>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HubspotLinkedService>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubspotLinkedService>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                if (ConnectVia is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationRuntimeReference>)ConnectVia).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ParameterSpecification>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("clientId"u8);
            writer.WriteObjectValue(ClientId);
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                if (ClientSecret is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)ClientSecret).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken"u8);
                if (AccessToken is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)AccessToken).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                if (RefreshToken is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)RefreshToken).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(UseEncryptedEndpoints))
            {
                writer.WritePropertyName("useEncryptedEndpoints"u8);
                writer.WriteObjectValue(UseEncryptedEndpoints);
            }
            if (Optional.IsDefined(UseHostVerification))
            {
                writer.WritePropertyName("useHostVerification"u8);
                writer.WriteObjectValue(UseHostVerification);
            }
            if (Optional.IsDefined(UsePeerVerification))
            {
                writer.WritePropertyName("usePeerVerification"u8);
                writer.WriteObjectValue(UsePeerVerification);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HubspotLinkedService DeserializeHubspotLinkedService(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object clientId = default;
            Optional<SecretBase> clientSecret = default;
            Optional<SecretBase> accessToken = default;
            Optional<SecretBase> refreshToken = default;
            Optional<object> useEncryptedEndpoints = default;
            Optional<object> useHostVerification = default;
            Optional<object> usePeerVerification = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecret = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessToken = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("refreshToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshToken = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("useEncryptedEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useEncryptedEndpoints = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useHostVerification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useHostVerification = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("usePeerVerification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePeerVerification = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HubspotLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, clientId, clientSecret.Value, accessToken.Value, refreshToken.Value, useEncryptedEndpoints.Value, useHostVerification.Value, usePeerVerification.Value, encryptedCredential.Value);
        }

        HubspotLinkedService IModelJsonSerializable<HubspotLinkedService>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubspotLinkedService>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHubspotLinkedService(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HubspotLinkedService>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubspotLinkedService>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HubspotLinkedService IModelSerializable<HubspotLinkedService>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HubspotLinkedService>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHubspotLinkedService(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HubspotLinkedService"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HubspotLinkedService"/> to convert. </param>
        public static implicit operator RequestContent(HubspotLinkedService model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HubspotLinkedService"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HubspotLinkedService(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHubspotLinkedService(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class HubspotLinkedServiceConverter : JsonConverter<HubspotLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, HubspotLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HubspotLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHubspotLinkedService(document.RootElement);
            }
        }
    }
}
