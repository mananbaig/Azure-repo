// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Container group log analytics information. </summary>
    public partial class ContainerGroupLogAnalytics
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerGroupLogAnalytics"/>. </summary>
        /// <param name="workspaceId"> The workspace id for log analytics. </param>
        /// <param name="workspaceKey"> The workspace key for log analytics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="workspaceKey"/> is null. </exception>
        public ContainerGroupLogAnalytics(string workspaceId, string workspaceKey)
        {
            Argument.AssertNotNull(workspaceId, nameof(workspaceId));
            Argument.AssertNotNull(workspaceKey, nameof(workspaceKey));

            WorkspaceId = workspaceId;
            WorkspaceKey = workspaceKey;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupLogAnalytics"/>. </summary>
        /// <param name="workspaceId"> The workspace id for log analytics. </param>
        /// <param name="workspaceKey"> The workspace key for log analytics. </param>
        /// <param name="logType"> The log type to be used. </param>
        /// <param name="metadata"> Metadata for log analytics. </param>
        /// <param name="workspaceResourceId"> The workspace resource id for log analytics. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupLogAnalytics(string workspaceId, string workspaceKey, ContainerGroupLogAnalyticsLogType? logType, IDictionary<string, string> metadata, ResourceIdentifier workspaceResourceId, Dictionary<string, BinaryData> rawData)
        {
            WorkspaceId = workspaceId;
            WorkspaceKey = workspaceKey;
            LogType = logType;
            Metadata = metadata;
            WorkspaceResourceId = workspaceResourceId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupLogAnalytics"/> for deserialization. </summary>
        internal ContainerGroupLogAnalytics()
        {
        }

        /// <summary> The workspace id for log analytics. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> The workspace key for log analytics. </summary>
        public string WorkspaceKey { get; set; }
        /// <summary> The log type to be used. </summary>
        public ContainerGroupLogAnalyticsLogType? LogType { get; set; }
        /// <summary> Metadata for log analytics. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The workspace resource id for log analytics. </summary>
        public ResourceIdentifier WorkspaceResourceId { get; set; }
    }
}
