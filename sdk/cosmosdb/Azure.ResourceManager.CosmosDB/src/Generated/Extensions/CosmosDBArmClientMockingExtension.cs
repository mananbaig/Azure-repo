// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class CosmosDBArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="CosmosDBArmClientMockingExtension"/> class for mocking. </summary>
        protected CosmosDBArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal CosmosDBArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBAccountResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBAccountResource" /> object. </returns>
        public virtual CosmosDBAccountResource GetCosmosDBAccountResource(ResourceIdentifier id)
        {
            CosmosDBAccountResource.ValidateResourceId(id);
            return new CosmosDBAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GraphResourceGetResultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GraphResourceGetResultResource.CreateResourceIdentifier" /> to create a <see cref="GraphResourceGetResultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GraphResourceGetResultResource" /> object. </returns>
        public virtual GraphResourceGetResultResource GetGraphResourceGetResultResource(ResourceIdentifier id)
        {
            GraphResourceGetResultResource.ValidateResourceId(id);
            return new GraphResourceGetResultResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlDatabaseResource" /> object. </returns>
        public virtual CosmosDBSqlDatabaseResource GetCosmosDBSqlDatabaseResource(ResourceIdentifier id)
        {
            CosmosDBSqlDatabaseResource.ValidateResourceId(id);
            return new CosmosDBSqlDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlDatabaseThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlDatabaseThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlDatabaseThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlDatabaseThroughputSettingResource" /> object. </returns>
        public virtual CosmosDBSqlDatabaseThroughputSettingResource GetCosmosDBSqlDatabaseThroughputSettingResource(ResourceIdentifier id)
        {
            CosmosDBSqlDatabaseThroughputSettingResource.ValidateResourceId(id);
            return new CosmosDBSqlDatabaseThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlContainerThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlContainerThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlContainerThroughputSettingResource" /> object. </returns>
        public virtual CosmosDBSqlContainerThroughputSettingResource GetCosmosDBSqlContainerThroughputSettingResource(ResourceIdentifier id)
        {
            CosmosDBSqlContainerThroughputSettingResource.ValidateResourceId(id);
            return new CosmosDBSqlContainerThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoDBDatabaseThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoDBDatabaseThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="MongoDBDatabaseThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoDBDatabaseThroughputSettingResource" /> object. </returns>
        public virtual MongoDBDatabaseThroughputSettingResource GetMongoDBDatabaseThroughputSettingResource(ResourceIdentifier id)
        {
            MongoDBDatabaseThroughputSettingResource.ValidateResourceId(id);
            return new MongoDBDatabaseThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoDBCollectionThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoDBCollectionThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="MongoDBCollectionThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoDBCollectionThroughputSettingResource" /> object. </returns>
        public virtual MongoDBCollectionThroughputSettingResource GetMongoDBCollectionThroughputSettingResource(ResourceIdentifier id)
        {
            MongoDBCollectionThroughputSettingResource.ValidateResourceId(id);
            return new MongoDBCollectionThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosTableThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosTableThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="CosmosTableThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosTableThroughputSettingResource" /> object. </returns>
        public virtual CosmosTableThroughputSettingResource GetCosmosTableThroughputSettingResource(ResourceIdentifier id)
        {
            CosmosTableThroughputSettingResource.ValidateResourceId(id);
            return new CosmosTableThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraKeyspaceThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraKeyspaceThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="CassandraKeyspaceThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraKeyspaceThroughputSettingResource" /> object. </returns>
        public virtual CassandraKeyspaceThroughputSettingResource GetCassandraKeyspaceThroughputSettingResource(ResourceIdentifier id)
        {
            CassandraKeyspaceThroughputSettingResource.ValidateResourceId(id);
            return new CassandraKeyspaceThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraTableThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraTableThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="CassandraTableThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraTableThroughputSettingResource" /> object. </returns>
        public virtual CassandraTableThroughputSettingResource GetCassandraTableThroughputSettingResource(ResourceIdentifier id)
        {
            CassandraTableThroughputSettingResource.ValidateResourceId(id);
            return new CassandraTableThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraViewThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraViewThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="CassandraViewThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraViewThroughputSettingResource" /> object. </returns>
        public virtual CassandraViewThroughputSettingResource GetCassandraViewThroughputSettingResource(ResourceIdentifier id)
        {
            CassandraViewThroughputSettingResource.ValidateResourceId(id);
            return new CassandraViewThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GremlinDatabaseThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GremlinDatabaseThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="GremlinDatabaseThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GremlinDatabaseThroughputSettingResource" /> object. </returns>
        public virtual GremlinDatabaseThroughputSettingResource GetGremlinDatabaseThroughputSettingResource(ResourceIdentifier id)
        {
            GremlinDatabaseThroughputSettingResource.ValidateResourceId(id);
            return new GremlinDatabaseThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GremlinGraphThroughputSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GremlinGraphThroughputSettingResource.CreateResourceIdentifier" /> to create a <see cref="GremlinGraphThroughputSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GremlinGraphThroughputSettingResource" /> object. </returns>
        public virtual GremlinGraphThroughputSettingResource GetGremlinGraphThroughputSettingResource(ResourceIdentifier id)
        {
            GremlinGraphThroughputSettingResource.ValidateResourceId(id);
            return new GremlinGraphThroughputSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlClientEncryptionKeyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlClientEncryptionKeyResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlClientEncryptionKeyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlClientEncryptionKeyResource" /> object. </returns>
        public virtual CosmosDBSqlClientEncryptionKeyResource GetCosmosDBSqlClientEncryptionKeyResource(ResourceIdentifier id)
        {
            CosmosDBSqlClientEncryptionKeyResource.ValidateResourceId(id);
            return new CosmosDBSqlClientEncryptionKeyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlContainerResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlContainerResource" /> object. </returns>
        public virtual CosmosDBSqlContainerResource GetCosmosDBSqlContainerResource(ResourceIdentifier id)
        {
            CosmosDBSqlContainerResource.ValidateResourceId(id);
            return new CosmosDBSqlContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlStoredProcedureResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlStoredProcedureResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlStoredProcedureResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlStoredProcedureResource" /> object. </returns>
        public virtual CosmosDBSqlStoredProcedureResource GetCosmosDBSqlStoredProcedureResource(ResourceIdentifier id)
        {
            CosmosDBSqlStoredProcedureResource.ValidateResourceId(id);
            return new CosmosDBSqlStoredProcedureResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlUserDefinedFunctionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlUserDefinedFunctionResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlUserDefinedFunctionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlUserDefinedFunctionResource" /> object. </returns>
        public virtual CosmosDBSqlUserDefinedFunctionResource GetCosmosDBSqlUserDefinedFunctionResource(ResourceIdentifier id)
        {
            CosmosDBSqlUserDefinedFunctionResource.ValidateResourceId(id);
            return new CosmosDBSqlUserDefinedFunctionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlTriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlTriggerResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlTriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlTriggerResource" /> object. </returns>
        public virtual CosmosDBSqlTriggerResource GetCosmosDBSqlTriggerResource(ResourceIdentifier id)
        {
            CosmosDBSqlTriggerResource.ValidateResourceId(id);
            return new CosmosDBSqlTriggerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlRoleDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlRoleDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlRoleDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlRoleDefinitionResource" /> object. </returns>
        public virtual CosmosDBSqlRoleDefinitionResource GetCosmosDBSqlRoleDefinitionResource(ResourceIdentifier id)
        {
            CosmosDBSqlRoleDefinitionResource.ValidateResourceId(id);
            return new CosmosDBSqlRoleDefinitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBSqlRoleAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBSqlRoleAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBSqlRoleAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBSqlRoleAssignmentResource" /> object. </returns>
        public virtual CosmosDBSqlRoleAssignmentResource GetCosmosDBSqlRoleAssignmentResource(ResourceIdentifier id)
        {
            CosmosDBSqlRoleAssignmentResource.ValidateResourceId(id);
            return new CosmosDBSqlRoleAssignmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoDBDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoDBDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="MongoDBDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoDBDatabaseResource" /> object. </returns>
        public virtual MongoDBDatabaseResource GetMongoDBDatabaseResource(ResourceIdentifier id)
        {
            MongoDBDatabaseResource.ValidateResourceId(id);
            return new MongoDBDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoDBCollectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoDBCollectionResource.CreateResourceIdentifier" /> to create a <see cref="MongoDBCollectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoDBCollectionResource" /> object. </returns>
        public virtual MongoDBCollectionResource GetMongoDBCollectionResource(ResourceIdentifier id)
        {
            MongoDBCollectionResource.ValidateResourceId(id);
            return new MongoDBCollectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoDBRoleDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoDBRoleDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="MongoDBRoleDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoDBRoleDefinitionResource" /> object. </returns>
        public virtual MongoDBRoleDefinitionResource GetMongoDBRoleDefinitionResource(ResourceIdentifier id)
        {
            MongoDBRoleDefinitionResource.ValidateResourceId(id);
            return new MongoDBRoleDefinitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoDBUserDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoDBUserDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="MongoDBUserDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoDBUserDefinitionResource" /> object. </returns>
        public virtual MongoDBUserDefinitionResource GetMongoDBUserDefinitionResource(ResourceIdentifier id)
        {
            MongoDBUserDefinitionResource.ValidateResourceId(id);
            return new MongoDBUserDefinitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBTableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBTableResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBTableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBTableResource" /> object. </returns>
        public virtual CosmosDBTableResource GetCosmosDBTableResource(ResourceIdentifier id)
        {
            CosmosDBTableResource.ValidateResourceId(id);
            return new CosmosDBTableResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraKeyspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraKeyspaceResource.CreateResourceIdentifier" /> to create a <see cref="CassandraKeyspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraKeyspaceResource" /> object. </returns>
        public virtual CassandraKeyspaceResource GetCassandraKeyspaceResource(ResourceIdentifier id)
        {
            CassandraKeyspaceResource.ValidateResourceId(id);
            return new CassandraKeyspaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraTableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraTableResource.CreateResourceIdentifier" /> to create a <see cref="CassandraTableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraTableResource" /> object. </returns>
        public virtual CassandraTableResource GetCassandraTableResource(ResourceIdentifier id)
        {
            CassandraTableResource.ValidateResourceId(id);
            return new CassandraTableResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraViewGetResultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraViewGetResultResource.CreateResourceIdentifier" /> to create a <see cref="CassandraViewGetResultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraViewGetResultResource" /> object. </returns>
        public virtual CassandraViewGetResultResource GetCassandraViewGetResultResource(ResourceIdentifier id)
        {
            CassandraViewGetResultResource.ValidateResourceId(id);
            return new CassandraViewGetResultResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GremlinDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GremlinDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="GremlinDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GremlinDatabaseResource" /> object. </returns>
        public virtual GremlinDatabaseResource GetGremlinDatabaseResource(ResourceIdentifier id)
        {
            GremlinDatabaseResource.ValidateResourceId(id);
            return new GremlinDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GremlinGraphResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GremlinGraphResource.CreateResourceIdentifier" /> to create a <see cref="GremlinGraphResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GremlinGraphResource" /> object. </returns>
        public virtual GremlinGraphResource GetGremlinGraphResource(ResourceIdentifier id)
        {
            GremlinGraphResource.ValidateResourceId(id);
            return new GremlinGraphResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBLocationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBLocationResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBLocationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBLocationResource" /> object. </returns>
        public virtual CosmosDBLocationResource GetCosmosDBLocationResource(ResourceIdentifier id)
        {
            CosmosDBLocationResource.ValidateResourceId(id);
            return new CosmosDBLocationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataTransferJobGetResultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataTransferJobGetResultResource.CreateResourceIdentifier" /> to create a <see cref="DataTransferJobGetResultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataTransferJobGetResultResource" /> object. </returns>
        public virtual DataTransferJobGetResultResource GetDataTransferJobGetResultResource(ResourceIdentifier id)
        {
            DataTransferJobGetResultResource.ValidateResourceId(id);
            return new DataTransferJobGetResultResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraClusterResource.CreateResourceIdentifier" /> to create a <see cref="CassandraClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraClusterResource" /> object. </returns>
        public virtual CassandraClusterResource GetCassandraClusterResource(ResourceIdentifier id)
        {
            CassandraClusterResource.ValidateResourceId(id);
            return new CassandraClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraClusterBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraClusterBackupResource.CreateResourceIdentifier" /> to create a <see cref="CassandraClusterBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraClusterBackupResource" /> object. </returns>
        public virtual CassandraClusterBackupResource GetCassandraClusterBackupResource(ResourceIdentifier id)
        {
            CassandraClusterBackupResource.ValidateResourceId(id);
            return new CassandraClusterBackupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CassandraDataCenterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CassandraDataCenterResource.CreateResourceIdentifier" /> to create a <see cref="CassandraDataCenterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CassandraDataCenterResource" /> object. </returns>
        public virtual CassandraDataCenterResource GetCassandraDataCenterResource(ResourceIdentifier id)
        {
            CassandraDataCenterResource.ValidateResourceId(id);
            return new CassandraDataCenterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MongoClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MongoClusterResource.CreateResourceIdentifier" /> to create a <see cref="MongoClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MongoClusterResource" /> object. </returns>
        public virtual MongoClusterResource GetMongoClusterResource(ResourceIdentifier id)
        {
            MongoClusterResource.ValidateResourceId(id);
            return new MongoClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBFirewallRuleResource" /> object. </returns>
        public virtual CosmosDBFirewallRuleResource GetCosmosDBFirewallRuleResource(ResourceIdentifier id)
        {
            CosmosDBFirewallRuleResource.ValidateResourceId(id);
            return new CosmosDBFirewallRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBPrivateEndpointConnectionResource" /> object. </returns>
        public virtual CosmosDBPrivateEndpointConnectionResource GetCosmosDBPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            CosmosDBPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new CosmosDBPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBPrivateLinkResource" /> object. </returns>
        public virtual CosmosDBPrivateLinkResource GetCosmosDBPrivateLinkResource(ResourceIdentifier id)
        {
            CosmosDBPrivateLinkResource.ValidateResourceId(id);
            return new CosmosDBPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RestorableCosmosDBAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RestorableCosmosDBAccountResource.CreateResourceIdentifier" /> to create a <see cref="RestorableCosmosDBAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorableCosmosDBAccountResource" /> object. </returns>
        public virtual RestorableCosmosDBAccountResource GetRestorableCosmosDBAccountResource(ResourceIdentifier id)
        {
            RestorableCosmosDBAccountResource.ValidateResourceId(id);
            return new RestorableCosmosDBAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CosmosDBServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CosmosDBServiceResource.CreateResourceIdentifier" /> to create a <see cref="CosmosDBServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CosmosDBServiceResource" /> object. </returns>
        public virtual CosmosDBServiceResource GetCosmosDBServiceResource(ResourceIdentifier id)
        {
            CosmosDBServiceResource.ValidateResourceId(id);
            return new CosmosDBServiceResource(Client, id);
        }
    }
}
