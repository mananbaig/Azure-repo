// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningDiagnoseResultValue. </summary>
    public partial class MachineLearningDiagnoseResultValue
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningDiagnoseResultValue"/>. </summary>
        internal MachineLearningDiagnoseResultValue()
        {
            UserDefinedRouteResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            NetworkSecurityRuleResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            ResourceLockResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            DnsResolutionResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            StorageAccountResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            KeyVaultResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            ContainerRegistryResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            ApplicationInsightsResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
            OtherResults = new ChangeTrackingList<MachineLearningDiagnoseResult>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDiagnoseResultValue"/>. </summary>
        /// <param name="userDefinedRouteResults"></param>
        /// <param name="networkSecurityRuleResults"></param>
        /// <param name="resourceLockResults"></param>
        /// <param name="dnsResolutionResults"></param>
        /// <param name="storageAccountResults"></param>
        /// <param name="keyVaultResults"></param>
        /// <param name="containerRegistryResults"></param>
        /// <param name="applicationInsightsResults"></param>
        /// <param name="otherResults"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningDiagnoseResultValue(IReadOnlyList<MachineLearningDiagnoseResult> userDefinedRouteResults, IReadOnlyList<MachineLearningDiagnoseResult> networkSecurityRuleResults, IReadOnlyList<MachineLearningDiagnoseResult> resourceLockResults, IReadOnlyList<MachineLearningDiagnoseResult> dnsResolutionResults, IReadOnlyList<MachineLearningDiagnoseResult> storageAccountResults, IReadOnlyList<MachineLearningDiagnoseResult> keyVaultResults, IReadOnlyList<MachineLearningDiagnoseResult> containerRegistryResults, IReadOnlyList<MachineLearningDiagnoseResult> applicationInsightsResults, IReadOnlyList<MachineLearningDiagnoseResult> otherResults, Dictionary<string, BinaryData> rawData)
        {
            UserDefinedRouteResults = userDefinedRouteResults;
            NetworkSecurityRuleResults = networkSecurityRuleResults;
            ResourceLockResults = resourceLockResults;
            DnsResolutionResults = dnsResolutionResults;
            StorageAccountResults = storageAccountResults;
            KeyVaultResults = keyVaultResults;
            ContainerRegistryResults = containerRegistryResults;
            ApplicationInsightsResults = applicationInsightsResults;
            OtherResults = otherResults;
            _rawData = rawData;
        }

        /// <summary> Gets the user defined route results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> UserDefinedRouteResults { get; }
        /// <summary> Gets the network security rule results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> NetworkSecurityRuleResults { get; }
        /// <summary> Gets the resource lock results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> ResourceLockResults { get; }
        /// <summary> Gets the dns resolution results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> DnsResolutionResults { get; }
        /// <summary> Gets the storage account results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> StorageAccountResults { get; }
        /// <summary> Gets the key vault results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> KeyVaultResults { get; }
        /// <summary> Gets the container registry results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> ContainerRegistryResults { get; }
        /// <summary> Gets the application insights results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> ApplicationInsightsResults { get; }
        /// <summary> Gets the other results. </summary>
        public IReadOnlyList<MachineLearningDiagnoseResult> OtherResults { get; }
    }
}
