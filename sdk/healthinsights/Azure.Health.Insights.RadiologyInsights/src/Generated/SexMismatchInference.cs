// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> A notification for a sex mismatch is displayed when the gender, personal pronouns, gender-related body parts, or gender-related procedures mentioned in a patient's clinical document are either inconsistent or do not match the gender specified in the patient information. </summary>
    public partial class SexMismatchInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="SexMismatchInference"/>. </summary>
        /// <param name="sexIndication"> Sex indication : SNOMED CT code for gender finding. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sexIndication"/> is null. </exception>
        internal SexMismatchInference(FhirR4CodeableConcept sexIndication)
        {
            Argument.AssertNotNull(sexIndication, nameof(sexIndication));

            Kind = RadiologyInsightsInferenceType.SexMismatch;
            SexIndication = sexIndication;
        }

        /// <summary> Initializes a new instance of <see cref="SexMismatchInference"/>. </summary>
        /// <param name="kind"> Discriminator property for RadiologyInsightsInference. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sexIndication"> Sex indication : SNOMED CT code for gender finding. </param>
        internal SexMismatchInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4CodeableConcept sexIndication) : base(kind, extension, serializedAdditionalRawData)
        {
            SexIndication = sexIndication;
        }

        /// <summary> Initializes a new instance of <see cref="SexMismatchInference"/> for deserialization. </summary>
        internal SexMismatchInference()
        {
        }

        /// <summary> Sex indication : SNOMED CT code for gender finding. </summary>
        public FhirR4CodeableConcept SexIndication { get; }
    }
}
