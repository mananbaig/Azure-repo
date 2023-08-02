// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> The billing information of the resource. </summary>
    public partial class BillingInfoSku
    {
        /// <summary> Initializes a new instance of BillingInfoSku. </summary>
        /// <param name="name">
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public BillingInfoSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of BillingInfoSku. </summary>
        /// <param name="name">
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </param>
        /// <param name="tier">
        /// Optional tier of this particular SKU. 'Standard' or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead.
        /// </param>
        /// <param name="size"> Not used. Retained for future use. </param>
        /// <param name="family"> Not used. Retained for future use. </param>
        /// <param name="capacity">
        /// Optional, integer. The unit count of the resource. 1 by default.
        ///
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </param>
        internal BillingInfoSku(string name, WebPubSubSkuTier? tier, string size, string family, int? capacity)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
        }

        /// <summary>
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Optional tier of this particular SKU. 'Standard' or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead.
        /// </summary>
        public WebPubSubSkuTier? Tier { get; set; }
        /// <summary> Not used. Retained for future use. </summary>
        public string Size { get; }
        /// <summary> Not used. Retained for future use. </summary>
        public string Family { get; }
        /// <summary>
        /// Optional, integer. The unit count of the resource. 1 by default.
        ///
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </summary>
        public int? Capacity { get; set; }
    }
}
