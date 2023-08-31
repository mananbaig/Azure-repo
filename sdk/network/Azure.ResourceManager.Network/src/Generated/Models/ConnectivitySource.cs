// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the source of the connection. </summary>
    public partial class ConnectivitySource
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivitySource"/>. </summary>
        /// <param name="resourceId"> The ID of the resource from which a connectivity check will be initiated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public ConnectivitySource(ResourceIdentifier resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivitySource"/>. </summary>
        /// <param name="resourceId"> The ID of the resource from which a connectivity check will be initiated. </param>
        /// <param name="port"> The source port from which a connectivity check will be performed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivitySource(ResourceIdentifier resourceId, int? port, Dictionary<string, BinaryData> rawData)
        {
            ResourceId = resourceId;
            Port = port;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivitySource"/> for deserialization. </summary>
        internal ConnectivitySource()
        {
        }

        /// <summary> The ID of the resource from which a connectivity check will be initiated. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The source port from which a connectivity check will be performed. </summary>
        public int? Port { get; set; }
    }
}
