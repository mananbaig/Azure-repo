// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The partner authorization details. </summary>
    public partial class PartnerAuthorization
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PartnerAuthorization"/>. </summary>
        public PartnerAuthorization()
        {
            AuthorizedPartnersList = new ChangeTrackingList<EventGridPartnerContent>();
        }

        /// <summary> Initializes a new instance of <see cref="PartnerAuthorization"/>. </summary>
        /// <param name="defaultMaximumExpirationTimeInDays">
        /// Time used to validate the authorization expiration time for each authorized partner. If DefaultMaximumExpirationTimeInDays is
        /// not specified, the default is 7 days. Otherwise, allowed values are between 1 and 365 days.
        /// </param>
        /// <param name="authorizedPartnersList"> The list of authorized partners. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PartnerAuthorization(int? defaultMaximumExpirationTimeInDays, IList<EventGridPartnerContent> authorizedPartnersList, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultMaximumExpirationTimeInDays = defaultMaximumExpirationTimeInDays;
            AuthorizedPartnersList = authorizedPartnersList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Time used to validate the authorization expiration time for each authorized partner. If DefaultMaximumExpirationTimeInDays is
        /// not specified, the default is 7 days. Otherwise, allowed values are between 1 and 365 days.
        /// </summary>
        public int? DefaultMaximumExpirationTimeInDays { get; set; }
        /// <summary> The list of authorized partners. </summary>
        public IList<EventGridPartnerContent> AuthorizedPartnersList { get; }
    }
}
