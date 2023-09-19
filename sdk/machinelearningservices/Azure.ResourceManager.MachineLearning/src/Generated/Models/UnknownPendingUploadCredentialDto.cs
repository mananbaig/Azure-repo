// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownPendingUploadCredentialDto. </summary>
    internal partial class UnknownPendingUploadCredentialDto : PendingUploadCredentialDto
    {
        /// <summary> Initializes a new instance of UnknownPendingUploadCredentialDto. </summary>
        /// <param name="credentialType"> [Required] Credential type used to authentication with storage. </param>
        internal UnknownPendingUploadCredentialDto(PendingUploadCredentialType credentialType) : base(credentialType)
        {
            CredentialType = credentialType;
        }
    }
}
