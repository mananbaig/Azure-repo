// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownDataFlow. </summary>
    internal partial class UnknownDataFlow : DataFlow
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataFlow"/>. </summary>
        /// <param name="type"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDataFlow(string type, string description, IList<object> annotations, DataFlowFolder folder, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(type, description, annotations, folder, serializedAdditionalRawData)
        {
            Type = type ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDataFlow"/> for deserialization. </summary>
        internal UnknownDataFlow()
        {
        }
    }
}
