// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disable protection input properties. </summary>
    public partial class DisableProtectionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DisableProtectionProperties"/>. </summary>
        public DisableProtectionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DisableProtectionProperties"/>. </summary>
        /// <param name="disableProtectionReason"> Disable protection reason. It can have values NotSpecified/MigrationComplete. </param>
        /// <param name="replicationProviderContent">
        /// Replication provider specific input.
        /// Please note <see cref="DisableProtectionProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageDisableProtectionProviderSpecificContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DisableProtectionProperties(DisableProtectionReason? disableProtectionReason, DisableProtectionProviderSpecificContent replicationProviderContent, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisableProtectionReason = disableProtectionReason;
            ReplicationProviderContent = replicationProviderContent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Disable protection reason. It can have values NotSpecified/MigrationComplete. </summary>
        public DisableProtectionReason? DisableProtectionReason { get; set; }
        /// <summary>
        /// Replication provider specific input.
        /// Please note <see cref="DisableProtectionProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageDisableProtectionProviderSpecificContent"/>.
        /// </summary>
        public DisableProtectionProviderSpecificContent ReplicationProviderContent { get; set; }
    }
}
