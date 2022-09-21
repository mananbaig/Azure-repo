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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerJobExecutionStepTarget along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerJobExecutionStepTargetResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerJobExecutionStepTargetResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerJobExecutionStepResource" /> using the GetSqlServerJobExecutionStepTarget method.
    /// </summary>
    public partial class SqlServerJobExecutionStepTargetResource : BaseSqlServerJobExecutionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerJobExecutionStepTargetResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName, Guid targetId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics;
        private readonly JobTargetExecutionsRestOperations _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepTargetResource"/> class for mocking. </summary>
        protected SqlServerJobExecutionStepTargetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerJobExecutionStepTargetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerJobExecutionStepTargetResource(ArmClient client, SqlServerJobExecutionData data) : base(client, data)
        {
            _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
            _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepTargetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerJobExecutionStepTargetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
            _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs/executions/steps/targets";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseSqlServerJobExecutionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepTargetResource.GetCore");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Guid.Parse(Id.Parent.Parent.Name), Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SqlServerJobExecutionStepTargetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SqlServerJobExecutionStepTargetResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseSqlServerJobExecutionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepTargetResource.GetCore");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Guid.Parse(Id.Parent.Parent.Name), Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SqlServerJobExecutionStepTargetResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SqlServerJobExecutionStepTargetResource)value.Value, value.GetRawResponse());
        }
    }
}
