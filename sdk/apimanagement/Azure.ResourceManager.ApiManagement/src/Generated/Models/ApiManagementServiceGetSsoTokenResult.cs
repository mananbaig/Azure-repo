// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The response of the GetSsoToken operation. </summary>
    public partial class ApiManagementServiceGetSsoTokenResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceGetSsoTokenResult"/>. </summary>
        internal ApiManagementServiceGetSsoTokenResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceGetSsoTokenResult"/>. </summary>
        /// <param name="redirectUri"> Redirect URL to the Publisher Portal containing the SSO token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementServiceGetSsoTokenResult(Uri redirectUri, Dictionary<string, BinaryData> rawData)
        {
            RedirectUri = redirectUri;
            _rawData = rawData;
        }

        /// <summary> Redirect URL to the Publisher Portal containing the SSO token. </summary>
        public Uri RedirectUri { get; }
    }
}
