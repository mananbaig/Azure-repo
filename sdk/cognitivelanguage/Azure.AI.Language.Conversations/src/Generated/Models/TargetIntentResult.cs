// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.Conversations
{
    /// <summary> This is the base class of an intent prediction. </summary>
    public partial class TargetIntentResult
    {
        /// <summary> Initializes a new instance of TargetIntentResult. </summary>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        internal TargetIntentResult(float confidence)
        {
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of TargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        internal TargetIntentResult(TargetKind targetKind, string apiVersion, float confidence)
        {
            TargetKind = targetKind;
            ApiVersion = apiVersion;
            Confidence = confidence;
        }
        /// <summary> The API version used to call a target service. </summary>
        public string ApiVersion { get; }
        /// <summary> The prediction score and it ranges from 0.0 to 1.0. </summary>
        public float Confidence { get; }
    }
}
