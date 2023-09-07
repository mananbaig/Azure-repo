// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Management resource preference to link device. </summary>
    internal partial class ManagementResourcePreferences
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagementResourcePreferences"/>. </summary>
        public ManagementResourcePreferences()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementResourcePreferences"/>. </summary>
        /// <param name="preferredManagementResourceId"> Customer preferred Management resource ARM ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementResourcePreferences(string preferredManagementResourceId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PreferredManagementResourceId = preferredManagementResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Customer preferred Management resource ARM ID. </summary>
        public string PreferredManagementResourceId { get; set; }
    }
}
