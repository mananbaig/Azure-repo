// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The RulestackAppIdListResult. </summary>
    internal partial class RulestackAppIdListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RulestackAppIdListResult"/>. </summary>
        /// <param name="value"> List of AppIds. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RulestackAppIdListResult(IEnumerable<string> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RulestackAppIdListResult"/>. </summary>
        /// <param name="value"> List of AppIds. </param>
        /// <param name="nextLink"> next Link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RulestackAppIdListResult(IReadOnlyList<string> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulestackAppIdListResult"/> for deserialization. </summary>
        internal RulestackAppIdListResult()
        {
        }

        /// <summary> List of AppIds. </summary>
        public IReadOnlyList<string> Value { get; }
        /// <summary> next Link. </summary>
        public string NextLink { get; }
    }
}
