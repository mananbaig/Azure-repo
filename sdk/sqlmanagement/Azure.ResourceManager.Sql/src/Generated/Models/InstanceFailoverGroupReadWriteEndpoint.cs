// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Read-write endpoint of the failover group instance. </summary>
    public partial class InstanceFailoverGroupReadWriteEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InstanceFailoverGroupReadWriteEndpoint"/>. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        public InstanceFailoverGroupReadWriteEndpoint(ReadWriteEndpointFailoverPolicy failoverPolicy)
        {
            FailoverPolicy = failoverPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="InstanceFailoverGroupReadWriteEndpoint"/>. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        /// <param name="failoverWithDataLossGracePeriodMinutes"> Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstanceFailoverGroupReadWriteEndpoint(ReadWriteEndpointFailoverPolicy failoverPolicy, int? failoverWithDataLossGracePeriodMinutes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FailoverPolicy = failoverPolicy;
            FailoverWithDataLossGracePeriodMinutes = failoverWithDataLossGracePeriodMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InstanceFailoverGroupReadWriteEndpoint"/> for deserialization. </summary>
        internal InstanceFailoverGroupReadWriteEndpoint()
        {
        }

        /// <summary> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </summary>
        public ReadWriteEndpointFailoverPolicy FailoverPolicy { get; set; }
        /// <summary> Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </summary>
        public int? FailoverWithDataLossGracePeriodMinutes { get; set; }
    }
}
