// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Organization Info of the NewRelic account. </summary>
    internal partial class NewRelicObservabilityOrganizationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityOrganizationInfo"/>. </summary>
        public NewRelicObservabilityOrganizationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityOrganizationInfo"/>. </summary>
        /// <param name="organizationId"> Organization id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityOrganizationInfo(string organizationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OrganizationId = organizationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Organization id. </summary>
        public string OrganizationId { get; set; }
    }
}
