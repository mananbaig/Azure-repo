// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The AzureDevOpsOrgListResponse. </summary>
    internal partial class AzureDevOpsOrgListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsOrgListResponse"/>. </summary>
        internal AzureDevOpsOrgListResponse()
        {
            Value = new ChangeTrackingList<AzureDevOpsOrgData>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsOrgListResponse"/>. </summary>
        /// <param name="value"> Gets or sets list of resources. </param>
        /// <param name="nextLink"> Gets or sets next link to scroll over the results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsOrgListResponse(IReadOnlyList<AzureDevOpsOrgData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets list of resources. </summary>
        public IReadOnlyList<AzureDevOpsOrgData> Value { get; }
        /// <summary> Gets or sets next link to scroll over the results. </summary>
        public string NextLink { get; }
    }
}
