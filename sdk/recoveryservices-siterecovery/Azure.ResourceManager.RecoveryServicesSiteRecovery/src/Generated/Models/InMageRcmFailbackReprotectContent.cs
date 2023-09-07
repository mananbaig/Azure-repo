// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcmFailback specific provider input. </summary>
    public partial class InMageRcmFailbackReprotectContent : ReverseReplicationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackReprotectContent"/>. </summary>
        /// <param name="processServerId"> The process server Id. </param>
        /// <param name="policyId"> The Policy Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        public InMageRcmFailbackReprotectContent(Guid processServerId, ResourceIdentifier policyId)
        {
            Argument.AssertNotNull(policyId, nameof(policyId));

            ProcessServerId = processServerId;
            PolicyId = policyId;
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackReprotectContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="processServerId"> The process server Id. </param>
        /// <param name="runAsAccountId"> The run as account Id. </param>
        /// <param name="policyId"> The Policy Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmFailbackReprotectContent(string instanceType, Guid processServerId, string runAsAccountId, ResourceIdentifier policyId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            ProcessServerId = processServerId;
            RunAsAccountId = runAsAccountId;
            PolicyId = policyId;
            InstanceType = instanceType ?? "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackReprotectContent"/> for deserialization. </summary>
        internal InMageRcmFailbackReprotectContent()
        {
        }

        /// <summary> The process server Id. </summary>
        public Guid ProcessServerId { get; }
        /// <summary> The run as account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> The Policy Id. </summary>
        public ResourceIdentifier PolicyId { get; }
    }
}
