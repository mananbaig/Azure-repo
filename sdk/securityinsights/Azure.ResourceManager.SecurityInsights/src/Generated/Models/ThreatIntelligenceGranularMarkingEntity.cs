// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes threat granular marking model entity. </summary>
    public partial class ThreatIntelligenceGranularMarkingEntity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceGranularMarkingEntity"/>. </summary>
        public ThreatIntelligenceGranularMarkingEntity()
        {
            Selectors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceGranularMarkingEntity"/>. </summary>
        /// <param name="language"> Language granular marking model. </param>
        /// <param name="markingRef"> marking reference granular marking model. </param>
        /// <param name="selectors"> granular marking model selectors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceGranularMarkingEntity(string language, int? markingRef, IList<string> selectors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Language = language;
            MarkingRef = markingRef;
            Selectors = selectors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Language granular marking model. </summary>
        public string Language { get; set; }
        /// <summary> marking reference granular marking model. </summary>
        public int? MarkingRef { get; set; }
        /// <summary> granular marking model selectors. </summary>
        public IList<string> Selectors { get; }
    }
}
