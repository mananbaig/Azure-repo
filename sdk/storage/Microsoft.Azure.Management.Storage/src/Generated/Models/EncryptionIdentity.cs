// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Encryption identity for the storage account.
    /// </summary>
    public partial class EncryptionIdentity
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionIdentity class.
        /// </summary>
        public EncryptionIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionIdentity class.
        /// </summary>
        /// <param name="encryptionUserAssignedIdentity">Resource identifier of
        /// the UserAssigned identity to be associated with server-side
        /// encryption on the storage account.</param>
        public EncryptionIdentity(string encryptionUserAssignedIdentity = default(string))
        {
            EncryptionUserAssignedIdentity = encryptionUserAssignedIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource identifier of the UserAssigned identity to be
        /// associated with server-side encryption on the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentity")]
        public string EncryptionUserAssignedIdentity { get; set; }

    }
}
