// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> Describes a query to be executed. </summary>
    public partial class ResourceQueryContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceQueryContent"/>. </summary>
        /// <param name="query"> The resources query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="query"/> is null. </exception>
        public ResourceQueryContent(string query)
        {
            Argument.AssertNotNull(query, nameof(query));

            Subscriptions = new ChangeTrackingList<string>();
            ManagementGroups = new ChangeTrackingList<string>();
            Query = query;
            Facets = new ChangeTrackingList<FacetRequest>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceQueryContent"/>. </summary>
        /// <param name="subscriptions"> Azure subscriptions against which to execute the query. </param>
        /// <param name="managementGroups"> Azure management groups against which to execute the query. Example: [ 'mg1', 'mg2' ]. </param>
        /// <param name="query"> The resources query. </param>
        /// <param name="options"> The query evaluation options. </param>
        /// <param name="facets"> An array of facet requests to be computed against the query result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceQueryContent(IList<string> subscriptions, IList<string> managementGroups, string query, ResourceQueryRequestOptions options, IList<FacetRequest> facets, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Subscriptions = subscriptions;
            ManagementGroups = managementGroups;
            Query = query;
            Options = options;
            Facets = facets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceQueryContent"/> for deserialization. </summary>
        internal ResourceQueryContent()
        {
        }

        /// <summary> Azure subscriptions against which to execute the query. </summary>
        public IList<string> Subscriptions { get; }
        /// <summary> Azure management groups against which to execute the query. Example: [ 'mg1', 'mg2' ]. </summary>
        public IList<string> ManagementGroups { get; }
        /// <summary> The resources query. </summary>
        public string Query { get; }
        /// <summary> The query evaluation options. </summary>
        public ResourceQueryRequestOptions Options { get; set; }
        /// <summary> An array of facet requests to be computed against the query result. </summary>
        public IList<FacetRequest> Facets { get; }
    }
}
