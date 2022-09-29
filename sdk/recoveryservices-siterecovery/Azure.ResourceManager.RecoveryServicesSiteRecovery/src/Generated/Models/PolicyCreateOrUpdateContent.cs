// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Protection Policy input. </summary>
    public partial class PolicyCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of PolicyCreateOrUpdateContent. </summary>
        public PolicyCreateOrUpdateContent()
        {
        }

        /// <summary> Policy creation properties. </summary>
        internal CreatePolicyInputProperties Properties { get; set; }
        /// <summary>
        /// The ReplicationProviderSettings.
        /// Please note <see cref="PolicyProviderSpecificInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2APolicyCreationInput"/>, <see cref="A2ACrossClusterMigrationPolicyCreationInput"/>, <see cref="HyperVReplicaPolicyInput"/>, <see cref="HyperVReplicaBluePolicyInput"/>, <see cref="HyperVReplicaAzurePolicyInput"/>, <see cref="InMagePolicyInput"/>, <see cref="InMageAzureV2PolicyInput"/>, <see cref="InMageRcmPolicyCreationInput"/>, <see cref="InMageRcmFailbackPolicyCreationInput"/> and <see cref="VMwareCbtPolicyCreationInput"/>.
        /// </summary>
        public PolicyProviderSpecificInput ProviderSpecificInput
        {
            get => Properties is null ? default : Properties.ProviderSpecificInput;
            set
            {
                if (Properties is null)
                    Properties = new CreatePolicyInputProperties();
                Properties.ProviderSpecificInput = value;
            }
        }
    }
}
