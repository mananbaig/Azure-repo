// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Cross-Origin Resource Sharing (CORS) settings for the app. </summary>
    public partial class AppServiceCorsSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceCorsSettings"/>. </summary>
        public AppServiceCorsSettings()
        {
            AllowedOrigins = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceCorsSettings"/>. </summary>
        /// <param name="allowedOrigins">
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        /// calls (for example: http://example.com:12345). Use "*" to allow all.
        /// </param>
        /// <param name="isCredentialsSupported">
        /// Gets or sets whether CORS requests with credentials are allowed. See
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
        /// for more details.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceCorsSettings(IList<string> allowedOrigins, bool? isCredentialsSupported, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedOrigins = allowedOrigins;
            IsCredentialsSupported = isCredentialsSupported;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        /// calls (for example: http://example.com:12345). Use "*" to allow all.
        /// </summary>
        public IList<string> AllowedOrigins { get; }
        /// <summary>
        /// Gets or sets whether CORS requests with credentials are allowed. See
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials
        /// for more details.
        /// </summary>
        public bool? IsCredentialsSupported { get; set; }
    }
}
