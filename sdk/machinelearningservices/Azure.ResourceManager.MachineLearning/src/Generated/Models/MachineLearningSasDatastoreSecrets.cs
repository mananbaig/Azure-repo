// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Datastore SAS secrets. </summary>
    public partial class MachineLearningSasDatastoreSecrets : MachineLearningDatastoreSecrets
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningSasDatastoreSecrets"/>. </summary>
        public MachineLearningSasDatastoreSecrets()
        {
            SecretsType = SecretsType.Sas;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSasDatastoreSecrets"/>. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="sasToken"> Storage container SAS token. </param>
        internal MachineLearningSasDatastoreSecrets(SecretsType secretsType, string sasToken) : base(secretsType)
        {
            SasToken = sasToken;
            SecretsType = secretsType;
        }

        /// <summary> Storage container SAS token. </summary>
        public string SasToken { get; set; }
    }
}
