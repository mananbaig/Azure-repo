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
    [JsonConverter(typeof(DynamicsCrmLinkedServiceConverter))]
    public partial class DynamicsCrmLinkedService : IUtf8JsonSerializable, IModelJsonSerializable<DynamicsCrmLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DynamicsCrmLinkedService>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DynamicsCrmLinkedService>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynamicsCrmLinkedService>(this, options.Format);

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
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteObjectValue(DeploymentType);
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteObjectValue(HostName);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteObjectValue(Port);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUri"u8);
                writer.WriteObjectValue(ServiceUri);
            }
            if (Optional.IsDefined(OrganizationName))
            {
                writer.WritePropertyName("organizationName"u8);
                writer.WriteObjectValue(OrganizationName);
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteObjectValue(AuthenticationType);
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteObjectValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                if (Password is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)Password).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalCredentialType))
            {
                writer.WritePropertyName("servicePrincipalCredentialType"u8);
                writer.WriteObjectValue(ServicePrincipalCredentialType);
            }
            if (Optional.IsDefined(ServicePrincipalCredential))
            {
                writer.WritePropertyName("servicePrincipalCredential"u8);
                if (ServicePrincipalCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)ServicePrincipalCredential).Serialize(writer, options);
                }
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

        internal static DynamicsCrmLinkedService DeserializeDynamicsCrmLinkedService(JsonElement element, ModelSerializerOptions options = default)
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
            object deploymentType = default;
            Optional<object> hostName = default;
            Optional<object> port = default;
            Optional<object> serviceUri = default;
            Optional<object> organizationName = default;
            object authenticationType = default;
            Optional<object> username = default;
            Optional<SecretBase> password = default;
            Optional<object> servicePrincipalId = default;
            Optional<object> servicePrincipalCredentialType = default;
            Optional<SecretBase> servicePrincipalCredential = default;
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
                        if (property0.NameEquals("deploymentType"u8))
                        {
                            deploymentType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("serviceUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceUri = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("organizationName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            organizationName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            authenticationType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("username"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredentialType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredentialType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredential = SecretBase.DeserializeSecretBase(property0.Value);
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
            return new DynamicsCrmLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, deploymentType, hostName.Value, port.Value, serviceUri.Value, organizationName.Value, authenticationType, username.Value, password.Value, servicePrincipalId.Value, servicePrincipalCredentialType.Value, servicePrincipalCredential.Value, encryptedCredential.Value);
        }

        DynamicsCrmLinkedService IModelJsonSerializable<DynamicsCrmLinkedService>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynamicsCrmLinkedService>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynamicsCrmLinkedService(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DynamicsCrmLinkedService>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynamicsCrmLinkedService>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DynamicsCrmLinkedService IModelSerializable<DynamicsCrmLinkedService>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynamicsCrmLinkedService>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDynamicsCrmLinkedService(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DynamicsCrmLinkedService"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DynamicsCrmLinkedService"/> to convert. </param>
        public static implicit operator RequestContent(DynamicsCrmLinkedService model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DynamicsCrmLinkedService"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DynamicsCrmLinkedService(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDynamicsCrmLinkedService(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DynamicsCrmLinkedServiceConverter : JsonConverter<DynamicsCrmLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, DynamicsCrmLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DynamicsCrmLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDynamicsCrmLinkedService(document.RootElement);
            }
        }
    }
}
