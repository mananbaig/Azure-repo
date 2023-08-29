// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MixedReality.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MixedReality
{
    /// <summary>
    /// A class representing the RemoteRenderingAccount data model.
    /// RemoteRenderingAccount Response.
    /// </summary>
    public partial class RemoteRenderingAccountData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemoteRenderingAccountData"/>. </summary>
        /// <param name="location"> The location. </param>
        public RemoteRenderingAccountData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoteRenderingAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity associated with this account. Current supported identity types: SystemAssigned. </param>
        /// <param name="plan"> The plan associated with this account. Current supported identity types: SystemAssigned. </param>
        /// <param name="sku"> The sku associated with this account. </param>
        /// <param name="kind"> The kind of account, if supported. </param>
        /// <param name="storageAccountName"> The name of the storage account associated with this accountId. </param>
        /// <param name="accountId"> unique id of certain account. </param>
        /// <param name="accountDomain"> Correspond domain name of certain Spatial Anchors Account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoteRenderingAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ManagedServiceIdentity plan, MixedRealitySku sku, MixedRealitySku kind, string storageAccountName, Guid? accountId, string accountDomain, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Plan = plan;
            Sku = sku;
            Kind = kind;
            StorageAccountName = storageAccountName;
            AccountId = accountId;
            AccountDomain = accountDomain;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteRenderingAccountData"/> for deserialization. </summary>
        internal RemoteRenderingAccountData()
        {
        }

        /// <summary> The identity associated with this account. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The plan associated with this account. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Plan { get; set; }
        /// <summary> The sku associated with this account. </summary>
        public MixedRealitySku Sku { get; set; }
        /// <summary> The kind of account, if supported. </summary>
        public MixedRealitySku Kind { get; set; }
        /// <summary> The name of the storage account associated with this accountId. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> unique id of certain account. </summary>
        public Guid? AccountId { get; }
        /// <summary> Correspond domain name of certain Spatial Anchors Account. </summary>
        public string AccountDomain { get; }
    }
}
