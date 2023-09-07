// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The UnknownTimeSeriesDatabaseConnectionProperties. </summary>
    internal partial class UnknownTimeSeriesDatabaseConnectionProperties : TimeSeriesDatabaseConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTimeSeriesDatabaseConnectionProperties"/>. </summary>
        /// <param name="connectionType"> The type of time series connection resource. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="identity"> Managed identity properties for the time series database connection resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTimeSeriesDatabaseConnectionProperties(ConnectionType connectionType, TimeSeriesDatabaseConnectionState? provisioningState, DigitalTwinsManagedIdentityReference identity, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(connectionType, provisioningState, identity, serializedAdditionalRawData)
        {
            ConnectionType = connectionType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTimeSeriesDatabaseConnectionProperties"/> for deserialization. </summary>
        internal UnknownTimeSeriesDatabaseConnectionProperties()
        {
        }
    }
}
