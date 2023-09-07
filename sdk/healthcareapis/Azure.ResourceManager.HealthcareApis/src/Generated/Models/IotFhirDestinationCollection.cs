// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> A collection of IoT Connector FHIR destinations. </summary>
    internal partial class IotFhirDestinationCollection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotFhirDestinationCollection"/>. </summary>
        internal IotFhirDestinationCollection()
        {
            Value = new ChangeTrackingList<HealthcareApisIotFhirDestinationData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotFhirDestinationCollection"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of IoT FHIR destinations. </param>
        /// <param name="value"> The list of IoT Connector FHIR destinations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotFhirDestinationCollection(string nextLink, IReadOnlyList<HealthcareApisIotFhirDestinationData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link used to get the next page of IoT FHIR destinations. </summary>
        public string NextLink { get; }
        /// <summary> The list of IoT Connector FHIR destinations. </summary>
        public IReadOnlyList<HealthcareApisIotFhirDestinationData> Value { get; }
    }
}
