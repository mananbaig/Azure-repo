// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> SQLDataDirectory info. </summary>
    public partial class SqlDataDirectory
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlDataDirectory"/>. </summary>
        public SqlDataDirectory()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDataDirectory"/>. </summary>
        /// <param name="directoryType"> Type of data directory mapping. </param>
        /// <param name="path"> File path. </param>
        /// <param name="logicalName"> Logical name of the file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlDataDirectory(SqlDataDirectoryType? directoryType, string path, string logicalName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DirectoryType = directoryType;
            Path = path;
            LogicalName = logicalName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of data directory mapping. </summary>
        public SqlDataDirectoryType? DirectoryType { get; set; }
        /// <summary> File path. </summary>
        public string Path { get; set; }
        /// <summary> Logical name of the file. </summary>
        public string LogicalName { get; set; }
    }
}
