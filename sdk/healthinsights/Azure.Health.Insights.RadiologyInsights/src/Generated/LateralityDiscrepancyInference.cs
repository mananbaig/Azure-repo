// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> A laterality mismatch occurs when there is a discrepancy between the clinical documentation and the ordered procedure (orderLateralityMismatch), a contradiction within the clinical document (textLateralityContradiction), or when no laterality is mentioned (textLateralityMissing). </summary>
    public partial class LateralityDiscrepancyInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="LateralityDiscrepancyInference"/>. </summary>
        /// <param name="discrepancyType"> Mismatch type : orderLateralityMismatch, textLateralityContradiction, textLateralityMissing. </param>
        internal LateralityDiscrepancyInference(LateralityDiscrepancyType discrepancyType)
        {
            Kind = RadiologyInsightsInferenceType.LateralityDiscrepancy;
            DiscrepancyType = discrepancyType;
        }

        /// <summary> Initializes a new instance of <see cref="LateralityDiscrepancyInference"/>. </summary>
        /// <param name="kind"> Discriminator property for RadiologyInsightsInference. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="lateralityIndication"> Laterality indication : SNOMED CT code for laterality qualifier value. </param>
        /// <param name="discrepancyType"> Mismatch type : orderLateralityMismatch, textLateralityContradiction, textLateralityMissing. </param>
        internal LateralityDiscrepancyInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4CodeableConcept lateralityIndication, LateralityDiscrepancyType discrepancyType) : base(kind, extension, serializedAdditionalRawData)
        {
            LateralityIndication = lateralityIndication;
            DiscrepancyType = discrepancyType;
        }

        /// <summary> Initializes a new instance of <see cref="LateralityDiscrepancyInference"/> for deserialization. </summary>
        internal LateralityDiscrepancyInference()
        {
        }

        /// <summary> Laterality indication : SNOMED CT code for laterality qualifier value. </summary>
        public FhirR4CodeableConcept LateralityIndication { get; }
        /// <summary> Mismatch type : orderLateralityMismatch, textLateralityContradiction, textLateralityMissing. </summary>
        public LateralityDiscrepancyType DiscrepancyType { get; }
    }
}
