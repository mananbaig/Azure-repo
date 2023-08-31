// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The prediction model status. </summary>
    public partial class PredictionModelStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PredictionModelStatus"/>. </summary>
        /// <param name="status"> Prediction model life cycle.  When prediction is in PendingModelConfirmation status, it is allowed to update the status to PendingFeaturing or Active through API. </param>
        public PredictionModelStatus(PredictionModelLifeCycle status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="PredictionModelStatus"/>. </summary>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="predictionName"> The prediction name. </param>
        /// <param name="predictionGuidId"> The prediction GUID ID. </param>
        /// <param name="status"> Prediction model life cycle.  When prediction is in PendingModelConfirmation status, it is allowed to update the status to PendingFeaturing or Active through API. </param>
        /// <param name="message"> The model status message. </param>
        /// <param name="trainingSetCount"> Count of the training set. </param>
        /// <param name="testSetCount"> Count of the test set. </param>
        /// <param name="validationSetCount"> Count of the validation set. </param>
        /// <param name="trainingAccuracy"> The training accuracy. </param>
        /// <param name="signalsUsed"> The signals used. </param>
        /// <param name="modelVersion"> Version of the model. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PredictionModelStatus(Guid? tenantId, string predictionName, string predictionGuidId, PredictionModelLifeCycle status, string message, int? trainingSetCount, int? testSetCount, int? validationSetCount, decimal? trainingAccuracy, int? signalsUsed, string modelVersion, Dictionary<string, BinaryData> rawData)
        {
            TenantId = tenantId;
            PredictionName = predictionName;
            PredictionGuidId = predictionGuidId;
            Status = status;
            Message = message;
            TrainingSetCount = trainingSetCount;
            TestSetCount = testSetCount;
            ValidationSetCount = validationSetCount;
            TrainingAccuracy = trainingAccuracy;
            SignalsUsed = signalsUsed;
            ModelVersion = modelVersion;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PredictionModelStatus"/> for deserialization. </summary>
        internal PredictionModelStatus()
        {
        }

        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> The prediction name. </summary>
        public string PredictionName { get; }
        /// <summary> The prediction GUID ID. </summary>
        public string PredictionGuidId { get; }
        /// <summary> Prediction model life cycle.  When prediction is in PendingModelConfirmation status, it is allowed to update the status to PendingFeaturing or Active through API. </summary>
        public PredictionModelLifeCycle Status { get; set; }
        /// <summary> The model status message. </summary>
        public string Message { get; }
        /// <summary> Count of the training set. </summary>
        public int? TrainingSetCount { get; }
        /// <summary> Count of the test set. </summary>
        public int? TestSetCount { get; }
        /// <summary> Count of the validation set. </summary>
        public int? ValidationSetCount { get; }
        /// <summary> The training accuracy. </summary>
        public decimal? TrainingAccuracy { get; }
        /// <summary> The signals used. </summary>
        public int? SignalsUsed { get; }
        /// <summary> Version of the model. </summary>
        public string ModelVersion { get; }
    }
}
