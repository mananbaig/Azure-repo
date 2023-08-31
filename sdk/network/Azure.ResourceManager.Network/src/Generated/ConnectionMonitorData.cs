// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ConnectionMonitor data model.
    /// Information about the connection monitor.
    /// </summary>
    public partial class ConnectionMonitorData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorData"/>. </summary>
        internal ConnectionMonitorData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Endpoints = new ChangeTrackingList<ConnectionMonitorEndpoint>();
            TestConfigurations = new ChangeTrackingList<ConnectionMonitorTestConfiguration>();
            TestGroups = new ChangeTrackingList<ConnectionMonitorTestGroup>();
            Outputs = new ChangeTrackingList<ConnectionMonitorOutput>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="location"> Connection monitor location. </param>
        /// <param name="tags"> Connection monitor tags. </param>
        /// <param name="source"> Describes the source of connection monitor. </param>
        /// <param name="destination"> Describes the destination of connection monitor. </param>
        /// <param name="autoStart"> Determines if the connection monitor will start automatically once created. </param>
        /// <param name="monitoringIntervalInSeconds"> Monitoring interval in seconds. </param>
        /// <param name="endpoints"> List of connection monitor endpoints. </param>
        /// <param name="testConfigurations"> List of connection monitor test configurations. </param>
        /// <param name="testGroups"> List of connection monitor test groups. </param>
        /// <param name="outputs"> List of connection monitor outputs. </param>
        /// <param name="notes"> Optional notes to be associated with the connection monitor. </param>
        /// <param name="provisioningState"> The provisioning state of the connection monitor. </param>
        /// <param name="startOn"> The date and time when the connection monitor was started. </param>
        /// <param name="monitoringStatus"> The monitoring status of the connection monitor. </param>
        /// <param name="connectionMonitorType"> Type of connection monitor. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, AzureLocation? location, IReadOnlyDictionary<string, string> tags, ConnectionMonitorSource source, ConnectionMonitorDestination destination, bool? autoStart, int? monitoringIntervalInSeconds, IReadOnlyList<ConnectionMonitorEndpoint> endpoints, IReadOnlyList<ConnectionMonitorTestConfiguration> testConfigurations, IReadOnlyList<ConnectionMonitorTestGroup> testGroups, IReadOnlyList<ConnectionMonitorOutput> outputs, string notes, NetworkProvisioningState? provisioningState, DateTimeOffset? startOn, string monitoringStatus, ConnectionMonitorType? connectionMonitorType, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Location = location;
            Tags = tags;
            Source = source;
            Destination = destination;
            AutoStart = autoStart;
            MonitoringIntervalInSeconds = monitoringIntervalInSeconds;
            Endpoints = endpoints;
            TestConfigurations = testConfigurations;
            TestGroups = testGroups;
            Outputs = outputs;
            Notes = notes;
            ProvisioningState = provisioningState;
            StartOn = startOn;
            MonitoringStatus = monitoringStatus;
            ConnectionMonitorType = connectionMonitorType;
            _rawData = rawData;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Connection monitor location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Connection monitor tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Describes the source of connection monitor. </summary>
        public ConnectionMonitorSource Source { get; }
        /// <summary> Describes the destination of connection monitor. </summary>
        public ConnectionMonitorDestination Destination { get; }
        /// <summary> Determines if the connection monitor will start automatically once created. </summary>
        public bool? AutoStart { get; }
        /// <summary> Monitoring interval in seconds. </summary>
        public int? MonitoringIntervalInSeconds { get; }
        /// <summary> List of connection monitor endpoints. </summary>
        public IReadOnlyList<ConnectionMonitorEndpoint> Endpoints { get; }
        /// <summary> List of connection monitor test configurations. </summary>
        public IReadOnlyList<ConnectionMonitorTestConfiguration> TestConfigurations { get; }
        /// <summary> List of connection monitor test groups. </summary>
        public IReadOnlyList<ConnectionMonitorTestGroup> TestGroups { get; }
        /// <summary> List of connection monitor outputs. </summary>
        public IReadOnlyList<ConnectionMonitorOutput> Outputs { get; }
        /// <summary> Optional notes to be associated with the connection monitor. </summary>
        public string Notes { get; }
        /// <summary> The provisioning state of the connection monitor. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The date and time when the connection monitor was started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The monitoring status of the connection monitor. </summary>
        public string MonitoringStatus { get; }
        /// <summary> Type of connection monitor. </summary>
        public ConnectionMonitorType? ConnectionMonitorType { get; }
    }
}
