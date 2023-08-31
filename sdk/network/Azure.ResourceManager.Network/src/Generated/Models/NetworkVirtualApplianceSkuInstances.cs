// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of available Sku and instances. </summary>
    public partial class NetworkVirtualApplianceSkuInstances
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkVirtualApplianceSkuInstances"/>. </summary>
        public NetworkVirtualApplianceSkuInstances()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkVirtualApplianceSkuInstances"/>. </summary>
        /// <param name="scaleUnit"> Scale Unit. </param>
        /// <param name="instanceCount"> Instance Count. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkVirtualApplianceSkuInstances(string scaleUnit, int? instanceCount, Dictionary<string, BinaryData> rawData)
        {
            ScaleUnit = scaleUnit;
            InstanceCount = instanceCount;
            _rawData = rawData;
        }

        /// <summary> Scale Unit. </summary>
        public string ScaleUnit { get; }
        /// <summary> Instance Count. </summary>
        public int? InstanceCount { get; }
    }
}
