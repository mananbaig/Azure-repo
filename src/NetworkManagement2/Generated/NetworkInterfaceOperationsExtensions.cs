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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Windows Azure Network management API provides a RESTful set of web
    /// services that interact with Windows Azure Networks service to manage
    /// your network resrources. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Networks
    /// service.
    /// </summary>
    public static partial class NetworkInterfaceOperationsExtensions
    {
        /// <summary>
        /// The Put NetworkInterface operation creates/updates a
        /// networkInterface
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update NetworkInterface
        /// operation
        /// </param>
        /// <returns>
        /// Response for PutNetworkInterface Api servive call
        /// </returns>
        public static NetworkInterfacePutResponse BeginCreateOrUpdating(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).BeginCreateOrUpdatingAsync(resourceGroupName, networkInterfaceName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put NetworkInterface operation creates/updates a
        /// networkInterface
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update NetworkInterface
        /// operation
        /// </param>
        /// <returns>
        /// Response for PutNetworkInterface Api servive call
        /// </returns>
        public static Task<NetworkInterfacePutResponse> BeginCreateOrUpdatingAsync(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
        {
            return operations.BeginCreateOrUpdatingAsync(resourceGroupName, networkInterfaceName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The delete netwokInterface operation deletes the specified
        /// netwokInterface.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static UpdateOperationResponse BeginDeleting(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).BeginDeletingAsync(resourceGroupName, networkInterfaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The delete netwokInterface operation deletes the specified
        /// netwokInterface.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        public static Task<UpdateOperationResponse> BeginDeletingAsync(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, networkInterfaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Put NetworkInterface operation creates/updates a
        /// networkInterface
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update NetworkInterface
        /// operation
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static AzureAsyncOperationResponse CreateOrUpdate(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Put NetworkInterface operation creates/updates a
        /// networkInterface
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create/update NetworkInterface
        /// operation
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName, NetworkInterface parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).DeleteAsync(resourceGroupName, networkInterfaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName)
        {
            return operations.DeleteAsync(resourceGroupName, networkInterfaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get ntework interface operation retreives information about the
        /// specified network interface.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <returns>
        /// Response for GetNetworkInterface Api service call
        /// </returns>
        public static NetworkInterfaceGetResponse Get(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).GetAsync(resourceGroupName, networkInterfaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get ntework interface operation retreives information about the
        /// specified network interface.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// Required. The name of the network interface.
        /// </param>
        /// <returns>
        /// Response for GetNetworkInterface Api service call
        /// </returns>
        public static Task<NetworkInterfaceGetResponse> GetAsync(this INetworkInterfaceOperations operations, string resourceGroupName, string networkInterfaceName)
        {
            return operations.GetAsync(resourceGroupName, networkInterfaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List networkInterfaces opertion retrieves all the
        /// networkInterfaces in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListNetworkInterface Api service call
        /// </returns>
        public static NetworkInterfaceListResponse List(this INetworkInterfaceOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List networkInterfaces opertion retrieves all the
        /// networkInterfaces in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// Response for ListNetworkInterface Api service call
        /// </returns>
        public static Task<NetworkInterfaceListResponse> ListAsync(this INetworkInterfaceOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List networkInterfaces opertion retrieves all the
        /// networkInterfaces in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <returns>
        /// Response for ListNetworkInterface Api service call
        /// </returns>
        public static NetworkInterfaceListResponse ListAll(this INetworkInterfaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkInterfaceOperations)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List networkInterfaces opertion retrieves all the
        /// networkInterfaces in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkInterfaceOperations.
        /// </param>
        /// <returns>
        /// Response for ListNetworkInterface Api service call
        /// </returns>
        public static Task<NetworkInterfaceListResponse> ListAllAsync(this INetworkInterfaceOperations operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }
    }
}
