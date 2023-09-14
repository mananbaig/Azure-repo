// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmHybridComputeModelFactory
    {
        /// <summary> Initializes a new instance of HybridComputeMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resources"> The list of extensions affiliated to the machine. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="locationData"> Metadata pertaining to the geographic location of the resource. </param>
        /// <param name="agentConfiguration"> Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM. </param>
        /// <param name="serviceStatuses"> Statuses of dependent services that are reported back to ARM. </param>
        /// <param name="cloudMetadataProvider"> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </param>
        /// <param name="agentUpgrade"> The info of the machine w.r.t Agent Upgrade. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the hybrid machine. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="status"> The status of the hybrid machine agent. </param>
        /// <param name="lastStatusChange"> The time of the last status change. </param>
        /// <param name="errorDetails"> Details about the error state. </param>
        /// <param name="agentVersion"> The hybrid machine agent full version. </param>
        /// <param name="vmId"> Specifies the hybrid machine unique ID. </param>
        /// <param name="displayName"> Specifies the hybrid machine display name. </param>
        /// <param name="machineFqdn"> Specifies the hybrid machine FQDN. </param>
        /// <param name="clientPublicKey"> Public Key that the client provides to be used during initial resource onboarding. </param>
        /// <param name="osName"> The Operating System running on the hybrid machine. </param>
        /// <param name="osVersion"> The version of Operating System running on the hybrid machine. </param>
        /// <param name="osType"> The type of Operating System (windows/linux). </param>
        /// <param name="vmUuid"> Specifies the Arc Machine's unique SMBIOS ID. </param>
        /// <param name="extensions"> Machine Extensions information (deprecated field). </param>
        /// <param name="osSku"> Specifies the Operating System product SKU. </param>
        /// <param name="domainName"> Specifies the Windows domain name. </param>
        /// <param name="adFqdn"> Specifies the AD fully qualified display name. </param>
        /// <param name="dnsFqdn"> Specifies the DNS fully qualified display name. </param>
        /// <param name="privateLinkScopeResourceId"> The resource id of the private link scope this machine is assigned to, if any. </param>
        /// <param name="parentClusterResourceId"> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </param>
        /// <param name="mssqlDiscovered"> Specifies whether any MS SQL instance is discovered on the machine. </param>
        /// <param name="detectedProperties"> Detected properties from the machine. </param>
        /// <returns> A new <see cref="HybridCompute.HybridComputeMachineData"/> instance for mocking. </returns>
        public static HybridComputeMachineData HybridComputeMachineData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<HybridComputeMachineExtensionData> resources = null, ManagedServiceIdentity identity = null, LocationData locationData = null, AgentConfiguration agentConfiguration = null, HybridComputeServiceStatuses serviceStatuses = null, string cloudMetadataProvider = null, AgentUpgrade agentUpgrade = null, OSProfile osProfile = null, string provisioningState = null, HybridComputeStatusType? status = null, DateTimeOffset? lastStatusChange = null, IEnumerable<ResponseError> errorDetails = null, string agentVersion = null, Guid? vmId = null, string displayName = null, string machineFqdn = null, string clientPublicKey = null, string osName = null, string osVersion = null, string osType = null, Guid? vmUuid = null, IEnumerable<MachineExtensionInstanceView> extensions = null, string osSku = null, string domainName = null, string adFqdn = null, string dnsFqdn = null, string privateLinkScopeResourceId = null, string parentClusterResourceId = null, string mssqlDiscovered = null, IReadOnlyDictionary<string, string> detectedProperties = null)
        {
            tags ??= new Dictionary<string, string>();
            resources ??= new List<HybridComputeMachineExtensionData>();
            errorDetails ??= new List<ResponseError>();
            extensions ??= new List<MachineExtensionInstanceView>();
            detectedProperties ??= new Dictionary<string, string>();

            return new HybridComputeMachineData(id, name, resourceType, systemData, tags, location, resources?.ToList(), identity, locationData, agentConfiguration, serviceStatuses, cloudMetadataProvider != null ? new CloudMetadata(cloudMetadataProvider) : null, agentUpgrade, osProfile, provisioningState, status, lastStatusChange, errorDetails?.ToList(), agentVersion, vmId, displayName, machineFqdn, clientPublicKey, osName, osVersion, osType, vmUuid, extensions?.ToList(), osSku, domainName, adFqdn, dnsFqdn, privateLinkScopeResourceId, parentClusterResourceId, mssqlDiscovered, detectedProperties);
        }

        /// <summary> Initializes a new instance of AgentConfiguration. </summary>
        /// <param name="proxyUri"> Specifies the URL of the proxy to be used. </param>
        /// <param name="incomingConnectionsPorts"> Specifies the list of ports that the agent will be able to listen on. </param>
        /// <param name="extensionsAllowList"> Array of extensions that are allowed to be installed or updated. </param>
        /// <param name="extensionsBlockList"> Array of extensions that are blocked (cannot be installed or updated). </param>
        /// <param name="proxyBypass"> List of service names which should not use the specified proxy server. </param>
        /// <param name="extensionsEnabled"> Specifies whether the extension service is enabled or disabled. </param>
        /// <param name="guestConfigurationEnabled"> Specified whether the guest configuration service is enabled or disabled. </param>
        /// <param name="configMode"> Name of configuration mode to use. Modes are pre-defined configurations of security controls, extension allowlists and guest configuration, maintained by Microsoft. </param>
        /// <returns> A new <see cref="Models.AgentConfiguration"/> instance for mocking. </returns>
        public static AgentConfiguration AgentConfiguration(Uri proxyUri = null, IEnumerable<string> incomingConnectionsPorts = null, IEnumerable<ConfigurationExtension> extensionsAllowList = null, IEnumerable<ConfigurationExtension> extensionsBlockList = null, IEnumerable<string> proxyBypass = null, string extensionsEnabled = null, string guestConfigurationEnabled = null, AgentConfigurationMode? configMode = null)
        {
            incomingConnectionsPorts ??= new List<string>();
            extensionsAllowList ??= new List<ConfigurationExtension>();
            extensionsBlockList ??= new List<ConfigurationExtension>();
            proxyBypass ??= new List<string>();

            return new AgentConfiguration(proxyUri, incomingConnectionsPorts?.ToList(), extensionsAllowList?.ToList(), extensionsBlockList?.ToList(), proxyBypass?.ToList(), extensionsEnabled, guestConfigurationEnabled, configMode);
        }

        /// <summary> Initializes a new instance of ConfigurationExtension. </summary>
        /// <param name="publisher"> Publisher of the extension. </param>
        /// <param name="configurationExtensionType"> Type of the extension. </param>
        /// <returns> A new <see cref="Models.ConfigurationExtension"/> instance for mocking. </returns>
        public static ConfigurationExtension ConfigurationExtension(string publisher = null, string configurationExtensionType = null)
        {
            return new ConfigurationExtension(publisher, configurationExtensionType);
        }

        /// <summary> Initializes a new instance of AgentUpgrade. </summary>
        /// <param name="desiredVersion"> Specifies the version info w.r.t AgentUpgrade for the machine. </param>
        /// <param name="correlationId"> The correlation ID passed in from RSM per upgrade. </param>
        /// <param name="enableAutomaticUpgrade"> Specifies if RSM should try to upgrade this machine. </param>
        /// <param name="lastAttemptTimestamp"> Timestamp of last upgrade attempt. </param>
        /// <param name="lastAttemptStatus"> Specifies the status of Agent Upgrade. </param>
        /// <param name="lastAttemptMessage"> Failure message of last upgrade attempt if any. </param>
        /// <returns> A new <see cref="Models.AgentUpgrade"/> instance for mocking. </returns>
        public static AgentUpgrade AgentUpgrade(string desiredVersion = null, Guid? correlationId = null, bool? enableAutomaticUpgrade = null, DateTimeOffset? lastAttemptTimestamp = null, LastAttemptStatusEnum? lastAttemptStatus = null, string lastAttemptMessage = null)
        {
            return new AgentUpgrade(desiredVersion, correlationId, enableAutomaticUpgrade, lastAttemptTimestamp, lastAttemptStatus, lastAttemptMessage);
        }

        /// <summary> Initializes a new instance of OSProfile. </summary>
        /// <param name="computerName"> Specifies the host OS name of the hybrid machine. </param>
        /// <param name="windowsConfiguration"> Specifies the windows configuration for update management. </param>
        /// <param name="linuxConfiguration"> Specifies the linux configuration for update management. </param>
        /// <returns> A new <see cref="Models.OSProfile"/> instance for mocking. </returns>
        public static OSProfile OSProfile(string computerName = null, OSProfileWindowsConfiguration windowsConfiguration = null, OSProfileLinuxConfiguration linuxConfiguration = null)
        {
            return new OSProfile(computerName, windowsConfiguration, linuxConfiguration);
        }

        /// <summary> Initializes a new instance of HybridComputeMachineExtensionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="forceUpdateTag"> How the extension handler should be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="typePropertiesType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The machine extension instance view. </param>
        /// <returns> A new <see cref="HybridCompute.HybridComputeMachineExtensionData"/> instance for mocking. </returns>
        public static HybridComputeMachineExtensionData HybridComputeMachineExtensionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string forceUpdateTag = null, string publisher = null, string typePropertiesType = null, string typeHandlerVersion = null, bool? enableAutomaticUpgrade = null, bool? autoUpgradeMinorVersion = null, IDictionary<string, BinaryData> settings = null, IDictionary<string, BinaryData> protectedSettings = null, string provisioningState = null, MachineExtensionInstanceView instanceView = null)
        {
            tags ??= new Dictionary<string, string>();
            settings ??= new Dictionary<string, BinaryData>();
            protectedSettings ??= new Dictionary<string, BinaryData>();

            return new HybridComputeMachineExtensionData(id, name, resourceType, systemData, tags, location, forceUpdateTag, publisher, typePropertiesType, typeHandlerVersion, enableAutomaticUpgrade, autoUpgradeMinorVersion, settings, protectedSettings, provisioningState, instanceView);
        }

        /// <summary> Initializes a new instance of MachineAssessPatchesResult. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </param>
        /// <param name="assessmentActivityId"> The activity ID of the operation that produced this result. </param>
        /// <param name="rebootPending"> The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred. </param>
        /// <param name="availablePatchCountByClassification"> Summarization of patches available for installation on the machine by classification. </param>
        /// <param name="startOn"> The UTC timestamp when the operation began. </param>
        /// <param name="lastModifiedOn"> The UTC timestamp when the operation finished. </param>
        /// <param name="startedBy"> Indicates if operation was triggered by user or by platform. </param>
        /// <param name="patchServiceUsed"> Specifies the patch service used for the operation. </param>
        /// <param name="osType"> The operating system type of the machine. </param>
        /// <param name="errorDetails"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        /// <returns> A new <see cref="Models.MachineAssessPatchesResult"/> instance for mocking. </returns>
        public static MachineAssessPatchesResult MachineAssessPatchesResult(PatchOperationStatus? status = null, Guid? assessmentActivityId = null, bool? rebootPending = null, AvailablePatchCountByClassification availablePatchCountByClassification = null, DateTimeOffset? startOn = null, DateTimeOffset? lastModifiedOn = null, PatchOperationStartedBy? startedBy = null, PatchServiceUsed? patchServiceUsed = null, OSType? osType = null, ResponseError errorDetails = null)
        {
            return new MachineAssessPatchesResult(status, assessmentActivityId, rebootPending, availablePatchCountByClassification, startOn, lastModifiedOn, startedBy, patchServiceUsed, osType, errorDetails);
        }

        /// <summary> Initializes a new instance of AvailablePatchCountByClassification. </summary>
        /// <param name="security"> Number of security patches available for installation. </param>
        /// <param name="critical"> Number of critical patches available for installation. </param>
        /// <param name="definition"> Number of definition patches available for installation. </param>
        /// <param name="updateRollup"> Number of update Rollup patches available for installation. </param>
        /// <param name="featurePack"> Number of feature pack patches available for installation. </param>
        /// <param name="servicePack"> Number of service pack patches available for installation. </param>
        /// <param name="tools"> Number of tools patches available for installation. </param>
        /// <param name="updates"> Number of updates category patches available for installation. </param>
        /// <param name="other"> Number of other patches available for installation. </param>
        /// <returns> A new <see cref="Models.AvailablePatchCountByClassification"/> instance for mocking. </returns>
        public static AvailablePatchCountByClassification AvailablePatchCountByClassification(int? security = null, int? critical = null, int? definition = null, int? updateRollup = null, int? featurePack = null, int? servicePack = null, int? tools = null, int? updates = null, int? other = null)
        {
            return new AvailablePatchCountByClassification(security, critical, definition, updateRollup, featurePack, servicePack, tools, updates, other);
        }

        /// <summary> Initializes a new instance of MachineInstallPatchesResult. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Failed", "Succeeded", "Unknown" or "CompletedWithWarnings.". </param>
        /// <param name="installationActivityId"> The activity ID of the operation that produced this result. </param>
        /// <param name="rebootStatus"> The reboot state of the VM following completion of the operation. </param>
        /// <param name="maintenanceWindowExceeded"> Whether the operation ran out of time before it completed all its intended actions. </param>
        /// <param name="excludedPatchCount"> The number of patches that were not installed due to the user blocking their installation. </param>
        /// <param name="notSelectedPatchCount"> The number of patches that were detected as available for install, but did not meet the operation's criteria. </param>
        /// <param name="pendingPatchCount"> The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically this happens when maintenanceWindowExceeded == true. </param>
        /// <param name="installedPatchCount"> The number of patches successfully installed. </param>
        /// <param name="failedPatchCount"> The number of patches that could not be installed due to some issue. See errors for details. </param>
        /// <param name="startOn"> The UTC timestamp when the operation began. </param>
        /// <param name="lastModifiedOn"> The UTC timestamp when the operation finished. </param>
        /// <param name="startedBy"> Indicates if operation was triggered by user or by platform. </param>
        /// <param name="patchServiceUsed"> Specifies the patch service used for the operation. </param>
        /// <param name="osType"> The operating system type of the machine. </param>
        /// <param name="errorDetails"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        /// <returns> A new <see cref="Models.MachineInstallPatchesResult"/> instance for mocking. </returns>
        public static MachineInstallPatchesResult MachineInstallPatchesResult(PatchOperationStatus? status = null, string installationActivityId = null, VmGuestPatchRebootStatus? rebootStatus = null, bool? maintenanceWindowExceeded = null, int? excludedPatchCount = null, int? notSelectedPatchCount = null, int? pendingPatchCount = null, int? installedPatchCount = null, int? failedPatchCount = null, DateTimeOffset? startOn = null, DateTimeOffset? lastModifiedOn = null, PatchOperationStartedBy? startedBy = null, PatchServiceUsed? patchServiceUsed = null, OSType? osType = null, ResponseError errorDetails = null)
        {
            return new MachineInstallPatchesResult(status, installationActivityId, rebootStatus, maintenanceWindowExceeded, excludedPatchCount, notSelectedPatchCount, pendingPatchCount, installedPatchCount, failedPatchCount, startOn, lastModifiedOn, startedBy, patchServiceUsed, osType, errorDetails);
        }

        /// <summary> Initializes a new instance of ExtensionValueData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="extensionType"> The type of the Extension being received. </param>
        /// <param name="publisher"> The publisher of the Extension being received. </param>
        /// <returns> A new <see cref="HybridCompute.ExtensionValueData"/> instance for mocking. </returns>
        public static ExtensionValueData ExtensionValueData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string version = null, string extensionType = null, string publisher = null)
        {
            return new ExtensionValueData(id, name, resourceType, systemData, version, extensionType, publisher);
        }

        /// <summary> Initializes a new instance of NetworkProfile. </summary>
        /// <param name="networkInterfaces"> The list of network interfaces. </param>
        /// <returns> A new <see cref="Models.NetworkProfile"/> instance for mocking. </returns>
        public static NetworkProfile NetworkProfile(IEnumerable<NetworkInterface> networkInterfaces = null)
        {
            networkInterfaces ??= new List<NetworkInterface>();

            return new NetworkProfile(networkInterfaces?.ToList());
        }

        /// <summary> Initializes a new instance of NetworkInterface. </summary>
        /// <param name="ipAddresses"> The list of IP addresses in this interface. </param>
        /// <returns> A new <see cref="Models.NetworkInterface"/> instance for mocking. </returns>
        public static NetworkInterface NetworkInterface(IEnumerable<IPAddress> ipAddresses = null)
        {
            ipAddresses ??= new List<IPAddress>();

            return new NetworkInterface(ipAddresses?.ToList());
        }

        /// <summary> Initializes a new instance of IPAddress. </summary>
        /// <param name="address"> Represents the IP Address. </param>
        /// <param name="ipAddressVersion"> Represents the Ip Address Version. </param>
        /// <param name="subnetAddressPrefix"> The subnet to which this IP address belongs. </param>
        /// <returns> A new <see cref="Models.IPAddress"/> instance for mocking. </returns>
        public static IPAddress IPAddress(string address = null, string ipAddressVersion = null, string subnetAddressPrefix = null)
        {
            return new IPAddress(address, ipAddressVersion, subnetAddressPrefix != null ? new Subnet(subnetAddressPrefix) : null);
        }

        /// <summary> Initializes a new instance of HybridComputePrivateLinkScopeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties that define a Azure Arc PrivateLinkScope resource. </param>
        /// <returns> A new <see cref="HybridCompute.HybridComputePrivateLinkScopeData"/> instance for mocking. </returns>
        public static HybridComputePrivateLinkScopeData HybridComputePrivateLinkScopeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HybridComputePrivateLinkScopeProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HybridComputePrivateLinkScopeData(id, name, resourceType, systemData, tags, location, properties);
        }

        /// <summary> Initializes a new instance of HybridComputePrivateLinkScopeProperties. </summary>
        /// <param name="publicNetworkAccess"> Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints. </param>
        /// <param name="provisioningState"> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </param>
        /// <param name="privateLinkScopeId"> The Guid id of the private link scope. </param>
        /// <param name="privateEndpointConnections"> The collection of associated Private Endpoint Connections. </param>
        /// <returns> A new <see cref="Models.HybridComputePrivateLinkScopeProperties"/> instance for mocking. </returns>
        public static HybridComputePrivateLinkScopeProperties HybridComputePrivateLinkScopeProperties(PublicNetworkAccessType? publicNetworkAccess = null, string provisioningState = null, string privateLinkScopeId = null, IEnumerable<PrivateEndpointConnectionDataModel> privateEndpointConnections = null)
        {
            privateEndpointConnections ??= new List<PrivateEndpointConnectionDataModel>();

            return new HybridComputePrivateLinkScopeProperties(publicNetworkAccess, provisioningState, privateLinkScopeId, privateEndpointConnections?.ToList());
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionDataModel. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The Private Endpoint Connection properties. </param>
        /// <returns> A new <see cref="Models.PrivateEndpointConnectionDataModel"/> instance for mocking. </returns>
        public static PrivateEndpointConnectionDataModel PrivateEndpointConnectionDataModel(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PrivateEndpointConnectionProperties properties = null)
        {
            return new PrivateEndpointConnectionDataModel(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProperties. </summary>
        /// <param name="privateEndpointId"> Private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <param name="groupIds"> List of group IDs. </param>
        /// <returns> A new <see cref="Models.PrivateEndpointConnectionProperties"/> instance for mocking. </returns>
        public static PrivateEndpointConnectionProperties PrivateEndpointConnectionProperties(ResourceIdentifier privateEndpointId = null, HybridComputePrivateLinkServiceConnectionStateProperty connectionState = null, string provisioningState = null, IEnumerable<string> groupIds = null)
        {
            groupIds ??= new List<string>();

            return new PrivateEndpointConnectionProperties(privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState, groupIds?.ToList());
        }

        /// <summary> Initializes a new instance of HybridComputePrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        /// <returns> A new <see cref="Models.HybridComputePrivateLinkServiceConnectionStateProperty"/> instance for mocking. </returns>
        public static HybridComputePrivateLinkServiceConnectionStateProperty HybridComputePrivateLinkServiceConnectionStateProperty(string status = null, string description = null, string actionsRequired = null)
        {
            return new HybridComputePrivateLinkServiceConnectionStateProperty(status, description, actionsRequired);
        }

        /// <summary> Initializes a new instance of HybridComputePrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Resource properties. </param>
        /// <returns> A new <see cref="HybridCompute.HybridComputePrivateLinkResourceData"/> instance for mocking. </returns>
        public static HybridComputePrivateLinkResourceData HybridComputePrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, HybridComputePrivateLinkResourceProperties properties = null)
        {
            return new HybridComputePrivateLinkResourceData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of HybridComputePrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        /// <returns> A new <see cref="Models.HybridComputePrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static HybridComputePrivateLinkResourceProperties HybridComputePrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new HybridComputePrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList());
        }

        /// <summary> Initializes a new instance of HybridComputePrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Resource properties. </param>
        /// <returns> A new <see cref="HybridCompute.HybridComputePrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static HybridComputePrivateEndpointConnectionData HybridComputePrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PrivateEndpointConnectionProperties properties = null)
        {
            return new HybridComputePrivateEndpointConnectionData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of PrivateLinkScopeValidationDetails. </summary>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="publicNetworkAccess"> Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints. </param>
        /// <param name="connectionDetails"> List of Private Endpoint Connection details. </param>
        /// <returns> A new <see cref="Models.PrivateLinkScopeValidationDetails"/> instance for mocking. </returns>
        public static PrivateLinkScopeValidationDetails PrivateLinkScopeValidationDetails(string id = null, PublicNetworkAccessType? publicNetworkAccess = null, IEnumerable<ConnectionDetail> connectionDetails = null)
        {
            connectionDetails ??= new List<ConnectionDetail>();

            return new PrivateLinkScopeValidationDetails(id, publicNetworkAccess, connectionDetails?.ToList());
        }

        /// <summary> Initializes a new instance of ConnectionDetail. </summary>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="privateIPAddress"> The private endpoint connection private ip address. </param>
        /// <param name="linkIdentifier"> The private endpoint connection link identifier. </param>
        /// <param name="groupId"> The private endpoint connection group id. </param>
        /// <param name="memberName"> The private endpoint connection member name. </param>
        /// <returns> A new <see cref="Models.ConnectionDetail"/> instance for mocking. </returns>
        public static ConnectionDetail ConnectionDetail(string id = null, string privateIPAddress = null, string linkIdentifier = null, string groupId = null, string memberName = null)
        {
            return new ConnectionDetail(id, privateIPAddress, linkIdentifier, groupId, memberName);
        }
    }
}
