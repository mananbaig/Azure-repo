// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterDeployParameters represents the body of the request to deploy cluster. </summary>
    public partial class ClusterDeployContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClusterDeployContent"/>. </summary>
        public ClusterDeployContent()
        {
            SkipValidationsForMachines = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterDeployContent"/>. </summary>
        /// <param name="skipValidationsForMachines"> The names of bare metal machines in the cluster that should be skipped during environment validation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterDeployContent(IList<string> skipValidationsForMachines, Dictionary<string, BinaryData> rawData)
        {
            SkipValidationsForMachines = skipValidationsForMachines;
            _rawData = rawData;
        }

        /// <summary> The names of bare metal machines in the cluster that should be skipped during environment validation. </summary>
        public IList<string> SkipValidationsForMachines { get; }
    }
}
