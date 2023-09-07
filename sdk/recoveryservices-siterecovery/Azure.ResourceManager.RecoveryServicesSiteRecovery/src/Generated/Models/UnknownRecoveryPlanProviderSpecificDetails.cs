// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryPlanProviderSpecificDetails. </summary>
    internal partial class UnknownRecoveryPlanProviderSpecificDetails : RecoveryPlanProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryPlanProviderSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecoveryPlanProviderSpecificDetails(string instanceType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryPlanProviderSpecificDetails"/> for deserialization. </summary>
        internal UnknownRecoveryPlanProviderSpecificDetails()
        {
        }
    }
}
