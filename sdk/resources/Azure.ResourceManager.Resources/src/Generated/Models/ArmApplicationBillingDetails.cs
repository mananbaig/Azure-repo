// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application billing details definition. </summary>
    internal partial class ArmApplicationBillingDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationBillingDetails"/>. </summary>
        internal ArmApplicationBillingDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationBillingDetails"/>. </summary>
        /// <param name="resourceUsageId"> The managed application resource usage Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationBillingDetails(string resourceUsageId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceUsageId = resourceUsageId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The managed application resource usage Id. </summary>
        public string ResourceUsageId { get; }
    }
}
