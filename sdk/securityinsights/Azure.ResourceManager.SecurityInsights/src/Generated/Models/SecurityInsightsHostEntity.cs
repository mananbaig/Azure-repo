// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents a host entity.
    /// Serialized Name: HostEntity
    /// </summary>
    public partial class SecurityInsightsHostEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsHostEntity"/>. </summary>
        public SecurityInsightsHostEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.Host;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsHostEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The kind of the entity.
        /// Serialized Name: Entity.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="additionalData">
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: HostEntity.properties.additionalData
        /// </param>
        /// <param name="friendlyName">
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: HostEntity.properties.friendlyName
        /// </param>
        /// <param name="azureId">
        /// The azure resource id of the VM.
        /// Serialized Name: HostEntity.properties.azureID
        /// </param>
        /// <param name="dnsDomain">
        /// The DNS domain that this host belongs to. Should contain the compete DNS suffix for the domain
        /// Serialized Name: HostEntity.properties.dnsDomain
        /// </param>
        /// <param name="hostName">
        /// The hostname without the domain suffix.
        /// Serialized Name: HostEntity.properties.hostName
        /// </param>
        /// <param name="isDomainJoined">
        /// Determines whether this host belongs to a domain.
        /// Serialized Name: HostEntity.properties.isDomainJoined
        /// </param>
        /// <param name="netBiosName">
        /// The host name (pre-windows2000).
        /// Serialized Name: HostEntity.properties.netBiosName
        /// </param>
        /// <param name="ntDomain">
        /// The NT domain that this host belongs to.
        /// Serialized Name: HostEntity.properties.ntDomain
        /// </param>
        /// <param name="omsAgentId">
        /// The OMS agent id, if the host has OMS agent installed.
        /// Serialized Name: HostEntity.properties.omsAgentID
        /// </param>
        /// <param name="osFamily">
        /// The operating system type.
        /// Serialized Name: HostEntity.properties.osFamily
        /// </param>
        /// <param name="osVersion">
        /// A free text representation of the operating system. This field is meant to hold specific versions the are more fine grained than OSFamily or future values not supported by OSFamily enumeration
        /// Serialized Name: HostEntity.properties.osVersion
        /// </param>
        internal SecurityInsightsHostEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, ResourceIdentifier azureId, string dnsDomain, string hostName, bool? isDomainJoined, string netBiosName, string ntDomain, string omsAgentId, SecurityInsightsHostOSFamily? osFamily, string osVersion) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AzureId = azureId;
            DnsDomain = dnsDomain;
            HostName = hostName;
            IsDomainJoined = isDomainJoined;
            NetBiosName = netBiosName;
            NtDomain = ntDomain;
            OmsAgentId = omsAgentId;
            OSFamily = osFamily;
            OSVersion = osVersion;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: HostEntity.properties.additionalData
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: HostEntity.properties.friendlyName
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The azure resource id of the VM.
        /// Serialized Name: HostEntity.properties.azureID
        /// </summary>
        public ResourceIdentifier AzureId { get; }
        /// <summary>
        /// The DNS domain that this host belongs to. Should contain the compete DNS suffix for the domain
        /// Serialized Name: HostEntity.properties.dnsDomain
        /// </summary>
        public string DnsDomain { get; }
        /// <summary>
        /// The hostname without the domain suffix.
        /// Serialized Name: HostEntity.properties.hostName
        /// </summary>
        public string HostName { get; }
        /// <summary>
        /// Determines whether this host belongs to a domain.
        /// Serialized Name: HostEntity.properties.isDomainJoined
        /// </summary>
        public bool? IsDomainJoined { get; }
        /// <summary>
        /// The host name (pre-windows2000).
        /// Serialized Name: HostEntity.properties.netBiosName
        /// </summary>
        public string NetBiosName { get; }
        /// <summary>
        /// The NT domain that this host belongs to.
        /// Serialized Name: HostEntity.properties.ntDomain
        /// </summary>
        public string NtDomain { get; }
        /// <summary>
        /// The OMS agent id, if the host has OMS agent installed.
        /// Serialized Name: HostEntity.properties.omsAgentID
        /// </summary>
        public string OmsAgentId { get; }
        /// <summary>
        /// The operating system type.
        /// Serialized Name: HostEntity.properties.osFamily
        /// </summary>
        public SecurityInsightsHostOSFamily? OSFamily { get; set; }
        /// <summary>
        /// A free text representation of the operating system. This field is meant to hold specific versions the are more fine grained than OSFamily or future values not supported by OSFamily enumeration
        /// Serialized Name: HostEntity.properties.osVersion
        /// </summary>
        public string OSVersion { get; }
    }
}
