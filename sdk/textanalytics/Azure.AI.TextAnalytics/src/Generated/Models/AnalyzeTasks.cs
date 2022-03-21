// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasks. </summary>
    internal partial class AnalyzeTasks
    {
        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            Items = new ChangeTrackingList<AnalyzeTextLROResult>();
        }

        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        /// <param name="items"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total, IReadOnlyList<AnalyzeTextLROResult> items)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            Items = items;
        }

        /// <summary> Gets the completed. </summary>
        public int Completed { get; }
        /// <summary> Gets the failed. </summary>
        public int Failed { get; }
        /// <summary> Gets the in progress. </summary>
        public int InProgress { get; }
        /// <summary> Gets the total. </summary>
        public int Total { get; }
        /// <summary> Gets the items. </summary>
        public IReadOnlyList<AnalyzeTextLROResult> Items { get; }
    }
}
