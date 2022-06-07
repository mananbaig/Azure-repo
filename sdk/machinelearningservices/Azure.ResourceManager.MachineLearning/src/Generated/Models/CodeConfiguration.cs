// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Configuration for a scoring code asset. </summary>
    public partial class CodeConfiguration
    {
        /// <summary> Initializes a new instance of CodeConfiguration. </summary>
        /// <param name="scoringScript"> [Required] The script to execute on startup. eg. &quot;score.py&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scoringScript"/> is null. </exception>
        public CodeConfiguration(string scoringScript)
        {
            if (scoringScript == null)
            {
                throw new ArgumentNullException(nameof(scoringScript));
            }

            ScoringScript = scoringScript;
        }

        /// <summary> Initializes a new instance of CodeConfiguration. </summary>
        /// <param name="codeId"> ARM resource ID of the code asset. </param>
        /// <param name="scoringScript"> [Required] The script to execute on startup. eg. &quot;score.py&quot;. </param>
        internal CodeConfiguration(string codeId, string scoringScript)
        {
            CodeId = codeId;
            ScoringScript = scoringScript;
        }

        /// <summary> ARM resource ID of the code asset. </summary>
        public string CodeId { get; set; }
        /// <summary> [Required] The script to execute on startup. eg. &quot;score.py&quot;. </summary>
        public string ScoringScript { get; set; }
    }
}
