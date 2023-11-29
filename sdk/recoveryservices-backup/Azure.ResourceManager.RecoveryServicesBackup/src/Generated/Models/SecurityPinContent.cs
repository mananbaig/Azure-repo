// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Base class for get security pin request body. </summary>
    public partial class SecurityPinContent
    {
        /// <summary> Initializes a new instance of <see cref="SecurityPinContent"/>. </summary>
        public SecurityPinContent()
        {
            ResourceGuardOperationRequests = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityPinContent"/>. </summary>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        internal SecurityPinContent(IList<string> resourceGuardOperationRequests)
        {
            ResourceGuardOperationRequests = resourceGuardOperationRequests;
        }

        /// <summary> ResourceGuard Operation Requests. </summary>
        public IList<string> ResourceGuardOperationRequests { get; }
    }
}
