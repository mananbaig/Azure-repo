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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="OperationalInsightsWorkspaceResource" /> and their operations.
    /// Each <see cref="OperationalInsightsWorkspaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="OperationalInsightsWorkspaceCollection" /> instance call the GetOperationalInsightsWorkspaces method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class OperationalInsightsWorkspaceCollection : ArmCollection, IEnumerable<OperationalInsightsWorkspaceResource>, IAsyncEnumerable<OperationalInsightsWorkspaceResource>
    {
        private readonly ClientDiagnostics _operationalInsightsWorkspaceWorkspacesClientDiagnostics;
        private readonly WorkspacesRestOperations _operationalInsightsWorkspaceWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsWorkspaceCollection"/> class for mocking. </summary>
        protected OperationalInsightsWorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsWorkspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OperationalInsightsWorkspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _operationalInsightsWorkspaceWorkspacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsWorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OperationalInsightsWorkspaceResource.ResourceType, out string operationalInsightsWorkspaceWorkspacesApiVersion);
            _operationalInsightsWorkspaceWorkspacesRestClient = new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, operationalInsightsWorkspaceWorkspacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="data"> The parameters required to create or update a workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OperationalInsightsWorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workspaceName, OperationalInsightsWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsWorkspaceWorkspacesClientDiagnostics.CreateScope("OperationalInsightsWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _operationalInsightsWorkspaceWorkspacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsWorkspaceResource>(new OperationalInsightsWorkspaceOperationSource(Client), _operationalInsightsWorkspaceWorkspacesClientDiagnostics, Pipeline, _operationalInsightsWorkspaceWorkspacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="data"> The parameters required to create or update a workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OperationalInsightsWorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string workspaceName, OperationalInsightsWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsWorkspaceWorkspacesClientDiagnostics.CreateScope("OperationalInsightsWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _operationalInsightsWorkspaceWorkspacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsWorkspaceResource>(new OperationalInsightsWorkspaceOperationSource(Client), _operationalInsightsWorkspaceWorkspacesClientDiagnostics, Pipeline, _operationalInsightsWorkspaceWorkspacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a workspace instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<OperationalInsightsWorkspaceResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _operationalInsightsWorkspaceWorkspacesClientDiagnostics.CreateScope("OperationalInsightsWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _operationalInsightsWorkspaceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workspace instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<OperationalInsightsWorkspaceResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _operationalInsightsWorkspaceWorkspacesClientDiagnostics.CreateScope("OperationalInsightsWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _operationalInsightsWorkspaceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets workspaces in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsWorkspaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsWorkspaceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), _operationalInsightsWorkspaceWorkspacesClientDiagnostics, Pipeline, "OperationalInsightsWorkspaceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets workspaces in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsWorkspaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsWorkspaceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), _operationalInsightsWorkspaceWorkspacesClientDiagnostics, Pipeline, "OperationalInsightsWorkspaceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _operationalInsightsWorkspaceWorkspacesClientDiagnostics.CreateScope("OperationalInsightsWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsWorkspaceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _operationalInsightsWorkspaceWorkspacesClientDiagnostics.CreateScope("OperationalInsightsWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _operationalInsightsWorkspaceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OperationalInsightsWorkspaceResource> IEnumerable<OperationalInsightsWorkspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OperationalInsightsWorkspaceResource> IAsyncEnumerable<OperationalInsightsWorkspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
