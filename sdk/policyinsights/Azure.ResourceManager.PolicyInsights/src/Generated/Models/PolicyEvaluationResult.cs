// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The result of a non-compliant policy evaluation against the given resource content. </summary>
    public partial class PolicyEvaluationResult
    {
        /// <summary> Initializes a new instance of PolicyEvaluationResult. </summary>
        internal PolicyEvaluationResult()
        {
        }

        /// <summary> Initializes a new instance of PolicyEvaluationResult. </summary>
        /// <param name="policyInfo"> The details of the policy that was evaluated. </param>
        /// <param name="evaluationResult"> The result of the policy evaluation against the resource. This will typically be &apos;NonCompliant&apos; but may contain other values if errors were encountered. </param>
        /// <param name="evaluationDetails"> The detailed results of the policy expressions and values that were evaluated. </param>
        internal PolicyEvaluationResult(PolicyReference policyInfo, string evaluationResult, PolicyEvaluationDetails evaluationDetails)
        {
            PolicyInfo = policyInfo;
            EvaluationResult = evaluationResult;
            EvaluationDetails = evaluationDetails;
        }

        /// <summary> The details of the policy that was evaluated. </summary>
        public PolicyReference PolicyInfo { get; }
        /// <summary> The result of the policy evaluation against the resource. This will typically be &apos;NonCompliant&apos; but may contain other values if errors were encountered. </summary>
        public string EvaluationResult { get; }
        /// <summary> The detailed results of the policy expressions and values that were evaluated. </summary>
        public PolicyEvaluationDetails EvaluationDetails { get; }
    }
}
