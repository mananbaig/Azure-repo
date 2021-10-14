// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LabsOperations.
    /// </summary>
    public static partial class LabsOperationsExtensions
    {
            /// <summary>
            /// Get all labs for a subscription.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply to the operation.
            /// </param>
            public static IPage<Lab> ListBySubscription(this ILabsOperations operations, string filter = default(string))
            {
                return operations.ListBySubscriptionAsync(filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all labs for a subscription.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Lab>> ListBySubscriptionAsync(this ILabsOperations operations, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all labs for a subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<Lab> ListByResourceGroup(this ILabsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all labs for a subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Lab>> ListByResourceGroupAsync(this ILabsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a lab resource.
            /// </summary>
            /// <remarks>
            /// Returns the properties of a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static Lab Get(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                return operations.GetAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a lab resource.
            /// </summary>
            /// <remarks>
            /// Returns the properties of a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> GetAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to create or update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static Lab CreateOrUpdate(this ILabsOperations operations, Lab body, string resourceGroupName, string labName)
            {
                return operations.CreateOrUpdateAsync(body, resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to create or update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> CreateOrUpdateAsync(this ILabsOperations operations, Lab body, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(body, resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static Lab Update(this ILabsOperations operations, LabUpdate body, string resourceGroupName, string labName)
            {
                return operations.UpdateAsync(body, resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> UpdateAsync(this ILabsOperations operations, LabUpdate body, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(body, resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to delete a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static void Delete(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                operations.DeleteAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to delete a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Publish or re-publish a lab.
            /// </summary>
            /// <remarks>
            /// Publish or re-publish a lab. This will create or update all lab resources,
            /// such as virtual machines.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static void Publish(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                operations.PublishAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Publish or re-publish a lab.
            /// </summary>
            /// <remarks>
            /// Publish or re-publish a lab. This will create or update all lab resources,
            /// such as virtual machines.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PublishAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PublishWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Manually sync the lab group.
            /// </summary>
            /// <remarks>
            /// Action used to manually kick off an AAD group sync job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static void SyncGroup(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                operations.SyncGroupAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Manually sync the lab group.
            /// </summary>
            /// <remarks>
            /// Action used to manually kick off an AAD group sync job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SyncGroupAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SyncGroupWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to create or update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static Lab BeginCreateOrUpdate(this ILabsOperations operations, Lab body, string resourceGroupName, string labName)
            {
                return operations.BeginCreateOrUpdateAsync(body, resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to create or update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> BeginCreateOrUpdateAsync(this ILabsOperations operations, Lab body, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(body, resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static Lab BeginUpdate(this ILabsOperations operations, LabUpdate body, string resourceGroupName, string labName)
            {
                return operations.BeginUpdateAsync(body, resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to update a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The request body.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Lab> BeginUpdateAsync(this ILabsOperations operations, LabUpdate body, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(body, resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to delete a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static void BeginDelete(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                operations.BeginDeleteAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a lab resource.
            /// </summary>
            /// <remarks>
            /// Operation to delete a lab resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Publish or re-publish a lab.
            /// </summary>
            /// <remarks>
            /// Publish or re-publish a lab. This will create or update all lab resources,
            /// such as virtual machines.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static void BeginPublish(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                operations.BeginPublishAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Publish or re-publish a lab.
            /// </summary>
            /// <remarks>
            /// Publish or re-publish a lab. This will create or update all lab resources,
            /// such as virtual machines.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPublishAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPublishWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Manually sync the lab group.
            /// </summary>
            /// <remarks>
            /// Action used to manually kick off an AAD group sync job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            public static void BeginSyncGroup(this ILabsOperations operations, string resourceGroupName, string labName)
            {
                operations.BeginSyncGroupAsync(resourceGroupName, labName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Manually sync the lab group.
            /// </summary>
            /// <remarks>
            /// Action used to manually kick off an AAD group sync job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab that uniquely identifies it within containing lab
            /// account. Used in resource URIs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginSyncGroupAsync(this ILabsOperations operations, string resourceGroupName, string labName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginSyncGroupWithHttpMessagesAsync(resourceGroupName, labName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all labs for a subscription.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Lab> ListBySubscriptionNext(this ILabsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all labs for a subscription.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs for a subscription.
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
            public static async Task<IPage<Lab>> ListBySubscriptionNextAsync(this ILabsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all labs for a subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Lab> ListByResourceGroupNext(this ILabsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all labs for a subscription and resource group.
            /// </summary>
            /// <remarks>
            /// Returns a list of all labs in a resource group.
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
            public static async Task<IPage<Lab>> ListByResourceGroupNextAsync(this ILabsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
