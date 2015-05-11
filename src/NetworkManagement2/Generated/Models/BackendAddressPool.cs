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
    /// Pool of backend IP addresseses
    /// </summary>
    public partial class BackendAddressPool : ChildResource
    {
        private IList<ResourceId> _backendIpConfigurations;
        
        /// <summary>
        /// Optional. Gets collection of references to IPs defined in NICs
        /// </summary>
        public IList<ResourceId> BackendIpConfigurations
        {
            get { return this._backendIpConfigurations; }
            set { this._backendIpConfigurations = value; }
        }
        
        private IList<ResourceId> _loadBalancingRules;
        
        /// <summary>
        /// Optional. Gets Load Balancing rules that use this Backend Address
        /// Pool
        /// </summary>
        public IList<ResourceId> LoadBalancingRules
        {
            get { return this._loadBalancingRules; }
            set { this._loadBalancingRules = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackendAddressPool class.
        /// </summary>
        public BackendAddressPool()
        {
            this.BackendIpConfigurations = new LazyList<ResourceId>();
            this.LoadBalancingRules = new LazyList<ResourceId>();
        }
    }
}
