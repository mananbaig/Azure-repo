// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm policy creation input. </summary>
    public partial class InMageRcmPolicyCreationContent : PolicyProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmPolicyCreationContent"/>. </summary>
        public InMageRcmPolicyCreationContent()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmPolicyCreationContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="recoveryPointHistoryInMinutes"> The duration in minutes until which the recovery points need to be stored. </param>
        /// <param name="crashConsistentFrequencyInMinutes"> The crash consistent snapshot frequency (in minutes). </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency (in minutes). </param>
        /// <param name="enableMultiVmSync"> A value indicating whether multi-VM sync has to be enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmPolicyCreationContent(string instanceType, int? recoveryPointHistoryInMinutes, int? crashConsistentFrequencyInMinutes, int? appConsistentFrequencyInMinutes, string enableMultiVmSync, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointHistoryInMinutes = recoveryPointHistoryInMinutes;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            EnableMultiVmSync = enableMultiVmSync;
            InstanceType = instanceType ?? "InMageRcm";
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
