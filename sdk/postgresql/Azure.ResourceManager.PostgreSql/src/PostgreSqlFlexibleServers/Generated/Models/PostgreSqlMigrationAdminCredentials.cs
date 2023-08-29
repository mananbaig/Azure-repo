// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Server admin credentials. </summary>
    public partial class PostgreSqlMigrationAdminCredentials
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationAdminCredentials"/>. </summary>
        /// <param name="sourceServerPassword"> Password for source server. </param>
        /// <param name="targetServerPassword"> Password for target server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceServerPassword"/> or <paramref name="targetServerPassword"/> is null. </exception>
        public PostgreSqlMigrationAdminCredentials(string sourceServerPassword, string targetServerPassword)
        {
            Argument.AssertNotNull(sourceServerPassword, nameof(sourceServerPassword));
            Argument.AssertNotNull(targetServerPassword, nameof(targetServerPassword));

            SourceServerPassword = sourceServerPassword;
            TargetServerPassword = targetServerPassword;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationAdminCredentials"/>. </summary>
        /// <param name="sourceServerPassword"> Password for source server. </param>
        /// <param name="targetServerPassword"> Password for target server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlMigrationAdminCredentials(string sourceServerPassword, string targetServerPassword, Dictionary<string, BinaryData> rawData)
        {
            SourceServerPassword = sourceServerPassword;
            TargetServerPassword = targetServerPassword;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationAdminCredentials"/> for deserialization. </summary>
        internal PostgreSqlMigrationAdminCredentials()
        {
        }

        /// <summary> Password for source server. </summary>
        public string SourceServerPassword { get; set; }
        /// <summary> Password for target server. </summary>
        public string TargetServerPassword { get; set; }
    }
}
