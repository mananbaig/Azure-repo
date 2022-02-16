// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a SqlAgentConfiguration along with the instance operations that can be performed on it. </summary>
    public partial class SqlAgentConfiguration : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlAgentConfiguration"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlAgentConfigurationSqlAgentClientDiagnostics;
        private readonly SqlAgentRestOperations _sqlAgentConfigurationSqlAgentRestClient;
        private readonly SqlAgentConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlAgentConfiguration"/> class for mocking. </summary>
        protected SqlAgentConfiguration()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlAgentConfiguration"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlAgentConfiguration(ArmClient client, SqlAgentConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlAgentConfiguration"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlAgentConfiguration(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlAgentConfigurationSqlAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string sqlAgentConfigurationSqlAgentApiVersion);
            _sqlAgentConfigurationSqlAgentRestClient = new SqlAgentRestOperations(_sqlAgentConfigurationSqlAgentClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlAgentConfigurationSqlAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/sqlAgent";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlAgentConfigurationData Data
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
        /// Gets current instance sql agent configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// Operation Id: SqlAgent_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SqlAgentConfiguration>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlAgentConfigurationSqlAgentClientDiagnostics.CreateScope("SqlAgentConfiguration.Get");
            scope.Start();
            try
            {
                var response = await _sqlAgentConfigurationSqlAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sqlAgentConfigurationSqlAgentClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlAgentConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets current instance sql agent configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// Operation Id: SqlAgent_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlAgentConfiguration> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlAgentConfigurationSqlAgentClientDiagnostics.CreateScope("SqlAgentConfiguration.Get");
            scope.Start();
            try
            {
                var response = _sqlAgentConfigurationSqlAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _sqlAgentConfigurationSqlAgentClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlAgentConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Puts new sql agent configuration to instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// Operation Id: SqlAgent_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The SqlAgentConfiguration to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SqlAgentConfiguration>> CreateOrUpdateAsync(bool waitForCompletion, SqlAgentConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _sqlAgentConfigurationSqlAgentClientDiagnostics.CreateScope("SqlAgentConfiguration.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlAgentConfigurationSqlAgentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlAgentConfiguration>(Response.FromValue(new SqlAgentConfiguration(Client, response), response.GetRawResponse()));
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
        /// Puts new sql agent configuration to instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// Operation Id: SqlAgent_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The SqlAgentConfiguration to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SqlAgentConfiguration> CreateOrUpdate(bool waitForCompletion, SqlAgentConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _sqlAgentConfigurationSqlAgentClientDiagnostics.CreateScope("SqlAgentConfiguration.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlAgentConfigurationSqlAgentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<SqlAgentConfiguration>(Response.FromValue(new SqlAgentConfiguration(Client, response), response.GetRawResponse()));
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
    }
}
