// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MLTableJobInput. </summary>
    public partial class MLTableJobInput : JobInput
    {
        /// <summary> Initializes a new instance of MLTableJobInput. </summary>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public MLTableJobInput(string uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
            JobInputType = JobInputType.MLTable;
        }

        /// <summary> Initializes a new instance of MLTableJobInput. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="mode"> Input Asset Delivery Mode. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        internal MLTableJobInput(string description, JobInputType jobInputType, InputDeliveryMode? mode, string uri) : base(description, jobInputType)
        {
            Mode = mode;
            Uri = uri;
            JobInputType = jobInputType;
        }

        /// <summary> Input Asset Delivery Mode. </summary>
        public InputDeliveryMode? Mode { get; set; }
        /// <summary> [Required] Input Asset URI. </summary>
        public string Uri { get; set; }
    }
}
