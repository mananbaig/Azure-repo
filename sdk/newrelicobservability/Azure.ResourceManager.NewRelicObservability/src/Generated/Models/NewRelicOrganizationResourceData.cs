// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> The details of a Organization resource. </summary>
    public partial class NewRelicOrganizationResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicOrganizationResourceData"/>. </summary>
        public NewRelicOrganizationResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicOrganizationResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="organizationId"> organization id. </param>
        /// <param name="organizationName"> organization name. </param>
        /// <param name="billingSource"> Billing source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicOrganizationResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string organizationId, string organizationName, NewRelicObservabilityBillingSource? billingSource, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OrganizationId = organizationId;
            OrganizationName = organizationName;
            BillingSource = billingSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> organization id. </summary>
        public string OrganizationId { get; set; }
        /// <summary> organization name. </summary>
        public string OrganizationName { get; set; }
        /// <summary> Billing source. </summary>
        public NewRelicObservabilityBillingSource? BillingSource { get; set; }
    }
}
