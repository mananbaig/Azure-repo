// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of Workspace definitions. </summary>
    internal partial class WorkspaceList
    {
        /// <summary> Initializes a new instance of WorkspaceList. </summary>
        internal WorkspaceList()
        {
            Value = new Core.ChangeTrackingList<VirtualWorkspaceData>();
        }

        /// <summary> Initializes a new instance of WorkspaceList. </summary>
        /// <param name="value"> List of Workspace definitions. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal WorkspaceList(IReadOnlyList<VirtualWorkspaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Workspace definitions. </summary>
        public IReadOnlyList<VirtualWorkspaceData> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
