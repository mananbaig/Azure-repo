// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the LogAnalyticsQueryPack data model.
    /// An Log Analytics QueryPack definition.
    /// </summary>
    public partial class LogAnalyticsQueryPackData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryPackData"/>. </summary>
        /// <param name="location"> The location. </param>
        public LogAnalyticsQueryPackData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryPackData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="queryPackId"> The unique ID of your application. This field cannot be changed. </param>
        /// <param name="createdOn"> Creation Date for the Log Analytics QueryPack, in ISO 8601 format. </param>
        /// <param name="modifiedOn"> Last modified date of the Log Analytics QueryPack, in ISO 8601 format. </param>
        /// <param name="provisioningState"> Current state of this QueryPack: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogAnalyticsQueryPackData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? queryPackId, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, string provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            QueryPackId = queryPackId;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryPackData"/> for deserialization. </summary>
        internal LogAnalyticsQueryPackData()
        {
        }

        /// <summary> The unique ID of your application. This field cannot be changed. </summary>
        public Guid? QueryPackId { get; }
        /// <summary> Creation Date for the Log Analytics QueryPack, in ISO 8601 format. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last modified date of the Log Analytics QueryPack, in ISO 8601 format. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Current state of this QueryPack: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed. </summary>
        public string ProvisioningState { get; }
    }
}
