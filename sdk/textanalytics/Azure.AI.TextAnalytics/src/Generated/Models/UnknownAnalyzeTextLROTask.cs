// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The UnknownAnalyzeTextLROTask. </summary>
    internal partial class UnknownAnalyzeTextLROTask : AnalyzeTextLROTask
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAnalyzeTextLROTask"/>. </summary>
        /// <param name="taskName"></param>
        /// <param name="kind"> Enumeration of supported long-running Text Analysis tasks. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAnalyzeTextLROTask(string taskName, AnalyzeTextLROTaskKind kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(taskName, kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAnalyzeTextLROTask"/> for deserialization. </summary>
        internal UnknownAnalyzeTextLROTask()
        {
        }
    }
}
