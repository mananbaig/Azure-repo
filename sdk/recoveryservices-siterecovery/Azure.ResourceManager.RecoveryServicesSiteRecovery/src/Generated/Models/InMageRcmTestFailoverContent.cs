// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific input for test failover. </summary>
    public partial class InMageRcmTestFailoverContent : TestFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmTestFailoverContent"/>. </summary>
        public InMageRcmTestFailoverContent()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmTestFailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="networkId"> The test network Id. </param>
        /// <param name="recoveryPointId"> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmTestFailoverContent(string instanceType, ResourceIdentifier networkId, ResourceIdentifier recoveryPointId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            NetworkId = networkId;
            RecoveryPointId = recoveryPointId;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> The test network Id. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
    }
}
