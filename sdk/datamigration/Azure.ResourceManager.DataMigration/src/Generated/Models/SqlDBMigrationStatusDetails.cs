// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Detailed status of current Sql Db migration. </summary>
    public partial class SqlDBMigrationStatusDetails
    {
        /// <summary> Initializes a new instance of SqlDBMigrationStatusDetails. </summary>
        internal SqlDBMigrationStatusDetails()
        {
            SqlDataCopyErrors = new Core.ChangeTrackingList<string>();
            ListOfCopyProgressDetails = new Core.ChangeTrackingList<CopyProgressDetails>();
        }

        /// <summary> Initializes a new instance of SqlDBMigrationStatusDetails. </summary>
        /// <param name="migrationState"> Current State of Migration. </param>
        /// <param name="sqlDataCopyErrors"> Sql Data Copy errors, if any. </param>
        /// <param name="listOfCopyProgressDetails"> Details on progress of ADF copy activities. </param>
        internal SqlDBMigrationStatusDetails(string migrationState, IReadOnlyList<string> sqlDataCopyErrors, IReadOnlyList<CopyProgressDetails> listOfCopyProgressDetails)
        {
            MigrationState = migrationState;
            SqlDataCopyErrors = sqlDataCopyErrors;
            ListOfCopyProgressDetails = listOfCopyProgressDetails;
        }

        /// <summary> Current State of Migration. </summary>
        public string MigrationState { get; }
        /// <summary> Sql Data Copy errors, if any. </summary>
        public IReadOnlyList<string> SqlDataCopyErrors { get; }
        /// <summary> Details on progress of ADF copy activities. </summary>
        public IReadOnlyList<CopyProgressDetails> ListOfCopyProgressDetails { get; }
    }
}
