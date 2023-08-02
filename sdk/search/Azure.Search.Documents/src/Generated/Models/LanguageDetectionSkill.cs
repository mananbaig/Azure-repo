// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A skill that detects the language of input text and reports a single language code for every document submitted on the request. The language code is paired with a score indicating the confidence of the analysis. </summary>
    public partial class LanguageDetectionSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of LanguageDetectionSkill. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public LanguageDetectionSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(outputs, nameof(outputs));

            ODataType = "#Microsoft.Skills.Text.LanguageDetectionSkill";
        }

        /// <summary> Initializes a new instance of LanguageDetectionSkill. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="defaultCountryHint"> A country code to use as a hint to the language detection model if it cannot disambiguate the language. </param>
        /// <param name="modelVersion"> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </param>
        internal LanguageDetectionSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string defaultCountryHint, string modelVersion) : base(oDataType, name, description, context, inputs, outputs)
        {
            DefaultCountryHint = defaultCountryHint;
            ModelVersion = modelVersion;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.LanguageDetectionSkill";
        }

        /// <summary> A country code to use as a hint to the language detection model if it cannot disambiguate the language. </summary>
        public string DefaultCountryHint { get; set; }
    }
}
