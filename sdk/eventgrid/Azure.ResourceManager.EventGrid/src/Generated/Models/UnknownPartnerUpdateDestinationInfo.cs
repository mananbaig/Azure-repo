// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The UnknownPartnerUpdateDestinationInfo. </summary>
    internal partial class UnknownPartnerUpdateDestinationInfo : PartnerUpdateDestinationInfo
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPartnerUpdateDestinationInfo"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the partner destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownPartnerUpdateDestinationInfo(PartnerEndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(endpointType, serializedAdditionalRawData)
        {
            EndpointType = endpointType;
        }
    }
}
