// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A domain name that the managed instance service needs to communicate with, along with additional details. </summary>
    public partial class ManagedInstanceEndpointDependency
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceEndpointDependency"/>. </summary>
        internal ManagedInstanceEndpointDependency()
        {
            EndpointDetails = new ChangeTrackingList<ManagedInstanceEndpointDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceEndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The IP Addresses and Ports used when connecting to DomainName. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceEndpointDependency(string domainName, IReadOnlyList<ManagedInstanceEndpointDetail> endpointDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The domain name of the dependency. </summary>
        public string DomainName { get; }
        /// <summary> The IP Addresses and Ports used when connecting to DomainName. </summary>
        public IReadOnlyList<ManagedInstanceEndpointDetail> EndpointDetails { get; }
    }
}
