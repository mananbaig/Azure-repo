// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A formula object. </summary>
    public partial class DocumentFormula
    {
        /// <summary> Initializes a new instance of DocumentFormula. </summary>
        /// <param name="kind"> Formula kind. </param>
        /// <param name="value"> LaTex expression describing the formula. </param>
        /// <param name="span"> Location of the formula in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the formula. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DocumentFormula(DocumentFormulaKind kind, string value, DocumentSpan span, float confidence)
        {
            Argument.AssertNotNull(value, nameof(value));

            Kind = kind;
            Value = value;
            Polygon = new Core.ChangeTrackingList<float>();
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of DocumentFormula. </summary>
        /// <param name="kind"> Formula kind. </param>
        /// <param name="value"> LaTex expression describing the formula. </param>
        /// <param name="polygon"> Bounding polygon of the formula. </param>
        /// <param name="span"> Location of the formula in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the formula. </param>
        internal DocumentFormula(DocumentFormulaKind kind, string value, IReadOnlyList<float> polygon, DocumentSpan span, float confidence)
        {
            Kind = kind;
            Value = value;
            Polygon = polygon;
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Formula kind. </summary>
        public DocumentFormulaKind Kind { get; }
        /// <summary> LaTex expression describing the formula. </summary>
        public string Value { get; }
        /// <summary> Location of the formula in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> Confidence of correctly extracting the formula. </summary>
        public float Confidence { get; }
    }
}
