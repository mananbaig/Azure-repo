// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryPlanActionDetails. </summary>
    internal partial class UnknownRecoveryPlanActionDetails : RecoveryPlanActionDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryPlanActionDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecoveryPlanActionDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
