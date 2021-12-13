// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Verticals.AgriFood.Farming.Models
{
    /// <summary> Schema of seasonal field resource. </summary>
    public partial class SeasonalField
    {
        /// <summary> Initializes a new instance of SeasonalField. </summary>
        public SeasonalField()
        {
            BoundaryIds = new ChangeTrackingList<string>();
            CropVarietyIds = new ChangeTrackingList<string>();
            Properties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of SeasonalField. </summary>
        /// <param name="farmerId"> Farmer ID. </param>
        /// <param name="primaryBoundaryId"> Primary boundary id. </param>
        /// <param name="boundaryIds"> Boundary Ids. </param>
        /// <param name="farmId"> ID of the associated Farm. </param>
        /// <param name="fieldId"> ID of the associated Field. </param>
        /// <param name="seasonId"> ID of the season it belongs to. </param>
        /// <param name="cropVarietyIds"> CropVariety ids. </param>
        /// <param name="cropId"> ID of the crop it belongs to. </param>
        /// <param name="avgYieldValue"> Average yield value of the seasonal field. </param>
        /// <param name="avgYieldUnit"> Unit of the average yield value attribute. </param>
        /// <param name="avgSeedPopulationValue"> Average seed population value of the seasonal field. </param>
        /// <param name="avgSeedPopulationUnit"> Unit of average seed population value attribute. </param>
        /// <param name="plantingDateTime"> Planting datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="id"> Unique resource ID. </param>
        /// <param name="eTag"> The ETag value to implement optimistic concurrency. </param>
        /// <param name="status"> Status of the resource. </param>
        /// <param name="createdDateTime"> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="modifiedDateTime"> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="name"> Name to identify resource. </param>
        /// <param name="description"> Textual description of the resource. </param>
        /// <param name="properties">
        /// A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </param>
        internal SeasonalField(string farmerId, string primaryBoundaryId, IReadOnlyList<string> boundaryIds, string farmId, string fieldId, string seasonId, IList<string> cropVarietyIds, string cropId, double? avgYieldValue, string avgYieldUnit, double? avgSeedPopulationValue, string avgSeedPopulationUnit, DateTimeOffset? plantingDateTime, string id, string eTag, string status, DateTimeOffset? createdDateTime, DateTimeOffset? modifiedDateTime, string name, string description, IDictionary<string, object> properties)
        {
            FarmerId = farmerId;
            PrimaryBoundaryId = primaryBoundaryId;
            BoundaryIds = boundaryIds;
            FarmId = farmId;
            FieldId = fieldId;
            SeasonId = seasonId;
            CropVarietyIds = cropVarietyIds;
            CropId = cropId;
            AvgYieldValue = avgYieldValue;
            AvgYieldUnit = avgYieldUnit;
            AvgSeedPopulationValue = avgSeedPopulationValue;
            AvgSeedPopulationUnit = avgSeedPopulationUnit;
            PlantingDateTime = plantingDateTime;
            Id = id;
            ETag = eTag;
            Status = status;
            CreatedDateTime = createdDateTime;
            ModifiedDateTime = modifiedDateTime;
            Name = name;
            Description = description;
            Properties = properties;
        }

        /// <summary> Farmer ID. </summary>
        public string FarmerId { get; }
        /// <summary> Primary boundary id. </summary>
        public string PrimaryBoundaryId { get; }
        /// <summary> Boundary Ids. </summary>
        public IReadOnlyList<string> BoundaryIds { get; }
        /// <summary> ID of the associated Farm. </summary>
        public string FarmId { get; set; }
        /// <summary> ID of the associated Field. </summary>
        public string FieldId { get; set; }
        /// <summary> ID of the season it belongs to. </summary>
        public string SeasonId { get; set; }
        /// <summary> CropVariety ids. </summary>
        public IList<string> CropVarietyIds { get; }
        /// <summary> ID of the crop it belongs to. </summary>
        public string CropId { get; set; }
        /// <summary> Average yield value of the seasonal field. </summary>
        public double? AvgYieldValue { get; set; }
        /// <summary> Unit of the average yield value attribute. </summary>
        public string AvgYieldUnit { get; set; }
        /// <summary> Average seed population value of the seasonal field. </summary>
        public double? AvgSeedPopulationValue { get; set; }
        /// <summary> Unit of average seed population value attribute. </summary>
        public string AvgSeedPopulationUnit { get; set; }
        /// <summary> Planting datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? PlantingDateTime { get; set; }
        /// <summary> Unique resource ID. </summary>
        public string Id { get; }
        /// <summary> The ETag value to implement optimistic concurrency. </summary>
        public string ETag { get; }
        /// <summary> Status of the resource. </summary>
        public string Status { get; set; }
        /// <summary> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? ModifiedDateTime { get; }
        /// <summary> Name to identify resource. </summary>
        public string Name { get; set; }
        /// <summary> Textual description of the resource. </summary>
        public string Description { get; set; }
        /// <summary>
        /// A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </summary>
        public IDictionary<string, object> Properties { get; }
    }
}
