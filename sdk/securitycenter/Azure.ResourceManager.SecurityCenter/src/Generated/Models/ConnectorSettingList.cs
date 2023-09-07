// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> For a subscription, list of all cloud account connectors and their settings. </summary>
    internal partial class ConnectorSettingList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectorSettingList"/>. </summary>
        internal ConnectorSettingList()
        {
            Value = new ChangeTrackingList<SecurityCloudConnectorData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorSettingList"/>. </summary>
        /// <param name="value"> List of all the cloud account connector settings. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectorSettingList(IReadOnlyList<SecurityCloudConnectorData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of all the cloud account connector settings. </summary>
        public IReadOnlyList<SecurityCloudConnectorData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
