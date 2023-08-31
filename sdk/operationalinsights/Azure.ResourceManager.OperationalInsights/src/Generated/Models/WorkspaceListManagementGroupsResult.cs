// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list workspace management groups operation response. </summary>
    internal partial class WorkspaceListManagementGroupsResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceListManagementGroupsResult"/>. </summary>
        internal WorkspaceListManagementGroupsResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsManagementGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceListManagementGroupsResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of management groups attached to the workspace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceListManagementGroupsResult(IReadOnlyList<OperationalInsightsManagementGroup> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a list of management groups attached to the workspace. </summary>
        public IReadOnlyList<OperationalInsightsManagementGroup> Value { get; }
    }
}
