// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB indexing policy. </summary>
    public partial class CosmosDBIndexingPolicy
    {
        /// <summary> Initializes a new instance of CosmosDBIndexingPolicy. </summary>
        public CosmosDBIndexingPolicy()
        {
            IncludedPaths = new ChangeTrackingList<CosmosDBIncludedPath>();
            ExcludedPaths = new ChangeTrackingList<CosmosDBExcludedPath>();
            CompositeIndexes = new ChangeTrackingList<IList<CosmosDBCompositePath>>();
            SpatialIndexes = new ChangeTrackingList<SpatialSpec>();
        }

        /// <summary> Initializes a new instance of CosmosDBIndexingPolicy. </summary>
        /// <param name="isAutomatic"> Indicates if the indexing policy is automatic. </param>
        /// <param name="indexingMode"> Indicates the indexing mode. </param>
        /// <param name="includedPaths"> List of paths to include in the indexing. </param>
        /// <param name="excludedPaths"> List of paths to exclude from indexing. </param>
        /// <param name="compositeIndexes"> List of composite path list. </param>
        /// <param name="spatialIndexes"> List of spatial specifics. </param>
        internal CosmosDBIndexingPolicy(bool? isAutomatic, CosmosDBIndexingMode? indexingMode, IList<CosmosDBIncludedPath> includedPaths, IList<CosmosDBExcludedPath> excludedPaths, IList<IList<CosmosDBCompositePath>> compositeIndexes, IList<SpatialSpec> spatialIndexes)
        {
            IsAutomatic = isAutomatic;
            IndexingMode = indexingMode;
            IncludedPaths = includedPaths;
            ExcludedPaths = excludedPaths;
            CompositeIndexes = compositeIndexes;
            SpatialIndexes = spatialIndexes;
        }

        /// <summary> Indicates if the indexing policy is automatic. </summary>
        public bool? IsAutomatic { get; set; }
        /// <summary> Indicates the indexing mode. </summary>
        public CosmosDBIndexingMode? IndexingMode { get; set; }
        /// <summary> List of paths to include in the indexing. </summary>
        public IList<CosmosDBIncludedPath> IncludedPaths { get; }
        /// <summary> List of paths to exclude from indexing. </summary>
        public IList<CosmosDBExcludedPath> ExcludedPaths { get; }
        /// <summary> List of composite path list. </summary>
        public IList<IList<CosmosDBCompositePath>> CompositeIndexes { get; }
        /// <summary> List of spatial specifics. </summary>
        public IList<SpatialSpec> SpatialIndexes { get; }
    }
}
