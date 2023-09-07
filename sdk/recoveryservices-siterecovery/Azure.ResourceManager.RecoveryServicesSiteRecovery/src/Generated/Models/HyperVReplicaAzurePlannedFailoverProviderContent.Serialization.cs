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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaAzurePlannedFailoverProviderContent : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplicaAzurePlannedFailoverProviderContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplicaAzurePlannedFailoverProviderContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplicaAzurePlannedFailoverProviderContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzurePlannedFailoverProviderContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKekCertificatePfx))
            {
                writer.WritePropertyName("primaryKekCertificatePfx"u8);
                writer.WriteStringValue(PrimaryKekCertificatePfx);
            }
            if (Optional.IsDefined(SecondaryKekCertificatePfx))
            {
                writer.WritePropertyName("secondaryKekCertificatePfx"u8);
                writer.WriteStringValue(SecondaryKekCertificatePfx);
            }
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static HyperVReplicaAzurePlannedFailoverProviderContent DeserializeHyperVReplicaAzurePlannedFailoverProviderContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryKekCertificatePfx = default;
            Optional<string> secondaryKekCertificatePfx = default;
            Optional<ResourceIdentifier> recoveryPointId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKekCertificatePfx"u8))
                {
                    primaryKekCertificatePfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKekCertificatePfx"u8))
                {
                    secondaryKekCertificatePfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HyperVReplicaAzurePlannedFailoverProviderContent(instanceType, primaryKekCertificatePfx.Value, secondaryKekCertificatePfx.Value, recoveryPointId.Value, serializedAdditionalRawData);
        }

        HyperVReplicaAzurePlannedFailoverProviderContent IModelJsonSerializable<HyperVReplicaAzurePlannedFailoverProviderContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzurePlannedFailoverProviderContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzurePlannedFailoverProviderContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplicaAzurePlannedFailoverProviderContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzurePlannedFailoverProviderContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplicaAzurePlannedFailoverProviderContent IModelSerializable<HyperVReplicaAzurePlannedFailoverProviderContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzurePlannedFailoverProviderContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaAzurePlannedFailoverProviderContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVReplicaAzurePlannedFailoverProviderContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVReplicaAzurePlannedFailoverProviderContent"/> to convert. </param>
        public static implicit operator RequestContent(HyperVReplicaAzurePlannedFailoverProviderContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVReplicaAzurePlannedFailoverProviderContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVReplicaAzurePlannedFailoverProviderContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplicaAzurePlannedFailoverProviderContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
