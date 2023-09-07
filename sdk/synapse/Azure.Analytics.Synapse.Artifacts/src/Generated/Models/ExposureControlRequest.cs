// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The exposure control request. </summary>
    public partial class ExposureControlRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExposureControlRequest"/>. </summary>
        public ExposureControlRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExposureControlRequest"/>. </summary>
        /// <param name="featureName"> The feature name. </param>
        /// <param name="featureType"> The feature type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExposureControlRequest(string featureName, string featureType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FeatureName = featureName;
            FeatureType = featureType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The feature name. </summary>
        public string FeatureName { get; set; }
        /// <summary> The feature type. </summary>
        public string FeatureType { get; set; }
    }
}
