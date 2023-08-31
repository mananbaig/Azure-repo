// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSStorageSpec defines the desired state of HybridAKSStorage. </summary>
    public partial class StorageSpacesProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageSpacesProperties"/>. </summary>
        public StorageSpacesProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSpacesProperties"/>. </summary>
        /// <param name="hciStorageProfile"></param>
        /// <param name="vmwareStorageProfile"></param>
        /// <param name="provisioningState"></param>
        /// <param name="status"> HybridAKSStorageStatus defines the observed state of HybridAKSStorage. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSpacesProperties(StorageSpacesPropertiesHciStorageProfile hciStorageProfile, StorageSpacesPropertiesVmwareStorageProfile vmwareStorageProfile, ProvisioningState? provisioningState, StorageSpacesPropertiesStatus status, Dictionary<string, BinaryData> rawData)
        {
            HciStorageProfile = hciStorageProfile;
            VmwareStorageProfile = vmwareStorageProfile;
            ProvisioningState = provisioningState;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the hci storage profile. </summary>
        public StorageSpacesPropertiesHciStorageProfile HciStorageProfile { get; set; }
        /// <summary> Gets or sets the vmware storage profile. </summary>
        public StorageSpacesPropertiesVmwareStorageProfile VmwareStorageProfile { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> HybridAKSStorageStatus defines the observed state of HybridAKSStorage. </summary>
        internal StorageSpacesPropertiesStatus Status { get; set; }
        /// <summary> Contains Provisioning errors. </summary>
        public StorageSpacesPropertiesStatusProvisioningStatus ProvisioningStatus
        {
            get => Status is null ? default : Status.ProvisioningStatus;
            set
            {
                if (Status is null)
                    Status = new StorageSpacesPropertiesStatus();
                Status.ProvisioningStatus = value;
            }
        }
    }
}
