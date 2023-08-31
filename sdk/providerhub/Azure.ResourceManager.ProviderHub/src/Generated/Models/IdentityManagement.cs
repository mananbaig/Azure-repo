// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The IdentityManagement. </summary>
    internal partial class IdentityManagement
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IdentityManagement"/>. </summary>
        internal IdentityManagement()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IdentityManagement"/>. </summary>
        /// <param name="managementType"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IdentityManagement(IdentityManagementType? managementType, Dictionary<string, BinaryData> rawData)
        {
            ManagementType = managementType;
            _rawData = rawData;
        }

        /// <summary> Gets the management type. </summary>
        public IdentityManagementType? ManagementType { get; }
    }
}
