// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// IPConfiguration in a NetworkInterface
    /// </summary>
    public partial class NetworkInterfaceIpConfiguration : ChildResource
    {
        private IList<ResourceId> _loadBalancerBackendAddressPools;
        
        /// <summary>
        /// Optional. Gets or sets the reference of
        /// LoadBalancerBackendAddressPool resource
        /// </summary>
        public IList<ResourceId> LoadBalancerBackendAddressPools
        {
            get { return this._loadBalancerBackendAddressPools; }
            set { this._loadBalancerBackendAddressPools = value; }
        }
        
        private IList<ResourceId> _loadBalancerInboundNatRules;
        
        /// <summary>
        /// Optional. Gets or sets list of references of
        /// LoadBalancerInboundNatRules
        /// </summary>
        public IList<ResourceId> LoadBalancerInboundNatRules
        {
            get { return this._loadBalancerInboundNatRules; }
            set { this._loadBalancerInboundNatRules = value; }
        }
        
        private string _privateIpAddress;
        
        /// <summary>
        /// Optional. Gets or sets the privateIPAddress of the Network
        /// Interface IP Configuration
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }
        
        private string _privateIpAllocationMethod;
        
        /// <summary>
        /// Optional. Gets or sets PrivateIP allocation method (Static/Dynamic)
        /// </summary>
        public string PrivateIpAllocationMethod
        {
            get { return this._privateIpAllocationMethod; }
            set { this._privateIpAllocationMethod = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private ResourceId _publicIpAddress;
        
        /// <summary>
        /// Optional. Gets or sets the reference of the PublicIP resource
        /// </summary>
        public ResourceId PublicIpAddress
        {
            get { return this._publicIpAddress; }
            set { this._publicIpAddress = value; }
        }
        
        private ResourceId _subnet;
        
        /// <summary>
        /// Optional. Gets or sets the reference of the subnet resource
        /// </summary>
        public ResourceId Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceIpConfiguration
        /// class.
        /// </summary>
        public NetworkInterfaceIpConfiguration()
        {
            this.LoadBalancerBackendAddressPools = new LazyList<ResourceId>();
            this.LoadBalancerInboundNatRules = new LazyList<ResourceId>();
        }
    }
}
