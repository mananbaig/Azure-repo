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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionGovernanceRuleResource" /> and their operations.
    /// Each <see cref="SubscriptionGovernanceRuleResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionGovernanceRuleCollection" /> instance call the GetSubscriptionGovernanceRules method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionGovernanceRuleCollection : ArmCollection, IEnumerable<SubscriptionGovernanceRuleResource>, IAsyncEnumerable<SubscriptionGovernanceRuleResource>
    {
        private readonly ClientDiagnostics _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics;
        private readonly GovernanceRulesRestOperations _subscriptionGovernanceRuleGovernanceRulesRestClient;
        private readonly ClientDiagnostics _subscriptionGovernanceRuleGovernanceRuleClientDiagnostics;
        private readonly GovernanceRuleRestOperations _subscriptionGovernanceRuleGovernanceRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionGovernanceRuleCollection"/> class for mocking. </summary>
        protected SubscriptionGovernanceRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionGovernanceRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionGovernanceRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SubscriptionGovernanceRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionGovernanceRuleResource.ResourceType, out string subscriptionGovernanceRuleGovernanceRulesApiVersion);
            _subscriptionGovernanceRuleGovernanceRulesRestClient = new GovernanceRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionGovernanceRuleGovernanceRulesApiVersion);
            _subscriptionGovernanceRuleGovernanceRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SubscriptionGovernanceRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionGovernanceRuleResource.ResourceType, out string subscriptionGovernanceRuleGovernanceRuleApiVersion);
            _subscriptionGovernanceRuleGovernanceRuleRestClient = new GovernanceRuleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionGovernanceRuleGovernanceRuleApiVersion);
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
        /// Creates or update a security GovernanceRule on the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules/{ruleId}
        /// Operation Id: GovernanceRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="data"> GovernanceRule over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionGovernanceRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleId, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionGovernanceRuleGovernanceRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, ruleId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SubscriptionGovernanceRuleResource>(Response.FromValue(new SubscriptionGovernanceRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or update a security GovernanceRule on the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules/{ruleId}
        /// Operation Id: GovernanceRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="data"> GovernanceRule over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionGovernanceRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleId, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionGovernanceRuleGovernanceRulesRestClient.CreateOrUpdate(Id.SubscriptionId, ruleId, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SubscriptionGovernanceRuleResource>(Response.FromValue(new SubscriptionGovernanceRuleResource(Client, response), response.GetRawResponse()));
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
        /// Get a specific governanceRule for the requested scope by ruleId
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules/{ruleId}
        /// Operation Id: GovernanceRules_Get
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<Response<SubscriptionGovernanceRuleResource>> GetAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionGovernanceRuleGovernanceRulesRestClient.GetAsync(Id.SubscriptionId, ruleId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionGovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific governanceRule for the requested scope by ruleId
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules/{ruleId}
        /// Operation Id: GovernanceRules_Get
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual Response<SubscriptionGovernanceRuleResource> Get(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionGovernanceRuleGovernanceRulesRestClient.Get(Id.SubscriptionId, ruleId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionGovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all relevant governanceRules over a subscription level scope
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules
        /// Operation Id: GovernanceRule_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionGovernanceRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionGovernanceRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionGovernanceRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionGovernanceRuleGovernanceRuleClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionGovernanceRuleGovernanceRuleRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionGovernanceRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionGovernanceRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionGovernanceRuleGovernanceRuleClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionGovernanceRuleGovernanceRuleRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionGovernanceRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get a list of all relevant governanceRules over a subscription level scope
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules
        /// Operation Id: GovernanceRule_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionGovernanceRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionGovernanceRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubscriptionGovernanceRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionGovernanceRuleGovernanceRuleClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionGovernanceRuleGovernanceRuleRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionGovernanceRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionGovernanceRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionGovernanceRuleGovernanceRuleClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionGovernanceRuleGovernanceRuleRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionGovernanceRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules/{ruleId}
        /// Operation Id: GovernanceRules_Get
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionGovernanceRuleGovernanceRulesRestClient.GetAsync(Id.SubscriptionId, ruleId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/governanceRules/{ruleId}
        /// Operation Id: GovernanceRules_Get
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _subscriptionGovernanceRuleGovernanceRulesClientDiagnostics.CreateScope("SubscriptionGovernanceRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionGovernanceRuleGovernanceRulesRestClient.Get(Id.SubscriptionId, ruleId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionGovernanceRuleResource> IEnumerable<SubscriptionGovernanceRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionGovernanceRuleResource> IAsyncEnumerable<SubscriptionGovernanceRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
