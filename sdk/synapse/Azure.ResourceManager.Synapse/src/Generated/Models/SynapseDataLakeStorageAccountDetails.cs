// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Details of the data lake storage account associated with the workspace. </summary>
    public partial class SynapseDataLakeStorageAccountDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseDataLakeStorageAccountDetails"/>. </summary>
        public SynapseDataLakeStorageAccountDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDataLakeStorageAccountDetails"/>. </summary>
        /// <param name="accountUri"> Account URL. </param>
        /// <param name="filesystem"> Filesystem name. </param>
        /// <param name="resourceId"> ARM resource Id of this storage account. </param>
        /// <param name="createManagedPrivateEndpoint"> Create managed private endpoint to this storage account or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseDataLakeStorageAccountDetails(Uri accountUri, string filesystem, ResourceIdentifier resourceId, bool? createManagedPrivateEndpoint, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountUri = accountUri;
            Filesystem = filesystem;
            ResourceId = resourceId;
            CreateManagedPrivateEndpoint = createManagedPrivateEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Account URL. </summary>
        public Uri AccountUri { get; set; }
        /// <summary> Filesystem name. </summary>
        public string Filesystem { get; set; }
        /// <summary> ARM resource Id of this storage account. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Create managed private endpoint to this storage account or not. </summary>
        public bool? CreateManagedPrivateEndpoint { get; set; }
    }
}
