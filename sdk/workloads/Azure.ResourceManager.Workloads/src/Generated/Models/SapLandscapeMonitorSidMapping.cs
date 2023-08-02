// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the mapping for SID to Environment/Applications. </summary>
    public partial class SapLandscapeMonitorSidMapping
    {
        /// <summary> Initializes a new instance of SapLandscapeMonitorSidMapping. </summary>
        public SapLandscapeMonitorSidMapping()
        {
            TopSid = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SapLandscapeMonitorSidMapping. </summary>
        /// <param name="name"> Gets or sets the name of the grouping. </param>
        /// <param name="topSid"> Gets or sets the list of SID's. </param>
        internal SapLandscapeMonitorSidMapping(string name, IList<string> topSid)
        {
            Name = name;
            TopSid = topSid;
        }

        /// <summary> Gets or sets the name of the grouping. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the list of SID's. </summary>
        public IList<string> TopSid { get; }
    }
}
