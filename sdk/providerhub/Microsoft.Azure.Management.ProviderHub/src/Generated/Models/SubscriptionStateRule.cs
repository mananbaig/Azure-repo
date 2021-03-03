// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SubscriptionStateRule
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionStateRule class.
        /// </summary>
        public SubscriptionStateRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionStateRule class.
        /// </summary>
        /// <param name="state">Possible values include: 'NotDefined',
        /// 'Enabled', 'Warned', 'PastDue', 'Disabled', 'Deleted'</param>
        public SubscriptionStateRule(string state = default(string), IList<string> allowedActions = default(IList<string>))
        {
            State = state;
            AllowedActions = allowedActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NotDefined', 'Enabled',
        /// 'Warned', 'PastDue', 'Disabled', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedActions")]
        public IList<string> AllowedActions { get; set; }

    }
}
