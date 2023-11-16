// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Enables Firewall logs to be collected by this data collection rule. </summary>
    public partial class WindowsFirewallLogsDataSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WindowsFirewallLogsDataSource"/>. </summary>
        /// <param name="streams"> Firewall logs streams. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streams"/> is null. </exception>
        public WindowsFirewallLogsDataSource(IEnumerable<string> streams)
        {
            Argument.AssertNotNull(streams, nameof(streams));

            Streams = streams.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="WindowsFirewallLogsDataSource"/>. </summary>
        /// <param name="streams"> Firewall logs streams. </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WindowsFirewallLogsDataSource(IList<string> streams, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Streams = streams;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WindowsFirewallLogsDataSource"/> for deserialization. </summary>
        internal WindowsFirewallLogsDataSource()
        {
        }

        /// <summary> Firewall logs streams. </summary>
        public IList<string> Streams { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
