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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="PartnerDestinationResource"/> and their operations.
    /// Each <see cref="PartnerDestinationResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PartnerDestinationCollection"/> instance call the GetPartnerDestinations method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PartnerDestinationCollection : ArmCollection, IEnumerable<PartnerDestinationResource>, IAsyncEnumerable<PartnerDestinationResource>
    {
        private readonly ClientDiagnostics _partnerDestinationClientDiagnostics;
        private readonly PartnerDestinationsRestOperations _partnerDestinationRestClient;

        /// <summary> Initializes a new instance of the <see cref="PartnerDestinationCollection"/> class for mocking. </summary>
        protected PartnerDestinationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerDestinationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PartnerDestinationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerDestinationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", PartnerDestinationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PartnerDestinationResource.ResourceType, out string partnerDestinationApiVersion);
            _partnerDestinationRestClient = new PartnerDestinationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerDestinationApiVersion);
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
        /// Asynchronously creates a new partner destination with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="data"> Partner destination create information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PartnerDestinationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string partnerDestinationName, PartnerDestinationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _partnerDestinationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<PartnerDestinationResource>(new PartnerDestinationOperationSource(Client), _partnerDestinationClientDiagnostics, Pipeline, _partnerDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Asynchronously creates a new partner destination with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="data"> Partner destination create information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PartnerDestinationResource> CreateOrUpdate(WaitUntil waitUntil, string partnerDestinationName, PartnerDestinationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _partnerDestinationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, data, cancellationToken);
                var operation = new EventGridArmOperation<PartnerDestinationResource>(new PartnerDestinationOperationSource(Client), _partnerDestinationClientDiagnostics, Pipeline, _partnerDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a partner destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> is null. </exception>
        public virtual async Task<Response<PartnerDestinationResource>> GetAsync(string partnerDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.Get");
            scope.Start();
            try
            {
                var response = await _partnerDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a partner destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> is null. </exception>
        public virtual Response<PartnerDestinationResource> Get(string partnerDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.Get");
            scope.Start();
            try
            {
                var response = _partnerDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the partner destinations under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PartnerDestinationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PartnerDestinationResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _partnerDestinationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _partnerDestinationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new PartnerDestinationResource(Client, PartnerDestinationData.DeserializePartnerDestinationData(e)), _partnerDestinationClientDiagnostics, Pipeline, "PartnerDestinationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the partner destinations under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PartnerDestinationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PartnerDestinationResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _partnerDestinationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _partnerDestinationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new PartnerDestinationResource(Client, PartnerDestinationData.DeserializePartnerDestinationData(e)), _partnerDestinationClientDiagnostics, Pipeline, "PartnerDestinationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string partnerDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _partnerDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> is null. </exception>
        public virtual Response<bool> Exists(string partnerDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.Exists");
            scope.Start();
            try
            {
                var response = _partnerDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> is null. </exception>
        public virtual async Task<NullableResponse<PartnerDestinationResource>> GetIfExistsAsync(string partnerDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _partnerDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PartnerDestinationResource>(response.GetRawResponse());
                return Response.FromValue(new PartnerDestinationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerDestinations/{partnerDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerDestinations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerDestinationName"> Name of the partner destination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerDestinationName"/> is null. </exception>
        public virtual NullableResponse<PartnerDestinationResource> GetIfExists(string partnerDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerDestinationName, nameof(partnerDestinationName));

            using var scope = _partnerDestinationClientDiagnostics.CreateScope("PartnerDestinationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _partnerDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerDestinationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PartnerDestinationResource>(response.GetRawResponse());
                return Response.FromValue(new PartnerDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PartnerDestinationResource> IEnumerable<PartnerDestinationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PartnerDestinationResource> IAsyncEnumerable<PartnerDestinationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
