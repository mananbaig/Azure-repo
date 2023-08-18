// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of integration account maps. </summary>
    internal partial class IntegrationAccountMapListResult
    {
        /// <summary> Initializes a new instance of IntegrationAccountMapListResult. </summary>
        internal IntegrationAccountMapListResult()
        {
            Value = new Core.ChangeTrackingList<IntegrationAccountMapData>();
        }

        /// <summary> Initializes a new instance of IntegrationAccountMapListResult. </summary>
        /// <param name="value"> The list of integration account maps. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal IntegrationAccountMapListResult(IReadOnlyList<IntegrationAccountMapData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of integration account maps. </summary>
        public IReadOnlyList<IntegrationAccountMapData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
