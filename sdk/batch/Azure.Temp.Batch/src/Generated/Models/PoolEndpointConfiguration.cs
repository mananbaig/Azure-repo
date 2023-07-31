// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> The endpoint configuration for a Pool. </summary>
    public partial class PoolEndpointConfiguration
    {
        /// <summary> Initializes a new instance of PoolEndpointConfiguration. </summary>
        /// <param name="inboundNATPools"> The maximum number of inbound NAT Pools per Batch Pool is 5. If the maximum number of inbound NAT Pools is exceeded the request fails with HTTP status code 400. This cannot be specified if the IPAddressProvisioningType is NoPublicIPAddresses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNATPools"/> is null. </exception>
        public PoolEndpointConfiguration(IEnumerable<InboundNATPool> inboundNATPools)
        {
            Argument.AssertNotNull(inboundNATPools, nameof(inboundNATPools));

            InboundNATPools = inboundNATPools.ToList();
        }

        /// <summary> Initializes a new instance of PoolEndpointConfiguration. </summary>
        /// <param name="inboundNATPools"> The maximum number of inbound NAT Pools per Batch Pool is 5. If the maximum number of inbound NAT Pools is exceeded the request fails with HTTP status code 400. This cannot be specified if the IPAddressProvisioningType is NoPublicIPAddresses. </param>
        internal PoolEndpointConfiguration(IList<InboundNATPool> inboundNATPools)
        {
            InboundNATPools = inboundNATPools;
        }

        /// <summary> The maximum number of inbound NAT Pools per Batch Pool is 5. If the maximum number of inbound NAT Pools is exceeded the request fails with HTTP status code 400. This cannot be specified if the IPAddressProvisioningType is NoPublicIPAddresses. </summary>
        public IList<InboundNATPool> InboundNATPools { get; }
    }
}
