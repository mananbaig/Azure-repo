// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Qumulo.Models
{
    /// <summary> The updatable properties of the FileSystemResource. </summary>
    public partial class FileSystemResourceUpdateProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FileSystemResourceUpdateProperties"/>. </summary>
        public FileSystemResourceUpdateProperties()
        {
            PrivateIPs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FileSystemResourceUpdateProperties"/>. </summary>
        /// <param name="marketplaceDetails"> Marketplace details. </param>
        /// <param name="userDetails"> User Details. </param>
        /// <param name="delegatedSubnetId"> Delegated subnet id for Vnet injection. </param>
        /// <param name="clusterLoginUri"> File system Id of the resource. </param>
        /// <param name="privateIPs"> Private IPs of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileSystemResourceUpdateProperties(MarketplaceDetails marketplaceDetails, QumuloUserDetails userDetails, ResourceIdentifier delegatedSubnetId, Uri clusterLoginUri, IList<string> privateIPs, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MarketplaceDetails = marketplaceDetails;
            UserDetails = userDetails;
            DelegatedSubnetId = delegatedSubnetId;
            ClusterLoginUri = clusterLoginUri;
            PrivateIPs = privateIPs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Marketplace details. </summary>
        public MarketplaceDetails MarketplaceDetails { get; set; }
        /// <summary> User Details. </summary>
        internal QumuloUserDetails UserDetails { get; set; }
        /// <summary> User Email. </summary>
        public string UserDetailsEmail
        {
            get => UserDetails is null ? default : UserDetails.Email;
            set
            {
                if (UserDetails is null)
                    UserDetails = new QumuloUserDetails();
                UserDetails.Email = value;
            }
        }

        /// <summary> Delegated subnet id for Vnet injection. </summary>
        public ResourceIdentifier DelegatedSubnetId { get; set; }
        /// <summary> File system Id of the resource. </summary>
        public Uri ClusterLoginUri { get; set; }
        /// <summary> Private IPs of the resource. </summary>
        public IList<string> PrivateIPs { get; }
    }
}
