// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Synapse nested resource, which belongs to a workspace. </summary>
    public partial class SubResource : AzureEntityResource
    {
        /// <summary> Initializes a new instance of <see cref="SubResource"/>. </summary>
        public SubResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubResource"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubResource(string id, string name, string type, string etag, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, type, etag, serializedAdditionalRawData)
        {
        }
    }
}
