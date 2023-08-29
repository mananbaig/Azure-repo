// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListApplicationGatewayPrivateLinkResources API service call. Gets all private link resources for an application gateway. </summary>
    internal partial class ApplicationGatewayPrivateLinkResourceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayPrivateLinkResourceListResult"/>. </summary>
        internal ApplicationGatewayPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<ApplicationGatewayPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> List of private link resources of an application gateway. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayPrivateLinkResourceListResult(IReadOnlyList<ApplicationGatewayPrivateLinkResource> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of private link resources of an application gateway. </summary>
        public IReadOnlyList<ApplicationGatewayPrivateLinkResource> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
