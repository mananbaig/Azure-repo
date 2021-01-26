// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> List of job details. </summary>
    internal partial class JobDetailsList
    {
        /// <summary> Initializes a new instance of JobDetailsList. </summary>
        internal JobDetailsList()
        {
            Value = new ChangeTrackingList<JobDetails>();
        }

        /// <summary> Initializes a new instance of JobDetailsList. </summary>
        /// <param name="value"> . </param>
        /// <param name="count"> Total records count number. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal JobDetailsList(IReadOnlyList<JobDetails> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }
        /// <summary> Total records count number. </summary>
        public long? Count { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
