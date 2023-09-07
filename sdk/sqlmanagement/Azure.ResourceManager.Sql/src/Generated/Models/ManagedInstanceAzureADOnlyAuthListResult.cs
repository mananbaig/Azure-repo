// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of active directory only authentications. </summary>
    internal partial class ManagedInstanceAzureADOnlyAuthListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceAzureADOnlyAuthListResult"/>. </summary>
        internal ManagedInstanceAzureADOnlyAuthListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceAzureADOnlyAuthenticationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceAzureADOnlyAuthListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceAzureADOnlyAuthListResult(IReadOnlyList<ManagedInstanceAzureADOnlyAuthenticationData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceAzureADOnlyAuthenticationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
