// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The TasksStateTasksSentimentAnalysisTasksItem. </summary>
    internal partial class TasksStateTasksSentimentAnalysisTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of <see cref="TasksStateTasksSentimentAnalysisTasksItem"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal TasksStateTasksSentimentAnalysisTasksItem(DateTimeOffset lastUpdateDateTime, State status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of <see cref="TasksStateTasksSentimentAnalysisTasksItem"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="taskName"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TasksStateTasksSentimentAnalysisTasksItem(DateTimeOffset lastUpdateDateTime, string taskName, State status, SentimentResponse results, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(lastUpdateDateTime, taskName, status, serializedAdditionalRawData)
        {
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="TasksStateTasksSentimentAnalysisTasksItem"/> for deserialization. </summary>
        internal TasksStateTasksSentimentAnalysisTasksItem()
        {
        }

        /// <summary> Gets the results. </summary>
        public SentimentResponse Results { get; }
    }
}
