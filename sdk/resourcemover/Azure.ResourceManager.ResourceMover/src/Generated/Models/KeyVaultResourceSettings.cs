// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the key vault resource settings. </summary>
    public partial class KeyVaultResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="KeyVaultResourceSettings"/>. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public KeyVaultResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            Argument.AssertNotNull(targetResourceName, nameof(targetResourceName));

            ResourceType = "Microsoft.KeyVault/vaults";
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultResourceSettings(string resourceType, string targetResourceName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceType, targetResourceName, serializedAdditionalRawData)
        {
            ResourceType = resourceType ?? "Microsoft.KeyVault/vaults";
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultResourceSettings"/> for deserialization. </summary>
        internal KeyVaultResourceSettings()
        {
        }
    }
}
