// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The response of a list operation. </summary>
    internal partial class ServiceFabricList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricList"/>. </summary>
        internal ServiceFabricList()
        {
            Value = new ChangeTrackingList<DevTestLabServiceFabricData>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricList"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link for next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricList(IReadOnlyList<DevTestLabServiceFabricData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<DevTestLabServiceFabricData> Value { get; }
        /// <summary> Link for next set of results. </summary>
        public string NextLink { get; }
    }
}
