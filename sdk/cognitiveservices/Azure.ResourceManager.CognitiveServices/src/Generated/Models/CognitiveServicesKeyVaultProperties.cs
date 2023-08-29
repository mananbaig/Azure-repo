// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties to configure keyVault Properties. </summary>
    public partial class CognitiveServicesKeyVaultProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesKeyVaultProperties"/>. </summary>
        public CognitiveServicesKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesKeyVaultProperties"/>. </summary>
        /// <param name="keyName"> Name of the Key from KeyVault. </param>
        /// <param name="keyVersion"> Version of the Key from KeyVault. </param>
        /// <param name="keyVaultUri"> Uri of KeyVault. </param>
        /// <param name="identityClientId"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesKeyVaultProperties(string keyName, string keyVersion, Uri keyVaultUri, Guid? identityClientId, Dictionary<string, BinaryData> rawData)
        {
            KeyName = keyName;
            KeyVersion = keyVersion;
            KeyVaultUri = keyVaultUri;
            IdentityClientId = identityClientId;
            _rawData = rawData;
        }

        /// <summary> Name of the Key from KeyVault. </summary>
        public string KeyName { get; set; }
        /// <summary> Version of the Key from KeyVault. </summary>
        public string KeyVersion { get; set; }
        /// <summary> Uri of KeyVault. </summary>
        public Uri KeyVaultUri { get; set; }
        /// <summary> Gets or sets the identity client id. </summary>
        public Guid? IdentityClientId { get; set; }
    }
}
