// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The EntityLinkingTask. </summary>
    internal partial class EntityLinkingTask
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTask"/>. </summary>
        public EntityLinkingTask()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTask"/>. </summary>
        /// <param name="parameters"></param>
        /// <param name="taskName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityLinkingTask(EntityLinkingTaskParameters parameters, string taskName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Parameters = parameters;
            TaskName = taskName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public EntityLinkingTaskParameters Parameters { get; set; }
        /// <summary> Gets or sets the task name. </summary>
        public string TaskName { get; set; }
    }
}
