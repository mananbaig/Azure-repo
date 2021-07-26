// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Resource provider information. </summary>
    public partial class ProviderData : SubResource
    {
        /// <summary> Initializes a new instance of Provider. </summary>
        internal ProviderData()
        {
            ResourceTypes = new ChangeTrackingList<ProviderResourceType>();
        }

        /// <summary> Initializes a new instance of Provider. </summary>
        /// <param name="id"> The provider ID. </param>
        /// <param name="namespace"> The namespace of the resource provider. </param>
        /// <param name="registrationState"> The registration state of the resource provider. </param>
        /// <param name="registrationPolicy"> The registration policy of the resource provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        internal ProviderData(string id, string @namespace, string registrationState, string registrationPolicy, IReadOnlyList<ProviderResourceType> resourceTypes)
            : base(id)
        {
            Namespace = @namespace;
            RegistrationState = registrationState;
            RegistrationPolicy = registrationPolicy;
            ResourceTypes = resourceTypes;
        }

        /// <summary> The namespace of the resource provider. </summary>
        public string Namespace { get; }
        /// <summary> The registration state of the resource provider. </summary>
        public string RegistrationState { get; }
        /// <summary> The registration policy of the resource provider. </summary>
        public string RegistrationPolicy { get; }
        /// <summary> The collection of provider resource types. </summary>
        public IReadOnlyList<ProviderResourceType> ResourceTypes { get; }
    }
}
