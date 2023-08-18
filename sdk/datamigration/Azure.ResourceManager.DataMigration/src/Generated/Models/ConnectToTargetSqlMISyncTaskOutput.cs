// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure SQL Database Managed Instance. </summary>
    public partial class ConnectToTargetSqlMISyncTaskOutput
    {
        /// <summary> Initializes a new instance of ConnectToTargetSqlMISyncTaskOutput. </summary>
        internal ConnectToTargetSqlMISyncTaskOutput()
        {
            ValidationErrors = new Core.ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of ConnectToTargetSqlMISyncTaskOutput. </summary>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        internal ConnectToTargetSqlMISyncTaskOutput(string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<ReportableException> validationErrors)
        {
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ValidationErrors = validationErrors;
        }

        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
