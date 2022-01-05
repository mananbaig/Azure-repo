// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DatabaseSchema and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseSchemaCollection : ArmCollection, IEnumerable<ManagedInstanceDatabaseSchema>, IAsyncEnumerable<ManagedInstanceDatabaseSchema>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseSchemasRestOperations _managedDatabaseSchemasRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceDatabaseSchemaCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceDatabaseSchemaCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseSchemasRestClient = new ManagedDatabaseSchemasRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedDatabase.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseSchemas_Get
        /// <summary> Get managed database schema. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchema> Get(string schemaName, CancellationToken cancellationToken = default)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchema(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseSchemas_Get
        /// <summary> Get managed database schema. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceDatabaseSchema>> GetAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchema(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchema> GetIfExists(string schemaName, CancellationToken cancellationToken = default)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceDatabaseSchema>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceDatabaseSchema(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceDatabaseSchema>> GetIfExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceDatabaseSchema>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceDatabaseSchema(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaName, CancellationToken cancellationToken = default)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(schemaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseSchemas_ListByDatabase
        /// <summary> List managed database schemas. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDatabaseSchema" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDatabaseSchema> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceDatabaseSchema> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseSchemasRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchema(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceDatabaseSchema> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseSchemasRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchema(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseSchemas_ListByDatabase
        /// <summary> List managed database schemas. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDatabaseSchema" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDatabaseSchema> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceDatabaseSchema>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseSchemasRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchema(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceDatabaseSchema>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseSchemasRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchema(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceDatabaseSchema> IEnumerable<ManagedInstanceDatabaseSchema>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDatabaseSchema> IAsyncEnumerable<ManagedInstanceDatabaseSchema>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ManagedInstanceDatabaseSchema, DatabaseSchemaData> Construct() { }
    }
}
