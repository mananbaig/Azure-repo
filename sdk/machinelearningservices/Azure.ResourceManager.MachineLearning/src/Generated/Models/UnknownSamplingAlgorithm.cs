// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Unknown version of SamplingAlgorithm. </summary>
    internal partial class UnknownSamplingAlgorithm : SamplingAlgorithm
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSamplingAlgorithm"/>. </summary>
        /// <param name="samplingAlgorithmType"> [Required] The algorithm used for generating hyperparameter values, along with configuration properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSamplingAlgorithm(SamplingAlgorithmType samplingAlgorithmType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(samplingAlgorithmType, serializedAdditionalRawData)
        {
            SamplingAlgorithmType = samplingAlgorithmType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSamplingAlgorithm"/> for deserialization. </summary>
        internal UnknownSamplingAlgorithm()
        {
        }
    }
}
