// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Dto object representing the feature set job. </summary>
    public partial class FeaturesetJob
    {
        /// <summary> Initializes a new instance of FeaturesetJob. </summary>
        internal FeaturesetJob()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of FeaturesetJob. </summary>
        /// <param name="createdOn"> Specifies the created date. </param>
        /// <param name="displayName"> Specifies the display name. </param>
        /// <param name="duration"> Specifies the duration. </param>
        /// <param name="experimentId"> Specifies the experiment id. </param>
        /// <param name="featureWindow"> Specifies the backfill feature window to be materialized. </param>
        /// <param name="jobId"> Specifies the job id. </param>
        /// <param name="status"> Specifies the job status. </param>
        /// <param name="tags"> Specifies the tags if any. </param>
        /// <param name="featurestoreJobType"> Specifies the feature store job type. </param>
        internal FeaturesetJob(DateTimeOffset? createdOn, string displayName, TimeSpan? duration, string experimentId, FeatureWindow featureWindow, string jobId, MachineLearningJobStatus? status, IReadOnlyDictionary<string, string> tags, FeaturestoreJobType? featurestoreJobType)
        {
            CreatedOn = createdOn;
            DisplayName = displayName;
            Duration = duration;
            ExperimentId = experimentId;
            FeatureWindow = featureWindow;
            JobId = jobId;
            Status = status;
            Tags = tags;
            FeaturestoreJobType = featurestoreJobType;
        }

        /// <summary> Specifies the created date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Specifies the display name. </summary>
        public string DisplayName { get; }
        /// <summary> Specifies the duration. </summary>
        public TimeSpan? Duration { get; }
        /// <summary> Specifies the experiment id. </summary>
        public string ExperimentId { get; }
        /// <summary> Specifies the backfill feature window to be materialized. </summary>
        public FeatureWindow FeatureWindow { get; }
        /// <summary> Specifies the job id. </summary>
        public string JobId { get; }
        /// <summary> Specifies the job status. </summary>
        public MachineLearningJobStatus? Status { get; }
        /// <summary> Specifies the tags if any. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Specifies the feature store job type. </summary>
        public FeaturestoreJobType? FeaturestoreJobType { get; }
    }
}
