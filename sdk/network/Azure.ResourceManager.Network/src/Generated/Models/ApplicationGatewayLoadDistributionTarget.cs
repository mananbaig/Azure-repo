// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Load Distribution Target of an application gateway. </summary>
    public partial class ApplicationGatewayLoadDistributionTarget : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayLoadDistributionTarget"/>. </summary>
        public ApplicationGatewayLoadDistributionTarget()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayLoadDistributionTarget"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="weightPerServer"> Weight per server. Range between 1 and 100. </param>
        /// <param name="backendAddressPool"> Backend address pool resource of the application gateway. </param>
        internal ApplicationGatewayLoadDistributionTarget(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, int? weightPerServer, WritableSubResource backendAddressPool) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            WeightPerServer = weightPerServer;
            BackendAddressPool = backendAddressPool;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Weight per server. Range between 1 and 100. </summary>
        public int? WeightPerServer { get; set; }
        /// <summary> Backend address pool resource of the application gateway. </summary>
        internal WritableSubResource BackendAddressPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendAddressPoolId
        {
            get => BackendAddressPool is null ? default : BackendAddressPool.Id;
            set
            {
                if (BackendAddressPool is null)
                    BackendAddressPool = new WritableSubResource();
                BackendAddressPool.Id = value;
            }
        }
    }
}
