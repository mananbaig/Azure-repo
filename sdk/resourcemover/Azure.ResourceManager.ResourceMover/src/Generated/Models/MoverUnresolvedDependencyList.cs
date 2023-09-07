// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Unresolved dependency collection. </summary>
    internal partial class MoverUnresolvedDependencyList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoverUnresolvedDependencyList"/>. </summary>
        internal MoverUnresolvedDependencyList()
        {
            Value = new ChangeTrackingList<MoverUnresolvedDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="MoverUnresolvedDependencyList"/>. </summary>
        /// <param name="value"> Gets or sets the list of unresolved dependencies. </param>
        /// <param name="nextLink"> Gets or sets the value of  next link. </param>
        /// <param name="summaryCollection"> Gets or sets the list of summary items and the field on which summary is done. </param>
        /// <param name="totalCount"> Gets the total count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverUnresolvedDependencyList(IReadOnlyList<MoverUnresolvedDependency> value, string nextLink, MoverSummaryList summaryCollection, long? totalCount, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            SummaryCollection = summaryCollection;
            TotalCount = totalCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the list of unresolved dependencies. </summary>
        public IReadOnlyList<MoverUnresolvedDependency> Value { get; }
        /// <summary> Gets or sets the value of  next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets or sets the list of summary items and the field on which summary is done. </summary>
        public MoverSummaryList SummaryCollection { get; }
        /// <summary> Gets the total count. </summary>
        public long? TotalCount { get; }
    }
}
