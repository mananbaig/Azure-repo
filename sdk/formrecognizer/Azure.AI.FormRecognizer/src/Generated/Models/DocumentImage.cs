// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An image object detected in the page. </summary>
    internal partial class DocumentImage
    {
        /// <summary> Initializes a new instance of DocumentImage. </summary>
        /// <param name="span"> Location of the image in the reading order concatenated content. </param>
        /// <param name="pageRef"> 0-based index of the global pages array that containing the content of the image. </param>
        /// <param name="confidence"> Confidence of correctly identifying the image. </param>
        internal DocumentImage(DocumentSpan span, int pageRef, float confidence)
        {
            Polygon = new ChangeTrackingList<float>();
            Span = span;
            PageRef = pageRef;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of DocumentImage. </summary>
        /// <param name="polygon"> Bounding polygon of the image. </param>
        /// <param name="span"> Location of the image in the reading order concatenated content. </param>
        /// <param name="pageRef"> 0-based index of the global pages array that containing the content of the image. </param>
        /// <param name="confidence"> Confidence of correctly identifying the image. </param>
        internal DocumentImage(IReadOnlyList<float> polygon, DocumentSpan span, int pageRef, float confidence)
        {
            Polygon = polygon;
            Span = span;
            PageRef = pageRef;
            Confidence = confidence;
        }

        /// <summary> Bounding polygon of the image. </summary>
        public IReadOnlyList<float> Polygon { get; }
        /// <summary> Location of the image in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> 0-based index of the global pages array that containing the content of the image. </summary>
        public int PageRef { get; }
        /// <summary> Confidence of correctly identifying the image. </summary>
        public float Confidence { get; }
    }
}
