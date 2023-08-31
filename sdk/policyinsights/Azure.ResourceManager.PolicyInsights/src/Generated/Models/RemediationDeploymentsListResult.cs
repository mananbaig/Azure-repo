// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> List of deployments for a remediation. </summary>
    internal partial class RemediationDeploymentsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemediationDeploymentsListResult"/>. </summary>
        internal RemediationDeploymentsListResult()
        {
            Value = new ChangeTrackingList<RemediationDeployment>();
        }

        /// <summary> Initializes a new instance of <see cref="RemediationDeploymentsListResult"/>. </summary>
        /// <param name="value"> Array of deployments for the remediation. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationDeploymentsListResult(IReadOnlyList<RemediationDeployment> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of deployments for the remediation. </summary>
        public IReadOnlyList<RemediationDeployment> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
