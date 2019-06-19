// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Exported Model - Utterance that was used to train the model.
    /// </summary>
    public partial class JSONUtterance
    {
        /// <summary>
        /// Initializes a new instance of the JSONUtterance class.
        /// </summary>
        public JSONUtterance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONUtterance class.
        /// </summary>
        /// <param name="text">The utterance.</param>
        /// <param name="intent">The matched intent.</param>
        /// <param name="entities">The matched entities.</param>
        public JSONUtterance(string text = default(string), string intent = default(string), IList<JSONEntity> entities = default(IList<JSONEntity>))
        {
            Text = text;
            Intent = intent;
            Entities = entities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the utterance.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the matched intent.
        /// </summary>
        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

        /// <summary>
        /// Gets or sets the matched entities.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<JSONEntity> Entities { get; set; }

    }
}
