// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> configuration for the servers offering subPlan. </summary>
    internal partial class DefenderForServersAwsOfferingSubPlan
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DefenderForServersAwsOfferingSubPlan"/>. </summary>
        public DefenderForServersAwsOfferingSubPlan()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForServersAwsOfferingSubPlan"/>. </summary>
        /// <param name="availableSubPlanType"> The available sub plans. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderForServersAwsOfferingSubPlan(AvailableSubPlanType? availableSubPlanType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AvailableSubPlanType = availableSubPlanType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The available sub plans. </summary>
        public AvailableSubPlanType? AvailableSubPlanType { get; set; }
    }
}
