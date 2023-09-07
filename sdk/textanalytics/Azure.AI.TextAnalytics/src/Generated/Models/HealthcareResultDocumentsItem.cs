// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareResultDocumentsItem. </summary>
    internal partial class HealthcareResultDocumentsItem : HealthcareEntitiesDocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareResultDocumentsItem"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="entities"/> or <paramref name="relations"/> is null. </exception>
        public HealthcareResultDocumentsItem(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<HealthcareEntityInternal> entities, IEnumerable<HealthcareRelationInternal> relations) : base(id, warnings, entities, relations)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(entities, nameof(entities));
            Argument.AssertNotNull(relations, nameof(relations));
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareResultDocumentsItem"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareResultDocumentsItem(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<HealthcareEntityInternal> entities, IList<HealthcareRelationInternal> relations, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, warnings, statistics, entities, relations, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareResultDocumentsItem"/> for deserialization. </summary>
        internal HealthcareResultDocumentsItem()
        {
        }
    }
}
