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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dashboard
{
    /// <summary>
    /// A class representing a collection of <see cref="GrafanaResource" /> and their operations.
    /// Each <see cref="GrafanaResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="GrafanaResourceCollection" /> instance call the GetGrafanaResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class GrafanaResourceCollection : ArmCollection, IEnumerable<GrafanaResource>, IAsyncEnumerable<GrafanaResource>
    {
        private readonly ClientDiagnostics _grafanaResourceGrafanaClientDiagnostics;
        private readonly GrafanaRestOperations _grafanaResourceGrafanaRestClient;

        /// <summary> Initializes a new instance of the <see cref="GrafanaResourceCollection"/> class for mocking. </summary>
        protected GrafanaResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GrafanaResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GrafanaResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _grafanaResourceGrafanaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dashboard", GrafanaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GrafanaResource.ResourceType, out string grafanaResourceGrafanaApiVersion);
            _grafanaResourceGrafanaRestClient = new GrafanaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, grafanaResourceGrafanaApiVersion);
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
        /// Create or update a workspace for Grafana resource. This API is idempotent, so user can either create a new grafana or update an existing grafana.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="body"> The GrafanaResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<ArmOperation<GrafanaResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workspaceName, GrafanaResourceData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _grafanaResourceGrafanaRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, body, cancellationToken).ConfigureAwait(false);
                var operation = new DashboardArmOperation<GrafanaResource>(new GrafanaResourceOperationSource(Client), _grafanaResourceGrafanaClientDiagnostics, Pipeline, _grafanaResourceGrafanaRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a workspace for Grafana resource. This API is idempotent, so user can either create a new grafana or update an existing grafana.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="body"> The GrafanaResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual ArmOperation<GrafanaResource> CreateOrUpdate(WaitUntil waitUntil, string workspaceName, GrafanaResourceData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _grafanaResourceGrafanaRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, body, cancellationToken);
                var operation = new DashboardArmOperation<GrafanaResource>(new GrafanaResourceOperationSource(Client), _grafanaResourceGrafanaClientDiagnostics, Pipeline, _grafanaResourceGrafanaRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the properties of a specific workspace for Grafana resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Get
        /// </summary>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<GrafanaResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _grafanaResourceGrafanaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a specific workspace for Grafana resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Get
        /// </summary>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<GrafanaResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _grafanaResourceGrafanaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana
        /// Operation Id: Grafana_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GrafanaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GrafanaResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _grafanaResourceGrafanaRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GrafanaResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _grafanaResourceGrafanaRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all resources of workspaces for Grafana under the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana
        /// Operation Id: Grafana_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GrafanaResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GrafanaResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _grafanaResourceGrafanaRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GrafanaResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _grafanaResourceGrafanaRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Get
        /// </summary>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Get
        /// </summary>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(workspaceName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Get
        /// </summary>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<GrafanaResource>> GetIfExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _grafanaResourceGrafanaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GrafanaResource>(null, response.GetRawResponse());
                return Response.FromValue(new GrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}
        /// Operation Id: Grafana_Get
        /// </summary>
        /// <param name="workspaceName"> The name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<GrafanaResource> GetIfExists(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _grafanaResourceGrafanaClientDiagnostics.CreateScope("GrafanaResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _grafanaResourceGrafanaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GrafanaResource>(null, response.GetRawResponse());
                return Response.FromValue(new GrafanaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GrafanaResource> IEnumerable<GrafanaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GrafanaResource> IAsyncEnumerable<GrafanaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
