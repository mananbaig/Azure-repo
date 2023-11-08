// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecuritySolutionList. </summary>
    internal partial class SecuritySolutionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionList"/>. </summary>
        internal SecuritySolutionList()
        {
            Value = new ChangeTrackingList<SecuritySolution>();
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySolutionList(IReadOnlyList<SecuritySolution> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecuritySolution> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
