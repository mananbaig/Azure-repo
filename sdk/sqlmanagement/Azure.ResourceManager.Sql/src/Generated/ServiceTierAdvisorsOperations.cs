// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ServiceTierAdvisors service client. </summary>
    public partial class ServiceTierAdvisorsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServiceTierAdvisorsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ServiceTierAdvisorsOperations for mocking. </summary>
        protected ServiceTierAdvisorsOperations()
        {
        }

        /// <summary> Initializes a new instance of ServiceTierAdvisorsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ServiceTierAdvisorsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ServiceTierAdvisorsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a service tier advisor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of database. </param>
        /// <param name="serviceTierAdvisorName"> The name of service tier advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceTierAdvisor>> GetAsync(string resourceGroupName, string serverName, string databaseName, string serviceTierAdvisorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceTierAdvisorsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, databaseName, serviceTierAdvisorName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a service tier advisor. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of database. </param>
        /// <param name="serviceTierAdvisorName"> The name of service tier advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceTierAdvisor> Get(string resourceGroupName, string serverName, string databaseName, string serviceTierAdvisorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceTierAdvisorsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, databaseName, serviceTierAdvisorName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns service tier advisors for specified database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual AsyncPageable<ServiceTierAdvisor> ListByDatabaseAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            async Task<Page<ServiceTierAdvisor>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceTierAdvisorsOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByDatabaseAsync(resourceGroupName, serverName, databaseName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Returns service tier advisors for specified database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual Pageable<ServiceTierAdvisor> ListByDatabase(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Page<ServiceTierAdvisor> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceTierAdvisorsOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListByDatabase(resourceGroupName, serverName, databaseName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
