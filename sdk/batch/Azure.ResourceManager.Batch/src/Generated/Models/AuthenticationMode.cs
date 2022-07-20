// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The authentication mode for the Batch account. </summary>
    public enum AuthenticationMode
    {
        /// <summary> The authentication mode using shared keys. </summary>
        SharedKey,
        /// <summary> The authentication mode using Azure Active Directory. </summary>
        AAD,
        /// <summary> The authentication mode using task authentication tokens. </summary>
        TaskAuthenticationToken
    }
}
