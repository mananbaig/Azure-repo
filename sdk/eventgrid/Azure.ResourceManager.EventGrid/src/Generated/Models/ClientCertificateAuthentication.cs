// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The certificate authentication properties for the client. </summary>
    public partial class ClientCertificateAuthentication
    {
        /// <summary> Initializes a new instance of ClientCertificateAuthentication. </summary>
        public ClientCertificateAuthentication()
        {
            AllowedThumbprints = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ClientCertificateAuthentication. </summary>
        /// <param name="validationScheme"> The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName. </param>
        /// <param name="allowedThumbprints"> The list of thumbprints that are allowed during client authentication. This property is required only if the validationScheme is 'ThumbprintMatch'. </param>
        internal ClientCertificateAuthentication(ClientCertificateValidationScheme? validationScheme, IList<string> allowedThumbprints)
        {
            ValidationScheme = validationScheme;
            AllowedThumbprints = allowedThumbprints;
        }

        /// <summary> The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName. </summary>
        public ClientCertificateValidationScheme? ValidationScheme { get; set; }
        /// <summary> The list of thumbprints that are allowed during client authentication. This property is required only if the validationScheme is 'ThumbprintMatch'. </summary>
        public IList<string> AllowedThumbprints { get; }
    }
}
