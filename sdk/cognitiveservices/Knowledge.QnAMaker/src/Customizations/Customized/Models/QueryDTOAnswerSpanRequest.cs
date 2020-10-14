﻿namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using System.Linq;

    /// <summary>
    /// To configure Answer span prediction feature.
    /// </summary>
    public partial class QueryDTOAnswerSpanRequest : AnswerSpanRequestDTO
    {
        /// <summary>
        /// Initializes a new instance of the QueryDTOAnswerSpanRequest class.
        /// </summary>
        public QueryDTOAnswerSpanRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryDTOAnswerSpanRequest class.
        /// </summary>
        /// <param name="enable">Enable or Disable Answer Span
        /// prediction.</param>
        /// <param name="scoreThreshold">Minimum threshold score required to
        /// include an answer span.</param>
        /// <param name="topAnswersWithSpan">Number of Top answers to be
        /// considered for span prediction.</param>
        public QueryDTOAnswerSpanRequest(bool? enable = default(bool?), double? scoreThreshold = default(double?), int? topAnswersWithSpan = default(int?))
            : base(enable, scoreThreshold, topAnswersWithSpan)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}