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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementUserResource" /> and their operations.
    /// Each <see cref="ApiManagementUserResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementUserCollection" /> instance call the GetApiManagementUsers method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementUserCollection : ArmCollection, IEnumerable<ApiManagementUserResource>, IAsyncEnumerable<ApiManagementUserResource>
    {
        private readonly ClientDiagnostics _apiManagementUserUserClientDiagnostics;
        private readonly UserRestOperations _apiManagementUserUserRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserCollection"/> class for mocking. </summary>
        protected ApiManagementUserCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementUserCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementUserUserClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementUserResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementUserResource.ResourceType, out string apiManagementUserUserApiVersion);
            _apiManagementUserUserRestClient = new UserRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementUserUserApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="content"> Create or update parameters. </param>
        /// <param name="notify"> Send an Email notification to the User. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementUserResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string userId, ApiManagementUserCreateOrUpdateContent content, bool? notify = null, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementUserUserClientDiagnostics.CreateScope("ApiManagementUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementUserUserRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId, content, notify, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementUserResource>(Response.FromValue(new ApiManagementUserResource(Client, response), response.GetRawResponse()));
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
        /// Creates or Updates a user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="content"> Create or update parameters. </param>
        /// <param name="notify"> Send an Email notification to the User. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementUserResource> CreateOrUpdate(WaitUntil waitUntil, string userId, ApiManagementUserCreateOrUpdateContent content, bool? notify = null, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementUserUserClientDiagnostics.CreateScope("ApiManagementUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementUserUserRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId, content, notify, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementUserResource>(Response.FromValue(new ApiManagementUserResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the user specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementUserResource>> GetAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _apiManagementUserUserClientDiagnostics.CreateScope("ApiManagementUserCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementUserUserRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the user specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<ApiManagementUserResource> Get(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _apiManagementUserUserClientDiagnostics.CreateScope("ApiManagementUserCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementUserUserRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of registered users in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| firstName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| lastName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| email | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| registrationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;| note | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| groups | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="expandGroups"> Detailed Group in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementUserResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementUserResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, bool? expandGroups = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementUserUserRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementUserUserRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementUserResource(Client, UserContractData.DeserializeUserContractData(e)), _apiManagementUserUserClientDiagnostics, Pipeline, "ApiManagementUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of registered users in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| firstName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| lastName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| email | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| registrationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;| note | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| groups | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="expandGroups"> Detailed Group in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementUserResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementUserResource> GetAll(string filter = null, int? top = null, int? skip = null, bool? expandGroups = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementUserUserRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementUserUserRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, expandGroups);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementUserResource(Client, UserContractData.DeserializeUserContractData(e)), _apiManagementUserUserClientDiagnostics, Pipeline, "ApiManagementUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _apiManagementUserUserClientDiagnostics.CreateScope("ApiManagementUserCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementUserUserRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>User_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<bool> Exists(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _apiManagementUserUserClientDiagnostics.CreateScope("ApiManagementUserCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementUserUserRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementUserResource> IEnumerable<ApiManagementUserResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementUserResource> IAsyncEnumerable<ApiManagementUserResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
