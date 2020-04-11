// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// Get a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Get a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Get a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Update a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection object to update.
            /// </param>
            public static PrivateEndpointConnection Update(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection)
            {
                return operations.UpdateAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, privateEndpointConnection).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Update a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection object to update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> UpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, privateEndpointConnection, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Delete a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Delete a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all private endpoint connections under a resource.
            /// </summary>
            /// <remarks>
            /// Get all private endpoint connections under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            public static IPage<PrivateEndpointConnection> ListByResource(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListByResourceAsync(resourceGroupName, parentType, parentName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all private endpoint connections under a resource.
            /// </summary>
            /// <remarks>
            /// Get all private endpoint connections under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpointConnection>> ListByResourceAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceWithHttpMessagesAsync(resourceGroupName, parentType, parentName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Update a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection object to update.
            /// </param>
            public static PrivateEndpointConnection BeginUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection)
            {
                return operations.BeginUpdateAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, privateEndpointConnection).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Update a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The private endpoint connection object to update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, privateEndpointConnection, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Delete a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            public static void BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a specific private endpoint connection.
            /// </summary>
            /// <remarks>
            /// Delete a specific private endpoint connection under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\' or
            /// \'domains\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name or domain
            /// name).
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string parentType, string parentName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, parentType, parentName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all private endpoint connections under a resource.
            /// </summary>
            /// <remarks>
            /// Get all private endpoint connections under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateEndpointConnection> ListByResourceNext(this IPrivateEndpointConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all private endpoint connections under a resource.
            /// </summary>
            /// <remarks>
            /// Get all private endpoint connections under a topic or domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpointConnection>> ListByResourceNextAsync(this IPrivateEndpointConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
