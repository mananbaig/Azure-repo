// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A list of skills. </summary>
    public partial class SearchIndexerSkillset
    {
        /// <summary> Initializes a new instance of SearchIndexerSkillset. </summary>
        /// <param name="name"> The name of the skillset. </param>
        /// <param name="skills">
        /// A list of skills in the skillset.
        /// Please note <see cref="SearchIndexerSkill"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebApiSkill"/>, <see cref="CustomEntityLookupSkill"/>, <see cref="EntityRecognitionSkill"/>, <see cref="KeyPhraseExtractionSkill"/>, <see cref="LanguageDetectionSkill"/>, <see cref="MergeSkill"/>, <see cref="PiiDetectionSkill"/>, <see cref="SentimentSkill"/>, <see cref="SplitSkill"/>, <see cref="TextTranslationSkill"/>, <see cref="EntityLinkingSkill"/>, <see cref="EntityRecognitionSkillV3"/>, <see cref="SentimentSkillV3"/>, <see cref="ConditionalSkill"/>, <see cref="DocumentExtractionSkill"/>, <see cref="ShaperSkill"/>, <see cref="ImageAnalysisSkill"/> and <see cref="OcrSkill"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="skills"/> is null. </exception>
        public SearchIndexerSkillset(string name, IEnumerable<SearchIndexerSkill> skills)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(skills, nameof(skills));

            Name = name;
            Skills = skills.ToList();
        }

        /// <summary> Initializes a new instance of SearchIndexerSkillset. </summary>
        /// <param name="name"> The name of the skillset. </param>
        /// <param name="description"> The description of the skillset. </param>
        /// <param name="skills">
        /// A list of skills in the skillset.
        /// Please note <see cref="SearchIndexerSkill"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebApiSkill"/>, <see cref="CustomEntityLookupSkill"/>, <see cref="EntityRecognitionSkill"/>, <see cref="KeyPhraseExtractionSkill"/>, <see cref="LanguageDetectionSkill"/>, <see cref="MergeSkill"/>, <see cref="PiiDetectionSkill"/>, <see cref="SentimentSkill"/>, <see cref="SplitSkill"/>, <see cref="TextTranslationSkill"/>, <see cref="EntityLinkingSkill"/>, <see cref="EntityRecognitionSkillV3"/>, <see cref="SentimentSkillV3"/>, <see cref="ConditionalSkill"/>, <see cref="DocumentExtractionSkill"/>, <see cref="ShaperSkill"/>, <see cref="ImageAnalysisSkill"/> and <see cref="OcrSkill"/>.
        /// </param>
        /// <param name="cognitiveServicesAccount">
        /// Details about the Azure AI service to be used when running skills.
        /// Please note <see cref="Models.CognitiveServicesAccount"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CognitiveServicesAccountKey"/> and <see cref="DefaultCognitiveServicesAccount"/>.
        /// </param>
        /// <param name="knowledgeStore"> Definition of additional projections to Azure blob, table, or files, of enriched data. </param>
        /// <param name="etag"> The ETag of the skillset. </param>
        /// <param name="encryptionKey"> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your skillset definition when you want full assurance that no one, not even Microsoft, can decrypt your skillset definition. Once you have encrypted your skillset definition, it will always remain encrypted. The search service will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your skillset definition will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </param>
        internal SearchIndexerSkillset(string name, string description, IList<SearchIndexerSkill> skills, CognitiveServicesAccount cognitiveServicesAccount, KnowledgeStore knowledgeStore, string etag, SearchResourceEncryptionKey encryptionKey)
        {
            Name = name;
            Description = description;
            Skills = skills;
            CognitiveServicesAccount = cognitiveServicesAccount;
            KnowledgeStore = knowledgeStore;
            _etag = etag;
            EncryptionKey = encryptionKey;
        }

        /// <summary> The name of the skillset. </summary>
        public string Name { get; set; }
        /// <summary> The description of the skillset. </summary>
        public string Description { get; set; }
        /// <summary>
        /// Details about the Azure AI service to be used when running skills.
        /// Please note <see cref="Models.CognitiveServicesAccount"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CognitiveServicesAccountKey"/> and <see cref="DefaultCognitiveServicesAccount"/>.
        /// </summary>
        public CognitiveServicesAccount CognitiveServicesAccount { get; set; }
        /// <summary> Definition of additional projections to Azure blob, table, or files, of enriched data. </summary>
        public KnowledgeStore KnowledgeStore { get; set; }
        /// <summary> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your skillset definition when you want full assurance that no one, not even Microsoft, can decrypt your skillset definition. Once you have encrypted your skillset definition, it will always remain encrypted. The search service will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your skillset definition will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </summary>
        public SearchResourceEncryptionKey EncryptionKey { get; set; }
    }
}
