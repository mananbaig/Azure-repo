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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicAccountProperties : IUtf8JsonSerializable, IModelJsonSerializable<NewRelicAccountProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NewRelicAccountProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NewRelicAccountProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId"u8);
                writer.WriteStringValue(UserId);
            }
            if (Optional.IsDefined(AccountInfo))
            {
                writer.WritePropertyName("accountInfo"u8);
                if (AccountInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NewRelicObservabilityAccountInfo>)AccountInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OrganizationInfo))
            {
                writer.WritePropertyName("organizationInfo"u8);
                if (OrganizationInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NewRelicObservabilityOrganizationInfo>)OrganizationInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SingleSignOnProperties))
            {
                writer.WritePropertyName("singleSignOnProperties"u8);
                if (SingleSignOnProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NewRelicSingleSignOnProperties>)SingleSignOnProperties).Serialize(writer, options);
                }
            }
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

        internal static NewRelicAccountProperties DeserializeNewRelicAccountProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> userId = default;
            Optional<NewRelicObservabilityAccountInfo> accountInfo = default;
            Optional<NewRelicObservabilityOrganizationInfo> organizationInfo = default;
            Optional<NewRelicSingleSignOnProperties> singleSignOnProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountInfo = NewRelicObservabilityAccountInfo.DeserializeNewRelicObservabilityAccountInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("organizationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    organizationInfo = NewRelicObservabilityOrganizationInfo.DeserializeNewRelicObservabilityOrganizationInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("singleSignOnProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnProperties = NewRelicSingleSignOnProperties.DeserializeNewRelicSingleSignOnProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NewRelicAccountProperties(userId.Value, accountInfo.Value, organizationInfo.Value, singleSignOnProperties.Value, rawData);
        }

        NewRelicAccountProperties IModelJsonSerializable<NewRelicAccountProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicAccountProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NewRelicAccountProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NewRelicAccountProperties IModelSerializable<NewRelicAccountProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNewRelicAccountProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NewRelicAccountProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NewRelicAccountProperties"/> to convert. </param>
        public static implicit operator RequestContent(NewRelicAccountProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NewRelicAccountProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NewRelicAccountProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNewRelicAccountProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
