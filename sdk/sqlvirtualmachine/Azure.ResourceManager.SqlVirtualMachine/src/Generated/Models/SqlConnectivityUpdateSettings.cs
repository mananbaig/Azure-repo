// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Set the access level and network port settings for SQL Server. </summary>
    public partial class SqlConnectivityUpdateSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlConnectivityUpdateSettings"/>. </summary>
        public SqlConnectivityUpdateSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlConnectivityUpdateSettings"/>. </summary>
        /// <param name="connectivityType"> SQL Server connectivity option. </param>
        /// <param name="port"> SQL Server port. </param>
        /// <param name="sqlAuthUpdateUserName"> SQL Server sysadmin login to create. </param>
        /// <param name="sqlAuthUpdatePassword"> SQL Server sysadmin login password. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlConnectivityUpdateSettings(SqlServerConnectivityType? connectivityType, int? port, string sqlAuthUpdateUserName, string sqlAuthUpdatePassword, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectivityType = connectivityType;
            Port = port;
            SqlAuthUpdateUserName = sqlAuthUpdateUserName;
            SqlAuthUpdatePassword = sqlAuthUpdatePassword;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SQL Server connectivity option. </summary>
        public SqlServerConnectivityType? ConnectivityType { get; set; }
        /// <summary> SQL Server port. </summary>
        public int? Port { get; set; }
        /// <summary> SQL Server sysadmin login to create. </summary>
        public string SqlAuthUpdateUserName { get; set; }
        /// <summary> SQL Server sysadmin login password. </summary>
        public string SqlAuthUpdatePassword { get; set; }
    }
}
