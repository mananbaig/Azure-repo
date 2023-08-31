// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A rule governing the accessibility of a vault from a specific ip address or ip range. </summary>
    public partial class KeyVaultIPRule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultIPRule"/>. </summary>
        /// <param name="addressRange"> An IPv4 address range in CIDR notation, such as '124.56.78.91' (simple IP address) or '124.56.78.0/24' (all addresses that start with 124.56.78). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressRange"/> is null. </exception>
        public KeyVaultIPRule(string addressRange)
        {
            Argument.AssertNotNull(addressRange, nameof(addressRange));

            AddressRange = addressRange;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultIPRule"/>. </summary>
        /// <param name="addressRange"> An IPv4 address range in CIDR notation, such as '124.56.78.91' (simple IP address) or '124.56.78.0/24' (all addresses that start with 124.56.78). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultIPRule(string addressRange, Dictionary<string, BinaryData> rawData)
        {
            AddressRange = addressRange;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultIPRule"/> for deserialization. </summary>
        internal KeyVaultIPRule()
        {
        }

        /// <summary> An IPv4 address range in CIDR notation, such as '124.56.78.91' (simple IP address) or '124.56.78.0/24' (all addresses that start with 124.56.78). </summary>
        public string AddressRange { get; set; }
    }
}
