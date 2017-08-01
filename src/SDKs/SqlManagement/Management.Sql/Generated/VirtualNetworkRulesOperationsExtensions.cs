// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualNetworkRulesOperations.
    /// </summary>
    public static partial class VirtualNetworkRulesOperationsExtensions
    {
            /// <summary>
            /// Gets a virtual network rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            public static VirtualNetworkRule Get(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName)
            {
                return operations.GetAsync(resourceGroupName, serverName, virtualNetworkRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a virtual network rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkRule> GetAsync(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, virtualNetworkRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an existing virtual network rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='parameters'>
            /// The requested virtual Network Rule Resource state.
            /// </param>
            public static VirtualNetworkRule CreateOrUpdate(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, VirtualNetworkRule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, virtualNetworkRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an existing virtual network rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='parameters'>
            /// The requested virtual Network Rule Resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkRule> CreateOrUpdateAsync(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, VirtualNetworkRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, virtualNetworkRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the virtual network rule with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            public static void Delete(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, virtualNetworkRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the virtual network rule with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, virtualNetworkRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of virtual network rules in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IPage<VirtualNetworkRule> ListByServer(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual network rules in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkRule>> ListByServerAsync(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an existing virtual network rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='parameters'>
            /// The requested virtual Network Rule Resource state.
            /// </param>
            public static VirtualNetworkRule BeginCreateOrUpdate(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, VirtualNetworkRule parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, virtualNetworkRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an existing virtual network rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='parameters'>
            /// The requested virtual Network Rule Resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkRule> BeginCreateOrUpdateAsync(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, VirtualNetworkRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, virtualNetworkRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the virtual network rule with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            public static void BeginDelete(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, virtualNetworkRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the virtual network rule with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='virtualNetworkRuleName'>
            /// The name of the virtual network rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworkRulesOperations operations, string resourceGroupName, string serverName, string virtualNetworkRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, virtualNetworkRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of virtual network rules in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkRule> ListByServerNext(this IVirtualNetworkRulesOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual network rules in a server.
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
            public static async Task<IPage<VirtualNetworkRule>> ListByServerNextAsync(this IVirtualNetworkRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
