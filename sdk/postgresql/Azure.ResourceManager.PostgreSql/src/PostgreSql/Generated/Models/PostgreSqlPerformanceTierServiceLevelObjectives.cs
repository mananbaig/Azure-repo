// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Service level objectives for performance tier. </summary>
    public partial class PostgreSqlPerformanceTierServiceLevelObjectives
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlPerformanceTierServiceLevelObjectives"/>. </summary>
        internal PostgreSqlPerformanceTierServiceLevelObjectives()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlPerformanceTierServiceLevelObjectives"/>. </summary>
        /// <param name="id"> ID for the service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlPerformanceTierServiceLevelObjectives(string id, string edition, int? vCores, string hardwareGeneration, int? maxBackupRetentionDays, int? minBackupRetentionDays, int? maxStorageInMB, int? minStorageInMB, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Edition = edition;
            VCores = vCores;
            HardwareGeneration = hardwareGeneration;
            MaxBackupRetentionDays = maxBackupRetentionDays;
            MinBackupRetentionDays = minBackupRetentionDays;
            MaxStorageInMB = maxStorageInMB;
            MinStorageInMB = minStorageInMB;
            _rawData = rawData;
        }

        /// <summary> ID for the service level objective. </summary>
        public string Id { get; }
        /// <summary> Edition of the performance tier. </summary>
        public string Edition { get; }
        /// <summary> vCore associated with the service level objective. </summary>
        public int? VCores { get; }
        /// <summary> Hardware generation associated with the service level objective. </summary>
        public string HardwareGeneration { get; }
        /// <summary> Maximum Backup retention in days for the performance tier edition. </summary>
        public int? MaxBackupRetentionDays { get; }
        /// <summary> Minimum Backup retention in days for the performance tier edition. </summary>
        public int? MinBackupRetentionDays { get; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? MaxStorageInMB { get; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? MinStorageInMB { get; }
    }
}
