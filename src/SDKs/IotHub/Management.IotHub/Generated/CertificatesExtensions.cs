// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Iothub
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Certificates.
    /// </summary>
    public static partial class CertificatesExtensions
    {
            /// <summary>
            /// Get the certificate list.
            /// </summary>
            /// <remarks>
            /// Returns the list of certificates.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static CertificateListDescription ListByIotHub(this ICertificates operations, string resourceGroupName, string resourceName)
            {
                return operations.ListByIotHubAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the certificate list.
            /// </summary>
            /// <remarks>
            /// Returns the list of certificates.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateListDescription> ListByIotHubAsync(this ICertificates operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIotHubWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the certificate.
            /// </summary>
            /// <remarks>
            /// Returns the certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            public static CertificateDescription Get(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName)
            {
                return operations.GetAsync(resourceGroupName, resourceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the certificate.
            /// </summary>
            /// <remarks>
            /// Returns the certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateDescription> GetAsync(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upload the certificate to the IoT hub.
            /// </summary>
            /// <remarks>
            /// Adds new or replaces existing certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='certificateDescription'>
            /// The certificate body.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate. Do not specify for creating a brand new
            /// certificate. Required to update an existing certificate.
            /// </param>
            public static CertificateDescription CreateOrUpdate(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, CertificateBodyDescription certificateDescription, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, certificateName, certificateDescription, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upload the certificate to the IoT hub.
            /// </summary>
            /// <remarks>
            /// Adds new or replaces existing certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='certificateDescription'>
            /// The certificate body.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate. Do not specify for creating a brand new
            /// certificate. Required to update an existing certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateDescription> CreateOrUpdateAsync(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, CertificateBodyDescription certificateDescription, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, certificateName, certificateDescription, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an X509 certificate.
            /// </summary>
            /// <remarks>
            /// Deletes an existing X509 certificate or does nothing if it does not exist.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate.
            /// </param>
            public static void Delete(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, resourceName, certificateName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an X509 certificate.
            /// </summary>
            /// <remarks>
            /// Deletes an existing X509 certificate or does nothing if it does not exist.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, certificateName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Generate verification code for proof of possession flow.
            /// </summary>
            /// <remarks>
            /// Generates verification code for proof of possession flow. The verification
            /// code will be used to generate a leaf certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate.
            /// </param>
            public static CertificateWithNonceDescription GenerateVerificationCode(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, string ifMatch)
            {
                return operations.GenerateVerificationCodeAsync(resourceGroupName, resourceName, certificateName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate verification code for proof of possession flow.
            /// </summary>
            /// <remarks>
            /// Generates verification code for proof of possession flow. The verification
            /// code will be used to generate a leaf certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateWithNonceDescription> GenerateVerificationCodeAsync(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateVerificationCodeWithHttpMessagesAsync(resourceGroupName, resourceName, certificateName, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Verify certificate's private key possession.
            /// </summary>
            /// <remarks>
            /// Verifies the certificate's private key possession by providing the leaf
            /// cert issued by the verifying pre uploaded certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='certificateVerificationBody'>
            /// The name of the certificate
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate.
            /// </param>
            public static CertificateDescription Verify(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, CertificateVerificationDescription certificateVerificationBody, string ifMatch)
            {
                return operations.VerifyAsync(resourceGroupName, resourceName, certificateName, certificateVerificationBody, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Verify certificate's private key possession.
            /// </summary>
            /// <remarks>
            /// Verifies the certificate's private key possession by providing the leaf
            /// cert issued by the verifying pre uploaded certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate
            /// </param>
            /// <param name='certificateVerificationBody'>
            /// The name of the certificate
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateDescription> VerifyAsync(this ICertificates operations, string resourceGroupName, string resourceName, string certificateName, CertificateVerificationDescription certificateVerificationBody, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyWithHttpMessagesAsync(resourceGroupName, resourceName, certificateName, certificateVerificationBody, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
