// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to list tokens for a container registry. </summary>
    internal partial class ContainerRegistryTokenListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenListResult"/>. </summary>
        internal ContainerRegistryTokenListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryTokenData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenListResult"/>. </summary>
        /// <param name="value"> The list of tokens. Since this list may be incomplete, the nextLink field should be used to request the next list of tokens. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of tokens. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTokenListResult(IReadOnlyList<ContainerRegistryTokenData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of tokens. Since this list may be incomplete, the nextLink field should be used to request the next list of tokens. </summary>
        public IReadOnlyList<ContainerRegistryTokenData> Value { get; }
        /// <summary> The URI that can be used to request the next list of tokens. </summary>
        public string NextLink { get; }
    }
}
