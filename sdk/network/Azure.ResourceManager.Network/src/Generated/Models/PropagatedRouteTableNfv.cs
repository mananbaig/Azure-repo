// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Nfv version of the list of RouteTables to advertise the routes to. </summary>
    public partial class PropagatedRouteTableNfv
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PropagatedRouteTableNfv"/>. </summary>
        public PropagatedRouteTableNfv()
        {
            Labels = new ChangeTrackingList<string>();
            Ids = new ChangeTrackingList<RoutingConfigurationNfvSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="PropagatedRouteTableNfv"/>. </summary>
        /// <param name="labels"> The list of labels. </param>
        /// <param name="ids"> The list of resource ids of all the RouteTables. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PropagatedRouteTableNfv(IList<string> labels, IList<RoutingConfigurationNfvSubResource> ids, Dictionary<string, BinaryData> rawData)
        {
            Labels = labels;
            Ids = ids;
            _rawData = rawData;
        }

        /// <summary> The list of labels. </summary>
        public IList<string> Labels { get; }
        /// <summary> The list of resource ids of all the RouteTables. </summary>
        public IList<RoutingConfigurationNfvSubResource> Ids { get; }
    }
}
