// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocalNetworkGatewaysOperations.
    /// </summary>
    public static partial class LocalNetworkGatewaysOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            public static LocalNetworkGateway CreateOrUpdate(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, localNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> CreateOrUpdateAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified local network gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static LocalNetworkGateway Get(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                return operations.GetAsync(resourceGroupName, localNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified local network gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> GetAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static void Delete(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                operations.DeleteAsync(resourceGroupName, localNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a local network gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update local network gateway tags.
            /// </param>
            public static LocalNetworkGateway UpdateTags(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, TagsObject parameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, localNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a local network gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update local network gateway tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> UpdateTagsAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<LocalNetworkGateway> List(this ILocalNetworkGatewaysOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
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
            public static async Task<IPage<LocalNetworkGateway>> ListAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            public static LocalNetworkGateway BeginCreateOrUpdate(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, localNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> BeginCreateOrUpdateAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static void BeginDelete(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                operations.BeginDeleteAsync(resourceGroupName, localNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a local network gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update local network gateway tags.
            /// </param>
            public static LocalNetworkGateway BeginUpdateTags(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, TagsObject parameters)
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, localNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a local network gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update local network gateway tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> BeginUpdateTagsAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LocalNetworkGateway> ListNext(this ILocalNetworkGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
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
            public static async Task<IPage<LocalNetworkGateway>> ListNextAsync(this ILocalNetworkGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
