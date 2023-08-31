// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The request object for trigger support package. </summary>
    public partial class TriggerSupportPackageContent : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TriggerSupportPackageContent"/>. </summary>
        public TriggerSupportPackageContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TriggerSupportPackageContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="minimumTimeStamp"> MinimumTimeStamp from where logs need to be collected. </param>
        /// <param name="maximumTimeStamp"> Start of the timespan of the log collection. </param>
        /// <param name="include">
        /// Type of files, which need to be included in the logs
        /// This will contain the type of logs (Default/DefaultWithDumps/None/All/DefaultWithArchived)
        /// or a comma separated list of log types that are required
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggerSupportPackageContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? minimumTimeStamp, DateTimeOffset? maximumTimeStamp, string include, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            MinimumTimeStamp = minimumTimeStamp;
            MaximumTimeStamp = maximumTimeStamp;
            Include = include;
            _rawData = rawData;
        }

        /// <summary> MinimumTimeStamp from where logs need to be collected. </summary>
        public DateTimeOffset? MinimumTimeStamp { get; set; }
        /// <summary> Start of the timespan of the log collection. </summary>
        public DateTimeOffset? MaximumTimeStamp { get; set; }
        /// <summary>
        /// Type of files, which need to be included in the logs
        /// This will contain the type of logs (Default/DefaultWithDumps/None/All/DefaultWithArchived)
        /// or a comma separated list of log types that are required
        /// </summary>
        public string Include { get; set; }
    }
}
