// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to update model settings. One of "name" or "defaultTypeId" must be set. </summary>
    internal partial class UpdateModelSettingsRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpdateModelSettingsRequest"/>. </summary>
        public UpdateModelSettingsRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateModelSettingsRequest"/>. </summary>
        /// <param name="name"> Model display name which is shown in the UX and mutable by the user. Initial value is "DefaultModel". </param>
        /// <param name="defaultTypeId"> Default type id of the model that new instances will automatically belong to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateModelSettingsRequest(string name, string defaultTypeId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DefaultTypeId = defaultTypeId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Model display name which is shown in the UX and mutable by the user. Initial value is "DefaultModel". </summary>
        public string Name { get; set; }
        /// <summary> Default type id of the model that new instances will automatically belong to. </summary>
        public string DefaultTypeId { get; set; }
    }
}
