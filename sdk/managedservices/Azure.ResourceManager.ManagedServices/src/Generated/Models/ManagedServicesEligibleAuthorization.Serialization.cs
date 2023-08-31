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

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesEligibleAuthorization : IUtf8JsonSerializable, IModelJsonSerializable<ManagedServicesEligibleAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedServicesEligibleAuthorization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedServicesEligibleAuthorization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsDefined(PrincipalIdDisplayName))
            {
                writer.WritePropertyName("principalIdDisplayName"u8);
                writer.WriteStringValue(PrincipalIdDisplayName);
            }
            writer.WritePropertyName("roleDefinitionId"u8);
            writer.WriteStringValue(RoleDefinitionId);
            if (Optional.IsDefined(JustInTimeAccessPolicy))
            {
                writer.WritePropertyName("justInTimeAccessPolicy"u8);
                writer.WriteObjectValue(JustInTimeAccessPolicy);
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

        internal static ManagedServicesEligibleAuthorization DeserializeManagedServicesEligibleAuthorization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid principalId = default;
            Optional<string> principalIdDisplayName = default;
            string roleDefinitionId = default;
            Optional<ManagedServicesJustInTimeAccessPolicy> justInTimeAccessPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalIdDisplayName"u8))
                {
                    principalIdDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"u8))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justInTimeAccessPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    justInTimeAccessPolicy = ManagedServicesJustInTimeAccessPolicy.DeserializeManagedServicesJustInTimeAccessPolicy(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedServicesEligibleAuthorization(principalId, principalIdDisplayName.Value, roleDefinitionId, justInTimeAccessPolicy.Value, rawData);
        }

        ManagedServicesEligibleAuthorization IModelJsonSerializable<ManagedServicesEligibleAuthorization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesEligibleAuthorization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedServicesEligibleAuthorization>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedServicesEligibleAuthorization IModelSerializable<ManagedServicesEligibleAuthorization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedServicesEligibleAuthorization(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedServicesEligibleAuthorization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedServicesEligibleAuthorization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedServicesEligibleAuthorization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
