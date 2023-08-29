// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Restore payload for single file backup restore. </summary>
    public partial class NetAppVolumeBackupBackupRestoreFilesContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupBackupRestoreFilesContent"/>. </summary>
        /// <param name="fileList"> List of files to be restored. </param>
        /// <param name="destinationVolumeId"> Resource Id of the destination volume on which the files need to be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileList"/> or <paramref name="destinationVolumeId"/> is null. </exception>
        public NetAppVolumeBackupBackupRestoreFilesContent(IEnumerable<string> fileList, ResourceIdentifier destinationVolumeId)
        {
            Argument.AssertNotNull(fileList, nameof(fileList));
            Argument.AssertNotNull(destinationVolumeId, nameof(destinationVolumeId));

            FileList = fileList.ToList();
            DestinationVolumeId = destinationVolumeId;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupBackupRestoreFilesContent"/>. </summary>
        /// <param name="fileList"> List of files to be restored. </param>
        /// <param name="restoreFilePath"> Destination folder where the files will be restored. The path name should start with a forward slash. If it is omitted from request then restore is done at the root folder of the destination volume by default. </param>
        /// <param name="destinationVolumeId"> Resource Id of the destination volume on which the files need to be restored. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBackupBackupRestoreFilesContent(IList<string> fileList, string restoreFilePath, ResourceIdentifier destinationVolumeId, Dictionary<string, BinaryData> rawData)
        {
            FileList = fileList;
            RestoreFilePath = restoreFilePath;
            DestinationVolumeId = destinationVolumeId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupBackupRestoreFilesContent"/> for deserialization. </summary>
        internal NetAppVolumeBackupBackupRestoreFilesContent()
        {
        }

        /// <summary> List of files to be restored. </summary>
        public IList<string> FileList { get; }
        /// <summary> Destination folder where the files will be restored. The path name should start with a forward slash. If it is omitted from request then restore is done at the root folder of the destination volume by default. </summary>
        public string RestoreFilePath { get; set; }
        /// <summary> Resource Id of the destination volume on which the files need to be restored. </summary>
        public ResourceIdentifier DestinationVolumeId { get; }
    }
}
