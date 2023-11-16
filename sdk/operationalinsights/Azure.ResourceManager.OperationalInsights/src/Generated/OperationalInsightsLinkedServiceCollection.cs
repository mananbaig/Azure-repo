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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="OperationalInsightsLinkedServiceResource" /> and their operations.
    /// Each <see cref="OperationalInsightsLinkedServiceResource" /> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceResource" />.
    /// To get an <see cref="OperationalInsightsLinkedServiceCollection" /> instance call the GetOperationalInsightsLinkedServices method from an instance of <see cref="OperationalInsightsWorkspaceResource" />.
    /// </summary>
    public partial class OperationalInsightsLinkedServiceCollection : ArmCollection, IEnumerable<OperationalInsightsLinkedServiceResource>, IAsyncEnumerable<OperationalInsightsLinkedServiceResource>
    {
        private readonly ClientDiagnostics _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics;
        private readonly LinkedServicesRestOperations _operationalInsightsLinkedServiceLinkedServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsLinkedServiceCollection"/> class for mocking. </summary>
        protected OperationalInsightsLinkedServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsLinkedServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OperationalInsightsLinkedServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsLinkedServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OperationalInsightsLinkedServiceResource.ResourceType, out string operationalInsightsLinkedServiceLinkedServicesApiVersion);
            _operationalInsightsLinkedServiceLinkedServicesRestClient = new LinkedServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, operationalInsightsLinkedServiceLinkedServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a linked service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkedServiceName"> Name of the linkedServices resource. </param>
        /// <param name="data"> The parameters required to create or update a linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OperationalInsightsLinkedServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkedServiceName, OperationalInsightsLinkedServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedServiceLinkedServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsLinkedServiceResource>(new OperationalInsightsLinkedServiceOperationSource(Client), _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics, Pipeline, _operationalInsightsLinkedServiceLinkedServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a linked service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkedServiceName"> Name of the linkedServices resource. </param>
        /// <param name="data"> The parameters required to create or update a linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OperationalInsightsLinkedServiceResource> CreateOrUpdate(WaitUntil waitUntil, string linkedServiceName, OperationalInsightsLinkedServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedServiceLinkedServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsLinkedServiceResource>(new OperationalInsightsLinkedServiceOperationSource(Client), _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics, Pipeline, _operationalInsightsLinkedServiceLinkedServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a linked service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServiceName"> Name of the linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual async Task<Response<OperationalInsightsLinkedServiceResource>> GetAsync(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedServiceLinkedServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a linked service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServiceName"> Name of the linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual Response<OperationalInsightsLinkedServiceResource> Get(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedServiceLinkedServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the linked services instances in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsLinkedServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsLinkedServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsLinkedServiceLinkedServicesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new OperationalInsightsLinkedServiceResource(Client, OperationalInsightsLinkedServiceData.DeserializeOperationalInsightsLinkedServiceData(e)), _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics, Pipeline, "OperationalInsightsLinkedServiceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the linked services instances in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsLinkedServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsLinkedServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsLinkedServiceLinkedServicesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new OperationalInsightsLinkedServiceResource(Client, OperationalInsightsLinkedServiceData.DeserializeOperationalInsightsLinkedServiceData(e)), _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics, Pipeline, "OperationalInsightsLinkedServiceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServiceName"> Name of the linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedServiceLinkedServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServiceName"> Name of the linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedServiceLinkedServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServiceName"> Name of the linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<OperationalInsightsLinkedServiceResource>> GetIfExistsAsync(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsLinkedServiceLinkedServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<OperationalInsightsLinkedServiceResource>(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/linkedServices/{linkedServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServiceName"> Name of the linked service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual NullableResponse<OperationalInsightsLinkedServiceResource> GetIfExists(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServiceName, nameof(linkedServiceName));

            using var scope = _operationalInsightsLinkedServiceLinkedServicesClientDiagnostics.CreateScope("OperationalInsightsLinkedServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _operationalInsightsLinkedServiceLinkedServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<OperationalInsightsLinkedServiceResource>(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsLinkedServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OperationalInsightsLinkedServiceResource> IEnumerable<OperationalInsightsLinkedServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OperationalInsightsLinkedServiceResource> IAsyncEnumerable<OperationalInsightsLinkedServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
