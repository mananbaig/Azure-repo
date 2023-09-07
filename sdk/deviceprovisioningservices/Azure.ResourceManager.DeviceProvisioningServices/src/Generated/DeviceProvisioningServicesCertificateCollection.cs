// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceProvisioningServicesCertificateResource" /> and their operations.
    /// Each <see cref="DeviceProvisioningServicesCertificateResource" /> in the collection will belong to the same instance of <see cref="DeviceProvisioningServiceResource" />.
    /// To get a <see cref="DeviceProvisioningServicesCertificateCollection" /> instance call the GetDeviceProvisioningServicesCertificates method from an instance of <see cref="DeviceProvisioningServiceResource" />.
    /// </summary>
    public partial class DeviceProvisioningServicesCertificateCollection : ArmCollection, IEnumerable<DeviceProvisioningServicesCertificateResource>, IAsyncEnumerable<DeviceProvisioningServicesCertificateResource>
    {
        private readonly ClientDiagnostics _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics;
        private readonly DpsCertificateRestOperations _deviceProvisioningServicesCertificateDpsCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesCertificateCollection"/> class for mocking. </summary>
        protected DeviceProvisioningServicesCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceProvisioningServicesCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", DeviceProvisioningServicesCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceProvisioningServicesCertificateResource.ResourceType, out string deviceProvisioningServicesCertificateDpsCertificateApiVersion);
            _deviceProvisioningServicesCertificateDpsCertificateRestClient = new DpsCertificateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServicesCertificateDpsCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceProvisioningServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceProvisioningServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add new certificate or update an existing certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The name of the certificate create or update. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceProvisioningServicesCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, DeviceProvisioningServicesCertificateData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesCertificateResource>(Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add new certificate or update an existing certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The name of the certificate create or update. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceProvisioningServicesCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, DeviceProvisioningServicesCertificateData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, ifMatch, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesCertificateResource>(Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the certificate from the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the certificate to retrieve. </param>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<DeviceProvisioningServicesCertificateResource>> GetAsync(string certificateName, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, ifMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the certificate from the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the certificate to retrieve. </param>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<DeviceProvisioningServicesCertificateResource> Get(string certificateName, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, ifMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the certificates tied to the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceProvisioningServicesCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceProvisioningServicesCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new DeviceProvisioningServicesCertificateResource(Client, DeviceProvisioningServicesCertificateData.DeserializeDeviceProvisioningServicesCertificateData(e)), _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics, Pipeline, "DeviceProvisioningServicesCertificateCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all the certificates tied to the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceProvisioningServicesCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceProvisioningServicesCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new DeviceProvisioningServicesCertificateResource(Client, DeviceProvisioningServicesCertificateData.DeserializeDeviceProvisioningServicesCertificateData(e)), _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics, Pipeline, "DeviceProvisioningServicesCertificateCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the certificate to retrieve. </param>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, ifMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the certificate to retrieve. </param>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, ifMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceProvisioningServicesCertificateResource> IEnumerable<DeviceProvisioningServicesCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceProvisioningServicesCertificateResource> IAsyncEnumerable<DeviceProvisioningServicesCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
