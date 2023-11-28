// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownJobInput. </summary>
    internal partial class UnknownJobInput : MachineLearningJobInput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownJobInput"/>. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        internal UnknownJobInput(string description, JobInputType jobInputType) : base(description, jobInputType)
        {
            JobInputType = jobInputType;
        }
    }
}
