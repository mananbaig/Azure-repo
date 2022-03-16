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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerJobAgentJobExecutionStepTarget and their operations over its parent. </summary>
    public partial class ServerJobAgentJobExecutionStepTargetCollection : ArmCollection, IEnumerable<ServerJobAgentJobExecutionStepTargetResource>, IAsyncEnumerable<ServerJobAgentJobExecutionStepTargetResource>
    {
        private readonly ClientDiagnostics _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics;
        private readonly JobTargetExecutionsRestOperations _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionStepTargetCollection"/> class for mocking. </summary>
        protected ServerJobAgentJobExecutionStepTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionStepTargetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerJobAgentJobExecutionStepTargetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerJobAgentJobExecutionStepTargetResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerJobAgentJobExecutionStepTargetResource.ResourceType, out string serverJobAgentJobExecutionStepTargetJobTargetExecutionsApiVersion);
            _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverJobAgentJobExecutionStepTargetJobTargetExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerJobAgentJobExecutionStepResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerJobAgentJobExecutionStepResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerJobAgentJobExecutionStepTargetResource>> GetAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepTargetResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecutionStepTargetResource> Get(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the target executions of a job step execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets
        /// Operation Id: JobTargetExecutions_ListByStep
        /// </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobExecutionStepTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobExecutionStepTargetResource> GetAllAsync(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobExecutionStepTargetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByStepAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobExecutionStepTargetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByStepNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the target executions of a job step execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets
        /// Operation Id: JobTargetExecutions_ListByStep
        /// </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobExecutionStepTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobExecutionStepTargetResource> GetAll(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobExecutionStepTargetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByStep(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobExecutionStepTargetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByStepNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(targetId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(targetId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerJobAgentJobExecutionStepTargetResource>> GetIfExistsAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerJobAgentJobExecutionStepTargetResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecutionStepTargetResource> GetIfExists(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerJobAgentJobExecutionStepTargetResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerJobAgentJobExecutionStepTargetResource> IEnumerable<ServerJobAgentJobExecutionStepTargetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerJobAgentJobExecutionStepTargetResource> IAsyncEnumerable<ServerJobAgentJobExecutionStepTargetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
