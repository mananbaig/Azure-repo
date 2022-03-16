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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of GeoBackupPolicy and their operations over its parent. </summary>
    public partial class GeoBackupPolicyCollection : ArmCollection, IEnumerable<GeoBackupPolicyResource>, IAsyncEnumerable<GeoBackupPolicyResource>
    {
        private readonly ClientDiagnostics _geoBackupPolicyClientDiagnostics;
        private readonly GeoBackupPoliciesRestOperations _geoBackupPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="GeoBackupPolicyCollection"/> class for mocking. </summary>
        protected GeoBackupPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GeoBackupPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GeoBackupPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _geoBackupPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", GeoBackupPolicyResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(GeoBackupPolicyResource.ResourceType, out string geoBackupPolicyApiVersion);
            _geoBackupPolicyRestClient = new GeoBackupPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, geoBackupPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a database geo backup policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="parameters"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<GeoBackupPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, GeoBackupPolicyName geoBackupPolicyName, GeoBackupPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _geoBackupPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<GeoBackupPolicyResource>(Response.FromValue(new GeoBackupPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Updates a database geo backup policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="parameters"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<GeoBackupPolicyResource> CreateOrUpdate(WaitUntil waitUntil, GeoBackupPolicyName geoBackupPolicyName, GeoBackupPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _geoBackupPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<GeoBackupPolicyResource>(Response.FromValue(new GeoBackupPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Gets a geo backup policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_Get
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GeoBackupPolicyResource>> GetAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _geoBackupPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a geo backup policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_Get
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GeoBackupPolicyResource> Get(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _geoBackupPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of geo backup policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies
        /// Operation Id: GeoBackupPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GeoBackupPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GeoBackupPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GeoBackupPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _geoBackupPolicyRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GeoBackupPolicyResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Returns a list of geo backup policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies
        /// Operation Id: GeoBackupPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GeoBackupPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GeoBackupPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GeoBackupPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _geoBackupPolicyRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GeoBackupPolicyResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_Get
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_Get
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(geoBackupPolicyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_Get
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GeoBackupPolicyResource>> GetIfExistsAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _geoBackupPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GeoBackupPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// Operation Id: GeoBackupPolicies_Get
        /// </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GeoBackupPolicyResource> GetIfExists(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _geoBackupPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GeoBackupPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GeoBackupPolicyResource> IEnumerable<GeoBackupPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GeoBackupPolicyResource> IAsyncEnumerable<GeoBackupPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
