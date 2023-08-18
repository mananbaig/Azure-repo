// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The response of a list operation. </summary>
    internal partial class CustomImageList
    {
        /// <summary> Initializes a new instance of CustomImageList. </summary>
        internal CustomImageList()
        {
            Value = new Core.ChangeTrackingList<DevTestLabCustomImageData>();
        }

        /// <summary> Initializes a new instance of CustomImageList. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link for next set of results. </param>
        internal CustomImageList(IReadOnlyList<DevTestLabCustomImageData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<DevTestLabCustomImageData> Value { get; }
        /// <summary> Link for next set of results. </summary>
        public string NextLink { get; }
    }
}
