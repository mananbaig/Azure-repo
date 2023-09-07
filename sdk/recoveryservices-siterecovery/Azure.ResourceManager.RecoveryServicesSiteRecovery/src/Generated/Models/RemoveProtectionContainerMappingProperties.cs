// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unpairing input properties. </summary>
    internal partial class RemoveProtectionContainerMappingProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemoveProtectionContainerMappingProperties"/>. </summary>
        public RemoveProtectionContainerMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoveProtectionContainerMappingProperties"/>. </summary>
        /// <param name="providerSpecificContent"> Provider specific input for unpairing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoveProtectionContainerMappingProperties(ReplicationProviderContainerUnmappingContent providerSpecificContent, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProviderSpecificContent = providerSpecificContent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provider specific input for unpairing. </summary>
        internal ReplicationProviderContainerUnmappingContent ProviderSpecificContent { get; set; }
        /// <summary> The class type. </summary>
        public string ProviderSpecificContentInstanceType
        {
            get => ProviderSpecificContent is null ? default : ProviderSpecificContent.InstanceType;
            set
            {
                if (ProviderSpecificContent is null)
                    ProviderSpecificContent = new ReplicationProviderContainerUnmappingContent();
                ProviderSpecificContent.InstanceType = value;
            }
        }
    }
}
