// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> An object representing a list in the document. </summary>
    public partial class DocumentList
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

        /// <summary> Initializes a new instance of <see cref="DocumentList"/>. </summary>
        /// <param name="spans"> Location of the list in the reading order concatenated content. </param>
        /// <param name="items"> Items in the list. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="spans"/> or <paramref name="items"/> is null. </exception>
        internal DocumentList(IEnumerable<DocumentSpan> spans, IEnumerable<DocumentListItem> items)
        {
            Argument.AssertNotNull(spans, nameof(spans));
            Argument.AssertNotNull(items, nameof(items));

            Spans = spans.ToList();
            Items = items.ToList();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentList"/>. </summary>
        /// <param name="spans"> Location of the list in the reading order concatenated content. </param>
        /// <param name="items"> Items in the list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentList(IReadOnlyList<DocumentSpan> spans, IReadOnlyList<DocumentListItem> items, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Spans = spans;
            Items = items;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentList"/> for deserialization. </summary>
        internal DocumentList()
        {
        }

        /// <summary> Location of the list in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Items in the list. </summary>
        public IReadOnlyList<DocumentListItem> Items { get; }
    }
}
