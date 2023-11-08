// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines options to control Cross-Origin Resource Sharing (CORS) for an index. </summary>
    public partial class CorsOptions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CorsOptions"/>. </summary>
        /// <param name="allowedOrigins"> The list of origins from which JavaScript code will be granted access to your index. Can contain a list of hosts of the form {protocol}://{fully-qualified-domain-name}[:{port#}], or a single `*` to allow all origins (not recommended). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedOrigins"/> is null. </exception>
        public CorsOptions(IEnumerable<string> allowedOrigins)
        {
            Argument.AssertNotNull(allowedOrigins, nameof(allowedOrigins));

            AllowedOrigins = allowedOrigins.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CorsOptions"/>. </summary>
        /// <param name="allowedOrigins"> The list of origins from which JavaScript code will be granted access to your index. Can contain a list of hosts of the form {protocol}://{fully-qualified-domain-name}[:{port#}], or a single `*` to allow all origins (not recommended). </param>
        /// <param name="maxAgeInSeconds"> The duration for which browsers should cache CORS preflight responses. Defaults to 5 minutes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CorsOptions(IList<string> allowedOrigins, long? maxAgeInSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedOrigins = allowedOrigins;
            MaxAgeInSeconds = maxAgeInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CorsOptions"/> for deserialization. </summary>
        internal CorsOptions()
        {
        }
        /// <summary> The duration for which browsers should cache CORS preflight responses. Defaults to 5 minutes. </summary>
        public long? MaxAgeInSeconds { get; set; }
    }
}
