// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Q-A object.
    /// </summary>
    public partial class QnADTO
    {
        /// <summary>
        /// Initializes a new instance of the QnADTO class.
        /// </summary>
        public QnADTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QnADTO class.
        /// </summary>
        /// <param name="answer">Answer text</param>
        /// <param name="questions">List of questions associated with the
        /// answer.</param>
        /// <param name="id">Unique id for the Q-A.</param>
        /// <param name="source">Source from which Q-A was indexed. eg.
        /// https://docs.microsoft.com/en-us/azure/cognitive-services/QnAMaker/FAQs</param>
        /// <param name="metadata">List of metadata associated with the
        /// answer.</param>
        /// <param name="context">Context of a QnA</param>
        public QnADTO(string answer, IList<string> questions, int? id = default(int?), string source = default(string), IList<MetadataDTO> metadata = default(IList<MetadataDTO>), QnADTOContext context = default(QnADTOContext))
        {
            Id = id;
            Answer = answer;
            Source = source;
            Questions = questions;
            Metadata = metadata;
            Context = context;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique id for the Q-A.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets answer text
        /// </summary>
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or sets source from which Q-A was indexed. eg.
        /// https://docs.microsoft.com/en-us/azure/cognitive-services/QnAMaker/FAQs
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets list of questions associated with the answer.
        /// </summary>
        [JsonProperty(PropertyName = "questions")]
        public IList<string> Questions { get; set; }

        /// <summary>
        /// Gets or sets list of metadata associated with the answer.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataDTO> Metadata { get; set; }

        /// <summary>
        /// Gets or sets context of a QnA
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public QnADTOContext Context { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Answer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Answer");
            }
            if (Questions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Questions");
            }
            if (Answer != null)
            {
                if (Answer.Length > 25000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Answer", 25000);
                }
                if (Answer.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Answer", 1);
                }
            }
            if (Source != null)
            {
                if (Source.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Source", 300);
                }
            }
            if (Metadata != null)
            {
                foreach (var element in Metadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
