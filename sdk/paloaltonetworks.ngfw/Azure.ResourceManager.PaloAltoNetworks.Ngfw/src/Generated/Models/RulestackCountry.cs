// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Country Description. </summary>
    public partial class RulestackCountry
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RulestackCountry"/>. </summary>
        /// <param name="code"> country code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> is null. </exception>
        internal RulestackCountry(string code)
        {
            Argument.AssertNotNull(code, nameof(code));

            Code = code;
        }

        /// <summary> Initializes a new instance of <see cref="RulestackCountry"/>. </summary>
        /// <param name="code"> country code. </param>
        /// <param name="description"> code description. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RulestackCountry(string code, string description, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Description = description;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulestackCountry"/> for deserialization. </summary>
        internal RulestackCountry()
        {
        }

        /// <summary> country code. </summary>
        public string Code { get; }
        /// <summary> code description. </summary>
        public string Description { get; }
    }
}
