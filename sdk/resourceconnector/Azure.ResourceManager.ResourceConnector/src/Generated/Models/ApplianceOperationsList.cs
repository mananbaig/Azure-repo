// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> Lists of Appliances operations. </summary>
    internal partial class ApplianceOperationsList
    {
        /// <summary> Initializes a new instance of ApplianceOperationsList. </summary>
        /// <param name="value"> Array of applianceOperation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ApplianceOperationsList(IEnumerable<ApplianceOperation> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ApplianceOperationsList. </summary>
        /// <param name="nextLink"> Next page of operations. </param>
        /// <param name="value"> Array of applianceOperation. </param>
        internal ApplianceOperationsList(string nextLink, IReadOnlyList<ApplianceOperation> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> Array of applianceOperation. </summary>
        public IReadOnlyList<ApplianceOperation> Value { get; }
    }
}
