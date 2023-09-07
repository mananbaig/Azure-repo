// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Information about a tenant managing the subscription. </summary>
    public partial class ManagedByTenant
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedByTenant"/>. </summary>
        internal ManagedByTenant()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedByTenant"/>. </summary>
        /// <param name="tenantId"> The tenant ID of the managing tenant. This is a GUID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedByTenant(Guid? tenantId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The tenant ID of the managing tenant. This is a GUID. </summary>
        public Guid? TenantId { get; }
    }
}
