// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CertificatesOperations.
    /// </summary>
    public static partial class CertificatesOperationsExtensions
    {
            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<CertificateInner> List(this ICertificatesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateInner>> ListAsync(this ICertificatesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            public static IPage<CertificateInner> ListByResourceGroup(this ICertificatesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateInner>> ListByResourceGroupAsync(this ICertificatesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a certificate.
            /// </summary>
            /// <remarks>
            /// Get a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            public static CertificateInner Get(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                return operations.GetAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a certificate.
            /// </summary>
            /// <remarks>
            /// Get a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> GetAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static CertificateInner CreateOrUpdate(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, certificateEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> CreateOrUpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a certificate.
            /// </summary>
            /// <remarks>
            /// Delete a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            public static void Delete(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                operations.DeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a certificate.
            /// </summary>
            /// <remarks>
            /// Delete a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static CertificateInner Update(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope)
            {
                return operations.UpdateAsync(resourceGroupName, name, certificateEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> UpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CertificateInner> ListNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
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
            public static async Task<IPage<CertificateInner>> ListNextAsync(this ICertificatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CertificateInner> ListByResourceGroupNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
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
            public static async Task<IPage<CertificateInner>> ListByResourceGroupNextAsync(this ICertificatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
