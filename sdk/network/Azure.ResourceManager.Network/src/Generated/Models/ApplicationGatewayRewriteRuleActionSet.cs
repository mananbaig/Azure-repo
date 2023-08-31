// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Set of actions in the Rewrite Rule in Application Gateway. </summary>
    public partial class ApplicationGatewayRewriteRuleActionSet
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRewriteRuleActionSet"/>. </summary>
        public ApplicationGatewayRewriteRuleActionSet()
        {
            RequestHeaderConfigurations = new ChangeTrackingList<ApplicationGatewayHeaderConfiguration>();
            ResponseHeaderConfigurations = new ChangeTrackingList<ApplicationGatewayHeaderConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRewriteRuleActionSet"/>. </summary>
        /// <param name="requestHeaderConfigurations"> Request Header Actions in the Action Set. </param>
        /// <param name="responseHeaderConfigurations"> Response Header Actions in the Action Set. </param>
        /// <param name="urlConfiguration"> Url Configuration Action in the Action Set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayRewriteRuleActionSet(IList<ApplicationGatewayHeaderConfiguration> requestHeaderConfigurations, IList<ApplicationGatewayHeaderConfiguration> responseHeaderConfigurations, ApplicationGatewayUrlConfiguration urlConfiguration, Dictionary<string, BinaryData> rawData)
        {
            RequestHeaderConfigurations = requestHeaderConfigurations;
            ResponseHeaderConfigurations = responseHeaderConfigurations;
            UrlConfiguration = urlConfiguration;
            _rawData = rawData;
        }

        /// <summary> Request Header Actions in the Action Set. </summary>
        public IList<ApplicationGatewayHeaderConfiguration> RequestHeaderConfigurations { get; }
        /// <summary> Response Header Actions in the Action Set. </summary>
        public IList<ApplicationGatewayHeaderConfiguration> ResponseHeaderConfigurations { get; }
        /// <summary> Url Configuration Action in the Action Set. </summary>
        public ApplicationGatewayUrlConfiguration UrlConfiguration { get; set; }
    }
}
