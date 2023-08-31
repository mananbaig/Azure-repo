// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration status. </summary>
    public partial class PostgreSqlMigrationStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationStatus"/>. </summary>
        internal PostgreSqlMigrationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationStatus"/>. </summary>
        /// <param name="state"> State of migration. </param>
        /// <param name="error"> Error message, if any, for the migration state. </param>
        /// <param name="currentSubStateDetails"> Current Migration sub state details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlMigrationStatus(PostgreSqlMigrationState? state, string error, PostgreSqlMigrationSubStateDetails currentSubStateDetails, Dictionary<string, BinaryData> rawData)
        {
            State = state;
            Error = error;
            CurrentSubStateDetails = currentSubStateDetails;
            _rawData = rawData;
        }

        /// <summary> State of migration. </summary>
        public PostgreSqlMigrationState? State { get; }
        /// <summary> Error message, if any, for the migration state. </summary>
        public string Error { get; }
        /// <summary> Current Migration sub state details. </summary>
        internal PostgreSqlMigrationSubStateDetails CurrentSubStateDetails { get; }
        /// <summary> Migration sub state. </summary>
        public PostgreSqlMigrationSubState? CurrentSubState
        {
            get => CurrentSubStateDetails?.CurrentSubState;
        }
    }
}
