// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the TriggeredJobHistory data model.
    /// Triggered Web Job History. List of Triggered Web Job Run Information elements.
    /// </summary>
    public partial class TriggeredJobHistoryData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TriggeredJobHistoryData"/>. </summary>
        public TriggeredJobHistoryData()
        {
            Runs = new ChangeTrackingList<TriggeredJobRun>();
        }

        /// <summary> Initializes a new instance of <see cref="TriggeredJobHistoryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="runs"> List of triggered web job runs. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggeredJobHistoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<TriggeredJobRun> runs, string kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Runs = runs;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of triggered web job runs. </summary>
        public IList<TriggeredJobRun> Runs { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
