// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Details Related To Provision Resource. </summary>
    public partial class ProvisioningDetails
    {
        /// <summary> Initializes a new instance of ProvisioningDetails. </summary>
        public ProvisioningDetails()
        {
        }

        /// <summary> Initializes a new instance of ProvisioningDetails. </summary>
        /// <param name="autoProvisioningStatus"> Auto Provisioning Details. </param>
        /// <param name="quantity"> Quantity of the devices. </param>
        /// <param name="provisioningArmId"> Provisioning Resource Arm ID. </param>
        /// <param name="provisioningEndPoint"> Provisioning End Point. </param>
        /// <param name="serialNumber"> Serial Number for the Device. </param>
        /// <param name="vendorName"> Vendor Name for the Device , (for 1P devices - Microsoft). </param>
        /// <param name="model"> Model of the Device. </param>
        /// <param name="readyToConnectArmId"> Arc Enabled Resource Arm id of target resource. </param>
        /// <param name="onboardingArmId"> Arc Enabled Resource Arm id of Onboarding ARC resource. </param>
        /// <param name="managementResourceArmId"> Management Resource ArmId. </param>
        /// <param name="uniqueDeviceIdentifier"> Unique Identity for a Device. </param>
        /// <param name="ownershipVoucherDetails"> Ownership voucher for the FDO Flow. </param>
        /// <param name="operatingSystemPreferences"> Operating System Preferences for Provisioning. </param>
        /// <param name="deviceConfigurations"> Device configurations for the OS Provisioning. </param>
        internal ProvisioningDetails(AutoProvisioningStatus? autoProvisioningStatus, int? quantity, ResourceIdentifier provisioningArmId, string provisioningEndPoint, string serialNumber, string vendorName, string model, ResourceIdentifier readyToConnectArmId, string onboardingArmId, ResourceIdentifier managementResourceArmId, string uniqueDeviceIdentifier, OwnershipVoucherDetails ownershipVoucherDetails, OperatingSystemPreferences operatingSystemPreferences, DeviceConfigurations deviceConfigurations)
        {
            AutoProvisioningStatus = autoProvisioningStatus;
            Quantity = quantity;
            ProvisioningArmId = provisioningArmId;
            ProvisioningEndPoint = provisioningEndPoint;
            SerialNumber = serialNumber;
            VendorName = vendorName;
            Model = model;
            ReadyToConnectArmId = readyToConnectArmId;
            OnboardingArmId = onboardingArmId;
            ManagementResourceArmId = managementResourceArmId;
            UniqueDeviceIdentifier = uniqueDeviceIdentifier;
            OwnershipVoucherDetails = ownershipVoucherDetails;
            OperatingSystemPreferences = operatingSystemPreferences;
            DeviceConfigurations = deviceConfigurations;
        }

        /// <summary> Auto Provisioning Details. </summary>
        public AutoProvisioningStatus? AutoProvisioningStatus { get; set; }
        /// <summary> Quantity of the devices. </summary>
        public int? Quantity { get; set; }
        /// <summary> Provisioning Resource Arm ID. </summary>
        public ResourceIdentifier ProvisioningArmId { get; set; }
        /// <summary> Provisioning End Point. </summary>
        public string ProvisioningEndPoint { get; set; }
        /// <summary> Serial Number for the Device. </summary>
        public string SerialNumber { get; set; }
        /// <summary> Vendor Name for the Device , (for 1P devices - Microsoft). </summary>
        public string VendorName { get; set; }
        /// <summary> Model of the Device. </summary>
        public string Model { get; set; }
        /// <summary> Arc Enabled Resource Arm id of target resource. </summary>
        public ResourceIdentifier ReadyToConnectArmId { get; set; }
        /// <summary> Arc Enabled Resource Arm id of Onboarding ARC resource. </summary>
        public string OnboardingArmId { get; set; }
        /// <summary> Management Resource ArmId. </summary>
        public ResourceIdentifier ManagementResourceArmId { get; set; }
        /// <summary> Unique Identity for a Device. </summary>
        public string UniqueDeviceIdentifier { get; }
        /// <summary> Ownership voucher for the FDO Flow. </summary>
        internal OwnershipVoucherDetails OwnershipVoucherDetails { get; set; }
        /// <summary> Ownership voucher. </summary>
        public string OwnershipVoucher
        {
            get => OwnershipVoucherDetails is null ? default : OwnershipVoucherDetails.OwnershipVoucher;
            set => OwnershipVoucherDetails = new OwnershipVoucherDetails(value);
        }

        /// <summary> Operating System Preferences for Provisioning. </summary>
        public OperatingSystemPreferences OperatingSystemPreferences { get; set; }
        /// <summary> Device configurations for the OS Provisioning. </summary>
        public DeviceConfigurations DeviceConfigurations { get; set; }
    }
}
