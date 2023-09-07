// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> A path element of a management group ancestors. </summary>
    public partial class ManagementGroupPathElement
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagementGroupPathElement"/>. </summary>
        internal ManagementGroupPathElement()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementGroupPathElement"/>. </summary>
        /// <param name="name"> The name of the group. </param>
        /// <param name="displayName"> The friendly name of the group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementGroupPathElement(string name, string displayName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DisplayName = displayName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the group. </summary>
        public string Name { get; }
        /// <summary> The friendly name of the group. </summary>
        public string DisplayName { get; }
    }
}
