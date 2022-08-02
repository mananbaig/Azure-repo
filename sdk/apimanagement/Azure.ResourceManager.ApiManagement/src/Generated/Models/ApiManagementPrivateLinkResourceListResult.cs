// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class ApiManagementPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of ApiManagementPrivateLinkResourceListResult. </summary>
        internal ApiManagementPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<ApiManagementPrivateLinkData>();
        }

        /// <summary> Initializes a new instance of ApiManagementPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal ApiManagementPrivateLinkResourceListResult(IReadOnlyList<ApiManagementPrivateLinkData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<ApiManagementPrivateLinkData> Value { get; }
    }
}
