// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AgFoodPlatform.FieldChanged event. </summary>
    public partial class FarmBeatsFieldChangedEventData
    {
        /// <summary> Initializes a new instance of FarmBeatsFieldChangedEventData. </summary>
        internal FarmBeatsFieldChangedEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of FarmBeatsFieldChangedEventData. </summary>
        /// <param name="farmerId"> Farmer Id. </param>
        /// <param name="farmId"> Id of the associated Farm. </param>
        /// <param name="actionType"> Action occurred on a resource. </param>
        /// <param name="status"> Status of the resource. </param>
        /// <param name="modifiedDateTime"> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="eTag"> The ETag value to implement optimistic concurrency. </param>
        /// <param name="id"> Unique id of resource. </param>
        /// <param name="name"> Name to identify resource. </param>
        /// <param name="description"> Textual description of resource. </param>
        /// <param name="createdDateTime"> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="properties">
        /// A list of key value pairs that describe the resource.
        /// 
        /// Only string and numeral values are supported.
        /// </param>
        internal FarmBeatsFieldChangedEventData(string farmerId, string farmId, ResourceActionType? actionType, string status, DateTimeOffset? modifiedDateTime, string eTag, string id, string name, string description, DateTimeOffset? createdDateTime, IReadOnlyDictionary<string, object> properties)
        {
            FarmerId = farmerId;
            FarmId = farmId;
            ActionType = actionType;
            Status = status;
            ModifiedDateTime = modifiedDateTime;
            ETag = eTag;
            Id = id;
            Name = name;
            Description = description;
            CreatedDateTime = createdDateTime;
            Properties = properties;
        }

        /// <summary> Farmer Id. </summary>
        public string FarmerId { get; }
        /// <summary> Id of the associated Farm. </summary>
        public string FarmId { get; }
        /// <summary> Action occurred on a resource. </summary>
        public ResourceActionType? ActionType { get; }
        /// <summary> Status of the resource. </summary>
        public string Status { get; }
        /// <summary> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? ModifiedDateTime { get; }
        /// <summary> The ETag value to implement optimistic concurrency. </summary>
        public string ETag { get; }
        /// <summary> Unique id of resource. </summary>
        public string Id { get; }
        /// <summary> Name to identify resource. </summary>
        public string Name { get; }
        /// <summary> Textual description of resource. </summary>
        public string Description { get; }
        /// <summary> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary>
        /// A list of key value pairs that describe the resource.
        /// 
        /// Only string and numeral values are supported.
        /// </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
    }
}
