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
    public partial class RecoveryPlanHyperVReplicaAzureFailoverContent : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryPlanHyperVReplicaAzureFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryPlanHyperVReplicaAzureFailoverContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryPlanHyperVReplicaAzureFailoverContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanHyperVReplicaAzureFailoverContent>(this, options.Format);

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
            if (Optional.IsDefined(RecoveryPointType))
            {
                writer.WritePropertyName("recoveryPointType"u8);
                writer.WriteStringValue(RecoveryPointType.Value.ToString());
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

        internal static RecoveryPlanHyperVReplicaAzureFailoverContent DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryKekCertificatePfx = default;
            Optional<string> secondaryKekCertificatePfx = default;
            Optional<HyperVReplicaAzureRpRecoveryPointType> recoveryPointType = default;
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
                if (property.NameEquals("recoveryPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointType = new HyperVReplicaAzureRpRecoveryPointType(property.Value.GetString());
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
            return new RecoveryPlanHyperVReplicaAzureFailoverContent(instanceType, primaryKekCertificatePfx.Value, secondaryKekCertificatePfx.Value, Optional.ToNullable(recoveryPointType), serializedAdditionalRawData);
        }

        RecoveryPlanHyperVReplicaAzureFailoverContent IModelJsonSerializable<RecoveryPlanHyperVReplicaAzureFailoverContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanHyperVReplicaAzureFailoverContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryPlanHyperVReplicaAzureFailoverContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanHyperVReplicaAzureFailoverContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryPlanHyperVReplicaAzureFailoverContent IModelSerializable<RecoveryPlanHyperVReplicaAzureFailoverContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanHyperVReplicaAzureFailoverContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryPlanHyperVReplicaAzureFailoverContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryPlanHyperVReplicaAzureFailoverContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
