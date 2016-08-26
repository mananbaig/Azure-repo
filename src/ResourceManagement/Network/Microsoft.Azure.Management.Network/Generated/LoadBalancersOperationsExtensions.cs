// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for LoadBalancersOperations.
    /// </summary>
    public static partial class LoadBalancersOperationsExtensions
    {
            /// <summary>
            /// The delete loadbalancer operation deletes the specified loadbalancer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            public static void Delete(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName)
            {
                Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).DeleteAsync(resourceGroupName, loadBalancerName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete loadbalancer operation deletes the specified loadbalancer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, loadBalancerName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete loadbalancer operation deletes the specified loadbalancer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            public static void BeginDelete(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName)
            {
                Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).BeginDeleteAsync(resourceGroupName, loadBalancerName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete loadbalancer operation deletes the specified loadbalancer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, loadBalancerName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get ntework interface operation retreives information about the
            /// specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static LoadBalancer Get(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).GetAsync(resourceGroupName, loadBalancerName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get ntework interface operation retreives information about the
            /// specified network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LoadBalancer> GetAsync(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, loadBalancerName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put LoadBalancer operation creates/updates a LoadBalancer
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete LoadBalancer operation
            /// </param>
            public static LoadBalancer CreateOrUpdate(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, LoadBalancer parameters)
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).CreateOrUpdateAsync(resourceGroupName, loadBalancerName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put LoadBalancer operation creates/updates a LoadBalancer
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete LoadBalancer operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LoadBalancer> CreateOrUpdateAsync(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, LoadBalancer parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, loadBalancerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put LoadBalancer operation creates/updates a LoadBalancer
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete LoadBalancer operation
            /// </param>
            public static LoadBalancer BeginCreateOrUpdate(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, LoadBalancer parameters)
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, loadBalancerName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put LoadBalancer operation creates/updates a LoadBalancer
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the loadBalancer.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete LoadBalancer operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LoadBalancer> BeginCreateOrUpdateAsync(this ILoadBalancersOperations operations, string resourceGroupName, string loadBalancerName, LoadBalancer parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, loadBalancerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<LoadBalancer> ListAll(this ILoadBalancersOperations operations)
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LoadBalancer>> ListAllAsync(this ILoadBalancersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<LoadBalancer> List(this ILoadBalancersOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// resource group.
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
            public static async Task<IPage<LoadBalancer>> ListAsync(this ILoadBalancersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LoadBalancer> ListAllNext(this ILoadBalancersOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// subscription.
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
            public static async Task<IPage<LoadBalancer>> ListAllNextAsync(this ILoadBalancersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LoadBalancer> ListNext(this ILoadBalancersOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ILoadBalancersOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List loadBalancer operation retrieves all the loadbalancers in a
            /// resource group.
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
            public static async Task<IPage<LoadBalancer>> ListNextAsync(this ILoadBalancersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
