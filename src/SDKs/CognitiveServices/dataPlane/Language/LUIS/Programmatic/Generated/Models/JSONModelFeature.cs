// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Exported Model - Phraselist Model Feature.
    /// </summary>
    public partial class JSONModelFeature
    {
        /// <summary>
        /// Initializes a new instance of the JSONModelFeature class.
        /// </summary>
        public JSONModelFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONModelFeature class.
        /// </summary>
        /// <param name="activated">Indicates if the feature is
        /// enabled.</param>
        /// <param name="name">The Phraselist name.</param>
        /// <param name="words">List of comma-separated phrases that represent
        /// the Phraselist.</param>
        /// <param name="mode">An exchangeable phrase list feature are serves
        /// as single feature to the LUIS underlying training algorithm. It is
        /// used as a lexicon lookup feature where its value is 1 if the
        /// lexicon contains a given word or 0 if it doesn’t. Think of an
        /// exchangeable as a synonyms list. A non-exchangeable phrase list
        /// feature has all the phrases in the list serve as separate features
        /// to the underlying training algorithm. So, if you your phrase list
        /// feature contains 5 phrases, they will be mapped to 5 separate
        /// features. You can think of the non-exchangeable phrase list feature
        /// as an additional bag of words that you are willing to add to LUIS
        /// existing vocabulary features. Think of a non-exchangeable as set of
        /// different words. Default value is true.</param>
        public JSONModelFeature(bool? activated = default(bool?), string name = default(string), string words = default(string), bool? mode = default(bool?))
        {
            Activated = activated;
            Name = name;
            Words = words;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates if the feature is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "activated")]
        public bool? Activated { get; set; }

        /// <summary>
        /// Gets or sets the Phraselist name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of comma-separated phrases that represent the
        /// Phraselist.
        /// </summary>
        [JsonProperty(PropertyName = "words")]
        public string Words { get; set; }

        /// <summary>
        /// Gets or sets an exchangeable phrase list feature are serves as
        /// single feature to the LUIS underlying training algorithm. It is
        /// used as a lexicon lookup feature where its value is 1 if the
        /// lexicon contains a given word or 0 if it doesn’t. Think of an
        /// exchangeable as a synonyms list. A non-exchangeable phrase list
        /// feature has all the phrases in the list serve as separate features
        /// to the underlying training algorithm. So, if you your phrase list
        /// feature contains 5 phrases, they will be mapped to 5 separate
        /// features. You can think of the non-exchangeable phrase list feature
        /// as an additional bag of words that you are willing to add to LUIS
        /// existing vocabulary features. Think of a non-exchangeable as set of
        /// different words. Default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public bool? Mode { get; set; }

    }
}
