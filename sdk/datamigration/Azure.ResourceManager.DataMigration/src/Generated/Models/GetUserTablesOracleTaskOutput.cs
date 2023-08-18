// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that gets the list of tables contained within a provided list of Oracle schemas. </summary>
    public partial class GetUserTablesOracleTaskOutput
    {
        /// <summary> Initializes a new instance of GetUserTablesOracleTaskOutput. </summary>
        internal GetUserTablesOracleTaskOutput()
        {
            Tables = new Core.ChangeTrackingList<DatabaseTable>();
            ValidationErrors = new Core.ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of GetUserTablesOracleTaskOutput. </summary>
        /// <param name="schemaName"> The schema this result is for. </param>
        /// <param name="tables"> List of valid tables found for this schema. </param>
        /// <param name="validationErrors"> Validation errors associated with the task. </param>
        internal GetUserTablesOracleTaskOutput(string schemaName, IReadOnlyList<DatabaseTable> tables, IReadOnlyList<ReportableException> validationErrors)
        {
            SchemaName = schemaName;
            Tables = tables;
            ValidationErrors = validationErrors;
        }

        /// <summary> The schema this result is for. </summary>
        public string SchemaName { get; }
        /// <summary> List of valid tables found for this schema. </summary>
        public IReadOnlyList<DatabaseTable> Tables { get; }
        /// <summary> Validation errors associated with the task. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
