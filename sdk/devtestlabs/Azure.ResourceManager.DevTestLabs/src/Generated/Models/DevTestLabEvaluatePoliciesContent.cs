// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Request body for evaluating a policy set. </summary>
    public partial class DevTestLabEvaluatePoliciesContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePoliciesContent"/>. </summary>
        public DevTestLabEvaluatePoliciesContent()
        {
            Policies = new ChangeTrackingList<DevTestLabEvaluatePolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePoliciesContent"/>. </summary>
        /// <param name="policies"> Policies to evaluate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabEvaluatePoliciesContent(IList<DevTestLabEvaluatePolicy> policies, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Policies = policies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Policies to evaluate. </summary>
        public IList<DevTestLabEvaluatePolicy> Policies { get; }
    }
}
