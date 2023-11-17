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
    /// A class representing a collection of <see cref="DomainTopicEventSubscriptionResource" /> and their operations.
    /// Each <see cref="DomainTopicEventSubscriptionResource" /> in the collection will belong to the same instance of <see cref="DomainTopicResource" />.
    /// To get a <see cref="DomainTopicEventSubscriptionCollection" /> instance call the GetDomainTopicEventSubscriptions method from an instance of <see cref="DomainTopicResource" />.
    /// </summary>
    public partial class DomainTopicEventSubscriptionCollection : ArmCollection, IEnumerable<DomainTopicEventSubscriptionResource>, IAsyncEnumerable<DomainTopicEventSubscriptionResource>
    {
        private readonly ClientDiagnostics _domainTopicEventSubscriptionClientDiagnostics;
        private readonly DomainTopicEventSubscriptionsRestOperations _domainTopicEventSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="DomainTopicEventSubscriptionCollection"/> class for mocking. </summary>
        protected DomainTopicEventSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DomainTopicEventSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DomainTopicEventSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _domainTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", DomainTopicEventSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DomainTopicEventSubscriptionResource.ResourceType, out string domainTopicEventSubscriptionApiVersion);
            _domainTopicEventSubscriptionRestClient = new DomainTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, domainTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DomainTopicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DomainTopicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates a new event subscription or updates an existing event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DomainTopicEventSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string eventSubscriptionName, EventGridSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<DomainTopicEventSubscriptionResource>(new DomainTopicEventSubscriptionOperationSource(Client), _domainTopicEventSubscriptionClientDiagnostics, Pipeline, _domainTopicEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates a new event subscription or updates an existing event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DomainTopicEventSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string eventSubscriptionName, EventGridSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, data, cancellationToken);
                var operation = new EventGridArmOperation<DomainTopicEventSubscriptionResource>(new DomainTopicEventSubscriptionOperationSource(Client), _domainTopicEventSubscriptionClientDiagnostics, Pipeline, _domainTopicEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get properties of a nested event subscription for a domain topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<DomainTopicEventSubscriptionResource>> GetAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a nested event subscription for a domain topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<DomainTopicEventSubscriptionResource> Get(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all event subscriptions that have been created for a specific domain topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DomainTopicEventSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DomainTopicEventSubscriptionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainTopicEventSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainTopicEventSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DomainTopicEventSubscriptionResource(Client, EventGridSubscriptionData.DeserializeEventGridSubscriptionData(e)), _domainTopicEventSubscriptionClientDiagnostics, Pipeline, "DomainTopicEventSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all event subscriptions that have been created for a specific domain topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DomainTopicEventSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DomainTopicEventSubscriptionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainTopicEventSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainTopicEventSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DomainTopicEventSubscriptionResource(Client, EventGridSubscriptionData.DeserializeEventGridSubscriptionData(e)), _domainTopicEventSubscriptionClientDiagnostics, Pipeline, "DomainTopicEventSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<NullableResponse<DomainTopicEventSubscriptionResource>> GetIfExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DomainTopicEventSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new DomainTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual NullableResponse<DomainTopicEventSubscriptionResource> GetIfExists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DomainTopicEventSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new DomainTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DomainTopicEventSubscriptionResource> IEnumerable<DomainTopicEventSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DomainTopicEventSubscriptionResource> IAsyncEnumerable<DomainTopicEventSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
