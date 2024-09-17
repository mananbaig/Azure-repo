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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsIncidentRelationResource"/> and their operations.
    /// Each <see cref="SecurityInsightsIncidentRelationResource"/> in the collection will belong to the same instance of <see cref="SecurityInsightsIncidentResource"/>.
    /// To get a <see cref="SecurityInsightsIncidentRelationCollection"/> instance call the GetSecurityInsightsIncidentRelations method from an instance of <see cref="SecurityInsightsIncidentResource"/>.
    /// </summary>
    public partial class SecurityInsightsIncidentRelationCollection : ArmCollection, IEnumerable<SecurityInsightsIncidentRelationResource>, IAsyncEnumerable<SecurityInsightsIncidentRelationResource>
    {
        private readonly ClientDiagnostics _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics;
        private readonly IncidentRelationsRestOperations _securityInsightsIncidentRelationIncidentRelationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsIncidentRelationCollection"/> class for mocking. </summary>
        protected SecurityInsightsIncidentRelationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsIncidentRelationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsIncidentRelationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsIncidentRelationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsIncidentRelationResource.ResourceType, out string securityInsightsIncidentRelationIncidentRelationsApiVersion);
            _securityInsightsIncidentRelationIncidentRelationsRestClient = new IncidentRelationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsIncidentRelationIncidentRelationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityInsightsIncidentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityInsightsIncidentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the incident relation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="data"> The relation model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsIncidentRelationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string relationName, SecurityInsightsIncidentRelationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsIncidentRelationResource>(Response.FromValue(new SecurityInsightsIncidentRelationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates the incident relation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="data"> The relation model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsIncidentRelationResource> CreateOrUpdate(WaitUntil waitUntil, string relationName, SecurityInsightsIncidentRelationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data, cancellationToken);
                var uri = _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsIncidentRelationResource>(Response.FromValue(new SecurityInsightsIncidentRelationResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets an incident relation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsIncidentRelationResource>> GetAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentRelationIncidentRelationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an incident relation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual Response<SecurityInsightsIncidentRelationResource> Get(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentRelationIncidentRelationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all incident relations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsIncidentRelationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsIncidentRelationResource> GetAllAsync(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsIncidentRelationResource(Client, SecurityInsightsIncidentRelationData.DeserializeSecurityInsightsIncidentRelationData(e)), _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics, Pipeline, "SecurityInsightsIncidentRelationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all incident relations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsIncidentRelationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsIncidentRelationResource> GetAll(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsIncidentRelationIncidentRelationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsIncidentRelationResource(Client, SecurityInsightsIncidentRelationData.DeserializeSecurityInsightsIncidentRelationData(e)), _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics, Pipeline, "SecurityInsightsIncidentRelationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentRelationIncidentRelationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual Response<bool> Exists(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentRelationIncidentRelationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsIncidentRelationResource>> GetIfExistsAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentRelationIncidentRelationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsIncidentRelationResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentRelationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/relations/{relationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentRelations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentRelationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsIncidentRelationResource> GetIfExists(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _securityInsightsIncidentRelationIncidentRelationsClientDiagnostics.CreateScope("SecurityInsightsIncidentRelationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentRelationIncidentRelationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsIncidentRelationResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsIncidentRelationResource> IEnumerable<SecurityInsightsIncidentRelationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsIncidentRelationResource> IAsyncEnumerable<SecurityInsightsIncidentRelationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
