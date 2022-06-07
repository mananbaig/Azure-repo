// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of ModelVersion entities. </summary>
    internal partial class ModelVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of ModelVersionResourceArmPaginatedResult. </summary>
        internal ModelVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<ModelVersionData>();
        }

        /// <summary> Initializes a new instance of ModelVersionResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of ModelVersion objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type ModelVersion. </param>
        internal ModelVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<ModelVersionData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of ModelVersion objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type ModelVersion. </summary>
        public IReadOnlyList<ModelVersionData> Value { get; }
    }
}
