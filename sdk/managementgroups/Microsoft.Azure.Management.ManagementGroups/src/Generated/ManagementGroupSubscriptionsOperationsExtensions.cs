// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagementGroupSubscriptionsOperations.
    /// </summary>
    public static partial class ManagementGroupSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Associates existing subscription with the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static void Create(this IManagementGroupSubscriptionsOperations operations, string groupId, string subscriptionId, string cacheControl = "no-cache")
            {
                operations.CreateAsync(groupId, subscriptionId, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates existing subscription with the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this IManagementGroupSubscriptionsOperations operations, string groupId, string subscriptionId, string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(groupId, subscriptionId, cacheControl, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// De-associates subscription from the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static void Delete(this IManagementGroupSubscriptionsOperations operations, string groupId, string subscriptionId, string cacheControl = "no-cache")
            {
                operations.DeleteAsync(groupId, subscriptionId, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// De-associates subscription from the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription ID.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagementGroupSubscriptionsOperations operations, string groupId, string subscriptionId, string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(groupId, subscriptionId, cacheControl, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
