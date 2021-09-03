// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ExpressRouteConnection list. </summary>
    public partial class ExpressRouteConnectionList
    {
        /// <summary> Initializes a new instance of ExpressRouteConnectionList. </summary>
        internal ExpressRouteConnectionList()
        {
            Value = new ChangeTrackingList<ExpressRouteConnectionData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteConnectionList. </summary>
        /// <param name="value"> The list of ExpressRoute connections. </param>
        internal ExpressRouteConnectionList(IReadOnlyList<ExpressRouteConnectionData> value)
        {
            Value = value;
        }

        /// <summary> The list of ExpressRoute connections. </summary>
        public IReadOnlyList<ExpressRouteConnectionData> Value { get; }
    }
}
