// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The log size capability. </summary>
    public partial class LogSizeCapability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogSizeCapability"/>. </summary>
        internal LogSizeCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogSizeCapability"/>. </summary>
        /// <param name="limit"> The log size limit (see 'unit' for the units). </param>
        /// <param name="unit"> The units that the limit is expressed in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogSizeCapability(int? limit, LogSizeUnit? unit, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Limit = limit;
            Unit = unit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The log size limit (see 'unit' for the units). </summary>
        public int? Limit { get; }
        /// <summary> The units that the limit is expressed in. </summary>
        public LogSizeUnit? Unit { get; }
    }
}
