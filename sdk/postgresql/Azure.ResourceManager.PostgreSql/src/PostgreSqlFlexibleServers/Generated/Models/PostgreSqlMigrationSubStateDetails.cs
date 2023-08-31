// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration sub state details. </summary>
    internal partial class PostgreSqlMigrationSubStateDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationSubStateDetails"/>. </summary>
        internal PostgreSqlMigrationSubStateDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationSubStateDetails"/>. </summary>
        /// <param name="currentSubState"> Migration sub state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlMigrationSubStateDetails(PostgreSqlMigrationSubState? currentSubState, Dictionary<string, BinaryData> rawData)
        {
            CurrentSubState = currentSubState;
            _rawData = rawData;
        }

        /// <summary> Migration sub state. </summary>
        public PostgreSqlMigrationSubState? CurrentSubState { get; }
    }
}
