// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a DatabaseAccountCassandraKeyspaceThroughputSetting along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAccountCassandraKeyspaceThroughputSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAccountCassandraKeyspaceThroughputSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string keyspaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountCassandraKeyspaceThroughputSetting"/> class for mocking. </summary>
        protected DatabaseAccountCassandraKeyspaceThroughputSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAccountCassandraKeyspaceThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAccountCassandraKeyspaceThroughputSetting(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountCassandraKeyspaceThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAccountCassandraKeyspaceThroughputSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesApiVersion);
            _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient = new CassandraResourcesRestOperations(_databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the RUs per second of the Cassandra Keyspace under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceThroughputSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the RUs per second of the Cassandra Keyspace under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAccountCassandraKeyspaceThroughputSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Cassandra Keyspace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_UpdateCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current Cassandra Keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>> CreateOrUpdateAsync(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            if (updateThroughputParameters == null)
            {
                throw new ArgumentNullException(nameof(updateThroughputParameters));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.UpdateCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>(new DatabaseAccountCassandraKeyspaceThroughputSettingOperationSource(Client), _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.CreateUpdateCassandraKeyspaceThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Update RUs per second of an Azure Cosmos DB Cassandra Keyspace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_UpdateCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current Cassandra Keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual ArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting> CreateOrUpdate(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            if (updateThroughputParameters == null)
            {
                throw new ArgumentNullException(nameof(updateThroughputParameters));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.UpdateCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>(new DatabaseAccountCassandraKeyspaceThroughputSettingOperationSource(Client), _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.CreateUpdateCassandraKeyspaceThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Cassandra Keyspace from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: CassandraResources_MigrateCassandraKeyspaceToAutoscale
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>> MigrateCassandraKeyspaceToAutoscaleAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.MigrateCassandraKeyspaceToAutoscale");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.MigrateCassandraKeyspaceToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>(new DatabaseAccountCassandraKeyspaceThroughputSettingOperationSource(Client), _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraKeyspaceToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Cassandra Keyspace from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: CassandraResources_MigrateCassandraKeyspaceToAutoscale
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting> MigrateCassandraKeyspaceToAutoscale(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.MigrateCassandraKeyspaceToAutoscale");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.MigrateCassandraKeyspaceToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>(new DatabaseAccountCassandraKeyspaceThroughputSettingOperationSource(Client), _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraKeyspaceToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Cassandra Keyspace from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: CassandraResources_MigrateCassandraKeyspaceToManualThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>> MigrateCassandraKeyspaceToManualThroughputAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.MigrateCassandraKeyspaceToManualThroughput");
            scope.Start();
            try
            {
                var response = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.MigrateCassandraKeyspaceToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>(new DatabaseAccountCassandraKeyspaceThroughputSettingOperationSource(Client), _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraKeyspaceToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Cassandra Keyspace from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: CassandraResources_MigrateCassandraKeyspaceToManualThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting> MigrateCassandraKeyspaceToManualThroughput(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.MigrateCassandraKeyspaceToManualThroughput");
            scope.Start();
            try
            {
                var response = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.MigrateCassandraKeyspaceToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountCassandraKeyspaceThroughputSetting>(new DatabaseAccountCassandraKeyspaceThroughputSettingOperationSource(Client), _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics, Pipeline, _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.CreateMigrateCassandraKeyspaceToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceThroughputSetting>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DatabaseAccountCassandraKeyspaceThroughputSetting> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceThroughputSetting>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DatabaseAccountCassandraKeyspaceThroughputSetting> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountCassandraKeyspaceThroughputSetting>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DatabaseAccountCassandraKeyspaceThroughputSetting> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesClientDiagnostics.CreateScope("DatabaseAccountCassandraKeyspaceThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountCassandraKeyspaceThroughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountCassandraKeyspaceThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
