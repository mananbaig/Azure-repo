// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The settings for the CORS configuration of the service instance. </summary>
    public partial class HealthcareApisServiceCorsConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceCorsConfiguration"/>. </summary>
        public HealthcareApisServiceCorsConfiguration()
        {
            Origins = new ChangeTrackingList<string>();
            Headers = new ChangeTrackingList<string>();
            Methods = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceCorsConfiguration"/>. </summary>
        /// <param name="origins"> The origins to be allowed via CORS. </param>
        /// <param name="headers"> The headers to be allowed via CORS. </param>
        /// <param name="methods"> The methods to be allowed via CORS. </param>
        /// <param name="maxAge"> The max age to be allowed via CORS. </param>
        /// <param name="allowCredentials"> If credentials are allowed via CORS. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareApisServiceCorsConfiguration(IList<string> origins, IList<string> headers, IList<string> methods, int? maxAge, bool? allowCredentials, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Origins = origins;
            Headers = headers;
            Methods = methods;
            MaxAge = maxAge;
            AllowCredentials = allowCredentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The origins to be allowed via CORS. </summary>
        public IList<string> Origins { get; }
        /// <summary> The headers to be allowed via CORS. </summary>
        public IList<string> Headers { get; }
        /// <summary> The methods to be allowed via CORS. </summary>
        public IList<string> Methods { get; }
        /// <summary> The max age to be allowed via CORS. </summary>
        public int? MaxAge { get; set; }
        /// <summary> If credentials are allowed via CORS. </summary>
        public bool? AllowCredentials { get; set; }
    }
}
