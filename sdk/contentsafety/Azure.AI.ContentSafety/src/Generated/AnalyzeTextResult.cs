// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    /// <summary> The text analysis response. </summary>
    public partial class AnalyzeTextResult
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextResult"/>. </summary>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="categoriesAnalysis"/> is null. </exception>
        internal AnalyzeTextResult(IEnumerable<TextCategoriesAnalysis> categoriesAnalysis)
        {
            Argument.AssertNotNull(categoriesAnalysis, nameof(categoriesAnalysis));

            BlocklistsMatch = new ChangeTrackingList<TextBlocklistMatch>();
            CategoriesAnalysis = categoriesAnalysis.ToList();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextResult"/>. </summary>
        /// <param name="blocklistsMatch"> The blocklist match details. </param>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeTextResult(IReadOnlyList<TextBlocklistMatch> blocklistsMatch, IReadOnlyList<TextCategoriesAnalysis> categoriesAnalysis, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlocklistsMatch = blocklistsMatch;
            CategoriesAnalysis = categoriesAnalysis;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextResult"/> for deserialization. </summary>
        internal AnalyzeTextResult()
        {
        }

        /// <summary> The blocklist match details. </summary>
        public IReadOnlyList<TextBlocklistMatch> BlocklistsMatch { get; }
        /// <summary> Analysis result for categories. </summary>
        public IReadOnlyList<TextCategoriesAnalysis> CategoriesAnalysis { get; }
    }
}
