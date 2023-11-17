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
    /// A class representing a collection of <see cref="NamespaceTopicResource" /> and their operations.
    /// Each <see cref="NamespaceTopicResource" /> in the collection will belong to the same instance of <see cref="EventGridNamespaceResource" />.
    /// To get a <see cref="NamespaceTopicCollection" /> instance call the GetNamespaceTopics method from an instance of <see cref="EventGridNamespaceResource" />.
    /// </summary>
    public partial class NamespaceTopicCollection : ArmCollection, IEnumerable<NamespaceTopicResource>, IAsyncEnumerable<NamespaceTopicResource>
    {
        private readonly ClientDiagnostics _namespaceTopicClientDiagnostics;
        private readonly NamespaceTopicsRestOperations _namespaceTopicRestClient;

        /// <summary> Initializes a new instance of the <see cref="NamespaceTopicCollection"/> class for mocking. </summary>
        protected NamespaceTopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceTopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NamespaceTopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceTopicClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", NamespaceTopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NamespaceTopicResource.ResourceType, out string namespaceTopicApiVersion);
            _namespaceTopicRestClient = new NamespaceTopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, namespaceTopicApiVersion);
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
        /// Asynchronously creates a new namespace topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="data"> Namespace topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NamespaceTopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string topicName, NamespaceTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _namespaceTopicRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<NamespaceTopicResource>(new NamespaceTopicOperationSource(Client), _namespaceTopicClientDiagnostics, Pipeline, _namespaceTopicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Asynchronously creates a new namespace topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="data"> Namespace topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NamespaceTopicResource> CreateOrUpdate(WaitUntil waitUntil, string topicName, NamespaceTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _namespaceTopicRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, data, cancellationToken);
                var operation = new EventGridArmOperation<NamespaceTopicResource>(new NamespaceTopicOperationSource(Client), _namespaceTopicClientDiagnostics, Pipeline, _namespaceTopicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<NamespaceTopicResource>> GetAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _namespaceTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<NamespaceTopicResource> Get(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.Get");
            scope.Start();
            try
            {
                var response = _namespaceTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the namespace topics under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NamespaceTopicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NamespaceTopicResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _namespaceTopicRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _namespaceTopicRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NamespaceTopicResource(Client, NamespaceTopicData.DeserializeNamespaceTopicData(e)), _namespaceTopicClientDiagnostics, Pipeline, "NamespaceTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the namespace topics under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NamespaceTopicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NamespaceTopicResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _namespaceTopicRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _namespaceTopicRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NamespaceTopicResource(Client, NamespaceTopicData.DeserializeNamespaceTopicData(e)), _namespaceTopicClientDiagnostics, Pipeline, "NamespaceTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _namespaceTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<bool> Exists(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _namespaceTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<NullableResponse<NamespaceTopicResource>> GetIfExistsAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _namespaceTopicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NamespaceTopicResource>(response.GetRawResponse());
                return Response.FromValue(new NamespaceTopicResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the namespace topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual NullableResponse<NamespaceTopicResource> GetIfExists(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _namespaceTopicClientDiagnostics.CreateScope("NamespaceTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _namespaceTopicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NamespaceTopicResource>(response.GetRawResponse());
                return Response.FromValue(new NamespaceTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NamespaceTopicResource> IEnumerable<NamespaceTopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NamespaceTopicResource> IAsyncEnumerable<NamespaceTopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
