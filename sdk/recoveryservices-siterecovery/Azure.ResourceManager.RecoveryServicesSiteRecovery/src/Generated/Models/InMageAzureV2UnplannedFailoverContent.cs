// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 provider specific input for unplanned failover. </summary>
    public partial class InMageAzureV2UnplannedFailoverContent : UnplannedFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageAzureV2UnplannedFailoverContent"/>. </summary>
        public InMageAzureV2UnplannedFailoverContent()
        {
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2UnplannedFailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="recoveryPointId"> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2UnplannedFailoverContent(string instanceType, ResourceIdentifier recoveryPointId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointId = recoveryPointId;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
    }
}
