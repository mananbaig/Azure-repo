// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Object that includes an array of resources and a possible link for next set. </summary>
    internal partial class ReportResourceList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReportResourceList"/>. </summary>
        internal ReportResourceList()
        {
            Value = new ChangeTrackingList<ReportResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ReportResourceList"/>. </summary>
        /// <param name="value"> List of the reports. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportResourceList(IReadOnlyList<ReportResourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of the reports. </summary>
        public IReadOnlyList<ReportResourceData> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
