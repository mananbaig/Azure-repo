// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Work item configuration associated with an application insights resource. </summary>
    public partial class WorkItemConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkItemConfiguration"/>. </summary>
        internal WorkItemConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkItemConfiguration"/>. </summary>
        /// <param name="connectorId"> Connector identifier where work item is created. </param>
        /// <param name="configDisplayName"> Configuration friendly name. </param>
        /// <param name="isDefault"> Boolean value indicating whether configuration is default. </param>
        /// <param name="id"> Unique Id for work item. </param>
        /// <param name="configProperties"> Serialized JSON object for detailed properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkItemConfiguration(string connectorId, string configDisplayName, bool? isDefault, string id, string configProperties, Dictionary<string, BinaryData> rawData)
        {
            ConnectorId = connectorId;
            ConfigDisplayName = configDisplayName;
            IsDefault = isDefault;
            Id = id;
            ConfigProperties = configProperties;
            _rawData = rawData;
        }

        /// <summary> Connector identifier where work item is created. </summary>
        public string ConnectorId { get; }
        /// <summary> Configuration friendly name. </summary>
        public string ConfigDisplayName { get; }
        /// <summary> Boolean value indicating whether configuration is default. </summary>
        public bool? IsDefault { get; }
        /// <summary> Unique Id for work item. </summary>
        public string Id { get; }
        /// <summary> Serialized JSON object for detailed properties. </summary>
        public string ConfigProperties { get; }
    }
}
