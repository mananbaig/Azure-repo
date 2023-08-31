// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ApiProperties. </summary>
    internal partial class ApiProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiProperties"/>. </summary>
        public ApiProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiProperties"/>. </summary>
        /// <param name="serverVersion"> Describes the ServerVersion of an a MongoDB account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiProperties(CosmosDBServerVersion? serverVersion, Dictionary<string, BinaryData> rawData)
        {
            ServerVersion = serverVersion;
            _rawData = rawData;
        }

        /// <summary> Describes the ServerVersion of an a MongoDB account. </summary>
        public CosmosDBServerVersion? ServerVersion { get; set; }
    }
}
