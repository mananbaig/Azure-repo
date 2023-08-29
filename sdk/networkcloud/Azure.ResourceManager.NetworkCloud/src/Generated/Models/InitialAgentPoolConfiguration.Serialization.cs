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
    public partial class InitialAgentPoolConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<InitialAgentPoolConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InitialAgentPoolConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InitialAgentPoolConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                writer.WriteObjectValue(AdministratorConfiguration);
            }
            if (Optional.IsDefined(AgentOptions))
            {
                writer.WritePropertyName("agentOptions"u8);
                writer.WriteObjectValue(AgentOptions);
            }
            if (Optional.IsDefined(AttachedNetworkConfiguration))
            {
                writer.WritePropertyName("attachedNetworkConfiguration"u8);
                writer.WriteObjectValue(AttachedNetworkConfiguration);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Taints))
            {
                writer.WritePropertyName("taints"u8);
                writer.WriteStartArray();
                foreach (var item in Taints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings);
            }
            writer.WritePropertyName("vmSkuName"u8);
            writer.WriteStringValue(VmSkuName);
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

        internal static InitialAgentPoolConfiguration DeserializeInitialAgentPoolConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AdministratorConfiguration> administratorConfiguration = default;
            Optional<NetworkCloudAgentConfiguration> agentOptions = default;
            Optional<AttachedNetworkConfiguration> attachedNetworkConfiguration = default;
            Optional<IList<string>> availabilityZones = default;
            long count = default;
            Optional<IList<KubernetesLabel>> labels = default;
            NetworkCloudAgentPoolMode mode = default;
            string name = default;
            Optional<IList<KubernetesLabel>> taints = default;
            Optional<AgentPoolUpgradeSettings> upgradeSettings = default;
            string vmSkuName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("agentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentOptions = NetworkCloudAgentConfiguration.DeserializeNetworkCloudAgentConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("attachedNetworkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachedNetworkConfiguration = AttachedNetworkConfiguration.DeserializeAttachedNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesLabel> array = new List<KubernetesLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesLabel.DeserializeKubernetesLabel(item));
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = new NetworkCloudAgentPoolMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesLabel> array = new List<KubernetesLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesLabel.DeserializeKubernetesLabel(item));
                    }
                    taints = array;
                    continue;
                }
                if (property.NameEquals("upgradeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("vmSkuName"u8))
                {
                    vmSkuName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InitialAgentPoolConfiguration(administratorConfiguration.Value, agentOptions.Value, attachedNetworkConfiguration.Value, Optional.ToList(availabilityZones), count, Optional.ToList(labels), mode, name, Optional.ToList(taints), upgradeSettings.Value, vmSkuName, rawData);
        }

        InitialAgentPoolConfiguration IModelJsonSerializable<InitialAgentPoolConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInitialAgentPoolConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InitialAgentPoolConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InitialAgentPoolConfiguration IModelSerializable<InitialAgentPoolConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInitialAgentPoolConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InitialAgentPoolConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InitialAgentPoolConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInitialAgentPoolConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
