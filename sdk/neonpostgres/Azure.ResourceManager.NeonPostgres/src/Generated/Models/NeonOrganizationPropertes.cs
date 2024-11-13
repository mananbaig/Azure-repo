// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NeonPostgres.Models
{
    /// <summary> Properties specific to Data Organization resource. </summary>
    public partial class NeonOrganizationPropertes
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NeonOrganizationPropertes"/>. </summary>
        /// <param name="marketplaceDetails"> Marketplace details of the resource. </param>
        /// <param name="userDetails"> Details of the user. </param>
        /// <param name="companyDetails"> Details of the company. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceDetails"/>, <paramref name="userDetails"/> or <paramref name="companyDetails"/> is null. </exception>
        public NeonOrganizationPropertes(NeonMarketplaceDetails marketplaceDetails, NeonUserDetails userDetails, NeonCompanyDetails companyDetails)
        {
            Argument.AssertNotNull(marketplaceDetails, nameof(marketplaceDetails));
            Argument.AssertNotNull(userDetails, nameof(userDetails));
            Argument.AssertNotNull(companyDetails, nameof(companyDetails));

            MarketplaceDetails = marketplaceDetails;
            UserDetails = userDetails;
            CompanyDetails = companyDetails;
        }

        /// <summary> Initializes a new instance of <see cref="NeonOrganizationPropertes"/>. </summary>
        /// <param name="marketplaceDetails"> Marketplace details of the resource. </param>
        /// <param name="userDetails"> Details of the user. </param>
        /// <param name="companyDetails"> Details of the company. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="partnerOrganizationProperties"> Organization properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NeonOrganizationPropertes(NeonMarketplaceDetails marketplaceDetails, NeonUserDetails userDetails, NeonCompanyDetails companyDetails, NeonResourceProvisioningState? provisioningState, PartnerOrganizationProperties partnerOrganizationProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MarketplaceDetails = marketplaceDetails;
            UserDetails = userDetails;
            CompanyDetails = companyDetails;
            ProvisioningState = provisioningState;
            PartnerOrganizationProperties = partnerOrganizationProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NeonOrganizationPropertes"/> for deserialization. </summary>
        internal NeonOrganizationPropertes()
        {
        }

        /// <summary> Marketplace details of the resource. </summary>
        public NeonMarketplaceDetails MarketplaceDetails { get; set; }
        /// <summary> Details of the user. </summary>
        public NeonUserDetails UserDetails { get; set; }
        /// <summary> Details of the company. </summary>
        public NeonCompanyDetails CompanyDetails { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public NeonResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Organization properties. </summary>
        public PartnerOrganizationProperties PartnerOrganizationProperties { get; set; }
    }
}
