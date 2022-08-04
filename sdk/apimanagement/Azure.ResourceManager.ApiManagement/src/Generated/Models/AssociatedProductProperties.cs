// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Product profile. </summary>
    public partial class AssociatedProductProperties : ProductEntityBaseProperties
    {
        /// <summary> Initializes a new instance of AssociatedProductProperties. </summary>
        /// <param name="name"> Product name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal AssociatedProductProperties(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of AssociatedProductProperties. </summary>
        /// <param name="description"> Product description. May include HTML formatting tags. </param>
        /// <param name="terms"> Product terms of use. Developers trying to subscribe to the product will be presented and required to accept these terms before they can complete the subscription process. </param>
        /// <param name="isSubscriptionRequired"> Whether a product subscription is required for accessing APIs included in this product. If true, the product is referred to as &quot;protected&quot; and a valid subscription key is required for a request to an API included in the product to succeed. If false, the product is referred to as &quot;open&quot; and requests to an API included in the product can be made without a subscription key. If property is omitted when creating a new product it&apos;s value is assumed to be true. </param>
        /// <param name="isApprovalRequired"> whether subscription approval is required. If false, new subscriptions will be approved automatically enabling developers to call the product’s APIs immediately after subscribing. If true, administrators must manually approve the subscription before the developer can any of the product’s APIs. Can be present only if subscriptionRequired property is present and has a value of false. </param>
        /// <param name="subscriptionsLimit"> Whether the number of subscriptions a user can have to this product at the same time. Set to null or omit to allow unlimited per user subscriptions. Can be present only if subscriptionRequired property is present and has a value of false. </param>
        /// <param name="state"> whether product is published or not. Published products are discoverable by users of developer portal. Non published products are visible only to administrators. Default state of Product is notPublished. </param>
        /// <param name="id"> Identifier of the product in the form of /products/{productId}. </param>
        /// <param name="name"> Product name. </param>
        internal AssociatedProductProperties(string description, string terms, bool? isSubscriptionRequired, bool? isApprovalRequired, int? subscriptionsLimit, ApiManagementProductState? state, string id, string name) : base(description, terms, isSubscriptionRequired, isApprovalRequired, subscriptionsLimit, state)
        {
            Id = id;
            Name = name;
        }

        /// <summary> Identifier of the product in the form of /products/{productId}. </summary>
        public string Id { get; }
        /// <summary> Product name. </summary>
        public string Name { get; }
    }
}
