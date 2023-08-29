// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// An action for the delivery rule.
    /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UriRedirectAction"/>, <see cref="UriRewriteAction"/> and <see cref="UriSigningAction"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownDeliveryRuleAction))]
    public abstract partial class DeliveryRuleAction
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleAction"/>. </summary>
        protected DeliveryRuleAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryRuleAction(DeliveryRuleActionType name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The name of the action for the delivery rule. </summary>
        internal DeliveryRuleActionType Name { get; set; }
    }
}
