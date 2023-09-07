// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A list of custom entity store assignments. </summary>
    internal partial class CustomEntityStoreAssignmentsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentsListResult"/>. </summary>
        internal CustomEntityStoreAssignmentsListResult()
        {
            Value = new ChangeTrackingList<CustomEntityStoreAssignmentData>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentsListResult"/>. </summary>
        /// <param name="value"> Collection of custom entity store assignments. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomEntityStoreAssignmentsListResult(IReadOnlyList<CustomEntityStoreAssignmentData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Collection of custom entity store assignments. </summary>
        public IReadOnlyList<CustomEntityStoreAssignmentData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
