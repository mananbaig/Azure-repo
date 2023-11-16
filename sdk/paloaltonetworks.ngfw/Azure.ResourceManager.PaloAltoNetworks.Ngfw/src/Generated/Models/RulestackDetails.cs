// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Associated rulestack details. </summary>
    public partial class RulestackDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RulestackDetails"/>. </summary>
        public RulestackDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RulestackDetails"/>. </summary>
        /// <param name="resourceId"> Resource Id. </param>
        /// <param name="rulestackId"> Associated rulestack Id. </param>
        /// <param name="location"> Rulestack location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulestackDetails(ResourceIdentifier resourceId, string rulestackId, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            RulestackId = rulestackId;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Associated rulestack Id. </summary>
        public string RulestackId { get; set; }
        /// <summary> Rulestack location. </summary>
        public AzureLocation? Location { get; set; }
    }
}
