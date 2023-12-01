// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> AzureResource(IaaS VM) Specific feature support request. </summary>
    public partial class VmResourceFeatureSupportContent : FeatureSupportContent
    {
        /// <summary> Initializes a new instance of <see cref="VmResourceFeatureSupportContent"/>. </summary>
        public VmResourceFeatureSupportContent()
        {
            FeatureType = "AzureVMResourceBackup";
        }

        /// <summary> Initializes a new instance of <see cref="VmResourceFeatureSupportContent"/>. </summary>
        /// <param name="featureType"> backup support feature type. </param>
        /// <param name="vmSize"> Size of the resource: VM size(A/D series etc) in case of IaasVM. </param>
        /// <param name="vmSku"> SKUs (Premium/Managed etc) in case of IaasVM. </param>
        internal VmResourceFeatureSupportContent(string featureType, string vmSize, string vmSku) : base(featureType)
        {
            VmSize = vmSize;
            VmSku = vmSku;
            FeatureType = featureType ?? "AzureVMResourceBackup";
        }

        /// <summary> Size of the resource: VM size(A/D series etc) in case of IaasVM. </summary>
        public string VmSize { get; set; }
        /// <summary> SKUs (Premium/Managed etc) in case of IaasVM. </summary>
        public string VmSku { get; set; }
    }
}
