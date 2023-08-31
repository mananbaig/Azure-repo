// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmContainerInstanceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ContainerGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> The zones for the container group. </param>
        /// <param name="identity"> The identity of the container group, if configured. </param>
        /// <param name="provisioningState"> The provisioning state of the container group. This only appears in the response. </param>
        /// <param name="containers"> The containers within the container group. </param>
        /// <param name="imageRegistryCredentials"> The image registry credentials by which the container group is created from. </param>
        /// <param name="restartPolicy">
        /// Restart policy for all containers within the container group.
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        ///
        /// </param>
        /// <param name="ipAddress"> The IP address type of the container group. </param>
        /// <param name="osType"> The operating system type required by the containers in the container group. </param>
        /// <param name="volumes"> The list of volumes that can be mounted by containers in this container group. </param>
        /// <param name="instanceView"> The instance view of the container group. Only valid in response. </param>
        /// <param name="diagnosticsLogAnalytics"> The diagnostic information for a container group. </param>
        /// <param name="subnetIds"> The subnet resource IDs for a container group. </param>
        /// <param name="dnsConfig"> The DNS config information for a container group. </param>
        /// <param name="sku"> The SKU for a container group. </param>
        /// <param name="encryptionProperties"> The encryption properties for a container group. </param>
        /// <param name="initContainers"> The init containers for a container group. </param>
        /// <param name="extensions"> extensions used by virtual kubelet. </param>
        /// <param name="confidentialComputeCcePolicy"> The properties for confidential container group. </param>
        /// <param name="priority"> The priority of the container group. </param>
        /// <returns> A new <see cref="ContainerInstance.ContainerGroupData"/> instance for mocking. </returns>
        public static ContainerGroupData ContainerGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<string> zones = null, ManagedServiceIdentity identity = null, string provisioningState = null, IEnumerable<ContainerInstanceContainer> containers = null, IEnumerable<ContainerGroupImageRegistryCredential> imageRegistryCredentials = null, ContainerGroupRestartPolicy? restartPolicy = null, ContainerGroupIPAddress ipAddress = null, ContainerInstanceOperatingSystemType osType = default, IEnumerable<ContainerVolume> volumes = null, ContainerGroupInstanceView instanceView = null, ContainerGroupLogAnalytics diagnosticsLogAnalytics = null, IEnumerable<ContainerGroupSubnetId> subnetIds = null, ContainerGroupDnsConfiguration dnsConfig = null, ContainerGroupSku? sku = null, ContainerGroupEncryptionProperties encryptionProperties = null, IEnumerable<InitContainerDefinitionContent> initContainers = null, IEnumerable<DeploymentExtensionSpec> extensions = null, string confidentialComputeCcePolicy = null, ContainerGroupPriority? priority = null)
        {
            tags ??= new Dictionary<string, string>();
            zones ??= new List<string>();
            containers ??= new List<ContainerInstanceContainer>();
            imageRegistryCredentials ??= new List<ContainerGroupImageRegistryCredential>();
            volumes ??= new List<ContainerVolume>();
            subnetIds ??= new List<ContainerGroupSubnetId>();
            initContainers ??= new List<InitContainerDefinitionContent>();
            extensions ??= new List<DeploymentExtensionSpec>();

            return new ContainerGroupData(id, name, resourceType, systemData, tags, location, zones?.ToList(), identity, provisioningState, containers?.ToList(), imageRegistryCredentials?.ToList(), restartPolicy, ipAddress, osType, volumes?.ToList(), instanceView, diagnosticsLogAnalytics != null ? new ContainerGroupDiagnostics(diagnosticsLogAnalytics, new Dictionary<string, BinaryData>()) : null, subnetIds?.ToList(), dnsConfig, sku, encryptionProperties, initContainers?.ToList(), extensions?.ToList(), confidentialComputeCcePolicy != null ? new ConfidentialComputeProperties(confidentialComputeCcePolicy, new Dictionary<string, BinaryData>()) : null, priority, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> The zones for the container group. </param>
        /// <returns> A new <see cref="Models.ContainerGroupPatch"/> instance for mocking. </returns>
        public static ContainerGroupPatch ContainerGroupPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<string> zones = null)
        {
            tags ??= new Dictionary<string, string>();
            zones ??= new List<string>();

            return new ContainerGroupPatch(id, name, resourceType, systemData, tags, location, zones?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceContainer"/>. </summary>
        /// <param name="name"> The user-provided name of the container instance. </param>
        /// <param name="image"> The name of the image used to create the container instance. </param>
        /// <param name="command"> The commands to execute within the container instance in exec form. </param>
        /// <param name="ports"> The exposed ports on the container instance. </param>
        /// <param name="environmentVariables"> The environment variables to set in the container instance. </param>
        /// <param name="instanceView"> The instance view of the container instance. Only valid in response. </param>
        /// <param name="resources"> The resource requirements of the container instance. </param>
        /// <param name="volumeMounts"> The volume mounts available to the container instance. </param>
        /// <param name="livenessProbe"> The liveness probe. </param>
        /// <param name="readinessProbe"> The readiness probe. </param>
        /// <param name="securityContext"> The container security properties. </param>
        /// <returns> A new <see cref="Models.ContainerInstanceContainer"/> instance for mocking. </returns>
        public static ContainerInstanceContainer ContainerInstanceContainer(string name = null, string image = null, IEnumerable<string> command = null, IEnumerable<ContainerPort> ports = null, IEnumerable<ContainerEnvironmentVariable> environmentVariables = null, ContainerInstanceView instanceView = null, ContainerResourceRequirements resources = null, IEnumerable<ContainerVolumeMount> volumeMounts = null, ContainerProbe livenessProbe = null, ContainerProbe readinessProbe = null, ContainerSecurityContextDefinition securityContext = null)
        {
            command ??= new List<string>();
            ports ??= new List<ContainerPort>();
            environmentVariables ??= new List<ContainerEnvironmentVariable>();
            volumeMounts ??= new List<ContainerVolumeMount>();

            return new ContainerInstanceContainer(name, image, command?.ToList(), ports?.ToList(), environmentVariables?.ToList(), instanceView, resources, volumeMounts?.ToList(), livenessProbe, readinessProbe, securityContext, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceView"/>. </summary>
        /// <param name="restartCount"> The number of times that the container instance has been restarted. </param>
        /// <param name="currentState"> Current container instance state. </param>
        /// <param name="previousState"> Previous container instance state. </param>
        /// <param name="events"> The events of the container instance. </param>
        /// <returns> A new <see cref="Models.ContainerInstanceView"/> instance for mocking. </returns>
        public static ContainerInstanceView ContainerInstanceView(int? restartCount = null, ContainerState currentState = null, ContainerState previousState = null, IEnumerable<ContainerEvent> events = null)
        {
            events ??= new List<ContainerEvent>();

            return new ContainerInstanceView(restartCount, currentState, previousState, events?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerState"/>. </summary>
        /// <param name="state"> The state of the container instance. </param>
        /// <param name="startOn"> The date-time when the container instance state started. </param>
        /// <param name="exitCode"> The container instance exit codes correspond to those from the `docker run` command. </param>
        /// <param name="finishOn"> The date-time when the container instance state finished. </param>
        /// <param name="detailStatus"> The human-readable status of the container instance state. </param>
        /// <returns> A new <see cref="Models.ContainerState"/> instance for mocking. </returns>
        public static ContainerState ContainerState(string state = null, DateTimeOffset? startOn = null, int? exitCode = null, DateTimeOffset? finishOn = null, string detailStatus = null)
        {
            return new ContainerState(state, startOn, exitCode, finishOn, detailStatus, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerEvent"/>. </summary>
        /// <param name="count"> The count of the event. </param>
        /// <param name="firstTimestamp"> The date-time of the earliest logged event. </param>
        /// <param name="lastTimestamp"> The date-time of the latest logged event. </param>
        /// <param name="name"> The event name. </param>
        /// <param name="message"> The event message. </param>
        /// <param name="eventType"> The event type. </param>
        /// <returns> A new <see cref="Models.ContainerEvent"/> instance for mocking. </returns>
        public static ContainerEvent ContainerEvent(int? count = null, DateTimeOffset? firstTimestamp = null, DateTimeOffset? lastTimestamp = null, string name = null, string message = null, string eventType = null)
        {
            return new ContainerEvent(count, firstTimestamp, lastTimestamp, name, message, eventType, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupIPAddress"/>. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="addressType"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <param name="ip"> The IP exposed to the public internet. </param>
        /// <param name="dnsNameLabel"> The Dns name label for the IP. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> The value representing the security enum. The 'Unsecure' value is the default value if not selected and means the object's domain name label is not secured against subdomain takeover. The 'TenantReuse' value is the default value if selected and means the object's domain name label can be reused within the same tenant. The 'SubscriptionReuse' value means the object's domain name label can be reused within the same subscription. The 'ResourceGroupReuse' value means the object's domain name label can be reused within the same resource group. The 'NoReuse' value means the object's domain name label cannot be reused within the same resource group, subscription, or tenant. </param>
        /// <param name="fqdn"> The FQDN for the IP. </param>
        /// <returns> A new <see cref="Models.ContainerGroupIPAddress"/> instance for mocking. </returns>
        public static ContainerGroupIPAddress ContainerGroupIPAddress(IEnumerable<ContainerGroupPort> ports = null, ContainerGroupIPAddressType addressType = default, IPAddress ip = null, string dnsNameLabel = null, DnsNameLabelReusePolicy? autoGeneratedDomainNameLabelScope = null, string fqdn = null)
        {
            ports ??= new List<ContainerGroupPort>();

            return new ContainerGroupIPAddress(ports?.ToList(), addressType, ip, dnsNameLabel, autoGeneratedDomainNameLabelScope, fqdn, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupInstanceView"/>. </summary>
        /// <param name="events"> The events of this container group. </param>
        /// <param name="state"> The state of the container group. Only valid in response. </param>
        /// <returns> A new <see cref="Models.ContainerGroupInstanceView"/> instance for mocking. </returns>
        public static ContainerGroupInstanceView ContainerGroupInstanceView(IEnumerable<ContainerEvent> events = null, string state = null)
        {
            events ??= new List<ContainerEvent>();

            return new ContainerGroupInstanceView(events?.ToList(), state, default);
        }

        /// <summary> Initializes a new instance of <see cref="InitContainerDefinitionContent"/>. </summary>
        /// <param name="name"> The name for the init container. </param>
        /// <param name="image"> The image of the init container. </param>
        /// <param name="command"> The command to execute within the init container in exec form. </param>
        /// <param name="environmentVariables"> The environment variables to set in the init container. </param>
        /// <param name="instanceView"> The instance view of the init container. Only valid in response. </param>
        /// <param name="volumeMounts"> The volume mounts available to the init container. </param>
        /// <param name="securityContext"> The container security properties. </param>
        /// <returns> A new <see cref="Models.InitContainerDefinitionContent"/> instance for mocking. </returns>
        public static InitContainerDefinitionContent InitContainerDefinitionContent(string name = null, string image = null, IEnumerable<string> command = null, IEnumerable<ContainerEnvironmentVariable> environmentVariables = null, InitContainerPropertiesDefinitionInstanceView instanceView = null, IEnumerable<ContainerVolumeMount> volumeMounts = null, ContainerSecurityContextDefinition securityContext = null)
        {
            command ??= new List<string>();
            environmentVariables ??= new List<ContainerEnvironmentVariable>();
            volumeMounts ??= new List<ContainerVolumeMount>();

            return new InitContainerDefinitionContent(name, image, command?.ToList(), environmentVariables?.ToList(), instanceView, volumeMounts?.ToList(), securityContext, default);
        }

        /// <summary> Initializes a new instance of <see cref="InitContainerPropertiesDefinitionInstanceView"/>. </summary>
        /// <param name="restartCount"> The number of times that the init container has been restarted. </param>
        /// <param name="currentState"> The current state of the init container. </param>
        /// <param name="previousState"> The previous state of the init container. </param>
        /// <param name="events"> The events of the init container. </param>
        /// <returns> A new <see cref="Models.InitContainerPropertiesDefinitionInstanceView"/> instance for mocking. </returns>
        public static InitContainerPropertiesDefinitionInstanceView InitContainerPropertiesDefinitionInstanceView(int? restartCount = null, ContainerState currentState = null, ContainerState previousState = null, IEnumerable<ContainerEvent> events = null)
        {
            events ??= new List<ContainerEvent>();

            return new InitContainerPropertiesDefinitionInstanceView(restartCount, currentState, previousState, events?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceUsage"/>. </summary>
        /// <param name="id"> Id of the usage result. </param>
        /// <param name="unit"> Unit of the usage result. </param>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name object of the resource. </param>
        /// <returns> A new <see cref="Models.ContainerInstanceUsage"/> instance for mocking. </returns>
        public static ContainerInstanceUsage ContainerInstanceUsage(string id = null, string unit = null, int? currentValue = null, int? limit = null, ContainerInstanceUsageName name = null)
        {
            return new ContainerInstanceUsage(id, unit, currentValue, limit, name, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceUsageName"/>. </summary>
        /// <param name="value"> The name of the resource. </param>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        /// <returns> A new <see cref="Models.ContainerInstanceUsageName"/> instance for mocking. </returns>
        public static ContainerInstanceUsageName ContainerInstanceUsageName(string value = null, string localizedValue = null)
        {
            return new ContainerInstanceUsageName(value, localizedValue, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerLogs"/>. </summary>
        /// <param name="content"> The content of the log. </param>
        /// <returns> A new <see cref="Models.ContainerLogs"/> instance for mocking. </returns>
        public static ContainerLogs ContainerLogs(string content = null)
        {
            return new ContainerLogs(content, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerExecResult"/>. </summary>
        /// <param name="webSocketUri"> The uri for the exec websocket. </param>
        /// <param name="password"> The password to start the exec command. </param>
        /// <returns> A new <see cref="Models.ContainerExecResult"/> instance for mocking. </returns>
        public static ContainerExecResult ContainerExecResult(Uri webSocketUri = null, string password = null)
        {
            return new ContainerExecResult(webSocketUri, password, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAttachResult"/>. </summary>
        /// <param name="webSocketUri"> The uri for the output stream from the attach. </param>
        /// <param name="password"> The password to the output stream from the attach. Send as an Authorization header value when connecting to the websocketUri. </param>
        /// <returns> A new <see cref="Models.ContainerAttachResult"/> instance for mocking. </returns>
        public static ContainerAttachResult ContainerAttachResult(Uri webSocketUri = null, string password = null)
        {
            return new ContainerAttachResult(webSocketUri, password, default);
        }

        /// <summary> Initializes a new instance of <see cref="CachedImages"/>. </summary>
        /// <param name="osType"> The OS type of the cached image. </param>
        /// <param name="image"> The cached image name. </param>
        /// <returns> A new <see cref="Models.CachedImages"/> instance for mocking. </returns>
        public static CachedImages CachedImages(string osType = null, string image = null)
        {
            return new CachedImages(osType, image, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerCapabilities"/>. </summary>
        /// <param name="resourceType"> The resource type that this capability describes. </param>
        /// <param name="osType"> The OS type that this capability describes. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="ipAddressType"> The ip address type that this capability describes. </param>
        /// <param name="gpu"> The GPU sku that this capability describes. </param>
        /// <param name="capabilities"> The supported capabilities. </param>
        /// <returns> A new <see cref="Models.ContainerCapabilities"/> instance for mocking. </returns>
        public static ContainerCapabilities ContainerCapabilities(string resourceType = null, string osType = null, AzureLocation? location = null, string ipAddressType = null, string gpu = null, ContainerSupportedCapabilities capabilities = null)
        {
            return new ContainerCapabilities(resourceType, osType, location, ipAddressType, gpu, capabilities, default);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerSupportedCapabilities"/>. </summary>
        /// <param name="maxMemoryInGB"> The maximum allowed memory request in GB. </param>
        /// <param name="maxCpu"> The maximum allowed CPU request in cores. </param>
        /// <param name="maxGpuCount"> The maximum allowed GPU count. </param>
        /// <returns> A new <see cref="Models.ContainerSupportedCapabilities"/> instance for mocking. </returns>
        public static ContainerSupportedCapabilities ContainerSupportedCapabilities(float? maxMemoryInGB = null, float? maxCpu = null, float? maxGpuCount = null)
        {
            return new ContainerSupportedCapabilities(maxMemoryInGB, maxCpu, maxGpuCount, default);
        }
    }
}
