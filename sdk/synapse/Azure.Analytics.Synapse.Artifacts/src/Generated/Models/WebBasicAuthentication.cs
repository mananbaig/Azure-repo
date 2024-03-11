// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A WebLinkedService that uses basic authentication to communicate with an HTTP endpoint. </summary>
    public partial class WebBasicAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="WebBasicAuthentication"/>. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="username"> User name for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// The password for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/>, <paramref name="username"/> or <paramref name="password"/> is null. </exception>
        public WebBasicAuthentication(object url, object username, SecretBase password) : base(url)
        {
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(password, nameof(password));

            Username = username;
            Password = password;
            AuthenticationType = WebAuthenticationType.Basic;
        }

        /// <summary> Initializes a new instance of <see cref="WebBasicAuthentication"/>. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="username"> User name for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// The password for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        internal WebBasicAuthentication(object url, WebAuthenticationType authenticationType, object username, SecretBase password) : base(url, authenticationType)
        {
            Username = username;
            Password = password;
            AuthenticationType = authenticationType;
        }

        /// <summary> User name for Basic authentication. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// The password for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
    }
}
