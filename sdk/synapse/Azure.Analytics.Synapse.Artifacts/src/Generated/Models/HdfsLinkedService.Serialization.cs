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
    [JsonConverter(typeof(HdfsLinkedServiceConverter))]
    public partial class HdfsLinkedService : IUtf8JsonSerializable, IModelJsonSerializable<HdfsLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HdfsLinkedService>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HdfsLinkedService>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HdfsLinkedService>(this, options.Format);

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
            writer.WritePropertyName("url"u8);
            writer.WriteObjectValue(Url);
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteObjectValue(AuthenticationType);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteObjectValue(UserName);
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
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HdfsLinkedService DeserializeHdfsLinkedService(JsonElement element, ModelSerializerOptions options = default)
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
            object url = default;
            Optional<object> authenticationType = default;
            Optional<object> encryptedCredential = default;
            Optional<object> userName = default;
            Optional<SecretBase> password = default;
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
                        if (property0.NameEquals("url"u8))
                        {
                            url = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = property0.Value.GetObject();
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
                        if (property0.NameEquals("userName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userName = property0.Value.GetObject();
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
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HdfsLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, url, authenticationType.Value, encryptedCredential.Value, userName.Value, password.Value);
        }

        HdfsLinkedService IModelJsonSerializable<HdfsLinkedService>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HdfsLinkedService>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHdfsLinkedService(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HdfsLinkedService>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HdfsLinkedService>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HdfsLinkedService IModelSerializable<HdfsLinkedService>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HdfsLinkedService>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHdfsLinkedService(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HdfsLinkedService"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HdfsLinkedService"/> to convert. </param>
        public static implicit operator RequestContent(HdfsLinkedService model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HdfsLinkedService"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HdfsLinkedService(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHdfsLinkedService(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class HdfsLinkedServiceConverter : JsonConverter<HdfsLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, HdfsLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HdfsLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHdfsLinkedService(document.RootElement);
            }
        }
    }
}
