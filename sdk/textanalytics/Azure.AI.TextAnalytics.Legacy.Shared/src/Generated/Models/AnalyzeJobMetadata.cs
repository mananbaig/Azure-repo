// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The AnalyzeJobMetadata. </summary>
    internal partial class AnalyzeJobMetadata : JobMetadata
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeJobMetadata"/>. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal AnalyzeJobMetadata(DateTimeOffset createdDateTime, Guid jobId, DateTimeOffset lastUpdateDateTime, State status) : base(createdDateTime, jobId, lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeJobMetadata"/>. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="displayName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeJobMetadata(DateTimeOffset createdDateTime, DateTimeOffset? expirationDateTime, Guid jobId, DateTimeOffset lastUpdateDateTime, State status, string displayName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(createdDateTime, expirationDateTime, jobId, lastUpdateDateTime, status, serializedAdditionalRawData)
        {
            DisplayName = displayName;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeJobMetadata"/> for deserialization. </summary>
        internal AnalyzeJobMetadata()
        {
        }

        /// <summary> Gets the display name. </summary>
        public string DisplayName { get; }
    }
}
