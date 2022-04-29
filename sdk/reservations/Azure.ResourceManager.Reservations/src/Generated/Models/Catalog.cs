// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The Catalog. </summary>
    public partial class Catalog
    {
        /// <summary> Initializes a new instance of Catalog. </summary>
        internal Catalog()
        {
            BillingPlans = new ChangeTrackingDictionary<string, IList<ReservationBillingPlan>>();
            Terms = new ChangeTrackingList<ReservationTerm>();
            Locations = new ChangeTrackingList<string>();
            SkuProperties = new ChangeTrackingList<SkuProperty>();
            Restrictions = new ChangeTrackingList<SkuRestriction>();
            Capabilities = new ChangeTrackingList<SkuCapability>();
        }

        /// <summary> Initializes a new instance of Catalog. </summary>
        /// <param name="resourceType"> The type of resource the SKU applies to. </param>
        /// <param name="name"> The name of SKU. </param>
        /// <param name="billingPlans"> The billing plan options available for this SKU. </param>
        /// <param name="terms"> Available reservation terms for this resource. </param>
        /// <param name="locations"></param>
        /// <param name="skuProperties"></param>
        /// <param name="msrp"> Pricing information about the SKU. </param>
        /// <param name="restrictions"></param>
        /// <param name="tier"> The tier of this SKU. </param>
        /// <param name="size"> The size of this SKU. </param>
        /// <param name="capabilities"></param>
        internal Catalog(string resourceType, string name, IReadOnlyDictionary<string, IList<ReservationBillingPlan>> billingPlans, IReadOnlyList<ReservationTerm> terms, IReadOnlyList<string> locations, IReadOnlyList<SkuProperty> skuProperties, CatalogMsrp msrp, IReadOnlyList<SkuRestriction> restrictions, string tier, string size, IReadOnlyList<SkuCapability> capabilities)
        {
            ResourceType = resourceType;
            Name = name;
            BillingPlans = billingPlans;
            Terms = terms;
            Locations = locations;
            SkuProperties = skuProperties;
            Msrp = msrp;
            Restrictions = restrictions;
            Tier = tier;
            Size = size;
            Capabilities = capabilities;
        }

        /// <summary> The type of resource the SKU applies to. </summary>
        public string ResourceType { get; }
        /// <summary> The name of SKU. </summary>
        public string Name { get; }
        /// <summary> The billing plan options available for this SKU. </summary>
        public IReadOnlyDictionary<string, IList<ReservationBillingPlan>> BillingPlans { get; }
        /// <summary> Available reservation terms for this resource. </summary>
        public IReadOnlyList<ReservationTerm> Terms { get; }
        /// <summary> Gets the locations. </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> Gets the sku properties. </summary>
        public IReadOnlyList<SkuProperty> SkuProperties { get; }
        /// <summary> Pricing information about the SKU. </summary>
        internal CatalogMsrp Msrp { get; }
        /// <summary> Amount in pricing currency. Tax not included. </summary>
        public Price MsrpP1Y
        {
            get => Msrp.P1Y;
        }

        /// <summary> Gets the restrictions. </summary>
        public IReadOnlyList<SkuRestriction> Restrictions { get; }
        /// <summary> The tier of this SKU. </summary>
        public string Tier { get; }
        /// <summary> The size of this SKU. </summary>
        public string Size { get; }
        /// <summary> Gets the capabilities. </summary>
        public IReadOnlyList<SkuCapability> Capabilities { get; }
    }
}
