// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request parameter to train a new custom model. </summary>
    internal partial class TrainRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrainRequest"/>. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public TrainRequest(string source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Source = source;
        }

        /// <summary> Initializes a new instance of <see cref="TrainRequest"/>. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        /// <param name="sourceFilter"> Filter to apply to the documents in the source path for training. </param>
        /// <param name="useLabelFile"> Use label file for training a model. </param>
        /// <param name="modelName"> Optional user defined model name (max length: 1024). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrainRequest(string source, TrainingFileFilter sourceFilter, bool? useLabelFile, string modelName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            SourceFilter = sourceFilter;
            UseLabelFile = useLabelFile;
            ModelName = modelName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrainRequest"/> for deserialization. </summary>
        internal TrainRequest()
        {
        }

        /// <summary> Source path containing the training documents. </summary>
        public string Source { get; }
        /// <summary> Filter to apply to the documents in the source path for training. </summary>
        public TrainingFileFilter SourceFilter { get; set; }
        /// <summary> Use label file for training a model. </summary>
        public bool? UseLabelFile { get; set; }
        /// <summary> Optional user defined model name (max length: 1024). </summary>
        public string ModelName { get; set; }
    }
}
