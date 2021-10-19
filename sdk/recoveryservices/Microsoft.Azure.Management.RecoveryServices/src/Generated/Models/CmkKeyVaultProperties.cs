// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of the Key Vault which hosts CMK
    /// </summary>
    public partial class CmkKeyVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the CmkKeyVaultProperties class.
        /// </summary>
        public CmkKeyVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CmkKeyVaultProperties class.
        /// </summary>
        /// <param name="keyUri">The key uri of the Customer Managed
        /// Key</param>
        public CmkKeyVaultProperties(string keyUri = default(string))
        {
            KeyUri = keyUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the key uri of the Customer Managed Key
        /// </summary>
        [JsonProperty(PropertyName = "keyUri")]
        public string KeyUri { get; set; }

    }
}
