// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Service level objectives for performance tier. </summary>
    public partial class PerformanceTierServiceLevelObjectives
    {
        /// <summary> Initializes a new instance of PerformanceTierServiceLevelObjectives. </summary>
        internal PerformanceTierServiceLevelObjectives()
        {
        }

        /// <summary> Initializes a new instance of PerformanceTierServiceLevelObjectives. </summary>
        /// <param name="id"> ID for the service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCore"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageMB"> Max storage allowed for a server. </param>
        internal PerformanceTierServiceLevelObjectives(string id, string edition, int? vCore, string hardwareGeneration, int? maxBackupRetentionDays, int? minBackupRetentionDays, int? maxStorageMB, int? minStorageMB)
        {
            Id = id;
            Edition = edition;
            VCore = vCore;
            HardwareGeneration = hardwareGeneration;
            MaxBackupRetentionDays = maxBackupRetentionDays;
            MinBackupRetentionDays = minBackupRetentionDays;
            MaxStorageMB = maxStorageMB;
            MinStorageMB = minStorageMB;
        }

        /// <summary> ID for the service level objective. </summary>
        public string Id { get; }
        /// <summary> Edition of the performance tier. </summary>
        public string Edition { get; }
        /// <summary> vCore associated with the service level objective. </summary>
        public int? VCore { get; }
        /// <summary> Hardware generation associated with the service level objective. </summary>
        public string HardwareGeneration { get; }
        /// <summary> Maximum Backup retention in days for the performance tier edition. </summary>
        public int? MaxBackupRetentionDays { get; }
        /// <summary> Minimum Backup retention in days for the performance tier edition. </summary>
        public int? MinBackupRetentionDays { get; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? MaxStorageMB { get; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? MinStorageMB { get; }
    }
}
