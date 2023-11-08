// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFabricSpecificDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFabricSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFabricSpecificDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<InMageRcmFabricSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(VMwareSiteId))
                {
                    writer.WritePropertyName("vmwareSiteId"u8);
                    writer.WriteStringValue(VMwareSiteId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PhysicalSiteId))
                {
                    writer.WritePropertyName("physicalSiteId"u8);
                    writer.WriteStringValue(PhysicalSiteId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ServiceEndpoint))
                {
                    writer.WritePropertyName("serviceEndpoint"u8);
                    writer.WriteStringValue(ServiceEndpoint);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ServiceResourceId))
                {
                    writer.WritePropertyName("serviceResourceId"u8);
                    writer.WriteStringValue(ServiceResourceId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ServiceContainerId))
                {
                    writer.WritePropertyName("serviceContainerId"u8);
                    writer.WriteStringValue(ServiceContainerId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DataPlaneUri))
                {
                    writer.WritePropertyName("dataPlaneUri"u8);
                    writer.WriteStringValue(DataPlaneUri.AbsoluteUri);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ControlPlaneUri))
                {
                    writer.WritePropertyName("controlPlaneUri"u8);
                    writer.WriteStringValue(ControlPlaneUri.AbsoluteUri);
                }
            }
            if (Optional.IsDefined(SourceAgentIdentityDetails))
            {
                writer.WritePropertyName("sourceAgentIdentityDetails"u8);
                writer.WriteObjectValue(SourceAgentIdentityDetails);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(ProcessServers))
                {
                    writer.WritePropertyName("processServers"u8);
                    writer.WriteStartArray();
                    foreach (var item in ProcessServers)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(RcmProxies))
                {
                    writer.WritePropertyName("rcmProxies"u8);
                    writer.WriteStartArray();
                    foreach (var item in RcmProxies)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(PushInstallers))
                {
                    writer.WritePropertyName("pushInstallers"u8);
                    writer.WriteStartArray();
                    foreach (var item in PushInstallers)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(ReplicationAgents))
                {
                    writer.WritePropertyName("replicationAgents"u8);
                    writer.WriteStartArray();
                    foreach (var item in ReplicationAgents)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(ReprotectAgents))
                {
                    writer.WritePropertyName("reprotectAgents"u8);
                    writer.WriteStartArray();
                    foreach (var item in ReprotectAgents)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(MarsAgents))
                {
                    writer.WritePropertyName("marsAgents"u8);
                    writer.WriteStartArray();
                    foreach (var item in MarsAgents)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Dras))
                {
                    writer.WritePropertyName("dras"u8);
                    writer.WriteStartArray();
                    foreach (var item in Dras)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(AgentDetails))
                {
                    writer.WritePropertyName("agentDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in AgentDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InMageRcmFabricSpecificDetails IJsonModel<InMageRcmFabricSpecificDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFabricSpecificDetails(document.RootElement, options);
        }

        internal static InMageRcmFabricSpecificDetails DeserializeInMageRcmFabricSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> vmwareSiteId = default;
            Optional<ResourceIdentifier> physicalSiteId = default;
            Optional<string> serviceEndpoint = default;
            Optional<ResourceIdentifier> serviceResourceId = default;
            Optional<string> serviceContainerId = default;
            Optional<Uri> dataPlaneUri = default;
            Optional<Uri> controlPlaneUri = default;
            Optional<IdentityProviderDetails> sourceAgentIdentityDetails = default;
            Optional<IReadOnlyList<SiteRecoveryProcessServerDetails>> processServers = default;
            Optional<IReadOnlyList<RcmProxyDetails>> rcmProxies = default;
            Optional<IReadOnlyList<PushInstallerDetails>> pushInstallers = default;
            Optional<IReadOnlyList<ReplicationAgentDetails>> replicationAgents = default;
            Optional<IReadOnlyList<ReprotectAgentDetails>> reprotectAgents = default;
            Optional<IReadOnlyList<MarsAgentDetails>> marsAgents = default;
            Optional<IReadOnlyList<SiteRecoveryDraDetails>> dras = default;
            Optional<IReadOnlyList<SiteRecoveryAgentDetails>> agentDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("physicalSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceEndpoint"u8))
                {
                    serviceEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceContainerId"u8))
                {
                    serviceContainerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPlaneUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controlPlaneUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlPlaneUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceAgentIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceAgentIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("processServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryProcessServerDetails> array = new List<SiteRecoveryProcessServerDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryProcessServerDetails.DeserializeSiteRecoveryProcessServerDetails(item));
                    }
                    processServers = array;
                    continue;
                }
                if (property.NameEquals("rcmProxies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RcmProxyDetails> array = new List<RcmProxyDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RcmProxyDetails.DeserializeRcmProxyDetails(item));
                    }
                    rcmProxies = array;
                    continue;
                }
                if (property.NameEquals("pushInstallers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PushInstallerDetails> array = new List<PushInstallerDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PushInstallerDetails.DeserializePushInstallerDetails(item));
                    }
                    pushInstallers = array;
                    continue;
                }
                if (property.NameEquals("replicationAgents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicationAgentDetails> array = new List<ReplicationAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationAgentDetails.DeserializeReplicationAgentDetails(item));
                    }
                    replicationAgents = array;
                    continue;
                }
                if (property.NameEquals("reprotectAgents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReprotectAgentDetails> array = new List<ReprotectAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReprotectAgentDetails.DeserializeReprotectAgentDetails(item));
                    }
                    reprotectAgents = array;
                    continue;
                }
                if (property.NameEquals("marsAgents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MarsAgentDetails> array = new List<MarsAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarsAgentDetails.DeserializeMarsAgentDetails(item));
                    }
                    marsAgents = array;
                    continue;
                }
                if (property.NameEquals("dras"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDraDetails> array = new List<SiteRecoveryDraDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDraDetails.DeserializeSiteRecoveryDraDetails(item));
                    }
                    dras = array;
                    continue;
                }
                if (property.NameEquals("agentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryAgentDetails> array = new List<SiteRecoveryAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryAgentDetails.DeserializeSiteRecoveryAgentDetails(item));
                    }
                    agentDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFabricSpecificDetails(instanceType, serializedAdditionalRawData, vmwareSiteId.Value, physicalSiteId.Value, serviceEndpoint.Value, serviceResourceId.Value, serviceContainerId.Value, dataPlaneUri.Value, controlPlaneUri.Value, sourceAgentIdentityDetails.Value, Optional.ToList(processServers), Optional.ToList(rcmProxies), Optional.ToList(pushInstallers), Optional.ToList(replicationAgents), Optional.ToList(reprotectAgents), Optional.ToList(marsAgents), Optional.ToList(dras), Optional.ToList(agentDetails));
        }

        BinaryData IModel<InMageRcmFabricSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InMageRcmFabricSpecificDetails IModel<InMageRcmFabricSpecificDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInMageRcmFabricSpecificDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<InMageRcmFabricSpecificDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
