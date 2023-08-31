// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Source SQL Connection. </summary>
    public partial class SqlConnectionInformation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlConnectionInformation"/>. </summary>
        public SqlConnectionInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlConnectionInformation"/>. </summary>
        /// <param name="dataSource"> Data source. </param>
        /// <param name="authentication"> Authentication type. </param>
        /// <param name="userName"> User name to connect to source SQL. </param>
        /// <param name="password"> Password to connect to source SQL. </param>
        /// <param name="encryptConnection"> Whether to encrypt connection or not. </param>
        /// <param name="trustServerCertificate"> Whether to trust server certificate or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlConnectionInformation(string dataSource, string authentication, string userName, string password, bool? encryptConnection, bool? trustServerCertificate, Dictionary<string, BinaryData> rawData)
        {
            DataSource = dataSource;
            Authentication = authentication;
            UserName = userName;
            Password = password;
            EncryptConnection = encryptConnection;
            TrustServerCertificate = trustServerCertificate;
            _rawData = rawData;
        }

        /// <summary> Data source. </summary>
        public string DataSource { get; set; }
        /// <summary> Authentication type. </summary>
        public string Authentication { get; set; }
        /// <summary> User name to connect to source SQL. </summary>
        public string UserName { get; set; }
        /// <summary> Password to connect to source SQL. </summary>
        public string Password { get; set; }
        /// <summary> Whether to encrypt connection or not. </summary>
        public bool? EncryptConnection { get; set; }
        /// <summary> Whether to trust server certificate or not. </summary>
        public bool? TrustServerCertificate { get; set; }
    }
}
