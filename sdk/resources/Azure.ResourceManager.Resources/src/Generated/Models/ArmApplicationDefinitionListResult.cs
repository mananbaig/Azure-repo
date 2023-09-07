// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of managed application definitions. </summary>
    internal partial class ArmApplicationDefinitionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationDefinitionListResult"/>. </summary>
        internal ArmApplicationDefinitionListResult()
        {
            Value = new ChangeTrackingList<ArmApplicationDefinitionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationDefinitionListResult"/>. </summary>
        /// <param name="value"> The array of managed application definitions. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationDefinitionListResult(IReadOnlyList<ArmApplicationDefinitionData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The array of managed application definitions. </summary>
        public IReadOnlyList<ArmApplicationDefinitionData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
