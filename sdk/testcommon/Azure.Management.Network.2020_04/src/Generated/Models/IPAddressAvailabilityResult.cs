// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for CheckIPAddressAvailability API service call. </summary>
    public partial class IPAddressAvailabilityResult
    {
        /// <summary> Initializes a new instance of IPAddressAvailabilityResult. </summary>
        internal IPAddressAvailabilityResult()
        {
            AvailableIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IPAddressAvailabilityResult. </summary>
        /// <param name="available"> Private IP address availability. </param>
        /// <param name="availableIPAddresses"> Contains other available private IP addresses if the asked for address is taken. </param>
        internal IPAddressAvailabilityResult(bool? available, IReadOnlyList<string> availableIPAddresses)
        {
            Available = available;
            AvailableIPAddresses = availableIPAddresses;
        }

        /// <summary> Private IP address availability. </summary>
        public bool? Available { get; }
        /// <summary> Contains other available private IP addresses if the asked for address is taken. </summary>
        public IReadOnlyList<string> AvailableIPAddresses { get; }
    }
}
