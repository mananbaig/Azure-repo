// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about SSH certificate public key and the path on
    /// the Linux VM where the public key is placed.
    /// </summary>
    public partial class SshPublicKey
    {
        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        public SshPublicKey() { }

        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        /// <param name="path">Specifies the full path on the created VM where
        /// SSH public key is stored. If the file already exists, the specified
        /// key is appended to the file.</param>
        /// <param name="keyData">Certificate public key used to authenticate
        /// to the VM through SSH. The certificate must be in Pem format with
        /// or without headers.</param>
        public SshPublicKey(string path = default(string), string keyData = default(string))
        {
            Path = path;
            KeyData = keyData;
        }

        /// <summary>
        /// Gets or sets specifies the full path on the created VM where SSH
        /// public key is stored. If the file already exists, the specified key
        /// is appended to the file.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets certificate public key used to authenticate to the VM
        /// through SSH. The certificate must be in Pem format with or without
        /// headers.
        /// </summary>
        [JsonProperty(PropertyName = "keyData")]
        public string KeyData { get; set; }

    }
}

