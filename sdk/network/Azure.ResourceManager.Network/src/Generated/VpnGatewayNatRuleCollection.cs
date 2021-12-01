// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnGatewayNatRule and their operations over its parent. </summary>
    public partial class VpnGatewayNatRuleCollection : ArmCollection, IEnumerable<VpnGatewayNatRule>, IAsyncEnumerable<VpnGatewayNatRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NatRulesRestOperations _natRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class for mocking. </summary>
        protected VpnGatewayNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of VpnGatewayNatRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnGatewayNatRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _natRulesRestClient = new NatRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VpnGateway.ResourceType;

        // Collection level operations.

        /// <summary> Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual NatRuleCreateOrUpdateOperation CreateOrUpdate(string natRuleName, VpnGatewayNatRuleData natRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _natRulesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                var operation = new NatRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _natRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
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

        /// <summary> Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<NatRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string natRuleName, VpnGatewayNatRuleData natRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _natRulesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NatRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _natRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
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

        /// <summary> Retrieves the details of a nat ruleGet. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VpnGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _natRulesRestClient.Get(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a nat ruleGet. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VpnGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _natRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnGatewayNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VpnGatewayNatRule> GetIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _natRulesRestClient.Get(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VpnGatewayNatRule>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VpnGatewayNatRule>> GetIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _natRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VpnGatewayNatRule>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CheckIfExists");
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

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CheckIfExistsAsync");
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

        /// <summary> Retrieves all nat rules for a particular virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _natRulesRestClient.ListByVpnGateway(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _natRulesRestClient.ListByVpnGatewayNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all nat rules for a particular virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _natRulesRestClient.ListByVpnGatewayAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _natRulesRestClient.ListByVpnGatewayNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
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

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VpnGatewayNatRule, VpnGatewayNatRuleData> Construct() { }
    }
}
