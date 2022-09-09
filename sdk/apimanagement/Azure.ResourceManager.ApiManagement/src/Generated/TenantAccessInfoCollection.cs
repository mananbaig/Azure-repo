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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantAccessInfoResource" /> and their operations.
    /// Each <see cref="TenantAccessInfoResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get a <see cref="TenantAccessInfoCollection" /> instance call the GetTenantAccessInfos method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class TenantAccessInfoCollection : ArmCollection, IEnumerable<TenantAccessInfoResource>, IAsyncEnumerable<TenantAccessInfoResource>
    {
        private readonly ClientDiagnostics _tenantAccessInfoTenantAccessClientDiagnostics;
        private readonly TenantAccessRestOperations _tenantAccessInfoTenantAccessRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantAccessInfoCollection"/> class for mocking. </summary>
        protected TenantAccessInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantAccessInfoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantAccessInfoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantAccessInfoTenantAccessClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", TenantAccessInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantAccessInfoResource.ResourceType, out string tenantAccessInfoTenantAccessApiVersion);
            _tenantAccessInfoTenantAccessRestClient = new TenantAccessRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantAccessInfoTenantAccessApiVersion);
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
        /// Update tenant access information details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}
        /// Operation Id: TenantAccess_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accessName"> The identifier of the Access configuration. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="content"> Parameters supplied to retrieve the Tenant Access Information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantAccessInfoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AccessName accessName, ETag ifMatch, TenantAccessInfoCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessName, ifMatch, content, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<TenantAccessInfoResource>(Response.FromValue(new TenantAccessInfoResource(Client, response), response.GetRawResponse()));
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
        /// Update tenant access information details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}
        /// Operation Id: TenantAccess_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accessName"> The identifier of the Access configuration. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="content"> Parameters supplied to retrieve the Tenant Access Information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<TenantAccessInfoResource> CreateOrUpdate(WaitUntil waitUntil, AccessName accessName, ETag ifMatch, TenantAccessInfoCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessName, ifMatch, content, cancellationToken);
                var operation = new ApiManagementArmOperation<TenantAccessInfoResource>(Response.FromValue(new TenantAccessInfoResource(Client, response), response.GetRawResponse()));
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
        /// Get tenant access information details without secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}
        /// Operation Id: TenantAccess_Get
        /// </summary>
        /// <param name="accessName"> The identifier of the Access configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantAccessInfoResource>> GetAsync(AccessName accessName, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantAccessInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get tenant access information details without secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}
        /// Operation Id: TenantAccess_Get
        /// </summary>
        /// <param name="accessName"> The identifier of the Access configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantAccessInfoResource> Get(AccessName accessName, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantAccessInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of access infos - for Git and Management endpoints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant
        /// Operation Id: TenantAccess_ListByService
        /// </summary>
        /// <param name="filter"> Not used. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantAccessInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantAccessInfoResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TenantAccessInfoResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tenantAccessInfoTenantAccessRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantAccessInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TenantAccessInfoResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tenantAccessInfoTenantAccessRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantAccessInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns list of access infos - for Git and Management endpoints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant
        /// Operation Id: TenantAccess_ListByService
        /// </summary>
        /// <param name="filter"> Not used. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantAccessInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantAccessInfoResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<TenantAccessInfoResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tenantAccessInfoTenantAccessRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantAccessInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TenantAccessInfoResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tenantAccessInfoTenantAccessRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantAccessInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}
        /// Operation Id: TenantAccess_Get
        /// </summary>
        /// <param name="accessName"> The identifier of the Access configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AccessName accessName, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantAccessInfoTenantAccessRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tenant/{accessName}
        /// Operation Id: TenantAccess_Get
        /// </summary>
        /// <param name="accessName"> The identifier of the Access configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AccessName accessName, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantAccessInfoTenantAccessClientDiagnostics.CreateScope("TenantAccessInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantAccessInfoTenantAccessRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TenantAccessInfoResource> IEnumerable<TenantAccessInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantAccessInfoResource> IAsyncEnumerable<TenantAccessInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
