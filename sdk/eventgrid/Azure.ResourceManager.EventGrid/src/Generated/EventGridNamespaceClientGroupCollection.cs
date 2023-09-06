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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="EventGridNamespaceClientGroupResource" /> and their operations.
    /// Each <see cref="EventGridNamespaceClientGroupResource" /> in the collection will belong to the same instance of <see cref="EventGridNamespaceResource" />.
    /// To get an <see cref="EventGridNamespaceClientGroupCollection" /> instance call the GetEventGridNamespaceClientGroups method from an instance of <see cref="EventGridNamespaceResource" />.
    /// </summary>
    public partial class EventGridNamespaceClientGroupCollection : ArmCollection, IEnumerable<EventGridNamespaceClientGroupResource>, IAsyncEnumerable<EventGridNamespaceClientGroupResource>
    {
        private readonly ClientDiagnostics _eventGridNamespaceClientGroupClientGroupsClientDiagnostics;
        private readonly ClientGroupsRestOperations _eventGridNamespaceClientGroupClientGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespaceClientGroupCollection"/> class for mocking. </summary>
        protected EventGridNamespaceClientGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespaceClientGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventGridNamespaceClientGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventGridNamespaceClientGroupClientGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", EventGridNamespaceClientGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventGridNamespaceClientGroupResource.ResourceType, out string eventGridNamespaceClientGroupClientGroupsApiVersion);
            _eventGridNamespaceClientGroupClientGroupsRestClient = new ClientGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventGridNamespaceClientGroupClientGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a client group with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups/{clientGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clientGroupName"> The client group name. </param>
        /// <param name="data"> Client group information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridNamespaceClientGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clientGroupName, EventGridNamespaceClientGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespaceClientGroupClientGroupsClientDiagnostics.CreateScope("EventGridNamespaceClientGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventGridNamespaceClientGroupClientGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridNamespaceClientGroupResource>(new EventGridNamespaceClientGroupOperationSource(Client), _eventGridNamespaceClientGroupClientGroupsClientDiagnostics, Pipeline, _eventGridNamespaceClientGroupClientGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a client group with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups/{clientGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clientGroupName"> The client group name. </param>
        /// <param name="data"> Client group information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridNamespaceClientGroupResource> CreateOrUpdate(WaitUntil waitUntil, string clientGroupName, EventGridNamespaceClientGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespaceClientGroupClientGroupsClientDiagnostics.CreateScope("EventGridNamespaceClientGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventGridNamespaceClientGroupClientGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridNamespaceClientGroupResource>(new EventGridNamespaceClientGroupOperationSource(Client), _eventGridNamespaceClientGroupClientGroupsClientDiagnostics, Pipeline, _eventGridNamespaceClientGroupClientGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a client group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups/{clientGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientGroupName"/> is null. </exception>
        public virtual async Task<Response<EventGridNamespaceClientGroupResource>> GetAsync(string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var scope = _eventGridNamespaceClientGroupClientGroupsClientDiagnostics.CreateScope("EventGridNamespaceClientGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventGridNamespaceClientGroupClientGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespaceClientGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a client group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups/{clientGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientGroupName"/> is null. </exception>
        public virtual Response<EventGridNamespaceClientGroupResource> Get(string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var scope = _eventGridNamespaceClientGroupClientGroupsClientDiagnostics.CreateScope("EventGridNamespaceClientGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _eventGridNamespaceClientGroupClientGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespaceClientGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the client groups under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventGridNamespaceClientGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventGridNamespaceClientGroupResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridNamespaceClientGroupClientGroupsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridNamespaceClientGroupClientGroupsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventGridNamespaceClientGroupResource(Client, EventGridNamespaceClientGroupData.DeserializeEventGridNamespaceClientGroupData(e)), _eventGridNamespaceClientGroupClientGroupsClientDiagnostics, Pipeline, "EventGridNamespaceClientGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the client groups under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventGridNamespaceClientGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventGridNamespaceClientGroupResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridNamespaceClientGroupClientGroupsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridNamespaceClientGroupClientGroupsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventGridNamespaceClientGroupResource(Client, EventGridNamespaceClientGroupData.DeserializeEventGridNamespaceClientGroupData(e)), _eventGridNamespaceClientGroupClientGroupsClientDiagnostics, Pipeline, "EventGridNamespaceClientGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups/{clientGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var scope = _eventGridNamespaceClientGroupClientGroupsClientDiagnostics.CreateScope("EventGridNamespaceClientGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventGridNamespaceClientGroupClientGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clientGroups/{clientGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClientGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var scope = _eventGridNamespaceClientGroupClientGroupsClientDiagnostics.CreateScope("EventGridNamespaceClientGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventGridNamespaceClientGroupClientGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventGridNamespaceClientGroupResource> IEnumerable<EventGridNamespaceClientGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventGridNamespaceClientGroupResource> IAsyncEnumerable<EventGridNamespaceClientGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
