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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementProductTagResource" /> and their operations.
    /// Each <see cref="ApiManagementProductTagResource" /> in the collection will belong to the same instance of <see cref="ApiManagementProductResource" />.
    /// To get an <see cref="ApiManagementProductTagCollection" /> instance call the GetApiManagementProductTags method from an instance of <see cref="ApiManagementProductResource" />.
    /// </summary>
    public partial class ApiManagementProductTagCollection : ArmCollection, IEnumerable<ApiManagementProductTagResource>, IAsyncEnumerable<ApiManagementProductTagResource>
    {
        private readonly ClientDiagnostics _apiManagementProductTagTagClientDiagnostics;
        private readonly TagRestOperations _apiManagementProductTagTagRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementProductTagCollection"/> class for mocking. </summary>
        protected ApiManagementProductTagCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementProductTagCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementProductTagCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementProductTagTagClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementProductTagResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementProductTagResource.ResourceType, out string apiManagementProductTagTagApiVersion);
            _apiManagementProductTagTagRestClient = new TagRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementProductTagTagApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementProductResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementProductResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Assign tag to the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_AssignToProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementProductTagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementProductTagTagClientDiagnostics.CreateScope("ApiManagementProductTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementProductTagTagRestClient.AssignToProductAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementProductTagResource>(Response.FromValue(new ApiManagementProductTagResource(Client, response), response.GetRawResponse()));
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
        /// Assign tag to the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_AssignToProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual ArmOperation<ApiManagementProductTagResource> CreateOrUpdate(WaitUntil waitUntil, string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementProductTagTagClientDiagnostics.CreateScope("ApiManagementProductTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementProductTagTagRestClient.AssignToProduct(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagId, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementProductTagResource>(Response.FromValue(new ApiManagementProductTagResource(Client, response), response.GetRawResponse()));
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
        /// Get tag associated with the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementProductTagResource>> GetAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementProductTagTagClientDiagnostics.CreateScope("ApiManagementProductTagCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementProductTagTagRestClient.GetByProductAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tag associated with the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<ApiManagementProductTagResource> Get(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementProductTagTagClientDiagnostics.CreateScope("ApiManagementProductTagCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementProductTagTagRestClient.GetByProduct(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Tags associated with the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_ListByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementProductTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementProductTagResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementProductTagTagRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementProductTagTagRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementProductTagResource(Client, TagContractData.DeserializeTagContractData(e)), _apiManagementProductTagTagClientDiagnostics, Pipeline, "ApiManagementProductTagCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Tags associated with the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_ListByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementProductTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementProductTagResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementProductTagTagRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementProductTagTagRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementProductTagResource(Client, TagContractData.DeserializeTagContractData(e)), _apiManagementProductTagTagClientDiagnostics, Pipeline, "ApiManagementProductTagCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementProductTagTagClientDiagnostics.CreateScope("ApiManagementProductTagCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementProductTagTagRestClient.GetByProductAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/tags/{tagId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tag_GetByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<bool> Exists(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _apiManagementProductTagTagClientDiagnostics.CreateScope("ApiManagementProductTagCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementProductTagTagRestClient.GetByProduct(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementProductTagResource> IEnumerable<ApiManagementProductTagResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementProductTagResource> IAsyncEnumerable<ApiManagementProductTagResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
