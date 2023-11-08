// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The TopologySingleResource. </summary>
    public partial class TopologySingleResource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TopologySingleResource"/>. </summary>
        internal TopologySingleResource()
        {
            Parents = new ChangeTrackingList<TopologySingleResourceParent>();
            Children = new ChangeTrackingList<TopologySingleResourceChild>();
        }

        /// <summary> Initializes a new instance of <see cref="TopologySingleResource"/>. </summary>
        /// <param name="resourceId"> Azure resource id. </param>
        /// <param name="severity"> The security severity of the resource. </param>
        /// <param name="recommendationsExist"> Indicates if the resource has security recommendations. </param>
        /// <param name="networkZones"> Indicates the resource connectivity level to the Internet (InternetFacing, Internal ,etc.). </param>
        /// <param name="topologyScore"> Score of the resource based on its security severity. </param>
        /// <param name="location"> The location of this resource. </param>
        /// <param name="parents"> Azure resources connected to this resource which are in higher level in the topology view. </param>
        /// <param name="children"> Azure resources connected to this resource which are in lower level in the topology view. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TopologySingleResource(ResourceIdentifier resourceId, string severity, bool? recommendationsExist, string networkZones, int? topologyScore, AzureLocation? location, IReadOnlyList<TopologySingleResourceParent> parents, IReadOnlyList<TopologySingleResourceChild> children, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            Severity = severity;
            RecommendationsExist = recommendationsExist;
            NetworkZones = networkZones;
            TopologyScore = topologyScore;
            Location = location;
            Parents = parents;
            Children = children;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Azure resource id. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The security severity of the resource. </summary>
        public string Severity { get; }
        /// <summary> Indicates if the resource has security recommendations. </summary>
        public bool? RecommendationsExist { get; }
        /// <summary> Indicates the resource connectivity level to the Internet (InternetFacing, Internal ,etc.). </summary>
        public string NetworkZones { get; }
        /// <summary> Score of the resource based on its security severity. </summary>
        public int? TopologyScore { get; }
        /// <summary> The location of this resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Azure resources connected to this resource which are in higher level in the topology view. </summary>
        public IReadOnlyList<TopologySingleResourceParent> Parents { get; }
        /// <summary> Azure resources connected to this resource which are in lower level in the topology view. </summary>
        public IReadOnlyList<TopologySingleResourceChild> Children { get; }
    }
}
