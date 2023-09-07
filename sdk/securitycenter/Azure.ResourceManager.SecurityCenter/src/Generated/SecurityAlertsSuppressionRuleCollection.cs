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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityAlertsSuppressionRuleResource" /> and their operations.
    /// Each <see cref="SecurityAlertsSuppressionRuleResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SecurityAlertsSuppressionRuleCollection" /> instance call the GetSecurityAlertsSuppressionRules method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SecurityAlertsSuppressionRuleCollection : ArmCollection, IEnumerable<SecurityAlertsSuppressionRuleResource>, IAsyncEnumerable<SecurityAlertsSuppressionRuleResource>
    {
        private readonly ClientDiagnostics _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics;
        private readonly AlertsSuppressionRulesRestOperations _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityAlertsSuppressionRuleCollection"/> class for mocking. </summary>
        protected SecurityAlertsSuppressionRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityAlertsSuppressionRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityAlertsSuppressionRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityAlertsSuppressionRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityAlertsSuppressionRuleResource.ResourceType, out string securityAlertsSuppressionRuleAlertsSuppressionRulesApiVersion);
            _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient = new AlertsSuppressionRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityAlertsSuppressionRuleAlertsSuppressionRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update existing rule or create new rule if it doesn't exist
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="data"> Suppression rule object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityAlertsSuppressionRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string alertsSuppressionRuleName, SecurityAlertsSuppressionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.UpdateAsync(Id.SubscriptionId, alertsSuppressionRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityAlertsSuppressionRuleResource>(Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response), response.GetRawResponse()));
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
        /// Update existing rule or create new rule if it doesn't exist
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="data"> Suppression rule object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityAlertsSuppressionRuleResource> CreateOrUpdate(WaitUntil waitUntil, string alertsSuppressionRuleName, SecurityAlertsSuppressionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.Update(Id.SubscriptionId, alertsSuppressionRuleName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityAlertsSuppressionRuleResource>(Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response), response.GetRawResponse()));
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
        /// Get dismiss rule, with name: {alertsSuppressionRuleName}, for the given subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual async Task<Response<SecurityAlertsSuppressionRuleResource>> GetAsync(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.GetAsync(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get dismiss rule, with name: {alertsSuppressionRuleName}, for the given subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual Response<SecurityAlertsSuppressionRuleResource> Get(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.Get(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of all the dismiss rules for the given subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertType"> Type of the alert to get rules for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityAlertsSuppressionRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityAlertsSuppressionRuleResource> GetAllAsync(string alertType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateListRequest(Id.SubscriptionId, alertType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, alertType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SecurityAlertsSuppressionRuleResource(Client, SecurityAlertsSuppressionRuleData.DeserializeSecurityAlertsSuppressionRuleData(e)), _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics, Pipeline, "SecurityAlertsSuppressionRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of all the dismiss rules for the given subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertType"> Type of the alert to get rules for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityAlertsSuppressionRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityAlertsSuppressionRuleResource> GetAll(string alertType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateListRequest(Id.SubscriptionId, alertType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, alertType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SecurityAlertsSuppressionRuleResource(Client, SecurityAlertsSuppressionRuleData.DeserializeSecurityAlertsSuppressionRuleData(e)), _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics, Pipeline, "SecurityAlertsSuppressionRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.GetAsync(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertsSuppressionRuleName"> The unique name of the suppression alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertsSuppressionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertsSuppressionRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertsSuppressionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertsSuppressionRuleName, nameof(alertsSuppressionRuleName));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.Get(Id.SubscriptionId, alertsSuppressionRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityAlertsSuppressionRuleResource> IEnumerable<SecurityAlertsSuppressionRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityAlertsSuppressionRuleResource> IAsyncEnumerable<SecurityAlertsSuppressionRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
