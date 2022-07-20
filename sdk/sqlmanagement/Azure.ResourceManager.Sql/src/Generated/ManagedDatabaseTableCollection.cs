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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedDatabaseTableResource" /> and their operations.
    /// Each <see cref="ManagedDatabaseTableResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceDatabaseSchemaResource" />.
    /// To get a <see cref="ManagedDatabaseTableCollection" /> instance call the GetManagedDatabaseTables method from an instance of <see cref="ManagedInstanceDatabaseSchemaResource" />.
    /// </summary>
    public partial class ManagedDatabaseTableCollection : ArmCollection, IEnumerable<ManagedDatabaseTableResource>, IAsyncEnumerable<ManagedDatabaseTableResource>
    {
        private readonly ClientDiagnostics _managedDatabaseTableClientDiagnostics;
        private readonly ManagedDatabaseTablesRestOperations _managedDatabaseTableRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseTableCollection"/> class for mocking. </summary>
        protected ManagedDatabaseTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedDatabaseTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseTableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedDatabaseTableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedDatabaseTableResource.ResourceType, out string managedDatabaseTableApiVersion);
            _managedDatabaseTableRestClient = new ManagedDatabaseTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseTableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceDatabaseSchemaResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceDatabaseSchemaResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<ManagedDatabaseTableResource>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ManagedDatabaseTableResource> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List managed database tables
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables
        /// Operation Id: ManagedDatabaseTables_ListBySchema
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedDatabaseTableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedDatabaseTableResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedDatabaseTableResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseTableRestClient.ListBySchemaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseTableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedDatabaseTableResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseTableRestClient.ListBySchemaNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseTableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List managed database tables
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables
        /// Operation Id: ManagedDatabaseTables_ListBySchema
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedDatabaseTableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedDatabaseTableResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedDatabaseTableResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseTableRestClient.ListBySchema(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseTableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedDatabaseTableResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseTableRestClient.ListBySchemaNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedDatabaseTableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedDatabaseTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedDatabaseTableResource> IEnumerable<ManagedDatabaseTableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedDatabaseTableResource> IAsyncEnumerable<ManagedDatabaseTableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
