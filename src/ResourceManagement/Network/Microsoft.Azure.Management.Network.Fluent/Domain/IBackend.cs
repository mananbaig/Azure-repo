// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{

    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using System.Collections.Generic;
    /// <summary>
    /// An immutable client-side representation of an load balancer's backend address pool.
    /// </summary>
    public interface IBackend  :
        IWrapper<Microsoft.Azure.Management.Network.Fluent.Models.BackendAddressPoolInner>,
        IChildResource<Microsoft.Azure.Management.Network.Fluent.ILoadBalancer>,
        IHasLoadBalancingRules
    {
        /// <returns>a map of names of the IP configurations of network interfaces assigned to this backend,</returns>
        /// <returns>indexed by their NIC's resource id</returns>
        System.Collections.Generic.IDictionary<string,string> BackendNicIpConfigurationNames { get; }

        /// <returns>a list of the resource IDs of the virtual machines associated with this backend</returns>
        System.Collections.Generic.ISet<string> GetVirtualMachineIds();

    }
}