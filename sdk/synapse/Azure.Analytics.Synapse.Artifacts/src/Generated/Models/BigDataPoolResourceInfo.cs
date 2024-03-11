// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A Big Data pool. </summary>
    public partial class BigDataPoolResourceInfo : TrackedResource
    {
        /// <summary> Initializes a new instance of <see cref="BigDataPoolResourceInfo"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public BigDataPoolResourceInfo(string location) : base(location)
        {
            Argument.AssertNotNull(location, nameof(location));

            CustomLibraries = new ChangeTrackingList<LibraryInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="BigDataPoolResourceInfo"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="provisioningState"> The state of the Big Data pool. </param>
        /// <param name="autoScale"> Auto-scaling properties. </param>
        /// <param name="creationDate"> The time when the Big Data pool was created. </param>
        /// <param name="autoPause"> Auto-pausing properties. </param>
        /// <param name="isComputeIsolationEnabled"> Whether compute isolation is required or not. </param>
        /// <param name="sessionLevelPackagesEnabled"> Whether session level packages enabled. </param>
        /// <param name="cacheSize"> The cache size. </param>
        /// <param name="dynamicExecutorAllocation"> Dynamic Executor Allocation. </param>
        /// <param name="sparkEventsFolder"> The Spark events folder. </param>
        /// <param name="nodeCount"> The number of nodes in the Big Data pool. </param>
        /// <param name="libraryRequirements"> Library version requirements. </param>
        /// <param name="customLibraries"> List of custom libraries/packages associated with the spark pool. </param>
        /// <param name="sparkConfigProperties"> Spark configuration file to specify additional properties. </param>
        /// <param name="sparkVersion"> The Apache Spark version. </param>
        /// <param name="defaultSparkLogFolder"> The default folder where Spark logs will be written. </param>
        /// <param name="nodeSize"> The level of compute power that each node in the Big Data pool has. </param>
        /// <param name="nodeSizeFamily"> The kind of nodes that the Big Data pool provides. </param>
        /// <param name="lastSucceededTimestamp"> The time when the Big Data pool was updated successfully. </param>
        internal BigDataPoolResourceInfo(string id, string name, string type, IDictionary<string, string> tags, string location, string provisioningState, AutoScaleProperties autoScale, DateTimeOffset? creationDate, AutoPauseProperties autoPause, bool? isComputeIsolationEnabled, bool? sessionLevelPackagesEnabled, int? cacheSize, DynamicExecutorAllocation dynamicExecutorAllocation, string sparkEventsFolder, int? nodeCount, LibraryRequirements libraryRequirements, IList<LibraryInfo> customLibraries, LibraryRequirements sparkConfigProperties, string sparkVersion, string defaultSparkLogFolder, NodeSize? nodeSize, NodeSizeFamily? nodeSizeFamily, DateTimeOffset? lastSucceededTimestamp) : base(id, name, type, tags, location)
        {
            ProvisioningState = provisioningState;
            AutoScale = autoScale;
            CreationDate = creationDate;
            AutoPause = autoPause;
            IsComputeIsolationEnabled = isComputeIsolationEnabled;
            SessionLevelPackagesEnabled = sessionLevelPackagesEnabled;
            CacheSize = cacheSize;
            DynamicExecutorAllocation = dynamicExecutorAllocation;
            SparkEventsFolder = sparkEventsFolder;
            NodeCount = nodeCount;
            LibraryRequirements = libraryRequirements;
            CustomLibraries = customLibraries;
            SparkConfigProperties = sparkConfigProperties;
            SparkVersion = sparkVersion;
            DefaultSparkLogFolder = defaultSparkLogFolder;
            NodeSize = nodeSize;
            NodeSizeFamily = nodeSizeFamily;
            LastSucceededTimestamp = lastSucceededTimestamp;
        }

        /// <summary> The state of the Big Data pool. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Auto-scaling properties. </summary>
        public AutoScaleProperties AutoScale { get; set; }
        /// <summary> The time when the Big Data pool was created. </summary>
        public DateTimeOffset? CreationDate { get; set; }
        /// <summary> Auto-pausing properties. </summary>
        public AutoPauseProperties AutoPause { get; set; }
        /// <summary> Whether compute isolation is required or not. </summary>
        public bool? IsComputeIsolationEnabled { get; set; }
        /// <summary> Whether session level packages enabled. </summary>
        public bool? SessionLevelPackagesEnabled { get; set; }
        /// <summary> The cache size. </summary>
        public int? CacheSize { get; set; }
        /// <summary> Dynamic Executor Allocation. </summary>
        public DynamicExecutorAllocation DynamicExecutorAllocation { get; set; }
        /// <summary> The Spark events folder. </summary>
        public string SparkEventsFolder { get; set; }
        /// <summary> The number of nodes in the Big Data pool. </summary>
        public int? NodeCount { get; set; }
        /// <summary> Library version requirements. </summary>
        public LibraryRequirements LibraryRequirements { get; set; }
        /// <summary> List of custom libraries/packages associated with the spark pool. </summary>
        public IList<LibraryInfo> CustomLibraries { get; }
        /// <summary> Spark configuration file to specify additional properties. </summary>
        public LibraryRequirements SparkConfigProperties { get; set; }
        /// <summary> The Apache Spark version. </summary>
        public string SparkVersion { get; set; }
        /// <summary> The default folder where Spark logs will be written. </summary>
        public string DefaultSparkLogFolder { get; set; }
        /// <summary> The level of compute power that each node in the Big Data pool has. </summary>
        public NodeSize? NodeSize { get; set; }
        /// <summary> The kind of nodes that the Big Data pool provides. </summary>
        public NodeSizeFamily? NodeSizeFamily { get; set; }
        /// <summary> The time when the Big Data pool was updated successfully. </summary>
        public DateTimeOffset? LastSucceededTimestamp { get; }
    }
}
