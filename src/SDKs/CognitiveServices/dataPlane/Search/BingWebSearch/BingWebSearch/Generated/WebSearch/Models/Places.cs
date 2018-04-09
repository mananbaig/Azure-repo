// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a local entity answer.
    /// </summary>
    public partial class Places : SearchResultsAnswer
    {
        /// <summary>
        /// Initializes a new instance of the Places class.
        /// </summary>
        public Places()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Places class.
        /// </summary>
        /// <param name="value">A list of local entities, such as restaurants
        /// or hotels.</param>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="totalEstimatedMatches">The estimated number of
        /// webpages that are relevant to the query. Use this number along with
        /// the count and offset query parameters to page the results.</param>
        public Places(IList<Thing> value, string id = default(string), string webSearchUrl = default(string), IList<Query> followUpQueries = default(IList<Query>), QueryContext queryContext = default(QueryContext), long? totalEstimatedMatches = default(long?), bool? isFamilyFriendly = default(bool?))
            : base(id, webSearchUrl, followUpQueries, queryContext, totalEstimatedMatches, isFamilyFriendly)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of local entities, such as restaurants or
        /// hotels.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Thing> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
