// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the CheckPrivateLinkServiceVisibility API service call. </summary>
    public partial class PrivateLinkServiceVisibility
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceVisibility"/>. </summary>
        internal PrivateLinkServiceVisibility()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceVisibility"/>. </summary>
        /// <param name="visible"> Private Link Service Visibility (True/False). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkServiceVisibility(bool? visible, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Visible = visible;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Private Link Service Visibility (True/False). </summary>
        public bool? Visible { get; }
    }
}
