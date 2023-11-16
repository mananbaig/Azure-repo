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

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlConfigurationResource" /> and their operations.
    /// Each <see cref="PostgreSqlConfigurationResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlServerResource" />.
    /// To get a <see cref="PostgreSqlConfigurationCollection" /> instance call the GetPostgreSqlConfigurations method from an instance of <see cref="PostgreSqlServerResource" />.
    /// </summary>
    public partial class PostgreSqlConfigurationCollection : ArmCollection, IEnumerable<PostgreSqlConfigurationResource>, IAsyncEnumerable<PostgreSqlConfigurationResource>
    {
        private readonly ClientDiagnostics _postgreSqlConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _postgreSqlConfigurationConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlConfigurationCollection"/> class for mocking. </summary>
        protected PostgreSqlConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", PostgreSqlConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlConfigurationResource.ResourceType, out string postgreSqlConfigurationConfigurationsApiVersion);
            _postgreSqlConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a configuration of a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="data"> The required parameters for updating a server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationName, PostgreSqlConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlConfigurationConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<PostgreSqlConfigurationResource>(new PostgreSqlConfigurationOperationSource(Client), _postgreSqlConfigurationConfigurationsClientDiagnostics, Pipeline, _postgreSqlConfigurationConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a configuration of a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="data"> The required parameters for updating a server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string configurationName, PostgreSqlConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlConfigurationConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken);
                var operation = new PostgreSqlArmOperation<PostgreSqlConfigurationResource>(new PostgreSqlConfigurationOperationSource(Client), _postgreSqlConfigurationConfigurationsClientDiagnostics, Pipeline, _postgreSqlConfigurationConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a configuration of server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlConfigurationResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<PostgreSqlConfigurationResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlConfigurationConfigurationsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new PostgreSqlConfigurationResource(Client, PostgreSqlConfigurationData.DeserializePostgreSqlConfigurationData(e)), _postgreSqlConfigurationConfigurationsClientDiagnostics, Pipeline, "PostgreSqlConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlConfigurationConfigurationsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new PostgreSqlConfigurationResource(Client, PostgreSqlConfigurationData.DeserializePostgreSqlConfigurationData(e)), _postgreSqlConfigurationConfigurationsClientDiagnostics, Pipeline, "PostgreSqlConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<PostgreSqlConfigurationResource>> GetIfExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _postgreSqlConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual NullableResponse<PostgreSqlConfigurationResource> GetIfExists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _postgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("PostgreSqlConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _postgreSqlConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlConfigurationResource> IEnumerable<PostgreSqlConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlConfigurationResource> IAsyncEnumerable<PostgreSqlConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
