// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Open authentication access policy defined by user. </summary>
    public partial class OpenAuthenticationAccessPolicy
    {
        /// <summary> Initializes a new instance of OpenAuthenticationAccessPolicy. </summary>
        public OpenAuthenticationAccessPolicy()
        {
            Claims = new ChangeTrackingList<OpenAuthenticationPolicyClaim>();
        }

        /// <summary> Initializes a new instance of OpenAuthenticationAccessPolicy. </summary>
        /// <param name="providerType"> Type of provider for OAuth. </param>
        /// <param name="claims"> The access policy claims. </param>
        internal OpenAuthenticationAccessPolicy(OpenAuthenticationProviderType? providerType, IList<OpenAuthenticationPolicyClaim> claims)
        {
            ProviderType = providerType;
            Claims = claims;
        }

        /// <summary> Type of provider for OAuth. </summary>
        public OpenAuthenticationProviderType? ProviderType { get; set; }
        /// <summary> The access policy claims. </summary>
        public IList<OpenAuthenticationPolicyClaim> Claims { get; }
    }
}
