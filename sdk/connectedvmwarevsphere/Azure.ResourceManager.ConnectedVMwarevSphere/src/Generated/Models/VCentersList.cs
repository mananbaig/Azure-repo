// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of VCenters. </summary>
    internal partial class VCentersList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VCentersList"/>. </summary>
        /// <param name="value"> Array of VCenters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VCentersList(IEnumerable<VCenterData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VCentersList"/>. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of VCenters. </param>
        /// <param name="value"> Array of VCenters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VCentersList(string nextLink, IReadOnlyList<VCenterData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VCentersList"/> for deserialization. </summary>
        internal VCentersList()
        {
        }

        /// <summary> Url to follow for getting next page of VCenters. </summary>
        public string NextLink { get; }
        /// <summary> Array of VCenters. </summary>
        public IReadOnlyList<VCenterData> Value { get; }
    }
}
