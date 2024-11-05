// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text
{
    /// <summary> A ranked list of sentences representing the extracted summary. </summary>
    public partial class KeyPhrasesActionResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesActionResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="keyPhrases"> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="keyPhrases"/> is null. </exception>
        internal KeyPhrasesActionResult(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<string> keyPhrases)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(keyPhrases, nameof(keyPhrases));

            Id = id;
            Warnings = warnings.ToList();
            KeyPhrases = keyPhrases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesActionResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="keyPhrases"> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </param>
        /// <param name="detectedLanguage"> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyPhrasesActionResult(string id, IReadOnlyList<DocumentWarning> warnings, DocumentStatistics statistics, IReadOnlyList<string> keyPhrases, DetectedLanguage detectedLanguage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Warnings = warnings;
            Statistics = statistics;
            KeyPhrases = keyPhrases;
            DetectedLanguage = detectedLanguage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesActionResult"/> for deserialization. </summary>
        internal KeyPhrasesActionResult()
        {
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<DocumentWarning> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
        /// <summary> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </summary>
        public IReadOnlyList<string> KeyPhrases { get; }
        /// <summary> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </summary>
        public DetectedLanguage DetectedLanguage { get; }
    }
}
