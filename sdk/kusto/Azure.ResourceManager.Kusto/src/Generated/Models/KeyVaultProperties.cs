// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Properties of the key vault. </summary>
    public partial class KeyVaultProperties
    {
        /// <summary> Initializes a new instance of KeyVaultProperties. </summary>
        public KeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultProperties. </summary>
        /// <param name="keyName"> The name of the key vault key. </param>
        /// <param name="keyVersion"> The version of the key vault key. </param>
        /// <param name="keyVaultUri"> The Uri of the key vault. </param>
        /// <param name="userIdentity"> The user assigned identity (ARM resource id) that has access to the key. </param>
        internal KeyVaultProperties(string keyName, string keyVersion, Uri keyVaultUri, string userIdentity)
        {
            KeyName = keyName;
            KeyVersion = keyVersion;
            KeyVaultUri = keyVaultUri;
            UserIdentity = userIdentity;
        }

        /// <summary> The name of the key vault key. </summary>
        public string KeyName { get; set; }
        /// <summary> The version of the key vault key. </summary>
        public string KeyVersion { get; set; }
        /// <summary> The Uri of the key vault. </summary>
        public Uri KeyVaultUri { get; set; }
        /// <summary> The user assigned identity (ARM resource id) that has access to the key. </summary>
        public string UserIdentity { get; set; }
    }
}
