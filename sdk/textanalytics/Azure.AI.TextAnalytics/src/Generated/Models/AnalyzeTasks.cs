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
            EntityRecognitionTasks = new ChangeTrackingList<EntityRecognitionTasksItem>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<EntityRecognitionPiiTasksItem>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<KeyPhraseExtractionTasksItem>();
            EntityLinkingTasks = new ChangeTrackingList<EntityLinkingTasksItem>();
            SentimentAnalysisTasks = new ChangeTrackingList<SentimentAnalysisTasksItem>();
            ExtractiveSummarizationTasks = new ChangeTrackingList<ExtractiveSummarizationTasksItem>();
            CustomEntityRecognitionTasks = new ChangeTrackingList<TasksStateTasksCustomEntityRecognitionTasksItem>();
            CustomSingleClassificationTasks = new ChangeTrackingList<TasksStateTasksCustomSingleClassificationTasksItem>();
            CustomMultiClassificationTasks = new ChangeTrackingList<CustomMultiClassificationTasksItem>();
        }

        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        /// <param name="entityRecognitionTasks"></param>
        /// <param name="entityRecognitionPiiTasks"></param>
        /// <param name="keyPhraseExtractionTasks"></param>
        /// <param name="entityLinkingTasks"></param>
        /// <param name="sentimentAnalysisTasks"></param>
        /// <param name="extractiveSummarizationTasks"></param>
        /// <param name="customEntityRecognitionTasks"></param>
        /// <param name="customSingleClassificationTasks"></param>
        /// <param name="customMultiClassificationTasks"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total, IReadOnlyList<EntityRecognitionTasksItem> entityRecognitionTasks, IReadOnlyList<EntityRecognitionPiiTasksItem> entityRecognitionPiiTasks, IReadOnlyList<KeyPhraseExtractionTasksItem> keyPhraseExtractionTasks, IReadOnlyList<EntityLinkingTasksItem> entityLinkingTasks, IReadOnlyList<SentimentAnalysisTasksItem> sentimentAnalysisTasks, IReadOnlyList<ExtractiveSummarizationTasksItem> extractiveSummarizationTasks, IReadOnlyList<TasksStateTasksCustomEntityRecognitionTasksItem> customEntityRecognitionTasks, IReadOnlyList<TasksStateTasksCustomSingleClassificationTasksItem> customSingleClassificationTasks, IReadOnlyList<CustomMultiClassificationTasksItem> customMultiClassificationTasks)
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
            ExtractiveSummarizationTasks = extractiveSummarizationTasks;
            CustomEntityRecognitionTasks = customEntityRecognitionTasks;
            CustomSingleClassificationTasks = customSingleClassificationTasks;
            CustomMultiClassificationTasks = customMultiClassificationTasks;
        }

        public int Completed { get; }
        public int Failed { get; }
        public int InProgress { get; }
        public int Total { get; }
        public IReadOnlyList<EntityRecognitionTasksItem> EntityRecognitionTasks { get; }
        public IReadOnlyList<EntityRecognitionPiiTasksItem> EntityRecognitionPiiTasks { get; }
        public IReadOnlyList<KeyPhraseExtractionTasksItem> KeyPhraseExtractionTasks { get; }
        public IReadOnlyList<EntityLinkingTasksItem> EntityLinkingTasks { get; }
        public IReadOnlyList<SentimentAnalysisTasksItem> SentimentAnalysisTasks { get; }
        public IReadOnlyList<ExtractiveSummarizationTasksItem> ExtractiveSummarizationTasks { get; }
        /// <summary> Gets the custom entity recognition tasks. </summary>
        public IReadOnlyList<TasksStateTasksCustomEntityRecognitionTasksItem> CustomEntityRecognitionTasks { get; }
        /// <summary> Gets the custom single classification tasks. </summary>
        public IReadOnlyList<TasksStateTasksCustomSingleClassificationTasksItem> CustomSingleClassificationTasks { get; }
        /// <summary> Gets the custom multi classification tasks. </summary>
        public IReadOnlyList<CustomMultiClassificationTasksItem> CustomMultiClassificationTasks { get; }
    }
}
