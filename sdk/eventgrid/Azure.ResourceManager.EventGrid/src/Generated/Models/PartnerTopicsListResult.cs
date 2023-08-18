// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Partner Topics operation. </summary>
    internal partial class PartnerTopicsListResult
    {
        /// <summary> Initializes a new instance of PartnerTopicsListResult. </summary>
        internal PartnerTopicsListResult()
        {
            Value = new Core.ChangeTrackingList<PartnerTopicData>();
        }

        /// <summary> Initializes a new instance of PartnerTopicsListResult. </summary>
        /// <param name="value"> A collection of partner topics. </param>
        /// <param name="nextLink"> A link for the next page of partner topics. </param>
        internal PartnerTopicsListResult(IReadOnlyList<PartnerTopicData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of partner topics. </summary>
        public IReadOnlyList<PartnerTopicData> Value { get; }
        /// <summary> A link for the next page of partner topics. </summary>
        public string NextLink { get; }
    }
}
