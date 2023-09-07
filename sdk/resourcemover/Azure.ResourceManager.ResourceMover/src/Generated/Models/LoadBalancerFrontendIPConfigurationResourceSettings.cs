// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines load balancer frontend IP configuration properties. </summary>
    public partial class LoadBalancerFrontendIPConfigurationResourceSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LoadBalancerFrontendIPConfigurationResourceSettings"/>. </summary>
        public LoadBalancerFrontendIPConfigurationResourceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerFrontendIPConfigurationResourceSettings"/>. </summary>
        /// <param name="name"> Gets or sets the frontend IP configuration name. </param>
        /// <param name="privateIPAddress">
        /// Gets or sets the IP address of the Load Balancer.This is only specified if a specific
        /// private IP address shall be allocated from the subnet specified in subnetRef.
        /// </param>
        /// <param name="privateIPAllocationMethod"> Gets or sets PrivateIP allocation method (Static/Dynamic). </param>
        /// <param name="subnet"> Defines reference to subnet. </param>
        /// <param name="zones"> Gets or sets the csv list of zones. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadBalancerFrontendIPConfigurationResourceSettings(string name, IPAddress privateIPAddress, string privateIPAllocationMethod, SubnetReferenceInfo subnet, string zones, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the frontend IP configuration name. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the IP address of the Load Balancer.This is only specified if a specific
        /// private IP address shall be allocated from the subnet specified in subnetRef.
        /// </summary>
        public IPAddress PrivateIPAddress { get; set; }
        /// <summary> Gets or sets PrivateIP allocation method (Static/Dynamic). </summary>
        public string PrivateIPAllocationMethod { get; set; }
        /// <summary> Defines reference to subnet. </summary>
        public SubnetReferenceInfo Subnet { get; set; }
        /// <summary> Gets or sets the csv list of zones. </summary>
        public string Zones { get; set; }
    }
}
