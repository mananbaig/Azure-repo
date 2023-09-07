// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Information regarding the low disk mode state. </summary>
    public partial class CloudTieringLowDiskMode
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudTieringLowDiskMode"/>. </summary>
        internal CloudTieringLowDiskMode()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudTieringLowDiskMode"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="state"> Low disk mode state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudTieringLowDiskMode(DateTimeOffset? lastUpdatedOn, CloudTieringLowDiskModeState? state, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastUpdatedOn = lastUpdatedOn;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Low disk mode state. </summary>
        public CloudTieringLowDiskModeState? State { get; }
    }
}
