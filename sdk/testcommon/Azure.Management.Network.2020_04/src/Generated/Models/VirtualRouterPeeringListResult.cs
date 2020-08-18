// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ListVirtualRouterPeerings API service call. </summary>
    public partial class VirtualRouterPeeringListResult
    {
        /// <summary> Initializes a new instance of VirtualRouterPeeringListResult. </summary>
        internal VirtualRouterPeeringListResult()
        {
            Value = new ChangeTrackingList<VirtualRouterPeering>();
        }

        /// <summary> Initializes a new instance of VirtualRouterPeeringListResult. </summary>
        /// <param name="value"> List of VirtualRouterPeerings in a VirtualRouter. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal VirtualRouterPeeringListResult(IReadOnlyList<VirtualRouterPeering> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VirtualRouterPeerings in a VirtualRouter. </summary>
        public IReadOnlyList<VirtualRouterPeering> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
