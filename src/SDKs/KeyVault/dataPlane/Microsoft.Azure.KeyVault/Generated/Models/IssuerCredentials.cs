// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The credentials to be used for the certificate issuer.
    /// </summary>
    public partial class IssuerCredentials
    {
        /// <summary>
        /// Initializes a new instance of the IssuerCredentials class.
        /// </summary>
        public IssuerCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssuerCredentials class.
        /// </summary>
        /// <param name="accountId">The user name/account name/account
        /// id.</param>
        /// <param name="password">The password/secret/account key.</param>
        public IssuerCredentials(string accountId = default(string), string password = default(string))
        {
            AccountId = accountId;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the user name/account name/account id.
        /// </summary>
        [JsonProperty(PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the password/secret/account key.
        /// </summary>
        [JsonProperty(PropertyName = "pwd")]
        public string Password { get; set; }

    }
}
