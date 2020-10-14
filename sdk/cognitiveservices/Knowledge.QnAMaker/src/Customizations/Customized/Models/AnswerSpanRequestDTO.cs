﻿namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// To configure Answer span prediction feature.
    /// </summary>
    public partial class AnswerSpanRequestDTO
    {
        /// <summary>
        /// Initializes a new instance of the AnswerSpanRequestDTO class.
        /// </summary>
        public AnswerSpanRequestDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnswerSpanRequestDTO class.
        /// </summary>
        /// <param name="enable">Enable or Disable Answer Span
        /// prediction.</param>
        /// <param name="scoreThreshold">Minimum threshold score required to
        /// include an answer span.</param>
        /// <param name="topAnswersWithSpan">Number of Top answers to be
        /// considered for span prediction.</param>
        public AnswerSpanRequestDTO(bool? enable = default(bool?), double? scoreThreshold = default(double?), int? topAnswersWithSpan = default(int?))
        {
            Enable = enable;
            ScoreThreshold = scoreThreshold;
            TopAnswersWithSpan = topAnswersWithSpan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enable or Disable Answer Span prediction.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Gets or sets minimum threshold score required to include an answer
        /// span.
        /// </summary>
        [JsonProperty(PropertyName = "scoreThreshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Gets or sets number of Top answers to be considered for span
        /// prediction.
        /// </summary>
        [JsonProperty(PropertyName = "topAnswersWithSpan")]
        public int? TopAnswersWithSpan { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TopAnswersWithSpan > 10)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TopAnswersWithSpan", 10);
            }
            if (TopAnswersWithSpan < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TopAnswersWithSpan", 1);
            }
        }
    }
}