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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterUpgradePolicy : IUtf8JsonSerializable, IModelJsonSerializable<ClusterUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterUpgradePolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterUpgradePolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterUpgradePolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ForceRestart))
            {
                writer.WritePropertyName("forceRestart"u8);
                writer.WriteBooleanValue(ForceRestart.Value);
            }
            writer.WritePropertyName("upgradeReplicaSetCheckTimeout"u8);
            writer.WriteStringValue(UpgradeReplicaSetCheckTimeout, "c");
            writer.WritePropertyName("healthCheckWaitDuration"u8);
            writer.WriteStringValue(HealthCheckWaitDuration, "c");
            writer.WritePropertyName("healthCheckStableDuration"u8);
            writer.WriteStringValue(HealthCheckStableDuration, "c");
            writer.WritePropertyName("healthCheckRetryTimeout"u8);
            writer.WriteStringValue(HealthCheckRetryTimeout, "c");
            writer.WritePropertyName("upgradeTimeout"u8);
            writer.WriteStringValue(UpgradeTimeout, "c");
            writer.WritePropertyName("upgradeDomainTimeout"u8);
            writer.WriteStringValue(UpgradeDomainTimeout, "c");
            writer.WritePropertyName("healthPolicy"u8);
            if (HealthPolicy is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ClusterHealthPolicy>)HealthPolicy).Serialize(writer, options);
            }
            if (Optional.IsDefined(DeltaHealthPolicy))
            {
                writer.WritePropertyName("deltaHealthPolicy"u8);
                if (DeltaHealthPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterUpgradeDeltaHealthPolicy>)DeltaHealthPolicy).Serialize(writer, options);
                }
            }
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

        internal static ClusterUpgradePolicy DeserializeClusterUpgradePolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> forceRestart = default;
            TimeSpan upgradeReplicaSetCheckTimeout = default;
            TimeSpan healthCheckWaitDuration = default;
            TimeSpan healthCheckStableDuration = default;
            TimeSpan healthCheckRetryTimeout = default;
            TimeSpan upgradeTimeout = default;
            TimeSpan upgradeDomainTimeout = default;
            ClusterHealthPolicy healthPolicy = default;
            Optional<ClusterUpgradeDeltaHealthPolicy> deltaHealthPolicy = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forceRestart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceRestart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("upgradeReplicaSetCheckTimeout"u8))
                {
                    upgradeReplicaSetCheckTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    healthCheckRetryTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    upgradeTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    upgradeDomainTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthPolicy"u8))
                {
                    healthPolicy = ClusterHealthPolicy.DeserializeClusterHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("deltaHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaHealthPolicy = ClusterUpgradeDeltaHealthPolicy.DeserializeClusterUpgradeDeltaHealthPolicy(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterUpgradePolicy(Optional.ToNullable(forceRestart), upgradeReplicaSetCheckTimeout, healthCheckWaitDuration, healthCheckStableDuration, healthCheckRetryTimeout, upgradeTimeout, upgradeDomainTimeout, healthPolicy, deltaHealthPolicy.Value, serializedAdditionalRawData);
        }

        ClusterUpgradePolicy IModelJsonSerializable<ClusterUpgradePolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterUpgradePolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterUpgradePolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterUpgradePolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterUpgradePolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterUpgradePolicy IModelSerializable<ClusterUpgradePolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterUpgradePolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterUpgradePolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterUpgradePolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterUpgradePolicy"/> to convert. </param>
        public static implicit operator RequestContent(ClusterUpgradePolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterUpgradePolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterUpgradePolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterUpgradePolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
