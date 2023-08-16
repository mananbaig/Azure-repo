// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiCenter;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiCenter.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmApiCenterModelFactory
    {
        /// <summary> Initializes a new instance of ServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the service. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="ApiCenter.ServiceData"/> instance for mocking. </returns>
        public static ServiceData ServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, ProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ServiceData(id, name, resourceType, systemData, tags, location, identity, provisioningState);
        }
    }
}
