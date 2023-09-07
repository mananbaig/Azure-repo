// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HvrA provider specific input for test failover. </summary>
    public partial class HyperVReplicaAzureTestFailoverContent : TestFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureTestFailoverContent"/>. </summary>
        public HyperVReplicaAzureTestFailoverContent()
        {
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureTestFailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="primaryKekCertificatePfx"> Primary kek certificate pfx. </param>
        /// <param name="secondaryKekCertificatePfx"> Secondary kek certificate pfx. </param>
        /// <param name="recoveryPointId"> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVReplicaAzureTestFailoverContent(string instanceType, string primaryKekCertificatePfx, string secondaryKekCertificatePfx, ResourceIdentifier recoveryPointId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            PrimaryKekCertificatePfx = primaryKekCertificatePfx;
            SecondaryKekCertificatePfx = secondaryKekCertificatePfx;
            RecoveryPointId = recoveryPointId;
            InstanceType = instanceType ?? "HyperVReplicaAzure";
        }

        /// <summary> Primary kek certificate pfx. </summary>
        public string PrimaryKekCertificatePfx { get; set; }
        /// <summary> Secondary kek certificate pfx. </summary>
        public string SecondaryKekCertificatePfx { get; set; }
        /// <summary> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
    }
}
