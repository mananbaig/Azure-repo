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
    [JsonConverter(typeof(HDInsightOnDemandLinkedServiceConverter))]
    public partial class HDInsightOnDemandLinkedService : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightOnDemandLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightOnDemandLinkedService>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightOnDemandLinkedService>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightOnDemandLinkedService>(this, options.Format);

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
            writer.WritePropertyName("clusterSize"u8);
            writer.WriteObjectValue(ClusterSize);
            writer.WritePropertyName("timeToLive"u8);
            writer.WriteObjectValue(TimeToLive);
            writer.WritePropertyName("version"u8);
            writer.WriteObjectValue(Version);
            writer.WritePropertyName("linkedServiceName"u8);
            if (LinkedServiceName is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<LinkedServiceReference>)LinkedServiceName).Serialize(writer, options);
            }
            writer.WritePropertyName("hostSubscriptionId"u8);
            writer.WriteObjectValue(HostSubscriptionId);
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                if (ServicePrincipalKey is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)ServicePrincipalKey).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("tenant"u8);
            writer.WriteObjectValue(Tenant);
            writer.WritePropertyName("clusterResourceGroup"u8);
            writer.WriteObjectValue(ClusterResourceGroup);
            if (Optional.IsDefined(ClusterNamePrefix))
            {
                writer.WritePropertyName("clusterNamePrefix"u8);
                writer.WriteObjectValue(ClusterNamePrefix);
            }
            if (Optional.IsDefined(ClusterUserName))
            {
                writer.WritePropertyName("clusterUserName"u8);
                writer.WriteObjectValue(ClusterUserName);
            }
            if (Optional.IsDefined(ClusterPassword))
            {
                writer.WritePropertyName("clusterPassword"u8);
                if (ClusterPassword is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)ClusterPassword).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ClusterSshUserName))
            {
                writer.WritePropertyName("clusterSshUserName"u8);
                writer.WriteObjectValue(ClusterSshUserName);
            }
            if (Optional.IsDefined(ClusterSshPassword))
            {
                writer.WritePropertyName("clusterSshPassword"u8);
                if (ClusterSshPassword is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecretBase>)ClusterSshPassword).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AdditionalLinkedServiceNames))
            {
                writer.WritePropertyName("additionalLinkedServiceNames"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalLinkedServiceNames)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<LinkedServiceReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HcatalogLinkedServiceName))
            {
                writer.WritePropertyName("hcatalogLinkedServiceName"u8);
                if (HcatalogLinkedServiceName is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LinkedServiceReference>)HcatalogLinkedServiceName).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType"u8);
                writer.WriteObjectValue(ClusterType);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteObjectValue(SparkVersion);
            }
            if (Optional.IsDefined(CoreConfiguration))
            {
                writer.WritePropertyName("coreConfiguration"u8);
                writer.WriteObjectValue(CoreConfiguration);
            }
            if (Optional.IsDefined(HBaseConfiguration))
            {
                writer.WritePropertyName("hBaseConfiguration"u8);
                writer.WriteObjectValue(HBaseConfiguration);
            }
            if (Optional.IsDefined(HdfsConfiguration))
            {
                writer.WritePropertyName("hdfsConfiguration"u8);
                writer.WriteObjectValue(HdfsConfiguration);
            }
            if (Optional.IsDefined(HiveConfiguration))
            {
                writer.WritePropertyName("hiveConfiguration"u8);
                writer.WriteObjectValue(HiveConfiguration);
            }
            if (Optional.IsDefined(MapReduceConfiguration))
            {
                writer.WritePropertyName("mapReduceConfiguration"u8);
                writer.WriteObjectValue(MapReduceConfiguration);
            }
            if (Optional.IsDefined(OozieConfiguration))
            {
                writer.WritePropertyName("oozieConfiguration"u8);
                writer.WriteObjectValue(OozieConfiguration);
            }
            if (Optional.IsDefined(StormConfiguration))
            {
                writer.WritePropertyName("stormConfiguration"u8);
                writer.WriteObjectValue(StormConfiguration);
            }
            if (Optional.IsDefined(YarnConfiguration))
            {
                writer.WritePropertyName("yarnConfiguration"u8);
                writer.WriteObjectValue(YarnConfiguration);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (Optional.IsDefined(HeadNodeSize))
            {
                writer.WritePropertyName("headNodeSize"u8);
                writer.WriteObjectValue(HeadNodeSize);
            }
            if (Optional.IsDefined(DataNodeSize))
            {
                writer.WritePropertyName("dataNodeSize"u8);
                writer.WriteObjectValue(DataNodeSize);
            }
            if (Optional.IsDefined(ZookeeperNodeSize))
            {
                writer.WritePropertyName("zookeeperNodeSize"u8);
                writer.WriteObjectValue(ZookeeperNodeSize);
            }
            if (Optional.IsCollectionDefined(ScriptActions))
            {
                writer.WritePropertyName("scriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ScriptAction>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteObjectValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(SubnetName))
            {
                writer.WritePropertyName("subnetName"u8);
                writer.WriteObjectValue(SubnetName);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                if (Credential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CredentialReference>)Credential).Serialize(writer, options);
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

        internal static HDInsightOnDemandLinkedService DeserializeHDInsightOnDemandLinkedService(JsonElement element, ModelSerializerOptions options = default)
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
            object clusterSize = default;
            object timeToLive = default;
            object version = default;
            LinkedServiceReference linkedServiceName = default;
            object hostSubscriptionId = default;
            Optional<object> servicePrincipalId = default;
            Optional<SecretBase> servicePrincipalKey = default;
            object tenant = default;
            object clusterResourceGroup = default;
            Optional<object> clusterNamePrefix = default;
            Optional<object> clusterUserName = default;
            Optional<SecretBase> clusterPassword = default;
            Optional<object> clusterSshUserName = default;
            Optional<SecretBase> clusterSshPassword = default;
            Optional<IList<LinkedServiceReference>> additionalLinkedServiceNames = default;
            Optional<LinkedServiceReference> hcatalogLinkedServiceName = default;
            Optional<object> clusterType = default;
            Optional<object> sparkVersion = default;
            Optional<object> coreConfiguration = default;
            Optional<object> hBaseConfiguration = default;
            Optional<object> hdfsConfiguration = default;
            Optional<object> hiveConfiguration = default;
            Optional<object> mapReduceConfiguration = default;
            Optional<object> oozieConfiguration = default;
            Optional<object> stormConfiguration = default;
            Optional<object> yarnConfiguration = default;
            Optional<object> encryptedCredential = default;
            Optional<object> headNodeSize = default;
            Optional<object> dataNodeSize = default;
            Optional<object> zookeeperNodeSize = default;
            Optional<IList<ScriptAction>> scriptActions = default;
            Optional<object> virtualNetworkId = default;
            Optional<object> subnetName = default;
            Optional<CredentialReference> credential = default;
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
                        if (property0.NameEquals("clusterSize"u8))
                        {
                            clusterSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("timeToLive"u8))
                        {
                            timeToLive = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"u8))
                        {
                            linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostSubscriptionId"u8))
                        {
                            hostSubscriptionId = property0.Value.GetObject();
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
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            tenant = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceGroup"u8))
                        {
                            clusterResourceGroup = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterNamePrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterNamePrefix = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterUserName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterSshUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshUserName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterSshPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalLinkedServiceNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                            }
                            additionalLinkedServiceNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hcatalogLinkedServiceName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hcatalogLinkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkVersion = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("coreConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coreConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hBaseConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hBaseConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hdfsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hdfsConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hiveConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hiveConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("mapReduceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mapReduceConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("oozieConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            oozieConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("stormConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stormConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("yarnConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            yarnConfiguration = property0.Value.GetObject();
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
                        if (property0.NameEquals("headNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            headNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("dataNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("zookeeperNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zookeeperNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scriptActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ScriptAction> array = new List<ScriptAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptAction.DeserializeScriptAction(item));
                            }
                            scriptActions = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("subnetName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = CredentialReference.DeserializeCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightOnDemandLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, clusterSize, timeToLive, version, linkedServiceName, hostSubscriptionId, servicePrincipalId.Value, servicePrincipalKey.Value, tenant, clusterResourceGroup, clusterNamePrefix.Value, clusterUserName.Value, clusterPassword.Value, clusterSshUserName.Value, clusterSshPassword.Value, Optional.ToList(additionalLinkedServiceNames), hcatalogLinkedServiceName.Value, clusterType.Value, sparkVersion.Value, coreConfiguration.Value, hBaseConfiguration.Value, hdfsConfiguration.Value, hiveConfiguration.Value, mapReduceConfiguration.Value, oozieConfiguration.Value, stormConfiguration.Value, yarnConfiguration.Value, encryptedCredential.Value, headNodeSize.Value, dataNodeSize.Value, zookeeperNodeSize.Value, Optional.ToList(scriptActions), virtualNetworkId.Value, subnetName.Value, credential.Value);
        }

        HDInsightOnDemandLinkedService IModelJsonSerializable<HDInsightOnDemandLinkedService>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightOnDemandLinkedService>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightOnDemandLinkedService(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightOnDemandLinkedService>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightOnDemandLinkedService>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightOnDemandLinkedService IModelSerializable<HDInsightOnDemandLinkedService>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightOnDemandLinkedService>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightOnDemandLinkedService(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightOnDemandLinkedService"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightOnDemandLinkedService"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightOnDemandLinkedService model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightOnDemandLinkedService"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightOnDemandLinkedService(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightOnDemandLinkedService(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class HDInsightOnDemandLinkedServiceConverter : JsonConverter<HDInsightOnDemandLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, HDInsightOnDemandLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HDInsightOnDemandLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHDInsightOnDemandLinkedService(document.RootElement);
            }
        }
    }
}
