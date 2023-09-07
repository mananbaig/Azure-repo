// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Details about target workload during restore operation. </summary>
    public partial class TargetRestoreInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TargetRestoreInfo"/>. </summary>
        public TargetRestoreInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TargetRestoreInfo"/>. </summary>
        /// <param name="overwriteOption"> Can Overwrite if Target DataBase already exists. </param>
        /// <param name="containerId"> Resource Id name of the container in which Target DataBase resides. </param>
        /// <param name="databaseName"> Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana. </param>
        /// <param name="targetDirectoryForFileRestore"> Target directory location for restore as files. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetRestoreInfo(RestoreOverwriteOption? overwriteOption, string containerId, string databaseName, string targetDirectoryForFileRestore, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OverwriteOption = overwriteOption;
            ContainerId = containerId;
            DatabaseName = databaseName;
            TargetDirectoryForFileRestore = targetDirectoryForFileRestore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Can Overwrite if Target DataBase already exists. </summary>
        public RestoreOverwriteOption? OverwriteOption { get; set; }
        /// <summary> Resource Id name of the container in which Target DataBase resides. </summary>
        public string ContainerId { get; set; }
        /// <summary> Database name InstanceName/DataBaseName for SQL or System/DbName for SAP Hana. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Target directory location for restore as files. </summary>
        public string TargetDirectoryForFileRestore { get; set; }
    }
}
