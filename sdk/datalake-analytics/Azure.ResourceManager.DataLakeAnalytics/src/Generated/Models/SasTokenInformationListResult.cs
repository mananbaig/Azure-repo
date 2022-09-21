// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary> The SAS response that contains the storage account, container and associated SAS token for connection use. </summary>
    internal partial class SasTokenInformationListResult
    {
        /// <summary> Initializes a new instance of SasTokenInformationListResult. </summary>
        internal SasTokenInformationListResult()
        {
            Value = new ChangeTrackingList<SasTokenInformation>();
        }

        /// <summary> Initializes a new instance of SasTokenInformationListResult. </summary>
        /// <param name="value"> The results of the list operation. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal SasTokenInformationListResult(IReadOnlyList<SasTokenInformation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The results of the list operation. </summary>
        public IReadOnlyList<SasTokenInformation> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
