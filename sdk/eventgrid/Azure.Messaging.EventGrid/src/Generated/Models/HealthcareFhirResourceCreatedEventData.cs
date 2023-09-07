// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.HealthcareApis.FhirResourceCreated event. </summary>
    public partial class HealthcareFhirResourceCreatedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareFhirResourceCreatedEventData"/>. </summary>
        internal HealthcareFhirResourceCreatedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareFhirResourceCreatedEventData"/>. </summary>
        /// <param name="fhirResourceType"> Type of HL7 FHIR resource. </param>
        /// <param name="fhirServiceHostName"> Domain name of FHIR account for this resource. </param>
        /// <param name="fhirResourceId"> Id of HL7 FHIR resource. </param>
        /// <param name="fhirResourceVersionId"> VersionId of HL7 FHIR resource. It changes when the resource is created, updated, or deleted(soft-deletion). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareFhirResourceCreatedEventData(HealthcareFhirResourceType? fhirResourceType, string fhirServiceHostName, string fhirResourceId, long? fhirResourceVersionId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FhirResourceType = fhirResourceType;
            FhirServiceHostName = fhirServiceHostName;
            FhirResourceId = fhirResourceId;
            FhirResourceVersionId = fhirResourceVersionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of HL7 FHIR resource. </summary>
        public HealthcareFhirResourceType? FhirResourceType { get; }
        /// <summary> Domain name of FHIR account for this resource. </summary>
        public string FhirServiceHostName { get; }
        /// <summary> Id of HL7 FHIR resource. </summary>
        public string FhirResourceId { get; }
        /// <summary> VersionId of HL7 FHIR resource. It changes when the resource is created, updated, or deleted(soft-deletion). </summary>
        public long? FhirResourceVersionId { get; }
    }
}
