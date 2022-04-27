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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PartnerConfigurationsOperations.
    /// </summary>
    public static partial class PartnerConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Get a partner configuration.
            /// </summary>
            /// <remarks>
            /// Get properties of a partner configuration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static PartnerConfiguration Get(this IPartnerConfigurationsOperations operations, string resourceGroupName)
            {
                return operations.GetAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a partner configuration.
            /// </summary>
            /// <remarks>
            /// Get properties of a partner configuration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> GetAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously creates or updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationInfo'>
            /// Partner configuration information.
            /// </param>
            public static PartnerConfiguration CreateOrUpdate(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfiguration partnerConfigurationInfo)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, partnerConfigurationInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously creates or updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationInfo'>
            /// Partner configuration information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> CreateOrUpdateAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfiguration partnerConfigurationInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, partnerConfigurationInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a partner configuration.
            /// </summary>
            /// <remarks>
            /// Delete existing partner configuration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static void Delete(this IPartnerConfigurationsOperations operations, string resourceGroupName)
            {
                operations.DeleteAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a partner configuration.
            /// </summary>
            /// <remarks>
            /// Delete existing partner configuration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationUpdateParameters'>
            /// Partner configuration update information.
            /// </param>
            public static PartnerConfiguration Update(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfigurationUpdateParameters partnerConfigurationUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, partnerConfigurationUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationUpdateParameters'>
            /// Partner configuration update information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> UpdateAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfigurationUpdateParameters partnerConfigurationUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, partnerConfigurationUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List partner configurations under a resource group.
            /// </summary>
            /// <remarks>
            /// List all the partner configurations under a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static IEnumerable<PartnerConfiguration> ListByResourceGroup(this IPartnerConfigurationsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List partner configurations under a resource group.
            /// </summary>
            /// <remarks>
            /// List all the partner configurations under a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PartnerConfiguration>> ListByResourceGroupAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List partner configurations under an Azure subscription.
            /// </summary>
            /// <remarks>
            /// List all the partner configurations under an Azure subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static IPage<PartnerConfiguration> ListBySubscription(this IPartnerConfigurationsOperations operations, string filter = default(string), int? top = default(int?))
            {
                return operations.ListBySubscriptionAsync(filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List partner configurations under an Azure subscription.
            /// </summary>
            /// <remarks>
            /// List all the partner configurations under an Azure subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static async Task<IPage<PartnerConfiguration>> ListBySubscriptionAsync(this IPartnerConfigurationsOperations operations, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorize a partner.
            /// </summary>
            /// <remarks>
            /// Authorize a single partner either by partner registration immutable Id or
            /// by partner name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerInfo'>
            /// The information of the partner to be authorized.
            /// </param>
            public static PartnerConfiguration AuthorizePartner(this IPartnerConfigurationsOperations operations, string resourceGroupName, Partner partnerInfo)
            {
                return operations.AuthorizePartnerAsync(resourceGroupName, partnerInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorize a partner.
            /// </summary>
            /// <remarks>
            /// Authorize a single partner either by partner registration immutable Id or
            /// by partner name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerInfo'>
            /// The information of the partner to be authorized.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> AuthorizePartnerAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, Partner partnerInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AuthorizePartnerWithHttpMessagesAsync(resourceGroupName, partnerInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Unauthorize a partner.
            /// </summary>
            /// <remarks>
            /// Unauthorize a single partner either by partner registration immutable Id or
            /// by partner name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerInfo'>
            /// The information of the partner to be unauthorized.
            /// </param>
            public static PartnerConfiguration UnauthorizePartner(this IPartnerConfigurationsOperations operations, string resourceGroupName, Partner partnerInfo)
            {
                return operations.UnauthorizePartnerAsync(resourceGroupName, partnerInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unauthorize a partner.
            /// </summary>
            /// <remarks>
            /// Unauthorize a single partner either by partner registration immutable Id or
            /// by partner name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerInfo'>
            /// The information of the partner to be unauthorized.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> UnauthorizePartnerAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, Partner partnerInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UnauthorizePartnerWithHttpMessagesAsync(resourceGroupName, partnerInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously creates or updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationInfo'>
            /// Partner configuration information.
            /// </param>
            public static PartnerConfiguration BeginCreateOrUpdate(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfiguration partnerConfigurationInfo)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, partnerConfigurationInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously creates or updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationInfo'>
            /// Partner configuration information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> BeginCreateOrUpdateAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfiguration partnerConfigurationInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, partnerConfigurationInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a partner configuration.
            /// </summary>
            /// <remarks>
            /// Delete existing partner configuration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static void BeginDelete(this IPartnerConfigurationsOperations operations, string resourceGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a partner configuration.
            /// </summary>
            /// <remarks>
            /// Delete existing partner configuration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationUpdateParameters'>
            /// Partner configuration update information.
            /// </param>
            public static PartnerConfiguration BeginUpdate(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfigurationUpdateParameters partnerConfigurationUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, partnerConfigurationUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a partner configuration.
            /// </summary>
            /// <remarks>
            /// Synchronously updates a partner configuration with the specified
            /// parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='partnerConfigurationUpdateParameters'>
            /// Partner configuration update information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PartnerConfiguration> BeginUpdateAsync(this IPartnerConfigurationsOperations operations, string resourceGroupName, PartnerConfigurationUpdateParameters partnerConfigurationUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, partnerConfigurationUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List partner configurations under an Azure subscription.
            /// </summary>
            /// <remarks>
            /// List all the partner configurations under an Azure subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PartnerConfiguration> ListBySubscriptionNext(this IPartnerConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List partner configurations under an Azure subscription.
            /// </summary>
            /// <remarks>
            /// List all the partner configurations under an Azure subscription.
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
            public static async Task<IPage<PartnerConfiguration>> ListBySubscriptionNextAsync(this IPartnerConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
