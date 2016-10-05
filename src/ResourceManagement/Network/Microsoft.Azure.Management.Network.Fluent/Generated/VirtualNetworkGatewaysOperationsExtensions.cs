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
    /// Extension methods for VirtualNetworkGatewaysOperations.
    /// </summary>
    public static partial class VirtualNetworkGatewaysOperationsExtensions
    {
            /// <summary>
            /// The Put VirtualNetworkGateway operation creates/updates a virtual network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Virtual Network Gateway
            /// operation through Network resource provider.
            /// </param>
            public static VirtualNetworkGatewayInner CreateOrUpdate(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).CreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetworkGateway operation creates/updates a virtual network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Virtual Network Gateway
            /// operation through Network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkGatewayInner> CreateOrUpdateAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put VirtualNetworkGateway operation creates/updates a virtual network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Virtual Network Gateway
            /// operation through Network resource provider.
            /// </param>
            public static VirtualNetworkGatewayInner BeginCreateOrUpdate(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put VirtualNetworkGateway operation creates/updates a virtual network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Virtual Network Gateway
            /// operation through Network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkGatewayInner> BeginCreateOrUpdateAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Get VirtualNetworkGateway operation retrieves information about the
            /// specified virtual network gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static VirtualNetworkGatewayInner Get(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).GetAsync(resourceGroupName, virtualNetworkGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get VirtualNetworkGateway operation retrieves information about the
            /// specified virtual network gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkGatewayInner> GetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Delete VirtualNetworkGateway operation deletes the specifed virtual
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static void Delete(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).DeleteAsync(resourceGroupName, virtualNetworkGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete VirtualNetworkGateway operation deletes the specifed virtual
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Delete VirtualNetworkGateway operation deletes the specifed virtual
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static void BeginDelete(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).BeginDeleteAsync(resourceGroupName, virtualNetworkGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete VirtualNetworkGateway operation deletes the specifed virtual
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The List VirtualNetworkGateways opertion retrieves all the virtual network
            /// gateways stored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<VirtualNetworkGatewayInner> List(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).ListAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List VirtualNetworkGateways opertion retrieves all the virtual network
            /// gateways stored.
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
            public static async Task<Microsoft.Rest.Azure.IPage<VirtualNetworkGatewayInner>> ListAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Reset VirtualNetworkGateway operation resets the primary of the
            /// virtual network gateway in the specified resource group through Network
            /// resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Reset Virtual Network Gateway operation
            /// through Network resource provider.
            /// </param>
            public static VirtualNetworkGatewayInner Reset(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).ResetAsync(resourceGroupName, virtualNetworkGatewayName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Reset VirtualNetworkGateway operation resets the primary of the
            /// virtual network gateway in the specified resource group through Network
            /// resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Reset Virtual Network Gateway operation
            /// through Network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkGatewayInner> ResetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ResetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Reset VirtualNetworkGateway operation resets the primary of the
            /// virtual network gateway in the specified resource group through Network
            /// resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Reset Virtual Network Gateway operation
            /// through Network resource provider.
            /// </param>
            public static VirtualNetworkGatewayInner BeginReset(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).BeginResetAsync(resourceGroupName, virtualNetworkGatewayName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Reset VirtualNetworkGateway operation resets the primary of the
            /// virtual network gateway in the specified resource group through Network
            /// resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Reset Virtual Network Gateway operation
            /// through Network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualNetworkGatewayInner> BeginResetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGatewayInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginResetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Generatevpnclientpackage operation generates Vpn client package for
            /// P2S client of the virtual network gateway in the specified resource group
            /// through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='processorArchitecture'>
            /// VPN client Processor Architecture -Amd64/X86. Possible values include:
            /// 'Amd64', 'X86'
            /// </param>
            public static string Generatevpnclientpackage(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string processorArchitecture = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).GeneratevpnclientpackageAsync(resourceGroupName, virtualNetworkGatewayName, processorArchitecture), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Generatevpnclientpackage operation generates Vpn client package for
            /// P2S client of the virtual network gateway in the specified resource group
            /// through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='processorArchitecture'>
            /// VPN client Processor Architecture -Amd64/X86. Possible values include:
            /// 'Amd64', 'X86'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<string> GeneratevpnclientpackageAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string processorArchitecture = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GeneratevpnclientpackageWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, processorArchitecture, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List VirtualNetworkGateways opertion retrieves all the virtual network
            /// gateways stored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<VirtualNetworkGatewayInner> ListNext(this IVirtualNetworkGatewaysOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualNetworkGatewaysOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List VirtualNetworkGateways opertion retrieves all the virtual network
            /// gateways stored.
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
            public static async Task<Microsoft.Rest.Azure.IPage<VirtualNetworkGatewayInner>> ListNextAsync(this IVirtualNetworkGatewaysOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
