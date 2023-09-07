// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The billing resources. </summary>
    public partial class HDInsightBillingResources
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightBillingResources"/>. </summary>
        internal HDInsightBillingResources()
        {
            BillingMeters = new ChangeTrackingList<HDInsightBillingMeters>();
            DiskBillingMeters = new ChangeTrackingList<HDInsightDiskBillingMeters>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightBillingResources"/>. </summary>
        /// <param name="region"> The region or location. </param>
        /// <param name="billingMeters"> The billing meter information. </param>
        /// <param name="diskBillingMeters"> The managed disk billing information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightBillingResources(AzureLocation? region, IReadOnlyList<HDInsightBillingMeters> billingMeters, IReadOnlyList<HDInsightDiskBillingMeters> diskBillingMeters, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Region = region;
            BillingMeters = billingMeters;
            DiskBillingMeters = diskBillingMeters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The region or location. </summary>
        public AzureLocation? Region { get; }
        /// <summary> The billing meter information. </summary>
        public IReadOnlyList<HDInsightBillingMeters> BillingMeters { get; }
        /// <summary> The managed disk billing information. </summary>
        public IReadOnlyList<HDInsightDiskBillingMeters> DiskBillingMeters { get; }
    }
}
