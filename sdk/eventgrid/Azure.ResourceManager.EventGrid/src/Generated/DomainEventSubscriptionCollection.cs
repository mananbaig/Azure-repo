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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="DomainEventSubscriptionResource"/> and their operations.
    /// Each <see cref="DomainEventSubscriptionResource"/> in the collection will belong to the same instance of <see cref="EventGridDomainResource"/>.
    /// To get a <see cref="DomainEventSubscriptionCollection"/> instance call the GetDomainEventSubscriptions method from an instance of <see cref="EventGridDomainResource"/>.
    /// </summary>
    public partial class DomainEventSubscriptionCollection : ArmCollection, IEnumerable<DomainEventSubscriptionResource>, IAsyncEnumerable<DomainEventSubscriptionResource>
    {
        private readonly ClientDiagnostics _domainEventSubscriptionClientDiagnostics;
        private readonly DomainEventSubscriptionsRestOperations _domainEventSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="DomainEventSubscriptionCollection"/> class for mocking. </summary>
        protected DomainEventSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DomainEventSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DomainEventSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _domainEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", DomainEventSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DomainEventSubscriptionResource.ResourceType, out string domainEventSubscriptionApiVersion);
            _domainEventSubscriptionRestClient = new DomainEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, domainEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridDomainResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridDomainResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates a new event subscription or updates an existing event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 64 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DomainEventSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string eventSubscriptionName, EventGridSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _domainEventSubscriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<DomainEventSubscriptionResource>(new DomainEventSubscriptionOperationSource(Client), _domainEventSubscriptionClientDiagnostics, Pipeline, _domainEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 64 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DomainEventSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string eventSubscriptionName, EventGridSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _domainEventSubscriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data, cancellationToken);
                var operation = new EventGridArmOperation<DomainEventSubscriptionResource>(new DomainEventSubscriptionOperationSource(Client), _domainEventSubscriptionClientDiagnostics, Pipeline, _domainEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get properties of an event subscription of a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<DomainEventSubscriptionResource>> GetAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _domainEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of an event subscription of a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<DomainEventSubscriptionResource> Get(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _domainEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all event subscriptions that have been created for a specific topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DomainEventSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DomainEventSubscriptionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainEventSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainEventSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DomainEventSubscriptionResource(Client, EventGridSubscriptionData.DeserializeEventGridSubscriptionData(e)), _domainEventSubscriptionClientDiagnostics, Pipeline, "DomainEventSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all event subscriptions that have been created for a specific topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DomainEventSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DomainEventSubscriptionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainEventSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainEventSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DomainEventSubscriptionResource(Client, EventGridSubscriptionData.DeserializeEventGridSubscriptionData(e)), _domainEventSubscriptionClientDiagnostics, Pipeline, "DomainEventSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _domainEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _domainEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<NullableResponse<DomainEventSubscriptionResource>> GetIfExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _domainEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DomainEventSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new DomainEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DomainEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be found. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual NullableResponse<DomainEventSubscriptionResource> GetIfExists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventSubscriptionName, nameof(eventSubscriptionName));

            using var scope = _domainEventSubscriptionClientDiagnostics.CreateScope("DomainEventSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _domainEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DomainEventSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new DomainEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DomainEventSubscriptionResource> IEnumerable<DomainEventSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DomainEventSubscriptionResource> IAsyncEnumerable<DomainEventSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
