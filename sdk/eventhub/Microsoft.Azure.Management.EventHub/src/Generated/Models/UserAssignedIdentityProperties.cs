// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserAssignedIdentityProperties
    {
        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentityProperties
        /// class.
        /// </summary>
        public UserAssignedIdentityProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentityProperties
        /// class.
        /// </summary>
        /// <param name="userAssignedIdentity">ARM ID of user Identity selected
        /// for encryption</param>
        public UserAssignedIdentityProperties(string userAssignedIdentity = default(string))
        {
            UserAssignedIdentity = userAssignedIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM ID of user Identity selected for encryption
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentity")]
        public string UserAssignedIdentity { get; set; }

    }
}
