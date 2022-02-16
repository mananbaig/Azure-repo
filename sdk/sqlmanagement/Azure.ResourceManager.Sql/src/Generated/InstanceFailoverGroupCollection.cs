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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of InstanceFailoverGroup and their operations over its parent. </summary>
    public partial class InstanceFailoverGroupCollection : ArmCollection, IEnumerable<InstanceFailoverGroup>, IAsyncEnumerable<InstanceFailoverGroup>
    {
        private readonly ClientDiagnostics _instanceFailoverGroupClientDiagnostics;
        private readonly InstanceFailoverGroupsRestOperations _instanceFailoverGroupRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="InstanceFailoverGroupCollection"/> class for mocking. </summary>
        protected InstanceFailoverGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InstanceFailoverGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        internal InstanceFailoverGroupCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _instanceFailoverGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", InstanceFailoverGroup.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(InstanceFailoverGroup.ResourceType, out string instanceFailoverGroupApiVersion);
            _instanceFailoverGroupRestClient = new InstanceFailoverGroupsRestOperations(_instanceFailoverGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, instanceFailoverGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a failover group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<InstanceFailoverGroup>> CreateOrUpdateAsync(bool waitForCompletion, string failoverGroupName, InstanceFailoverGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<InstanceFailoverGroup>(new InstanceFailoverGroupOperationSource(Client), _instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Creates or updates a failover group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<InstanceFailoverGroup> CreateOrUpdate(bool waitForCompletion, string failoverGroupName, InstanceFailoverGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, parameters, cancellationToken);
                var operation = new SqlArmOperation<InstanceFailoverGroup>(new InstanceFailoverGroupOperationSource(Client), _instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Gets a failover group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_Get
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<InstanceFailoverGroup>> GetAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _instanceFailoverGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new InstanceFailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a failover group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_Get
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<InstanceFailoverGroup> Get(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, cancellationToken);
                if (response.Value == null)
                    throw _instanceFailoverGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the failover groups in a location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups
        /// Operation Id: InstanceFailoverGroups_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InstanceFailoverGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InstanceFailoverGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<InstanceFailoverGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _instanceFailoverGroupRestClient.ListByLocationAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InstanceFailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InstanceFailoverGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _instanceFailoverGroupRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InstanceFailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the failover groups in a location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups
        /// Operation Id: InstanceFailoverGroups_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InstanceFailoverGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InstanceFailoverGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<InstanceFailoverGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _instanceFailoverGroupRestClient.ListByLocation(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InstanceFailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InstanceFailoverGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _instanceFailoverGroupRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InstanceFailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_Get
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_Get
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(failoverGroupName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_Get
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<InstanceFailoverGroup>> GetIfExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<InstanceFailoverGroup>(null, response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// Operation Id: InstanceFailoverGroups_Get
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<InstanceFailoverGroup> GetIfExists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, failoverGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<InstanceFailoverGroup>(null, response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InstanceFailoverGroup> IEnumerable<InstanceFailoverGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InstanceFailoverGroup> IAsyncEnumerable<InstanceFailoverGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
