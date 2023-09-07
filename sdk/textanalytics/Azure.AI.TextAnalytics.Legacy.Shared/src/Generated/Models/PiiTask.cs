// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The PiiTask. </summary>
    internal partial class PiiTask
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PiiTask"/>. </summary>
        public PiiTask()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PiiTask"/>. </summary>
        /// <param name="parameters"></param>
        /// <param name="taskName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PiiTask(PiiTaskParameters parameters, string taskName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Parameters = parameters;
            TaskName = taskName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public PiiTaskParameters Parameters { get; set; }
        /// <summary> Gets or sets the task name. </summary>
        public string TaskName { get; set; }
    }
}
