// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Monitoring account destination. </summary>
    public partial class MonitoringAccountDestination
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitoringAccountDestination"/>. </summary>
        public MonitoringAccountDestination()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringAccountDestination"/>. </summary>
        /// <param name="accountResourceId"> The resource ID of the monitoring account. </param>
        /// <param name="accountId"> The immutable ID  of the account. </param>
        /// <param name="name">
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoringAccountDestination(ResourceIdentifier accountResourceId, string accountId, string name, Dictionary<string, BinaryData> rawData)
        {
            AccountResourceId = accountResourceId;
            AccountId = accountId;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The resource ID of the monitoring account. </summary>
        public ResourceIdentifier AccountResourceId { get; set; }
        /// <summary> The immutable ID  of the account. </summary>
        public string AccountId { get; }
        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
