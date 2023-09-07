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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlFirewallRuleResource" /> and their operations.
    /// Each <see cref="PostgreSqlFirewallRuleResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlServerResource" />.
    /// To get a <see cref="PostgreSqlFirewallRuleCollection" /> instance call the GetPostgreSqlFirewallRules method from an instance of <see cref="PostgreSqlServerResource" />.
    /// </summary>
    public partial class PostgreSqlFirewallRuleCollection : ArmCollection, IEnumerable<PostgreSqlFirewallRuleResource>, IAsyncEnumerable<PostgreSqlFirewallRuleResource>
    {
        private readonly ClientDiagnostics _postgreSqlFirewallRuleFirewallRulesClientDiagnostics;
        private readonly FirewallRulesRestOperations _postgreSqlFirewallRuleFirewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFirewallRuleCollection"/> class for mocking. </summary>
        protected PostgreSqlFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlFirewallRuleFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", PostgreSqlFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlFirewallRuleResource.ResourceType, out string postgreSqlFirewallRuleFirewallRulesApiVersion);
            _postgreSqlFirewallRuleFirewallRulesRestClient = new FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlFirewallRuleFirewallRulesApiVersion);
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
        /// Creates a new firewall rule or updates an existing firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallRuleName, PostgreSqlFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlFirewallRuleFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<PostgreSqlFirewallRuleResource>(new PostgreSqlFirewallRuleOperationSource(Client), _postgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _postgreSqlFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates a new firewall rule or updates an existing firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string firewallRuleName, PostgreSqlFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlFirewallRuleFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken);
                var operation = new PostgreSqlArmOperation<PostgreSqlFirewallRuleResource>(new PostgreSqlFirewallRuleOperationSource(Client), _postgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _postgreSqlFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Gets information about a server firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFirewallRuleResource>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a server firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<PostgreSqlFirewallRuleResource> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the firewall rules in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFirewallRuleFirewallRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new PostgreSqlFirewallRuleResource(Client, PostgreSqlFirewallRuleData.DeserializePostgreSqlFirewallRuleData(e)), _postgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "PostgreSqlFirewallRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the firewall rules in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFirewallRuleFirewallRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new PostgreSqlFirewallRuleResource(Client, PostgreSqlFirewallRuleData.DeserializePostgreSqlFirewallRuleData(e)), _postgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "PostgreSqlFirewallRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlFirewallRuleResource> IEnumerable<PostgreSqlFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlFirewallRuleResource> IAsyncEnumerable<PostgreSqlFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
