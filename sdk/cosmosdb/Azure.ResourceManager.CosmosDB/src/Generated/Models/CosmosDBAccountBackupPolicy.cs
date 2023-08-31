// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary>
    /// The object representing the policy for taking backups on an account.
    /// Please note <see cref="CosmosDBAccountBackupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContinuousModeBackupPolicy"/> and <see cref="PeriodicModeBackupPolicy"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownBackupPolicy))]
    public abstract partial class CosmosDBAccountBackupPolicy
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountBackupPolicy"/>. </summary>
        protected CosmosDBAccountBackupPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountBackupPolicy"/>. </summary>
        /// <param name="backupPolicyType"> Describes the mode of backups. </param>
        /// <param name="migrationState"> The object representing the state of the migration between the backup policies. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBAccountBackupPolicy(BackupPolicyType backupPolicyType, BackupPolicyMigrationState migrationState, Dictionary<string, BinaryData> rawData)
        {
            BackupPolicyType = backupPolicyType;
            MigrationState = migrationState;
            _rawData = rawData;
        }

        /// <summary> Describes the mode of backups. </summary>
        internal BackupPolicyType BackupPolicyType { get; set; }
        /// <summary> The object representing the state of the migration between the backup policies. </summary>
        public BackupPolicyMigrationState MigrationState { get; set; }
    }
}
