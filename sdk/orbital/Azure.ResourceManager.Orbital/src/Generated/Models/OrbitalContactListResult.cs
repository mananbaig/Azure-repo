// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Response for the ListContacts API service call. </summary>
    internal partial class OrbitalContactListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OrbitalContactListResult"/>. </summary>
        internal OrbitalContactListResult()
        {
            Value = new ChangeTrackingList<OrbitalContactData>();
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalContactListResult"/>. </summary>
        /// <param name="value"> A list of contact resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OrbitalContactListResult(IReadOnlyList<OrbitalContactData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of contact resources in a resource group. </summary>
        public IReadOnlyList<OrbitalContactData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
