// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerJobVersionResource" /> and their operations.
    /// Each <see cref="SqlServerJobVersionResource" /> in the collection will belong to the same instance of <see cref="SqlServerJobResource" />.
    /// To get a <see cref="SqlServerJobVersionCollection" /> instance call the GetSqlServerJobVersions method from an instance of <see cref="SqlServerJobResource" />.
    /// </summary>
    public partial class SqlServerJobVersionCollection : ArmCollection, IEnumerable<SqlServerJobVersionResource>, IAsyncEnumerable<SqlServerJobVersionResource>
    {
        private readonly ClientDiagnostics _sqlServerJobVersionJobVersionsClientDiagnostics;
        private readonly JobVersionsRestOperations _sqlServerJobVersionJobVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionCollection"/> class for mocking. </summary>
        protected SqlServerJobVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobVersionJobVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobVersionResource.ResourceType, out string sqlServerJobVersionJobVersionsApiVersion);
            _sqlServerJobVersionJobVersionsRestClient = new JobVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobVersionJobVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a job version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerJobVersionResource>> GetAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionJobVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerJobVersionResource> Get(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionJobVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all versions of a job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_ListByJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobVersionJobVersionsRestClient.CreateListByJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobVersionJobVersionsRestClient.CreateListByJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobVersionResource(Client, SqlServerJobVersionData.DeserializeSqlServerJobVersionData(e)), _sqlServerJobVersionJobVersionsClientDiagnostics, Pipeline, "SqlServerJobVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all versions of a job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_ListByJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobVersionJobVersionsRestClient.CreateListByJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobVersionJobVersionsRestClient.CreateListByJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobVersionResource(Client, SqlServerJobVersionData.DeserializeSqlServerJobVersionData(e)), _sqlServerJobVersionJobVersionsClientDiagnostics, Pipeline, "SqlServerJobVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionJobVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionJobVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SqlServerJobVersionResource>> GetIfExistsAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionJobVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobVersionResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SqlServerJobVersionResource> GetIfExists(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionJobVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobVersionResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobVersionResource> IEnumerable<SqlServerJobVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobVersionResource> IAsyncEnumerable<SqlServerJobVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
