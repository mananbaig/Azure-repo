// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Encapsulates information regarding data directory. </summary>
    public partial class SqlDataDirectoryMapping
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlDataDirectoryMapping"/>. </summary>
        public SqlDataDirectoryMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDataDirectoryMapping"/>. </summary>
        /// <param name="mappingType"> Type of data directory mapping. </param>
        /// <param name="sourceLogicalName"> Restore source logical name path. </param>
        /// <param name="sourcePath"> Restore source path. </param>
        /// <param name="targetPath"> Target path. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlDataDirectoryMapping(SqlDataDirectoryType? mappingType, string sourceLogicalName, string sourcePath, string targetPath, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MappingType = mappingType;
            SourceLogicalName = sourceLogicalName;
            SourcePath = sourcePath;
            TargetPath = targetPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of data directory mapping. </summary>
        public SqlDataDirectoryType? MappingType { get; set; }
        /// <summary> Restore source logical name path. </summary>
        public string SourceLogicalName { get; set; }
        /// <summary> Restore source path. </summary>
        public string SourcePath { get; set; }
        /// <summary> Target path. </summary>
        public string TargetPath { get; set; }
    }
}
