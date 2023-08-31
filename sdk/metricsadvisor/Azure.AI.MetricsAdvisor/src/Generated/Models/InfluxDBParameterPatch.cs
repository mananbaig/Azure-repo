// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The InfluxDBParameterPatch. </summary>
    internal partial class InfluxDBParameterPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="InfluxDBParameterPatch"/>. </summary>
        public InfluxDBParameterPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InfluxDBParameterPatch"/>. </summary>
        /// <param name="connectionString"> The connection string of this InfluxDB. </param>
        /// <param name="database"> A database name. </param>
        /// <param name="userName"> The user name of the account that can access this database. </param>
        /// <param name="password"> The password of the account that can access this database. </param>
        /// <param name="query"> The script to query this database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InfluxDBParameterPatch(string connectionString, string database, string userName, string password, string query, Dictionary<string, BinaryData> rawData)
        {
            ConnectionString = connectionString;
            Database = database;
            UserName = userName;
            Password = password;
            Query = query;
            _rawData = rawData;
        }

        /// <summary> The connection string of this InfluxDB. </summary>
        public string ConnectionString { get; set; }
        /// <summary> A database name. </summary>
        public string Database { get; set; }
        /// <summary> The user name of the account that can access this database. </summary>
        public string UserName { get; set; }
        /// <summary> The password of the account that can access this database. </summary>
        public string Password { get; set; }
        /// <summary> The script to query this database. </summary>
        public string Query { get; set; }
    }
}
