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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="TopicSpaceResource" /> and their operations.
    /// Each <see cref="TopicSpaceResource" /> in the collection will belong to the same instance of <see cref="EventGridNamespaceResource" />.
    /// To get a <see cref="TopicSpaceCollection" /> instance call the GetTopicSpaces method from an instance of <see cref="EventGridNamespaceResource" />.
    /// </summary>
    public partial class TopicSpaceCollection : ArmCollection, IEnumerable<TopicSpaceResource>, IAsyncEnumerable<TopicSpaceResource>
    {
        private readonly ClientDiagnostics _topicSpaceClientDiagnostics;
        private readonly TopicSpacesRestOperations _topicSpaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopicSpaceCollection"/> class for mocking. </summary>
        protected TopicSpaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopicSpaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TopicSpaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicSpaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", TopicSpaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TopicSpaceResource.ResourceType, out string topicSpaceApiVersion);
            _topicSpaceRestClient = new TopicSpacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicSpaceApiVersion);
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
        /// Create or update a topic space with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces/{topicSpaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicSpaceName"> The topic space name. </param>
        /// <param name="data"> Topic space information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicSpaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicSpaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TopicSpaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string topicSpaceName, TopicSpaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicSpaceName, nameof(topicSpaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _topicSpaceClientDiagnostics.CreateScope("TopicSpaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _topicSpaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<TopicSpaceResource>(new TopicSpaceOperationSource(Client), _topicSpaceClientDiagnostics, Pipeline, _topicSpaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a topic space with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces/{topicSpaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicSpaceName"> The topic space name. </param>
        /// <param name="data"> Topic space information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicSpaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicSpaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TopicSpaceResource> CreateOrUpdate(WaitUntil waitUntil, string topicSpaceName, TopicSpaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicSpaceName, nameof(topicSpaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _topicSpaceClientDiagnostics.CreateScope("TopicSpaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _topicSpaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, data, cancellationToken);
                var operation = new EventGridArmOperation<TopicSpaceResource>(new TopicSpaceOperationSource(Client), _topicSpaceClientDiagnostics, Pipeline, _topicSpaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a topic space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces/{topicSpaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicSpaceName"> Name of the Topic space. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicSpaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicSpaceName"/> is null. </exception>
        public virtual async Task<Response<TopicSpaceResource>> GetAsync(string topicSpaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicSpaceName, nameof(topicSpaceName));

            using var scope = _topicSpaceClientDiagnostics.CreateScope("TopicSpaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _topicSpaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicSpaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a topic space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces/{topicSpaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicSpaceName"> Name of the Topic space. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicSpaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicSpaceName"/> is null. </exception>
        public virtual Response<TopicSpaceResource> Get(string topicSpaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicSpaceName, nameof(topicSpaceName));

            using var scope = _topicSpaceClientDiagnostics.CreateScope("TopicSpaceCollection.Get");
            scope.Start();
            try
            {
                var response = _topicSpaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicSpaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the topic spaces under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TopicSpaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TopicSpaceResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topicSpaceRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topicSpaceRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TopicSpaceResource(Client, TopicSpaceData.DeserializeTopicSpaceData(e)), _topicSpaceClientDiagnostics, Pipeline, "TopicSpaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the topic spaces under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TopicSpaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TopicSpaceResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topicSpaceRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topicSpaceRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TopicSpaceResource(Client, TopicSpaceData.DeserializeTopicSpaceData(e)), _topicSpaceClientDiagnostics, Pipeline, "TopicSpaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces/{topicSpaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicSpaceName"> Name of the Topic space. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicSpaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicSpaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topicSpaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicSpaceName, nameof(topicSpaceName));

            using var scope = _topicSpaceClientDiagnostics.CreateScope("TopicSpaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _topicSpaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topicSpaces/{topicSpaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicSpaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicSpaceName"> Name of the Topic space. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicSpaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicSpaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string topicSpaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicSpaceName, nameof(topicSpaceName));

            using var scope = _topicSpaceClientDiagnostics.CreateScope("TopicSpaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _topicSpaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicSpaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TopicSpaceResource> IEnumerable<TopicSpaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TopicSpaceResource> IAsyncEnumerable<TopicSpaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
