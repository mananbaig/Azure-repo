﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// The identifier of a Provider from Tenant.
    /// </summary>
    public class TenantProviderIdentifier : ResourceIdentifier
    {
        internal TenantProviderIdentifier(string provider)
        {
            Provider = provider;
        }

        internal TenantProviderIdentifier(TenantProviderIdentifier parent, string providerNamespace, ResourceType resourceType, string resourceName)
            : base(new ResourceType(providerNamespace, resourceType), resourceName)
        {
            Parent = parent;
            IsChild = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantProviderIdentifier"/> class 
        /// for resources in the sanem namespace as their parent resource.
        /// </summary>
        /// <param name="parent"> The resource id of the parent resource. </param>
        /// <param name="childResourceType"> The simple type of this resource, for example 'subnets'. </param>
        /// <param name="childResourceName"> The name of this resource. </param>
        /// <returns> The resource identifier for the given child resource. </returns>
        internal TenantProviderIdentifier(TenantProviderIdentifier parent, string childResourceType, string childResourceName)
            : base(childResourceType, childResourceName)
        {
            Parent = parent;
            IsChild = true;
        }

        /// <summary>
        /// Gets the Provider for the current ProviderIdentifier.
        /// </summary>
        public string Provider { get; }

        /// <summary>
        /// Convert a string resource identifier into a TenantResourceIdentifier.
        /// </summary>
        /// <param name="other"> The string representation of a subscription resource identifier. </param>
        public static implicit operator TenantProviderIdentifier(string other)
        {
            if (other is null)
                return null;
            TenantProviderIdentifier id = ResourceIdentifier.Create(other) as TenantProviderIdentifier;
            if (other is null)
                throw new ArgumentException("Not a valid tenant provider resource", nameof(other));
            return id;
        }
    }
}
