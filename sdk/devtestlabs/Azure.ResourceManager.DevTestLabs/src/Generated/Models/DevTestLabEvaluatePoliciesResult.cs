// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Response body for evaluating a policy set. </summary>
    public partial class DevTestLabEvaluatePoliciesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePoliciesResult"/>. </summary>
        internal DevTestLabEvaluatePoliciesResult()
        {
            Results = new ChangeTrackingList<DevTestLabPolicySetResult>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePoliciesResult"/>. </summary>
        /// <param name="results"> Results of evaluating a policy set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabEvaluatePoliciesResult(IReadOnlyList<DevTestLabPolicySetResult> results, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Results of evaluating a policy set. </summary>
        public IReadOnlyList<DevTestLabPolicySetResult> Results { get; }
    }
}
