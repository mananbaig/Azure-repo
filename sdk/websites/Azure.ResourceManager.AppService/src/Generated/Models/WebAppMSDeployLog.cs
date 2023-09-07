// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> MSDeploy log. </summary>
    public partial class WebAppMSDeployLog : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebAppMSDeployLog"/>. </summary>
        public WebAppMSDeployLog()
        {
            Entries = new ChangeTrackingList<WebAppMSDeployLogEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="WebAppMSDeployLog"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="entries"> List of log entry messages. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppMSDeployLog(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<WebAppMSDeployLogEntry> entries, string kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Entries = entries;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of log entry messages. </summary>
        public IReadOnlyList<WebAppMSDeployLogEntry> Entries { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
