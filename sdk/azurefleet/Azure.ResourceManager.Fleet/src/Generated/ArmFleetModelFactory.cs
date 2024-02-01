// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Fleet;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmFleetModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Fleet.FleetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> Zones in which the Azure Fleet is available. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="spotPriorityProfile"> Configuration Options for Spot instances in Azure Fleet. </param>
        /// <param name="regularPriorityProfile"> Configuration Options for On-Demand instances in Azure Fleet. </param>
        /// <param name="vmSizesProfile"> List of VM sizes supported for Fleet. </param>
        /// <param name="computeProfile"> Compute Profile to use for running user's workloads. </param>
        /// <returns> A new <see cref="Fleet.FleetData"/> instance for mocking. </returns>
        public static FleetData FleetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<string> zones = null, ProvisioningState? provisioningState = null, SpotPriorityProfile spotPriorityProfile = null, RegularPriorityProfile regularPriorityProfile = null, IEnumerable<VmSizeProfile> vmSizesProfile = null, ComputeProfile computeProfile = null)
        {
            tags ??= new Dictionary<string, string>();
            zones ??= new List<string>();
            vmSizesProfile ??= new List<VmSizeProfile>();

            return new FleetData(id, name, resourceType, systemData, tags, location, zones?.ToList(), provisioningState, spotPriorityProfile, regularPriorityProfile, vmSizesProfile?.ToList(), computeProfile);
        }

        /// <summary> Initializes a new instance of <see cref="Models.VirtualMachineScaleSetVmProfile"/>. </summary>
        /// <param name="osProfile"> Specifies the operating system settings for the virtual machines in the scale set. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="networkProfile"> Specifies properties of the network interfaces of the virtual machines in the scale set. </param>
        /// <param name="securityProfile"> Specifies the Security related profile settings for the virtual machines in the scale set. </param>
        /// <param name="bootDiagnostics"> Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15. </param>
        /// <param name="extensionProfile"> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="priority"> Specifies the priority for the virtual machines in the scale set. Minimum api-version: 2017-10-30-preview. </param>
        /// <param name="evictionPolicy"> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview. </param>
        /// <param name="billingMaxPrice"> Specifies the billing related details of a Azure Spot VMSS. Minimum api-version: 2019-03-01. </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        /// <param name="userData"> UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass any secrets in here. Minimum api-version: 2021-03-01. </param>
        /// <param name="capacityReservationGroupId"> Specifies the capacity reservation related details of a scale set. Minimum api-version: 2021-04-01. </param>
        /// <param name="galleryApplications"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        /// <param name="hardwareVmSizeProperties"> Specifies the hardware profile related details of a scale set. Minimum api-version: 2021-11-01. </param>
        /// <param name="serviceArtifactReferenceId"> Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when using 'latest' image version. Minimum api-version: 2022-11-01. </param>
        /// <param name="securityPostureReference"> Specifies the security posture to be used for all virtual machines in the scale set. Minimum api-version: 2023-03-01. </param>
        /// <param name="timeCreated"> Specifies the time in which this VM profile for the Virtual Machine Scale Set was created. Minimum API version for this property is 2023-09-01. This value will be added to VMSS Flex VM tags when creating/updating the VMSS VM Profile with minimum api-version 2023-09-01. </param>
        /// <returns> A new <see cref="Models.VirtualMachineScaleSetVmProfile"/> instance for mocking. </returns>
        public static VirtualMachineScaleSetVmProfile VirtualMachineScaleSetVmProfile(VirtualMachineScaleSetOSProfile osProfile = null, VirtualMachineScaleSetStorageProfile storageProfile = null, VirtualMachineScaleSetNetworkProfile networkProfile = null, SecurityProfile securityProfile = null, BootDiagnostics bootDiagnostics = null, VirtualMachineScaleSetExtensionProfile extensionProfile = null, string licenseType = null, VirtualMachinePriorityType? priority = null, VirtualMachineEvictionPolicyType? evictionPolicy = null, double? billingMaxPrice = null, ScheduledEventsProfile scheduledEventsProfile = null, string userData = null, ResourceIdentifier capacityReservationGroupId = null, IEnumerable<VmGalleryApplication> galleryApplications = null, VmSizeProperties hardwareVmSizeProperties = null, ResourceIdentifier serviceArtifactReferenceId = null, SecurityPostureReference securityPostureReference = null, DateTimeOffset? timeCreated = null)
        {
            galleryApplications ??= new List<VmGalleryApplication>();

            return new VirtualMachineScaleSetVmProfile(osProfile, storageProfile, networkProfile, securityProfile, bootDiagnostics != null ? new DiagnosticsProfile(bootDiagnostics) : null, extensionProfile, licenseType, priority, evictionPolicy, billingMaxPrice != null ? new BillingProfile(billingMaxPrice) : null, scheduledEventsProfile, userData, capacityReservationGroupId != null ? new CapacityReservationProfile(ResourceManagerModelFactory.WritableSubResource(capacityReservationGroupId)) : null, galleryApplications != null ? new ApplicationProfile(galleryApplications?.ToList()) : null, hardwareVmSizeProperties != null ? new VirtualMachineScaleSetHardwareProfile(hardwareVmSizeProperties) : null, serviceArtifactReferenceId != null ? ResourceManagerModelFactory.WritableSubResource(serviceArtifactReferenceId) : null, securityPostureReference, timeCreated);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ImageReference"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="publisher"> The image publisher. </param>
        /// <param name="offer"> Specifies the offer of the platform image or marketplace image used to create the virtual machine. </param>
        /// <param name="sku"> The image SKU. </param>
        /// <param name="version"> Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available. Please do not use field 'version' for gallery image deployment, gallery image should always use 'id' field for deployment, to use 'latest' version of gallery image, just set '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}' in the 'id' field without version input. </param>
        /// <param name="exactVersion"> Specifies in decimal numbers, the version of platform image or marketplace image used to create the virtual machine. This readonly field differs from 'version', only if the value specified in 'version' field is 'latest'. </param>
        /// <param name="sharedGalleryImageId"> Specified the shared gallery image unique id for vm deployment. This can be fetched from shared gallery image GET call. </param>
        /// <param name="communityGalleryImageId"> Specified the community gallery image unique id for vm deployment. This can be fetched from community gallery image GET call. </param>
        /// <returns> A new <see cref="Models.ImageReference"/> instance for mocking. </returns>
        public static ImageReference ImageReference(string id = null, string publisher = null, string offer = null, string sku = null, string version = null, string exactVersion = null, string sharedGalleryImageId = null, string communityGalleryImageId = null)
        {
            return new ImageReference(id, publisher, offer, sku, version, exactVersion, sharedGalleryImageId, communityGalleryImageId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.VirtualMachineScaleSetExtension"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> The name of the extension. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="forceUpdateTag"> If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="typePropertiesType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="provisionAfterExtensions"> Collection of extension names after which this extension needs to be provisioned. </param>
        /// <param name="suppressFailures"> Indicates whether failures stemming from the extension will be suppressed (Operational failures such as not connecting to the VM will not be suppressed regardless of this value). The default is false. </param>
        /// <param name="protectedSettingsFromKeyVault"> The extensions protected settings that are passed by reference, and consumed from key vault. </param>
        /// <returns> A new <see cref="Models.VirtualMachineScaleSetExtension"/> instance for mocking. </returns>
        public static VirtualMachineScaleSetExtension VirtualMachineScaleSetExtension(string id = null, string name = null, string resourceType = null, string forceUpdateTag = null, string publisher = null, string typePropertiesType = null, string typeHandlerVersion = null, bool? autoUpgradeMinorVersion = null, bool? enableAutomaticUpgrade = null, BinaryData settings = null, BinaryData protectedSettings = null, string provisioningState = null, IEnumerable<string> provisionAfterExtensions = null, bool? suppressFailures = null, KeyVaultSecretReference protectedSettingsFromKeyVault = null)
        {
            provisionAfterExtensions ??= new List<string>();

            return new VirtualMachineScaleSetExtension(id, name, resourceType, forceUpdateTag, publisher, typePropertiesType, typeHandlerVersion, autoUpgradeMinorVersion, enableAutomaticUpgrade, settings, protectedSettings, provisioningState, provisionAfterExtensions?.ToList(), suppressFailures, protectedSettingsFromKeyVault);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SubResourceReadOnly"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <returns> A new <see cref="Models.SubResourceReadOnly"/> instance for mocking. </returns>
        public static SubResourceReadOnly SubResourceReadOnly(string id = null)
        {
            return new SubResourceReadOnly(id);
        }

        /// <summary> Initializes a new instance of <see cref="Models.VirtualMachineExtension"/>. </summary>
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
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The virtual machine extension instance view. </param>
        /// <param name="suppressFailures"> Indicates whether failures stemming from the extension will be suppressed (Operational failures such as not connecting to the VM will not be suppressed regardless of this value). The default is false. </param>
        /// <param name="protectedSettingsFromKeyVault"> The extensions protected settings that are passed by reference, and consumed from key vault. </param>
        /// <param name="provisionAfterExtensions"> Collection of extension names after which this extension needs to be provisioned. </param>
        /// <returns> A new <see cref="Models.VirtualMachineExtension"/> instance for mocking. </returns>
        public static VirtualMachineExtension VirtualMachineExtension(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string forceUpdateTag = null, string publisher = null, string typePropertiesType = null, string typeHandlerVersion = null, bool? autoUpgradeMinorVersion = null, bool? enableAutomaticUpgrade = null, BinaryData settings = null, BinaryData protectedSettings = null, string provisioningState = null, VirtualMachineExtensionInstanceView instanceView = null, bool? suppressFailures = null, KeyVaultSecretReference protectedSettingsFromKeyVault = null, IEnumerable<string> provisionAfterExtensions = null)
        {
            tags ??= new Dictionary<string, string>();
            provisionAfterExtensions ??= new List<string>();

            return new VirtualMachineExtension(id, name, resourceType, systemData, tags, location, forceUpdateTag, publisher, typePropertiesType, typeHandlerVersion, autoUpgradeMinorVersion, enableAutomaticUpgrade, settings, protectedSettings, provisioningState, instanceView, suppressFailures, protectedSettingsFromKeyVault, provisionAfterExtensions?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.VirtualMachineScaleSet"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="Models.VirtualMachineScaleSet"/> instance for mocking. </returns>
        public static VirtualMachineScaleSet VirtualMachineScaleSet(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ProvisioningState provisioningState = default)
        {
            return new VirtualMachineScaleSet(id, name, resourceType, systemData, provisioningState);
        }
    }
}
