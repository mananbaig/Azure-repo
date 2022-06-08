// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> AzureStorageInfo dictionary resource. </summary>
    public partial class AzureStoragePropertyDictionaryResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="AzureStoragePropertyDictionaryResource"/>. </summary>
        public AzureStoragePropertyDictionaryResource()
        {
            Properties = new ChangeTrackingDictionary<string, AzureStorageInfoValue>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureStoragePropertyDictionaryResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="properties"> Azure storage accounts. </param>
        internal AzureStoragePropertyDictionaryResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, IDictionary<string, AzureStorageInfoValue> properties) : base(id, name, resourceType, systemData, kind)
        {
            Properties = properties;
        }

        /// <summary> Azure storage accounts. </summary>
        public IDictionary<string, AzureStorageInfoValue> Properties { get; }
    }
}
