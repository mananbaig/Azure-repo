// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the RequestBody condition for the delivery rule. </summary>
    public partial class DeliveryRuleRequestBodyCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestBodyCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleRequestBodyCondition(RequestBodyMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.RequestBody;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestBodyCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleRequestBodyCondition(MatchVariable name, IDictionary<string, BinaryData> serializedAdditionalRawData, RequestBodyMatchCondition properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestBodyCondition"/> for deserialization. </summary>
        internal DeliveryRuleRequestBodyCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public RequestBodyMatchCondition Properties { get; set; }
    }
}
