// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm policy creation input. </summary>
    public partial class InMageRcmPolicyCreationInput : PolicyProviderSpecificInput
    {
        /// <summary> Initializes a new instance of InMageRcmPolicyCreationInput. </summary>
        public InMageRcmPolicyCreationInput()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> The duration in minutes until which the recovery points need to be stored. </summary>
        public int? RecoveryPointHistoryInMinutes { get; set; }
        /// <summary> The crash consistent snapshot frequency (in minutes). </summary>
        public int? CrashConsistentFrequencyInMinutes { get; set; }
        /// <summary> The app consistent snapshot frequency (in minutes). </summary>
        public int? AppConsistentFrequencyInMinutes { get; set; }
        /// <summary> A value indicating whether multi-VM sync has to be enabled. </summary>
        public string EnableMultiVmSync { get; set; }
    }
}
