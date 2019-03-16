// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A skill that uses text analytics for key phrase extraction.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-keyphrases"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Text.KeyPhraseExtractionSkill")]
    public partial class KeyPhraseExtractionSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the KeyPhraseExtractionSkill class.
        /// </summary>
        public KeyPhraseExtractionSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyPhraseExtractionSkill class.
        /// </summary>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content).</param>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="defaultLanguageCode">A value indicating which language
        /// code to use. Default is en. Possible values include: 'da', 'nl',
        /// 'en', 'fi', 'fr', 'de', 'it', 'ja', 'ko', 'no', 'pl', 'pt-PT',
        /// 'pt-BR', 'ru', 'es', 'sv'</param>
        /// <param name="maxKeyPhraseCount">A number indicating how many key
        /// phrases to return. If absent, all identified key phrases will be
        /// returned.</param>
        public KeyPhraseExtractionSkill(string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, KeyPhraseExtractionSkillLanguage? defaultLanguageCode = default(KeyPhraseExtractionSkillLanguage?), int? maxKeyPhraseCount = default(int?))
            : base(description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            MaxKeyPhraseCount = maxKeyPhraseCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating which language code to use. Default
        /// is en. Possible values include: 'da', 'nl', 'en', 'fi', 'fr', 'de',
        /// 'it', 'ja', 'ko', 'no', 'pl', 'pt-PT', 'pt-BR', 'ru', 'es', 'sv'
        /// </summary>
        [JsonProperty(PropertyName = "defaultLanguageCode")]
        public KeyPhraseExtractionSkillLanguage? DefaultLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets a number indicating how many key phrases to return. If
        /// absent, all identified key phrases will be returned.
        /// </summary>
        [JsonProperty(PropertyName = "maxKeyPhraseCount")]
        public int? MaxKeyPhraseCount { get; set; }

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
