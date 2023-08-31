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
    /// <summary> List of Hosts. </summary>
    internal partial class HostsList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HostsList"/>. </summary>
        /// <param name="value"> Array of Hosts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal HostsList(IEnumerable<VMwareHostData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="HostsList"/>. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of Hosts. </param>
        /// <param name="value"> Array of Hosts. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HostsList(string nextLink, IReadOnlyList<VMwareHostData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HostsList"/> for deserialization. </summary>
        internal HostsList()
        {
        }

        /// <summary> Url to follow for getting next page of Hosts. </summary>
        public string NextLink { get; }
        /// <summary> Array of Hosts. </summary>
        public IReadOnlyList<VMwareHostData> Value { get; }
    }
}
