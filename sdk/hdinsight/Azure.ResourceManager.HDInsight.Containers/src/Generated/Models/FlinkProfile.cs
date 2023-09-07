// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The Flink cluster profile. </summary>
    public partial class FlinkProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FlinkProfile"/>. </summary>
        /// <param name="storage"> The storage profile. </param>
        /// <param name="jobManager"> Job Manager container/ process CPU and memory requirements. </param>
        /// <param name="taskManager"> Task Manager container/ process CPU and memory requirements. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storage"/>, <paramref name="jobManager"/> or <paramref name="taskManager"/> is null. </exception>
        public FlinkProfile(FlinkStorageProfile storage, ComputeResourceRequirement jobManager, ComputeResourceRequirement taskManager)
        {
            Argument.AssertNotNull(storage, nameof(storage));
            Argument.AssertNotNull(jobManager, nameof(jobManager));
            Argument.AssertNotNull(taskManager, nameof(taskManager));

            Storage = storage;
            JobManager = jobManager;
            TaskManager = taskManager;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkProfile"/>. </summary>
        /// <param name="storage"> The storage profile. </param>
        /// <param name="numReplicas"> The number of task managers. </param>
        /// <param name="jobManager"> Job Manager container/ process CPU and memory requirements. </param>
        /// <param name="historyServer"> History Server container/ process CPU and memory requirements. </param>
        /// <param name="taskManager"> Task Manager container/ process CPU and memory requirements. </param>
        /// <param name="catalogOptions"> Flink cluster catalog options. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FlinkProfile(FlinkStorageProfile storage, int? numReplicas, ComputeResourceRequirement jobManager, ComputeResourceRequirement historyServer, ComputeResourceRequirement taskManager, FlinkCatalogOptions catalogOptions, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Storage = storage;
            NumReplicas = numReplicas;
            JobManager = jobManager;
            HistoryServer = historyServer;
            TaskManager = taskManager;
            CatalogOptions = catalogOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkProfile"/> for deserialization. </summary>
        internal FlinkProfile()
        {
        }

        /// <summary> The storage profile. </summary>
        public FlinkStorageProfile Storage { get; set; }
        /// <summary> The number of task managers. </summary>
        public int? NumReplicas { get; set; }
        /// <summary> Job Manager container/ process CPU and memory requirements. </summary>
        public ComputeResourceRequirement JobManager { get; set; }
        /// <summary> History Server container/ process CPU and memory requirements. </summary>
        public ComputeResourceRequirement HistoryServer { get; set; }
        /// <summary> Task Manager container/ process CPU and memory requirements. </summary>
        public ComputeResourceRequirement TaskManager { get; set; }
        /// <summary> Flink cluster catalog options. </summary>
        internal FlinkCatalogOptions CatalogOptions { get; set; }
        /// <summary> Hive Catalog Option for Flink cluster. </summary>
        public FlinkHiveCatalogOption CatalogOptionsHive
        {
            get => CatalogOptions is null ? default : CatalogOptions.Hive;
            set
            {
                if (CatalogOptions is null)
                    CatalogOptions = new FlinkCatalogOptions();
                CatalogOptions.Hive = value;
            }
        }
    }
}
