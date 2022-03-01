// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Management resource preference to link device. </summary>
    internal partial class ManagementResourcePreferences
    {
        /// <summary> Initializes a new instance of ManagementResourcePreferences. </summary>
        public ManagementResourcePreferences()
        {
        }

        /// <summary> Initializes a new instance of ManagementResourcePreferences. </summary>
        /// <param name="preferredManagementResourceId"> Customer preferred Management resource ARM ID. </param>
        internal ManagementResourcePreferences(string preferredManagementResourceId)
        {
            PreferredManagementResourceId = preferredManagementResourceId;
        }

        /// <summary> Customer preferred Management resource ARM ID. </summary>
        public string PreferredManagementResourceId { get; set; }
    }
}
