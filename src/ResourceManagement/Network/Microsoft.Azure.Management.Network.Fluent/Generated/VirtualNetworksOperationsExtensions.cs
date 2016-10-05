// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for VirtualNetworksOperations.
    /// </summary>
    public static partial class VirtualNetworksOperationsExtensions
    {
            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static void Delete(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).DeleteAsync(resourceGroupName, virtualNetworkName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static void BeginDelete(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).BeginDeleteAsync(resourceGroupName, virtualNetworkName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete VirtualNetwork operation deletes the specifed virtual network
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get VirtualNetwork operation retrieves information about the specified
            /// virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static VirtualNetworkInner Get(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string expand = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).GetAsync(resourceGroupName, virtualNetworkName, expand), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get VirtualNetwork operation retrieves information about the specified
            /// virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkInner> GetAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            public static VirtualNetworkInner CreateOrUpdate(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetworkInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkInner> CreateOrUpdateAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetworkInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            public static VirtualNetworkInner BeginCreateOrUpdate(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetworkInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetwork operation creates/updates a virtual network in the
            /// specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update Virtual Network operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkInner> BeginCreateOrUpdateAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetworkInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<VirtualNetworkInner> ListAll(this IVirtualNetworksOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListAllAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<VirtualNetworkInner>> ListAllAsync(this IVirtualNetworksOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<VirtualNetworkInner> List(this IVirtualNetworksOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<VirtualNetworkInner>> ListAsync(this IVirtualNetworksOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<VirtualNetworkInner> ListAllNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListAllNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<VirtualNetworkInner>> ListAllNextAsync(this IVirtualNetworksOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<VirtualNetworkInner> ListNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworksOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The list VirtualNetwork returns all Virtual Networks in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<VirtualNetworkInner>> ListNextAsync(this IVirtualNetworksOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
