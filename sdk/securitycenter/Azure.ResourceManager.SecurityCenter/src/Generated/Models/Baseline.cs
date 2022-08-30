// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Baseline details. </summary>
    public partial class Baseline
    {
        /// <summary> Initializes a new instance of Baseline. </summary>
        public Baseline()
        {
            ExpectedResults = new ChangeTrackingList<IList<string>>();
        }

        /// <summary> Initializes a new instance of Baseline. </summary>
        /// <param name="expectedResults"> Expected results. </param>
        /// <param name="updatedOn"> Baseline update time (UTC). </param>
        internal Baseline(IList<IList<string>> expectedResults, DateTimeOffset? updatedOn)
        {
            ExpectedResults = expectedResults;
            UpdatedOn = updatedOn;
        }

        /// <summary> Expected results. </summary>
        public IList<IList<string>> ExpectedResults { get; }
        /// <summary> Baseline update time (UTC). </summary>
        public DateTimeOffset? UpdatedOn { get; set; }
    }
}
