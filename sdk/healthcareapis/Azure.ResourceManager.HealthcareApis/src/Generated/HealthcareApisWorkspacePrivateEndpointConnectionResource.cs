// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A Class representing a HealthcareApisWorkspacePrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHealthcareApisWorkspacePrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="HealthcareApisWorkspaceResource" /> using the GetHealthcareApisWorkspacePrivateEndpointConnection method.
    /// </summary>
    public partial class HealthcareApisWorkspacePrivateEndpointConnectionResource : HealthcareApisPrivateEndpointConnectionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics;
        private readonly WorkspacePrivateEndpointConnectionsRestOperations _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected HealthcareApisWorkspacePrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HealthcareApisWorkspacePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HealthcareApisWorkspacePrivateEndpointConnectionResource(ArmClient client, HealthcareApisPrivateEndpointConnectionData data) : base(client, data)
        {
            _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsApiVersion);
            _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient = new WorkspacePrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HealthcareApisWorkspacePrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsApiVersion);
            _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient = new WorkspacePrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthcareApis/workspaces/privateEndpointConnections";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<HealthcareApisPrivateEndpointConnectionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateEndpointConnectionResource.GetCore");
            scope.Start();
            try
            {
                var response = await _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<HealthcareApisWorkspacePrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((HealthcareApisWorkspacePrivateEndpointConnectionResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<HealthcareApisPrivateEndpointConnectionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateEndpointConnectionResource.GetCore");
            scope.Start();
            try
            {
                var response = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<HealthcareApisWorkspacePrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((HealthcareApisWorkspacePrivateEndpointConnectionResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateEndpointConnectionResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation(_healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics, Pipeline, _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateEndpointConnectionResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HealthcareApisArmOperation(_healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics, Pipeline, _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Update the state of the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<HealthcareApisPrivateEndpointConnectionResource>> UpdateCoreAsync(WaitUntil waitUntil, HealthcareApisPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateEndpointConnectionResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<HealthcareApisPrivateEndpointConnectionResource>(new HealthcareApisPrivateEndpointConnectionOperationSource(Client), _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics, Pipeline, _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the state of the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<ArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, HealthcareApisPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new HealthcareApisArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource>(Response.FromValue((HealthcareApisWorkspacePrivateEndpointConnectionResource)value.Value, value.GetRawResponse()));
            }
            var operation = new HealthcareApisArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource>(new HealthcareApisWorkspacePrivateEndpointConnectionOperationSource(Client), _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics, Pipeline, _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, value.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Update the state of the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<HealthcareApisPrivateEndpointConnectionResource> UpdateCore(WaitUntil waitUntil, HealthcareApisPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateEndpointConnectionResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<HealthcareApisPrivateEndpointConnectionResource>(new HealthcareApisPrivateEndpointConnectionOperationSource(Client), _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics, Pipeline, _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the state of the specified private endpoint connection associated with the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WorkspacePrivateEndpointConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual ArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource> Update(WaitUntil waitUntil, HealthcareApisPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(waitUntil, data, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new HealthcareApisArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource>(Response.FromValue((HealthcareApisWorkspacePrivateEndpointConnectionResource)value.Value, value.GetRawResponse()));
            }
            var operation = new HealthcareApisArmOperation<HealthcareApisWorkspacePrivateEndpointConnectionResource>(new HealthcareApisWorkspacePrivateEndpointConnectionOperationSource(Client), _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsClientDiagnostics, Pipeline, _healthcareApisWorkspacePrivateEndpointConnectionWorkspacePrivateEndpointConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, value.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
