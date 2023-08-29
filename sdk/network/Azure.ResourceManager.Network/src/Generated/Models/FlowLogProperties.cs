// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the flow log format. </summary>
    public partial class FlowLogProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FlowLogProperties"/>. </summary>
        public FlowLogProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FlowLogProperties"/>. </summary>
        /// <param name="formatType"> The file type of flow log. </param>
        /// <param name="version"> The version (revision) of the flow log. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FlowLogProperties(FlowLogFormatType? formatType, int? version, Dictionary<string, BinaryData> rawData)
        {
            FormatType = formatType;
            Version = version;
            _rawData = rawData;
        }

        /// <summary> The file type of flow log. </summary>
        public FlowLogFormatType? FormatType { get; set; }
        /// <summary> The version (revision) of the flow log. </summary>
        public int? Version { get; set; }
    }
}
