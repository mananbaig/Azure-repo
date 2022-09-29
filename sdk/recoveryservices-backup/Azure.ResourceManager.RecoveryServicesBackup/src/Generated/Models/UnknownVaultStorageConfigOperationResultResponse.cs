// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownVaultStorageConfigOperationResultResponse. </summary>
    internal partial class UnknownVaultStorageConfigOperationResultResponse : VaultStorageConfigOperationResultResponse
    {
        /// <summary> Initializes a new instance of UnknownVaultStorageConfigOperationResultResponse. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal UnknownVaultStorageConfigOperationResultResponse(string objectType) : base(objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
