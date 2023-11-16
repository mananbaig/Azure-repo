// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Qos Traffic Profiler Port range properties. </summary>
    public partial class QosPortRange
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QosPortRange"/>. </summary>
        public QosPortRange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QosPortRange"/>. </summary>
        /// <param name="start"> Qos Port Range start. </param>
        /// <param name="end"> Qos Port Range end. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QosPortRange(int? start, int? end, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Start = start;
            End = end;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Qos Port Range start. </summary>
        public int? Start { get; set; }
        /// <summary> Qos Port Range end. </summary>
        public int? End { get; set; }
    }
}
