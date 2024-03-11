// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Non versioned Container App configuration properties that define the mutable settings of a Container app. </summary>
    public partial class ContainerAppConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppConfiguration"/>. </summary>
        public ContainerAppConfiguration()
        {
            Secrets = new ChangeTrackingList<ContainerAppWritableSecret>();
            Registries = new ChangeTrackingList<ContainerAppRegistryCredentials>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppConfiguration"/>. </summary>
        /// <param name="secrets"> Collection of secrets used by a Container app. </param>
        /// <param name="activeRevisionsMode">
        /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
        /// &lt;list&gt;&lt;item&gt;Multiple: multiple revisions can be active.&lt;/item&gt;&lt;item&gt;Single: Only one revision can be active at a time. Revision weights can not be used in this mode. If no value if provided, this is the default.&lt;/item&gt;&lt;/list&gt;
        /// </param>
        /// <param name="ingress"> Ingress configurations. </param>
        /// <param name="registries"> Collection of private container registry credentials for containers used by the Container app. </param>
        /// <param name="dapr"> Dapr configuration for the Container App. </param>
        /// <param name="maxInactiveRevisions"> Optional. Max inactive revisions a Container App can have. </param>
        /// <param name="service"> Container App to be a dev Container App Service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppConfiguration(IList<ContainerAppWritableSecret> secrets, ContainerAppActiveRevisionsMode? activeRevisionsMode, ContainerAppIngressConfiguration ingress, IList<ContainerAppRegistryCredentials> registries, ContainerAppDaprConfiguration dapr, int? maxInactiveRevisions, Service service, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Secrets = secrets;
            ActiveRevisionsMode = activeRevisionsMode;
            Ingress = ingress;
            Registries = registries;
            Dapr = dapr;
            MaxInactiveRevisions = maxInactiveRevisions;
            Service = service;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Collection of secrets used by a Container app. </summary>
        public IList<ContainerAppWritableSecret> Secrets { get; }
        /// <summary>
        /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
        /// &lt;list&gt;&lt;item&gt;Multiple: multiple revisions can be active.&lt;/item&gt;&lt;item&gt;Single: Only one revision can be active at a time. Revision weights can not be used in this mode. If no value if provided, this is the default.&lt;/item&gt;&lt;/list&gt;
        /// </summary>
        public ContainerAppActiveRevisionsMode? ActiveRevisionsMode { get; set; }
        /// <summary> Ingress configurations. </summary>
        public ContainerAppIngressConfiguration Ingress { get; set; }
        /// <summary> Collection of private container registry credentials for containers used by the Container app. </summary>
        public IList<ContainerAppRegistryCredentials> Registries { get; }
        /// <summary> Dapr configuration for the Container App. </summary>
        public ContainerAppDaprConfiguration Dapr { get; set; }
        /// <summary> Optional. Max inactive revisions a Container App can have. </summary>
        public int? MaxInactiveRevisions { get; set; }
        /// <summary> Container App to be a dev Container App Service. </summary>
        internal Service Service { get; set; }
        /// <summary> Dev ContainerApp service type. </summary>
        public string ServiceType
        {
            get => Service is null ? default : Service.ServiceType;
            set => Service = new Service(value);
        }
    }
}
