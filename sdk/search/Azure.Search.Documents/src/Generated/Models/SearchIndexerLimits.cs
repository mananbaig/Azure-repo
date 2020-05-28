// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The SearchIndexerLimits. </summary>
    public partial class SearchIndexerLimits
    {
        /// <summary> Initializes a new instance of SearchIndexerLimits. </summary>
        internal SearchIndexerLimits()
        {
        }

        /// <summary> Initializes a new instance of SearchIndexerLimits. </summary>
        /// <param name="maxRunTime"> The maximum duration that the indexer is permitted to run for one execution. </param>
        /// <param name="maxDocumentExtractionSize"> The maximum size of a document, in bytes, which will be considered valid for indexing. </param>
        /// <param name="maxDocumentContentCharactersToExtract"> The maximum number of characters that will be extracted from a document picked up for indexing. </param>
        internal SearchIndexerLimits(TimeSpan? maxRunTime, long? maxDocumentExtractionSize, long? maxDocumentContentCharactersToExtract)
        {
            MaxRunTime = maxRunTime;
            MaxDocumentExtractionSize = maxDocumentExtractionSize;
            MaxDocumentContentCharactersToExtract = maxDocumentContentCharactersToExtract;
        }

        /// <summary> The maximum duration that the indexer is permitted to run for one execution. </summary>
        public TimeSpan? MaxRunTime { get; }
        /// <summary> The maximum size of a document, in bytes, which will be considered valid for indexing. </summary>
        public long? MaxDocumentExtractionSize { get; }
        /// <summary> The maximum number of characters that will be extracted from a document picked up for indexing. </summary>
        public long? MaxDocumentContentCharactersToExtract { get; }
    }
}
