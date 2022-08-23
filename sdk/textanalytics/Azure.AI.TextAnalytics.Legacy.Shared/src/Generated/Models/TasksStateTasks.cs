// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The TasksStateTasks. </summary>
    internal partial class TasksStateTasks
    {
        /// <summary> Initializes a new instance of TasksStateTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        internal TasksStateTasks(int completed, int failed, int inProgress, int total)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = new ChangeTrackingList<TasksStateTasksEntityRecognitionTasksItem>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<TasksStateTasksEntityRecognitionPiiTasksItem>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<TasksStateTasksKeyPhraseExtractionTasksItem>();
            EntityLinkingTasks = new ChangeTrackingList<TasksStateTasksEntityLinkingTasksItem>();
            SentimentAnalysisTasks = new ChangeTrackingList<TasksStateTasksSentimentAnalysisTasksItem>();
        }

        /// <summary> Initializes a new instance of TasksStateTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        /// <param name="entityRecognitionTasks"></param>
        /// <param name="entityRecognitionPiiTasks"></param>
        /// <param name="keyPhraseExtractionTasks"></param>
        /// <param name="entityLinkingTasks"></param>
        /// <param name="sentimentAnalysisTasks"></param>
        internal TasksStateTasks(int completed, int failed, int inProgress, int total, IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem> entityRecognitionTasks, IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem> entityRecognitionPiiTasks, IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem> keyPhraseExtractionTasks, IReadOnlyList<TasksStateTasksEntityLinkingTasksItem> entityLinkingTasks, IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem> sentimentAnalysisTasks)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = entityRecognitionTasks;
            EntityRecognitionPiiTasks = entityRecognitionPiiTasks;
            KeyPhraseExtractionTasks = keyPhraseExtractionTasks;
            EntityLinkingTasks = entityLinkingTasks;
            SentimentAnalysisTasks = sentimentAnalysisTasks;
        }

        /// <summary> Gets the completed. </summary>
        public int Completed { get; }
        /// <summary> Gets the failed. </summary>
        public int Failed { get; }
        /// <summary> Gets the in progress. </summary>
        public int InProgress { get; }
        /// <summary> Gets the total. </summary>
        public int Total { get; }
        /// <summary> Gets the entity recognition tasks. </summary>
        public IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem> EntityRecognitionTasks { get; }
        /// <summary> Gets the entity recognition pii tasks. </summary>
        public IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem> EntityRecognitionPiiTasks { get; }
        /// <summary> Gets the key phrase extraction tasks. </summary>
        public IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem> KeyPhraseExtractionTasks { get; }
        /// <summary> Gets the entity linking tasks. </summary>
        public IReadOnlyList<TasksStateTasksEntityLinkingTasksItem> EntityLinkingTasks { get; }
        /// <summary> Gets the sentiment analysis tasks. </summary>
        public IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem> SentimentAnalysisTasks { get; }
    }
}
