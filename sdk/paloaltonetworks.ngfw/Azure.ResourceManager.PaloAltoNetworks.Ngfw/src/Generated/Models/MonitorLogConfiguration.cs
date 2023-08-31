// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> MonitorLog configurations. </summary>
    public partial class MonitorLogConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorLogConfiguration"/>. </summary>
        public MonitorLogConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorLogConfiguration"/>. </summary>
        /// <param name="id"> Resource ID of MonitorLog. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="workspace"> MonitorLog workspace. </param>
        /// <param name="primaryKey"> Primary Key value for Monitor. </param>
        /// <param name="secondaryKey"> Secondary Key value for Monitor. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorLogConfiguration(ResourceIdentifier id, string subscriptionId, string workspace, string primaryKey, string secondaryKey, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Workspace = workspace;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            _rawData = rawData;
        }

        /// <summary> Resource ID of MonitorLog. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Subscription Id. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> MonitorLog workspace. </summary>
        public string Workspace { get; set; }
        /// <summary> Primary Key value for Monitor. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> Secondary Key value for Monitor. </summary>
        public string SecondaryKey { get; set; }
    }
}
