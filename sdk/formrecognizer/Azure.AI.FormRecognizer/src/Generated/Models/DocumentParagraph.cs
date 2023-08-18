// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A paragraph object consisting with contiguous lines generally with common alignment and spacing. </summary>
    public partial class DocumentParagraph
    {
        /// <summary> Initializes a new instance of DocumentParagraph. </summary>
        /// <param name="content"> Concatenated content of the paragraph in reading order. </param>
        /// <param name="spans"> Location of the paragraph in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentParagraph(string content, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(spans, nameof(spans));

            Content = content;
            BoundingRegions = new Core.ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of DocumentParagraph. </summary>
        /// <param name="role"> Semantic role of the paragraph. </param>
        /// <param name="content"> Concatenated content of the paragraph in reading order. </param>
        /// <param name="boundingRegions"> Bounding regions covering the paragraph. </param>
        /// <param name="spans"> Location of the paragraph in the reading order concatenated content. </param>
        internal DocumentParagraph(ParagraphRole? role, string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans)
        {
            Role = role;
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
        }

        /// <summary> Semantic role of the paragraph. </summary>
        public ParagraphRole? Role { get; }
        /// <summary> Concatenated content of the paragraph in reading order. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the paragraph. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the paragraph in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
