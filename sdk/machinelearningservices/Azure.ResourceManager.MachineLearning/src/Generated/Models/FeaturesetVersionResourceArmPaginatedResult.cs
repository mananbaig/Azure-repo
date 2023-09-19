// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of FeaturesetVersion entities. </summary>
    internal partial class FeaturesetVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of FeaturesetVersionResourceArmPaginatedResult. </summary>
        internal FeaturesetVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<FeaturesetVersionData>();
        }

        /// <summary> Initializes a new instance of FeaturesetVersionResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of FeaturesetVersion objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type FeaturesetVersion. </param>
        internal FeaturesetVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<FeaturesetVersionData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of FeaturesetVersion objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type FeaturesetVersion. </summary>
        public IReadOnlyList<FeaturesetVersionData> Value { get; }
    }
}
