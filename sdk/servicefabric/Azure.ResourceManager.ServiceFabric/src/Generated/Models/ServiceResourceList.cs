// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of service resources. </summary>
    internal partial class ServiceResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceResourceList"/>. </summary>
        internal ServiceResourceList()
        {
            Value = new ChangeTrackingList<ServiceFabricServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of service list results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceResourceList(IReadOnlyList<ServiceFabricServiceData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceFabricServiceData> Value { get; }
        /// <summary> URL to get the next set of service list results if there are any. </summary>
        public string NextLink { get; }
    }
}
