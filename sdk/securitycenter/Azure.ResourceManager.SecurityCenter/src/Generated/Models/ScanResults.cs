// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A list of vulnerability assessment scan results. </summary>
    internal partial class ScanResults
    {
        /// <summary> Initializes a new instance of ScanResults. </summary>
        internal ScanResults()
        {
            Value = new ChangeTrackingList<ScanResultData>();
        }

        /// <summary> Initializes a new instance of ScanResults. </summary>
        /// <param name="value"> List of vulnerability assessment scan results. </param>
        internal ScanResults(IReadOnlyList<ScanResultData> value)
        {
            Value = value;
        }

        /// <summary> List of vulnerability assessment scan results. </summary>
        public IReadOnlyList<ScanResultData> Value { get; }
    }
}
