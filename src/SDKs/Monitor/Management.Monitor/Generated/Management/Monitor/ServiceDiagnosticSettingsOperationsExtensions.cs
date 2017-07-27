// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceDiagnosticSettingsOperations.
    /// </summary>
    public static partial class ServiceDiagnosticSettingsOperationsExtensions
    {
            /// <summary>
            /// Gets the active diagnostic settings for the specified resource.
            /// **WARNING**: This method will be deprecated in future releases.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            public static ServiceDiagnosticSettingsResource Get(this IServiceDiagnosticSettingsOperations operations, string resourceUri)
            {
                return operations.GetAsync(resourceUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the active diagnostic settings for the specified resource.
            /// **WARNING**: This method will be deprecated in future releases.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceDiagnosticSettingsResource> GetAsync(this IServiceDiagnosticSettingsOperations operations, string resourceUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update new diagnostic settings for the specified resource.
            /// **WARNING**: This method will be deprecated in future releases.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static ServiceDiagnosticSettingsResource CreateOrUpdate(this IServiceDiagnosticSettingsOperations operations, string resourceUri, ServiceDiagnosticSettingsResource parameters)
            {
                return operations.CreateOrUpdateAsync(resourceUri, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update new diagnostic settings for the specified resource.
            /// **WARNING**: This method will be deprecated in future releases.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceDiagnosticSettingsResource> CreateOrUpdateAsync(this IServiceDiagnosticSettingsOperations operations, string resourceUri, ServiceDiagnosticSettingsResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceUri, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing ServiceDiagnosticSettingsResource. To update other
            /// fields use the CreateOrUpdate method. **WARNING**: This method will be
            /// deprecated in future releases.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='serviceDiagnosticSettingsResource'>
            /// Parameters supplied to the operation.
            /// </param>
            public static ServiceDiagnosticSettingsResource Update(this IServiceDiagnosticSettingsOperations operations, string resourceUri, ServiceDiagnosticSettingsResourcePatch serviceDiagnosticSettingsResource)
            {
                return operations.UpdateAsync(resourceUri, serviceDiagnosticSettingsResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing ServiceDiagnosticSettingsResource. To update other
            /// fields use the CreateOrUpdate method. **WARNING**: This method will be
            /// deprecated in future releases.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='serviceDiagnosticSettingsResource'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceDiagnosticSettingsResource> UpdateAsync(this IServiceDiagnosticSettingsOperations operations, string resourceUri, ServiceDiagnosticSettingsResourcePatch serviceDiagnosticSettingsResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceUri, serviceDiagnosticSettingsResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
