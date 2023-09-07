// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> The List availabilityStatus operation response. </summary>
    internal partial class ResourceHealthAvailabilityStatusListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthAvailabilityStatusListResult"/>. </summary>
        /// <param name="value"> The list of availabilityStatuses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ResourceHealthAvailabilityStatusListResult(IEnumerable<ResourceHealthAvailabilityStatus> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthAvailabilityStatusListResult"/>. </summary>
        /// <param name="value"> The list of availabilityStatuses. </param>
        /// <param name="nextLink"> The URI to fetch the next page of availabilityStatuses. Call ListNext() with this URI to fetch the next page of availabilityStatuses. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthAvailabilityStatusListResult(IReadOnlyList<ResourceHealthAvailabilityStatus> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthAvailabilityStatusListResult"/> for deserialization. </summary>
        internal ResourceHealthAvailabilityStatusListResult()
        {
        }

        /// <summary> The list of availabilityStatuses. </summary>
        public IReadOnlyList<ResourceHealthAvailabilityStatus> Value { get; }
        /// <summary> The URI to fetch the next page of availabilityStatuses. Call ListNext() with this URI to fetch the next page of availabilityStatuses. </summary>
        public string NextLink { get; }
    }
}
