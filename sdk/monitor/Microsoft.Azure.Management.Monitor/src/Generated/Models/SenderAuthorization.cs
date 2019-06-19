// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// the authorization used by the user who has performed the operation that
    /// led to this event. This captures the RBAC properties of the event.
    /// These usually include the 'action', 'role' and the 'scope'
    /// </summary>
    public partial class SenderAuthorization
    {
        /// <summary>
        /// Initializes a new instance of the SenderAuthorization class.
        /// </summary>
        public SenderAuthorization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SenderAuthorization class.
        /// </summary>
        /// <param name="action">the permissible actions. For instance:
        /// microsoft.support/supporttickets/write</param>
        /// <param name="role">the role of the user. For instance: Subscription
        /// Admin</param>
        /// <param name="scope">the scope.</param>
        public SenderAuthorization(string action = default(string), string role = default(string), string scope = default(string))
        {
            Action = action;
            Role = role;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the permissible actions. For instance:
        /// microsoft.support/supporttickets/write
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the role of the user. For instance: Subscription Admin
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

    }
}
