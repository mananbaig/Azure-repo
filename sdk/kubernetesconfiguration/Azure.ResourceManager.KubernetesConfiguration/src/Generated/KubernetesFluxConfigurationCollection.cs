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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="KubernetesFluxConfigurationResource" /> and their operations.
    /// Each <see cref="KubernetesFluxConfigurationResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="KubernetesFluxConfigurationCollection" /> instance call the GetKubernetesFluxConfigurations method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class KubernetesFluxConfigurationCollection : ArmCollection, IEnumerable<KubernetesFluxConfigurationResource>, IAsyncEnumerable<KubernetesFluxConfigurationResource>
    {
        private readonly ClientDiagnostics _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics;
        private readonly FluxConfigurationsRestOperations _kubernetesFluxConfigurationFluxConfigurationsRestClient;
        private readonly string _clusterRp;
        private readonly string _clusterResourceName;
        private readonly string _clusterName;

        /// <summary> Initializes a new instance of the <see cref="KubernetesFluxConfigurationCollection"/> class for mocking. </summary>
        protected KubernetesFluxConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KubernetesFluxConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        internal KubernetesFluxConfigurationCollection(ArmClient client, ResourceIdentifier id, string clusterRp, string clusterResourceName, string clusterName) : base(client, id)
        {
            _clusterRp = clusterRp;
            _clusterResourceName = clusterResourceName;
            _clusterName = clusterName;
            _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KubernetesConfiguration", KubernetesFluxConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KubernetesFluxConfigurationResource.ResourceType, out string kubernetesFluxConfigurationFluxConfigurationsApiVersion);
            _kubernetesFluxConfigurationFluxConfigurationsRestClient = new FluxConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kubernetesFluxConfigurationFluxConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Kubernetes Flux Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="data"> Properties necessary to Create a FluxConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KubernetesFluxConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fluxConfigurationName, KubernetesFluxConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KubernetesConfigurationArmOperation<KubernetesFluxConfigurationResource>(new KubernetesFluxConfigurationOperationSource(Client), _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics, Pipeline, _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new Kubernetes Flux Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="data"> Properties necessary to Create a FluxConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KubernetesFluxConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string fluxConfigurationName, KubernetesFluxConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, data, cancellationToken);
                var operation = new KubernetesConfigurationArmOperation<KubernetesFluxConfigurationResource>(new KubernetesFluxConfigurationOperationSource(Client), _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics, Pipeline, _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets details of the Flux Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> is null. </exception>
        public virtual async Task<Response<KubernetesFluxConfigurationResource>> GetAsync(string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _kubernetesFluxConfigurationFluxConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesFluxConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the Flux Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> is null. </exception>
        public virtual Response<KubernetesFluxConfigurationResource> Get(string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _kubernetesFluxConfigurationFluxConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesFluxConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Flux Configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KubernetesFluxConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KubernetesFluxConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new KubernetesFluxConfigurationResource(Client, KubernetesFluxConfigurationData.DeserializeKubernetesFluxConfigurationData(e)), _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics, Pipeline, "KubernetesFluxConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Flux Configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KubernetesFluxConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KubernetesFluxConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kubernetesFluxConfigurationFluxConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new KubernetesFluxConfigurationResource(Client, KubernetesFluxConfigurationData.DeserializeKubernetesFluxConfigurationData(e)), _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics, Pipeline, "KubernetesFluxConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kubernetesFluxConfigurationFluxConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _kubernetesFluxConfigurationFluxConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<KubernetesFluxConfigurationResource>> GetIfExistsAsync(string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kubernetesFluxConfigurationFluxConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KubernetesFluxConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new KubernetesFluxConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluxConfigurationName"/> is null. </exception>
        public virtual NullableResponse<KubernetesFluxConfigurationResource> GetIfExists(string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluxConfigurationName, nameof(fluxConfigurationName));

            using var scope = _kubernetesFluxConfigurationFluxConfigurationsClientDiagnostics.CreateScope("KubernetesFluxConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kubernetesFluxConfigurationFluxConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, fluxConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KubernetesFluxConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new KubernetesFluxConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KubernetesFluxConfigurationResource> IEnumerable<KubernetesFluxConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KubernetesFluxConfigurationResource> IAsyncEnumerable<KubernetesFluxConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
