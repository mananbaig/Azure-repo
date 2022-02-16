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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnGatewayNatRule and their operations over its parent. </summary>
    public partial class VpnGatewayNatRuleCollection : ArmCollection, IEnumerable<VpnGatewayNatRule>, IAsyncEnumerable<VpnGatewayNatRule>
    {
        private readonly ClientDiagnostics _vpnGatewayNatRuleNatRulesClientDiagnostics;
        private readonly NatRulesRestOperations _vpnGatewayNatRuleNatRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class for mocking. </summary>
        protected VpnGatewayNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnGatewayNatRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnGatewayNatRuleNatRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnGatewayNatRule.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VpnGatewayNatRule.ResourceType, out string vpnGatewayNatRuleNatRulesApiVersion);
            _vpnGatewayNatRuleNatRulesRestClient = new NatRulesRestOperations(_vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vpnGatewayNatRuleNatRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VpnGateway.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VpnGateway.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<VpnGatewayNatRule>> CreateOrUpdateAsync(bool waitForCompletion, string natRuleName, VpnGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnGatewayNatRule>(new VpnGatewayNatRuleOperationSource(Client), _vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual ArmOperation<VpnGatewayNatRule> CreateOrUpdate(bool waitForCompletion, string natRuleName, VpnGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                var operation = new NetworkArmOperation<VpnGatewayNatRule>(new VpnGatewayNatRuleOperationSource(Client), _vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a nat ruleGet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VpnGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a nat ruleGet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VpnGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules
        /// Operation Id: NatRules_ListByVpnGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGatewayNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules
        /// Operation Id: NatRules_ListByVpnGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGatewayNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(natRuleName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VpnGatewayNatRule>> GetIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VpnGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VpnGatewayNatRule> GetIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VpnGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnGatewayNatRule> IEnumerable<VpnGatewayNatRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnGatewayNatRule> IAsyncEnumerable<VpnGatewayNatRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
