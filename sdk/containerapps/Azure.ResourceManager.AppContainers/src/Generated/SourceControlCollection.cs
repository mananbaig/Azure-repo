// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="SourceControlResource" /> and their operations.
    /// Each <see cref="SourceControlResource" /> in the collection will belong to the same instance of <see cref="ContainerAppResource" />.
    /// To get a <see cref="SourceControlCollection" /> instance call the GetSourceControls method from an instance of <see cref="ContainerAppResource" />.
    /// </summary>
    public partial class SourceControlCollection : ArmCollection, IEnumerable<SourceControlResource>, IAsyncEnumerable<SourceControlResource>
    {
        private readonly ClientDiagnostics _sourceControlContainerAppsSourceControlsClientDiagnostics;
        private readonly ContainerAppsSourceControlsRestOperations _sourceControlContainerAppsSourceControlsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class for mocking. </summary>
        protected SourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SourceControlCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sourceControlContainerAppsSourceControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", SourceControlResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SourceControlResource.ResourceType, out string sourceControlContainerAppsSourceControlsApiVersion);
            _sourceControlContainerAppsSourceControlsRestClient = new ContainerAppsSourceControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sourceControlContainerAppsSourceControlsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the SourceControl for a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SourceControlResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceControlName, SourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sourceControlContainerAppsSourceControlsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<SourceControlResource>(new SourceControlOperationSource(Client), _sourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _sourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the SourceControl for a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SourceControlResource> CreateOrUpdate(WaitUntil waitUntil, string sourceControlName, SourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sourceControlContainerAppsSourceControlsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data, cancellationToken);
                var operation = new AppContainersArmOperation<SourceControlResource>(new SourceControlOperationSource(Client), _sourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _sourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a SourceControl of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Get
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<Response<SourceControlResource>> GetAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _sourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SourceControl of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Get
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual Response<SourceControlResource> Get(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _sourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Container App SourceControls in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols
        /// Operation Id: ContainerAppsSourceControls_ListByContainerApp
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SourceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SourceControlResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SourceControlResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sourceControlContainerAppsSourceControlsRestClient.ListByContainerAppAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControlResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SourceControlResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sourceControlContainerAppsSourceControlsRestClient.ListByContainerAppNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControlResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get the Container App SourceControls in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols
        /// Operation Id: ContainerAppsSourceControls_ListByContainerApp
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SourceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SourceControlResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SourceControlResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sourceControlContainerAppsSourceControlsRestClient.ListByContainerApp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControlResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SourceControlResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sourceControlContainerAppsSourceControlsRestClient.ListByContainerAppNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControlResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Get
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Get
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = _sourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SourceControlResource> IEnumerable<SourceControlResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SourceControlResource> IAsyncEnumerable<SourceControlResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
