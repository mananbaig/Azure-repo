// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServicePrincipalsOperations.
    /// </summary>
    public static partial class ServicePrincipalsOperationsExtensions
    {
            /// <summary>
            /// Creates a service principal in the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create a service principal.
            /// </param>
            public static ServicePrincipalInner Create(this IServicePrincipalsOperations operations, ServicePrincipalCreateParametersInner parameters)
            {
                return operations.CreateAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a service principal in the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create a service principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalInner> CreateAsync(this IServicePrincipalsOperations operations, ServicePrincipalCreateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ServicePrincipalInner> List(this IServicePrincipalsOperations operations, ODataQuery<ServicePrincipalInner> odataQuery = default(ODataQuery<ServicePrincipalInner>))
            {
                return ((IServicePrincipalsOperations)operations).ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServicePrincipalInner>> ListAsync(this IServicePrincipalsOperations operations, ODataQuery<ServicePrincipalInner> odataQuery = default(ODataQuery<ServicePrincipalInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a service principal from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal to delete.
            /// </param>
            public static void Delete(this IServicePrincipalsOperations operations, string objectId)
            {
                operations.DeleteAsync(objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a service principal from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServicePrincipalsOperations operations, string objectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets service principal information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal to get.
            /// </param>
            public static ServicePrincipalInner Get(this IServicePrincipalsOperations operations, string objectId)
            {
                return operations.GetAsync(objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets service principal information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalInner> GetAsync(this IServicePrincipalsOperations operations, string objectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the keyCredentials associated with the specified service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal for which to get keyCredentials.
            /// </param>
            public static IEnumerable<KeyCredential> ListKeyCredentials(this IServicePrincipalsOperations operations, string objectId)
            {
                return operations.ListKeyCredentialsAsync(objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the keyCredentials associated with the specified service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal for which to get keyCredentials.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<KeyCredential>> ListKeyCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeyCredentialsWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the keyCredentials associated with a service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID for which to get service principal information.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update the keyCredentials of an existing service principal.
            /// </param>
            public static void UpdateKeyCredentials(this IServicePrincipalsOperations operations, string objectId, KeyCredentialsUpdateParametersInner parameters)
            {
                operations.UpdateKeyCredentialsAsync(objectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the keyCredentials associated with a service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID for which to get service principal information.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update the keyCredentials of an existing service principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateKeyCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, KeyCredentialsUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateKeyCredentialsWithHttpMessagesAsync(objectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the passwordCredentials associated with a service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal.
            /// </param>
            public static IEnumerable<Models.PasswordCredential> ListPasswordCredentials(this IServicePrincipalsOperations operations, string objectId)
            {
                return operations.ListPasswordCredentialsAsync(objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the passwordCredentials associated with a service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Models.PasswordCredential>> ListPasswordCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPasswordCredentialsWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the passwordCredentials associated with a service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update the passwordCredentials of an existing service
            /// principal.
            /// </param>
            public static void UpdatePasswordCredentials(this IServicePrincipalsOperations operations, string objectId, PasswordCredentialsUpdateParametersInner parameters)
            {
                operations.UpdatePasswordCredentialsAsync(objectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the passwordCredentials associated with a service principal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the service principal.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update the passwordCredentials of an existing service
            /// principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePasswordCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, PasswordCredentialsUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatePasswordCredentialsWithHttpMessagesAsync(objectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            public static IPage<ServicePrincipalInner> ListNext(this IServicePrincipalsOperations operations, string nextLink)
            {
                return operations.ListNextAsync(nextLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServicePrincipalInner>> ListNextAsync(this IServicePrincipalsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
