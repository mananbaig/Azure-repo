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
    /// A Class representing a HealthcareApisWorkspacePrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HealthcareApisWorkspacePrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHealthcareApisWorkspacePrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="HealthcareApisWorkspaceResource" /> using the GetHealthcareApisWorkspacePrivateLinkResource method.
    /// </summary>
    public partial class HealthcareApisWorkspacePrivateLinkResource : HealthcareApisPrivateLinkResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HealthcareApisWorkspacePrivateLinkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string groupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateLinkResources/{groupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesClientDiagnostics;
        private readonly WorkspacePrivateLinkResourcesRestOperations _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisWorkspacePrivateLinkResource"/> class for mocking. </summary>
        protected HealthcareApisWorkspacePrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HealthcareApisWorkspacePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HealthcareApisWorkspacePrivateLinkResource(ArmClient client, HealthcareApisPrivateLinkResourceData data) : base(client, data)
        {
            _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesApiVersion);
            _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesRestClient = new WorkspacePrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisWorkspacePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HealthcareApisWorkspacePrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesApiVersion);
            _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesRestClient = new WorkspacePrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthcareApis/workspaces/privateLinkResources";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a private link resource that need to be created for a workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateLinkResources/{groupName}
        /// Operation Id: WorkspacePrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<HealthcareApisPrivateLinkResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateLinkResource.GetCore");
            scope.Start();
            try
            {
                var response = await _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets a private link resource that need to be created for a workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateLinkResources/{groupName}
        /// Operation Id: WorkspacePrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<HealthcareApisWorkspacePrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((HealthcareApisWorkspacePrivateLinkResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a private link resource that need to be created for a workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateLinkResources/{groupName}
        /// Operation Id: WorkspacePrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<HealthcareApisPrivateLinkResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesClientDiagnostics.CreateScope("HealthcareApisWorkspacePrivateLinkResource.GetCore");
            scope.Start();
            try
            {
                var response = _healthcareApisWorkspacePrivateLinkResourceWorkspacePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets a private link resource that need to be created for a workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/privateLinkResources/{groupName}
        /// Operation Id: WorkspacePrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<HealthcareApisWorkspacePrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((HealthcareApisWorkspacePrivateLinkResource)value.Value, value.GetRawResponse());
        }
    }
}
