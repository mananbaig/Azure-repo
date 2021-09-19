// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksCustomSingleClassificationTasksItem. </summary>
    internal partial class TasksStateTasksCustomSingleClassificationTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of TasksStateTasksCustomSingleClassificationTasksItem. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal TasksStateTasksCustomSingleClassificationTasksItem(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of TasksStateTasksCustomSingleClassificationTasksItem. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="taskName"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        internal TasksStateTasksCustomSingleClassificationTasksItem(DateTimeOffset lastUpdateDateTime, string taskName, TextAnalyticsOperationStatus status, CustomSingleClassificationResult results) : base(lastUpdateDateTime, taskName, status)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public CustomSingleClassificationResult Results { get; }
    }
}
