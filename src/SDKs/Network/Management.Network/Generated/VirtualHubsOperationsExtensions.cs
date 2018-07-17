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
    /// Extension methods for VirtualHubsOperations.
    /// </summary>
    public static partial class VirtualHubsOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            public static VirtualHub Get(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName)
            {
                return operations.GetAsync(resourceGroupName, virtualHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualHub> GetAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a VirtualHub resource if it doesn't exist else updates the existing
            /// VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to create or update VirtualHub.
            /// </param>
            public static VirtualHub CreateOrUpdate(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualHubName, virtualHubParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a VirtualHub resource if it doesn't exist else updates the existing
            /// VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to create or update VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualHub> CreateOrUpdateAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualHubName, virtualHubParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates VirtualHub tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to update VirtualHub tags.
            /// </param>
            public static VirtualHub UpdateTags(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, virtualHubName, virtualHubParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates VirtualHub tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to update VirtualHub tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualHub> UpdateTagsAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, virtualHubName, virtualHubParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            public static void Delete(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName)
            {
                operations.DeleteAsync(resourceGroupName, virtualHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualHubName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the VirtualHubs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            public static IPage<VirtualHub> ListByResourceGroup(this IVirtualHubsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualHubs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualHub>> ListByResourceGroupAsync(this IVirtualHubsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VirtualHubs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VirtualHub> List(this IVirtualHubsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualHubs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualHub>> ListAsync(this IVirtualHubsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a VirtualHub resource if it doesn't exist else updates the existing
            /// VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to create or update VirtualHub.
            /// </param>
            public static VirtualHub BeginCreateOrUpdate(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualHubName, virtualHubParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a VirtualHub resource if it doesn't exist else updates the existing
            /// VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to create or update VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualHub> BeginCreateOrUpdateAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, VirtualHub virtualHubParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualHubName, virtualHubParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates VirtualHub tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to update VirtualHub tags.
            /// </param>
            public static VirtualHub BeginUpdateTags(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters)
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, virtualHubName, virtualHubParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates VirtualHub tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubParameters'>
            /// Parameters supplied to update VirtualHub tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualHub> BeginUpdateTagsAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, TagsObject virtualHubParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, virtualHubName, virtualHubParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            public static void BeginDelete(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a VirtualHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualHubsOperations operations, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualHubName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the VirtualHubs in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualHub> ListByResourceGroupNext(this IVirtualHubsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualHubs in a resource group.
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
            public static async Task<IPage<VirtualHub>> ListByResourceGroupNextAsync(this IVirtualHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VirtualHubs in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualHub> ListNext(this IVirtualHubsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VirtualHubs in a subscription.
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
            public static async Task<IPage<VirtualHub>> ListNextAsync(this IVirtualHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
