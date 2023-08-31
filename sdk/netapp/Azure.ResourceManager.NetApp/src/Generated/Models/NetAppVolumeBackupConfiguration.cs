// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume Backup Properties. </summary>
    public partial class NetAppVolumeBackupConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupConfiguration"/>. </summary>
        public NetAppVolumeBackupConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupConfiguration"/>. </summary>
        /// <param name="backupPolicyId"> Backup Policy Resource ID. </param>
        /// <param name="isPolicyEnforced"> Policy Enforced. </param>
        /// <param name="isBackupEnabled"> Backup Enabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBackupConfiguration(ResourceIdentifier backupPolicyId, bool? isPolicyEnforced, bool? isBackupEnabled, Dictionary<string, BinaryData> rawData)
        {
            BackupPolicyId = backupPolicyId;
            IsPolicyEnforced = isPolicyEnforced;
            IsBackupEnabled = isBackupEnabled;
            _rawData = rawData;
        }

        /// <summary> Backup Policy Resource ID. </summary>
        public ResourceIdentifier BackupPolicyId { get; set; }
        /// <summary> Policy Enforced. </summary>
        public bool? IsPolicyEnforced { get; set; }
        /// <summary> Backup Enabled. </summary>
        public bool? IsBackupEnabled { get; set; }
    }
}
