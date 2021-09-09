// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The SignedIdentifier. </summary>
    public partial class SignedIdentifier : WritableSubResource
    {
        /// <summary> Initializes a new instance of SignedIdentifier. </summary>
        public SignedIdentifier()
        {
        }

        /// <summary> Initializes a new instance of SignedIdentifier. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="accessPolicy"> Access policy. </param>
        internal SignedIdentifier(string id, AccessPolicy accessPolicy) : base(id)
        {
            AccessPolicy = accessPolicy;
        }

        /// <summary> Access policy. </summary>
        public AccessPolicy AccessPolicy { get; set; }
    }
}
