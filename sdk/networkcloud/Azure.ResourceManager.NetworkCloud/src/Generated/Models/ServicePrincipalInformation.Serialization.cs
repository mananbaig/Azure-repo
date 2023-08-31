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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ServicePrincipalInformation : IUtf8JsonSerializable, IModelJsonSerializable<ServicePrincipalInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServicePrincipalInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServicePrincipalInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("applicationId"u8);
            writer.WriteStringValue(ApplicationId);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static ServicePrincipalInformation DeserializeServicePrincipalInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string applicationId = default;
            Optional<string> password = default;
            string principalId = default;
            string tenantId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServicePrincipalInformation(applicationId, password.Value, principalId, tenantId, rawData);
        }

        ServicePrincipalInformation IModelJsonSerializable<ServicePrincipalInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePrincipalInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServicePrincipalInformation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServicePrincipalInformation IModelSerializable<ServicePrincipalInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServicePrincipalInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServicePrincipalInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServicePrincipalInformation"/> to convert. </param>
        public static implicit operator RequestContent(ServicePrincipalInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServicePrincipalInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServicePrincipalInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServicePrincipalInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
