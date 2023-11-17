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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="EventHubsDisasterRecoveryResource" />.
    /// To get an <see cref="EventHubsDisasterRecoveryAuthorizationRuleCollection" /> instance call the GetEventHubsDisasterRecoveryAuthorizationRules method from an instance of <see cref="EventHubsDisasterRecoveryResource" />.
    /// </summary>
    public partial class EventHubsDisasterRecoveryAuthorizationRuleCollection : ArmCollection, IEnumerable<EventHubsDisasterRecoveryAuthorizationRuleResource>, IAsyncEnumerable<EventHubsDisasterRecoveryAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryAuthorizationRuleCollection"/> class for mocking. </summary>
        protected EventHubsDisasterRecoveryAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsDisasterRecoveryAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsDisasterRecoveryAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsDisasterRecoveryAuthorizationRuleResource.ResourceType, out string eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubsDisasterRecoveryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubsDisasterRecoveryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<EventHubsDisasterRecoveryAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<EventHubsDisasterRecoveryAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of authorization rules for a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_ListAuthorizationRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsDisasterRecoveryAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, EventHubsAuthorizationRuleData.DeserializeEventHubsAuthorizationRuleData(e)), _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics, Pipeline, "EventHubsDisasterRecoveryAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of authorization rules for a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_ListAuthorizationRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsDisasterRecoveryAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, EventHubsAuthorizationRuleData.DeserializeEventHubsAuthorizationRuleData(e)), _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics, Pipeline, "EventHubsDisasterRecoveryAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubsDisasterRecoveryAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsDisasterRecoveryAuthorizationRuleResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual NullableResponse<EventHubsDisasterRecoveryAuthorizationRuleResource> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsDisasterRecoveryAuthorizationRuleResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsDisasterRecoveryAuthorizationRuleResource> IEnumerable<EventHubsDisasterRecoveryAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsDisasterRecoveryAuthorizationRuleResource> IAsyncEnumerable<EventHubsDisasterRecoveryAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
