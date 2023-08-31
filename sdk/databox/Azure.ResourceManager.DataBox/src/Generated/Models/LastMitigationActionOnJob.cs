// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Last Mitigation Action Performed On Job. </summary>
    public partial class LastMitigationActionOnJob
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LastMitigationActionOnJob"/>. </summary>
        internal LastMitigationActionOnJob()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LastMitigationActionOnJob"/>. </summary>
        /// <param name="actionPerformedOn"> Action performed date time. </param>
        /// <param name="isPerformedByCustomer">
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </param>
        /// <param name="customerResolution"> Resolution code provided by customer. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LastMitigationActionOnJob(DateTimeOffset? actionPerformedOn, bool? isPerformedByCustomer, CustomerResolutionCode? customerResolution, Dictionary<string, BinaryData> rawData)
        {
            ActionPerformedOn = actionPerformedOn;
            IsPerformedByCustomer = isPerformedByCustomer;
            CustomerResolution = customerResolution;
            _rawData = rawData;
        }

        /// <summary> Action performed date time. </summary>
        public DateTimeOffset? ActionPerformedOn { get; }
        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        public bool? IsPerformedByCustomer { get; }
        /// <summary> Resolution code provided by customer. </summary>
        public CustomerResolutionCode? CustomerResolution { get; }
    }
}
