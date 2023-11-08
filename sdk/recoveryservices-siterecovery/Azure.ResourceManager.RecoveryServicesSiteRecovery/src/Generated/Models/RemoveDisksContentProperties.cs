// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Remove Disk input properties. </summary>
    internal partial class RemoveDisksContentProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemoveDisksContentProperties"/>. </summary>
        public RemoveDisksContentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoveDisksContentProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
        /// Please note <see cref="RemoveDisksProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ARemoveDisksContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoveDisksContentProperties(RemoveDisksProviderSpecificContent providerSpecificDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProviderSpecificDetails = providerSpecificDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
        /// Please note <see cref="RemoveDisksProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ARemoveDisksContent"/>.
        /// </summary>
        public RemoveDisksProviderSpecificContent ProviderSpecificDetails { get; set; }
    }
}
