// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsIncidentRelation data model.
    /// Represents a relation between two resources
    /// </summary>
    public partial class SecurityInsightsIncidentRelationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentRelationData"/>. </summary>
        public SecurityInsightsIncidentRelationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentRelationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="relatedResourceId"> The resource ID of the related resource. </param>
        /// <param name="relatedResourceName"> The name of the related resource. </param>
        /// <param name="relatedResourceType"> The resource type of the related resource. </param>
        /// <param name="relatedResourceKind"> The resource kind of the related resource. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsIncidentRelationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier relatedResourceId, string relatedResourceName, ResourceType? relatedResourceType, string relatedResourceKind, ETag? etag, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            RelatedResourceId = relatedResourceId;
            RelatedResourceName = relatedResourceName;
            RelatedResourceType = relatedResourceType;
            RelatedResourceKind = relatedResourceKind;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the related resource. </summary>
        public ResourceIdentifier RelatedResourceId { get; set; }
        /// <summary> The name of the related resource. </summary>
        public string RelatedResourceName { get; }
        /// <summary> The resource type of the related resource. </summary>
        public ResourceType? RelatedResourceType { get; }
        /// <summary> The resource kind of the related resource. </summary>
        public string RelatedResourceKind { get; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
