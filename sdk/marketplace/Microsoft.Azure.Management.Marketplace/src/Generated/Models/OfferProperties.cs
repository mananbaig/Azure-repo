// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class OfferProperties
    {
        /// <summary>
        /// Initializes a new instance of the OfferProperties class.
        /// </summary>
        public OfferProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfferProperties class.
        /// </summary>
        /// <param name="uniqueOfferId">Offers unique id</param>
        /// <param name="offerDisplayName">It will be displayed prominently in
        /// the marketplace</param>
        /// <param name="publisherDisplayName">Publisher name that will be
        /// displayed prominently in the marketplace</param>
        /// <param name="eTag">Identifier for purposes of race
        /// condition</param>
        /// <param name="privateStoreId">Private store unique id</param>
        /// <param name="createdAt">Private store offer creation date</param>
        /// <param name="modifiedAt">Private store offer modification
        /// date</param>
        /// <param name="specificPlanIdsLimitation">Plan ids limitation for
        /// this offer</param>
        /// <param name="updateSuppressedDueIdempotence">Indicating whether the
        /// offer was not updated to db (true = not updated). If the allow list
        /// is identical to the existed one in db, the offer would not be
        /// updated.</param>
        /// <param name="iconFileUris">Icon File Uris</param>
        /// <param name="plans">Offer plans</param>
        public OfferProperties(string uniqueOfferId = default(string), string offerDisplayName = default(string), string publisherDisplayName = default(string), string eTag = default(string), string privateStoreId = default(string), string createdAt = default(string), string modifiedAt = default(string), IList<string> specificPlanIdsLimitation = default(IList<string>), bool? updateSuppressedDueIdempotence = default(bool?), IDictionary<string, string> iconFileUris = default(IDictionary<string, string>), IList<Plan> plans = default(IList<Plan>))
        {
            UniqueOfferId = uniqueOfferId;
            OfferDisplayName = offerDisplayName;
            PublisherDisplayName = publisherDisplayName;
            ETag = eTag;
            PrivateStoreId = privateStoreId;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            SpecificPlanIdsLimitation = specificPlanIdsLimitation;
            UpdateSuppressedDueIdempotence = updateSuppressedDueIdempotence;
            IconFileUris = iconFileUris;
            Plans = plans;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets offers unique id
        /// </summary>
        [JsonProperty(PropertyName = "uniqueOfferId")]
        public string UniqueOfferId { get; private set; }

        /// <summary>
        /// Gets it will be displayed prominently in the marketplace
        /// </summary>
        [JsonProperty(PropertyName = "offerDisplayName")]
        public string OfferDisplayName { get; private set; }

        /// <summary>
        /// Gets publisher name that will be displayed prominently in the
        /// marketplace
        /// </summary>
        [JsonProperty(PropertyName = "publisherDisplayName")]
        public string PublisherDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets identifier for purposes of race condition
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets private store unique id
        /// </summary>
        [JsonProperty(PropertyName = "privateStoreId")]
        public string PrivateStoreId { get; private set; }

        /// <summary>
        /// Gets private store offer creation date
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Gets private store offer modification date
        /// </summary>
        [JsonProperty(PropertyName = "modifiedAt")]
        public string ModifiedAt { get; private set; }

        /// <summary>
        /// Gets or sets plan ids limitation for this offer
        /// </summary>
        [JsonProperty(PropertyName = "specificPlanIdsLimitation")]
        public IList<string> SpecificPlanIdsLimitation { get; set; }

        /// <summary>
        /// Gets or sets indicating whether the offer was not updated to db
        /// (true = not updated). If the allow list is identical to the existed
        /// one in db, the offer would not be updated.
        /// </summary>
        [JsonProperty(PropertyName = "updateSuppressedDueIdempotence")]
        public bool? UpdateSuppressedDueIdempotence { get; set; }

        /// <summary>
        /// Gets or sets icon File Uris
        /// </summary>
        [JsonProperty(PropertyName = "iconFileUris")]
        public IDictionary<string, string> IconFileUris { get; set; }

        /// <summary>
        /// Gets or sets offer plans
        /// </summary>
        [JsonProperty(PropertyName = "plans")]
        public IList<Plan> Plans { get; set; }

    }
}
