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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="EnvironmentContainerResource" /> and their operations.
    /// Each <see cref="EnvironmentContainerResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get an <see cref="EnvironmentContainerCollection" /> instance call the GetEnvironmentContainers method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class EnvironmentContainerCollection : ArmCollection, IEnumerable<EnvironmentContainerResource>, IAsyncEnumerable<EnvironmentContainerResource>
    {
        private readonly ClientDiagnostics _environmentContainerClientDiagnostics;
        private readonly EnvironmentContainersRestOperations _environmentContainerRestClient;

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerCollection"/> class for mocking. </summary>
        protected EnvironmentContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EnvironmentContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _environmentContainerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", EnvironmentContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EnvironmentContainerResource.ResourceType, out string environmentContainerApiVersion);
            _environmentContainerRestClient = new EnvironmentContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, environmentContainerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EnvironmentContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, EnvironmentContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _environmentContainerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<EnvironmentContainerResource>(Response.FromValue(new EnvironmentContainerResource(Client, response), response.GetRawResponse()));
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
        /// Create or update container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EnvironmentContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, EnvironmentContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _environmentContainerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<EnvironmentContainerResource>(Response.FromValue(new EnvironmentContainerResource(Client, response), response.GetRawResponse()));
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
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<EnvironmentContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _environmentContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<EnvironmentContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _environmentContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List environment containers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments
        /// Operation Id: EnvironmentContainers_List
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnvironmentContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EnvironmentContainerResource> GetAllAsync(string skip = null, ListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<EnvironmentContainerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _environmentContainerRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EnvironmentContainerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _environmentContainerRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List environment containers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments
        /// Operation Id: EnvironmentContainers_List
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnvironmentContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EnvironmentContainerResource> GetAll(string skip = null, ListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            Page<EnvironmentContainerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _environmentContainerRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EnvironmentContainerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _environmentContainerRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _environmentContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerClientDiagnostics.CreateScope("EnvironmentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _environmentContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EnvironmentContainerResource> IEnumerable<EnvironmentContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EnvironmentContainerResource> IAsyncEnumerable<EnvironmentContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
