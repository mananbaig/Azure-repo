// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a container registry. </summary>
    public partial class ContainerRegistryPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryPatch"/>. </summary>
        public ContainerRegistryPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryPatch"/>. </summary>
        /// <param name="identity"> The identity of the container registry. </param>
        /// <param name="tags"> The tags for the container registry. </param>
        /// <param name="sku"> The SKU of the container registry. </param>
        /// <param name="isAdminUserEnabled"> The value that indicates whether the admin user is enabled. </param>
        /// <param name="networkRuleSet"> The network rule set for a container registry. </param>
        /// <param name="policies"> The policies for a container registry. </param>
        /// <param name="encryption"> The encryption settings of container registry. </param>
        /// <param name="isDataEndpointEnabled"> Enable a single data endpoint per region for serving data. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for the container registry. </param>
        /// <param name="networkRuleBypassOptions"> Whether to allow trusted Azure services to access a network restricted registry. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryPatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, ContainerRegistrySku sku, bool? isAdminUserEnabled, ContainerRegistryNetworkRuleSet networkRuleSet, ContainerRegistryPolicies policies, ContainerRegistryEncryption encryption, bool? isDataEndpointEnabled, ContainerRegistryPublicNetworkAccess? publicNetworkAccess, ContainerRegistryNetworkRuleBypassOption? networkRuleBypassOptions, Dictionary<string, BinaryData> rawData)
        {
            Identity = identity;
            Tags = tags;
            Sku = sku;
            IsAdminUserEnabled = isAdminUserEnabled;
            NetworkRuleSet = networkRuleSet;
            Policies = policies;
            Encryption = encryption;
            IsDataEndpointEnabled = isDataEndpointEnabled;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkRuleBypassOptions = networkRuleBypassOptions;
            _rawData = rawData;
        }

        /// <summary> The identity of the container registry. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The tags for the container registry. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The SKU of the container registry. </summary>
        public ContainerRegistrySku Sku { get; set; }
        /// <summary> The value that indicates whether the admin user is enabled. </summary>
        public bool? IsAdminUserEnabled { get; set; }
        /// <summary> The network rule set for a container registry. </summary>
        public ContainerRegistryNetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> The policies for a container registry. </summary>
        public ContainerRegistryPolicies Policies { get; set; }
        /// <summary> The encryption settings of container registry. </summary>
        public ContainerRegistryEncryption Encryption { get; set; }
        /// <summary> Enable a single data endpoint per region for serving data. </summary>
        public bool? IsDataEndpointEnabled { get; set; }
        /// <summary> Whether or not public network access is allowed for the container registry. </summary>
        public ContainerRegistryPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Whether to allow trusted Azure services to access a network restricted registry. </summary>
        public ContainerRegistryNetworkRuleBypassOption? NetworkRuleBypassOptions { get; set; }
    }
}
