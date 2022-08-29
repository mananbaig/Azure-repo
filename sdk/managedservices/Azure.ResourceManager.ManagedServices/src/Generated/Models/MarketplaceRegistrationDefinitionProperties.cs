// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The properties of the marketplace registration definition. </summary>
    public partial class MarketplaceRegistrationDefinitionProperties
    {
        /// <summary> Initializes a new instance of MarketplaceRegistrationDefinitionProperties. </summary>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedByTenantId"/> or <paramref name="authorizations"/> is null. </exception>
        internal MarketplaceRegistrationDefinitionProperties(string managedByTenantId, IEnumerable<Authorization> authorizations)
        {
            if (managedByTenantId == null)
            {
                throw new ArgumentNullException(nameof(managedByTenantId));
            }
            if (authorizations == null)
            {
                throw new ArgumentNullException(nameof(authorizations));
            }

            ManagedByTenantId = managedByTenantId;
            Authorizations = authorizations.ToList();
            EligibleAuthorizations = new ChangeTrackingList<EligibleAuthorization>();
        }

        /// <summary> Initializes a new instance of MarketplaceRegistrationDefinitionProperties. </summary>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="offerDisplayName"> The marketplace offer display name. </param>
        /// <param name="publisherDisplayName"> The marketplace publisher display name. </param>
        /// <param name="planDisplayName"> The marketplace plan display name. </param>
        internal MarketplaceRegistrationDefinitionProperties(string managedByTenantId, IReadOnlyList<Authorization> authorizations, IReadOnlyList<EligibleAuthorization> eligibleAuthorizations, string offerDisplayName, string publisherDisplayName, string planDisplayName)
        {
            ManagedByTenantId = managedByTenantId;
            Authorizations = authorizations;
            EligibleAuthorizations = eligibleAuthorizations;
            OfferDisplayName = offerDisplayName;
            PublisherDisplayName = publisherDisplayName;
            PlanDisplayName = planDisplayName;
        }

        /// <summary> The identifier of the managedBy tenant. </summary>
        public string ManagedByTenantId { get; }
        /// <summary> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IReadOnlyList<Authorization> Authorizations { get; }
        /// <summary> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IReadOnlyList<EligibleAuthorization> EligibleAuthorizations { get; }
        /// <summary> The marketplace offer display name. </summary>
        public string OfferDisplayName { get; }
        /// <summary> The marketplace publisher display name. </summary>
        public string PublisherDisplayName { get; }
        /// <summary> The marketplace plan display name. </summary>
        public string PlanDisplayName { get; }
    }
}
