// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSH configuration.
    /// </summary>
    public partial class SshConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the SshConfiguration class.
        /// </summary>
        public SshConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshConfiguration class.
        /// </summary>
        /// <param name="userAccountSettings">User account settings.</param>
        /// <param name="publicIPsToAllow">Allowed public IPs.</param>
        public SshConfiguration(UserAccountSettings userAccountSettings, IList<string> publicIPsToAllow = default(IList<string>))
        {
            PublicIPsToAllow = publicIPsToAllow;
            UserAccountSettings = userAccountSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowed public IPs.
        /// </summary>
        /// <remarks>
        /// List of source IP ranges to allow SSH connection from. The default
        /// value is '*' (all source IPs are allowed). Maximum number of IP
        /// ranges that can be specified is 400.
        /// </remarks>
        [JsonProperty(PropertyName = "publicIPsToAllow")]
        public IList<string> PublicIPsToAllow { get; set; }

        /// <summary>
        /// Gets or sets user account settings.
        /// </summary>
        /// <remarks>
        /// Settings for administrator user account to be created on a node.
        /// The account can be used to establish SSH connection to the node.
        /// </remarks>
        [JsonProperty(PropertyName = "userAccountSettings")]
        public UserAccountSettings UserAccountSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserAccountSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserAccountSettings");
            }
            if (UserAccountSettings != null)
            {
                UserAccountSettings.Validate();
            }
        }
    }
}
