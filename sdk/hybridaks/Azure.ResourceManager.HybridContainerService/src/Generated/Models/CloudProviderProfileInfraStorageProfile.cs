// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> InfraStorageProfile - List of infra storage profiles for the provisioned cluster. </summary>
    internal partial class CloudProviderProfileInfraStorageProfile
    {
        /// <summary> Initializes a new instance of CloudProviderProfileInfraStorageProfile. </summary>
        public CloudProviderProfileInfraStorageProfile()
        {
            StorageSpaceIds = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CloudProviderProfileInfraStorageProfile. </summary>
        /// <param name="storageSpaceIds"> Reference to azure resource corresponding to the new HybridAKSStorage object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpaceName}. </param>
        internal CloudProviderProfileInfraStorageProfile(IList<string> storageSpaceIds)
        {
            StorageSpaceIds = storageSpaceIds;
        }

        /// <summary> Reference to azure resource corresponding to the new HybridAKSStorage object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpaceName}. </summary>
        public IList<string> StorageSpaceIds { get; }
    }
}
