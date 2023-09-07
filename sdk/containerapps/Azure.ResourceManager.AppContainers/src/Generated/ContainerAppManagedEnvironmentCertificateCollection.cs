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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppManagedEnvironmentCertificateResource" /> and their operations.
    /// Each <see cref="ContainerAppManagedEnvironmentCertificateResource" /> in the collection will belong to the same instance of <see cref="ContainerAppManagedEnvironmentResource" />.
    /// To get a <see cref="ContainerAppManagedEnvironmentCertificateCollection" /> instance call the GetContainerAppManagedEnvironmentCertificates method from an instance of <see cref="ContainerAppManagedEnvironmentResource" />.
    /// </summary>
    public partial class ContainerAppManagedEnvironmentCertificateCollection : ArmCollection, IEnumerable<ContainerAppManagedEnvironmentCertificateResource>, IAsyncEnumerable<ContainerAppManagedEnvironmentCertificateResource>
    {
        private readonly ClientDiagnostics _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics;
        private readonly CertificatesRestOperations _containerAppManagedEnvironmentCertificateCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentCertificateCollection"/> class for mocking. </summary>
        protected ContainerAppManagedEnvironmentCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppManagedEnvironmentCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppManagedEnvironmentCertificateResource.ResourceType, out string containerAppManagedEnvironmentCertificateCertificatesApiVersion);
            _containerAppManagedEnvironmentCertificateCertificatesRestClient = new CertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedEnvironmentCertificateCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppManagedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppManagedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="data"> Certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppManagedEnvironmentCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, ContainerAppCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentCertificateCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppManagedEnvironmentCertificateResource>(Response.FromValue(new ContainerAppManagedEnvironmentCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update a Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="data"> Certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppManagedEnvironmentCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, ContainerAppCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentCertificateCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppManagedEnvironmentCertificateResource>(Response.FromValue(new ContainerAppManagedEnvironmentCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Get the specified Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppManagedEnvironmentCertificateResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<ContainerAppManagedEnvironmentCertificateResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Certificates in a given managed environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppManagedEnvironmentCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppManagedEnvironmentCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentCertificateCertificatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppManagedEnvironmentCertificateCertificatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedEnvironmentCertificateResource(Client, ContainerAppCertificateData.DeserializeContainerAppCertificateData(e)), _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Certificates in a given managed environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppManagedEnvironmentCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppManagedEnvironmentCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentCertificateCertificatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppManagedEnvironmentCertificateCertificatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedEnvironmentCertificateResource(Client, ContainerAppCertificateData.DeserializeContainerAppCertificateData(e)), _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppManagedEnvironmentCertificateCertificatesClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppManagedEnvironmentCertificateResource> IEnumerable<ContainerAppManagedEnvironmentCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppManagedEnvironmentCertificateResource> IAsyncEnumerable<ContainerAppManagedEnvironmentCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
