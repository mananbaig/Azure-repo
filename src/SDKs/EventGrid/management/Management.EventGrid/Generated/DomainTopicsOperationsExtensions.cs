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
    /// Extension methods for DomainTopicsOperations.
    /// </summary>
    public static partial class DomainTopicsOperationsExtensions
    {
            /// <summary>
            /// Get a domain topic
            /// </summary>
            /// <remarks>
            /// Get properties of a domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the topic
            /// </param>
            public static DomainTopic Get(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName)
            {
                return operations.GetAsync(resourceGroupName, domainName, domainTopicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a domain topic
            /// </summary>
            /// <remarks>
            /// Get properties of a domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the topic
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainTopic> GetAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, domainName, domainTopicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a domain topic
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates a new domain topic with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            public static DomainTopic CreateOrUpdate(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, domainName, domainTopicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a domain topic
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates a new domain topic with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainTopic> CreateOrUpdateAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domainTopicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a domain topic
            /// </summary>
            /// <remarks>
            /// Delete existing domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            public static void Delete(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName)
            {
                operations.DeleteAsync(resourceGroupName, domainName, domainTopicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a domain topic
            /// </summary>
            /// <remarks>
            /// Delete existing domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, domainName, domainTopicName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List domain topics.
            /// </summary>
            /// <remarks>
            /// List all the topics in a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Domain name.
            /// </param>
            /// <param name='filter'>
            /// Filter the results using OData syntax.
            /// </param>
            /// <param name='top'>
            /// The number of results to return.
            /// </param>
            public static IPage<DomainTopic> ListByDomain(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListByDomainAsync(resourceGroupName, domainName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List domain topics.
            /// </summary>
            /// <remarks>
            /// List all the topics in a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Domain name.
            /// </param>
            /// <param name='filter'>
            /// Filter the results using OData syntax.
            /// </param>
            /// <param name='top'>
            /// The number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DomainTopic>> ListByDomainAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDomainWithHttpMessagesAsync(resourceGroupName, domainName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a domain topic
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates a new domain topic with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            public static DomainTopic BeginCreateOrUpdate(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, domainName, domainTopicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a domain topic
            /// </summary>
            /// <remarks>
            /// Asynchronously creates or updates a new domain topic with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainTopic> BeginCreateOrUpdateAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domainTopicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a domain topic
            /// </summary>
            /// <remarks>
            /// Delete existing domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            public static void BeginDelete(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName)
            {
                operations.BeginDeleteAsync(resourceGroupName, domainName, domainTopicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a domain topic
            /// </summary>
            /// <remarks>
            /// Delete existing domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainTopicName'>
            /// Name of the domain topic
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string domainTopicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, domainName, domainTopicName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List domain topics.
            /// </summary>
            /// <remarks>
            /// List all the topics in a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DomainTopic> ListByDomainNext(this IDomainTopicsOperations operations, string nextPageLink)
            {
                return operations.ListByDomainNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List domain topics.
            /// </summary>
            /// <remarks>
            /// List all the topics in a domain.
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
            public static async Task<IPage<DomainTopic>> ListByDomainNextAsync(this IDomainTopicsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDomainNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
