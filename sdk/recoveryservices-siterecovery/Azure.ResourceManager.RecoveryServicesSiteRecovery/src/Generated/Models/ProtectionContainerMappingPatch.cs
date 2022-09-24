// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Container pairing update input. </summary>
    public partial class ProtectionContainerMappingPatch
    {
        /// <summary> Initializes a new instance of ProtectionContainerMappingPatch. </summary>
        public ProtectionContainerMappingPatch()
        {
        }

        /// <summary> Update protection container mapping input properties. </summary>
        internal UpdateProtectionContainerMappingInputProperties Properties { get; set; }
        /// <summary>
        /// Provider specific input for updating protection container mapping.
        /// Please note <see cref="ReplicationProviderSpecificUpdateContainerMappingInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AUpdateContainerMappingInput"/> and <see cref="InMageRcmUpdateContainerMappingInput"/>.
        /// </summary>
        public ReplicationProviderSpecificUpdateContainerMappingInput ProviderSpecificInput
        {
            get => Properties is null ? default : Properties.ProviderSpecificInput;
            set
            {
                if (Properties is null)
                    Properties = new UpdateProtectionContainerMappingInputProperties();
                Properties.ProviderSpecificInput = value;
            }
        }
    }
}
