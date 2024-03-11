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

namespace Azure.ResourceManager.Grafana
{
    /// <summary>
    /// A Class representing a GrafanaPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GrafanaPrivateLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGrafanaPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedGrafanaResource"/> using the GetGrafanaPrivateLinkResource method.
    /// </summary>
    public partial class GrafanaPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GrafanaPrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="privateLinkResourceName"> The privateLinkResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string privateLinkResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}/privateLinkResources/{privateLinkResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _grafanaPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _grafanaPrivateLinkResourcePrivateLinkResourcesRestClient;
        private readonly GrafanaPrivateLinkResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Dashboard/grafana/privateLinkResources";

        /// <summary> Initializes a new instance of the <see cref="GrafanaPrivateLinkResource"/> class for mocking. </summary>
        protected GrafanaPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GrafanaPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GrafanaPrivateLinkResource(ArmClient client, GrafanaPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GrafanaPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GrafanaPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _grafanaPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Grafana", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string grafanaPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _grafanaPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, grafanaPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GrafanaPrivateLinkResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get specific private link resource information for this grafana resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GrafanaPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GrafanaPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _grafanaPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("GrafanaPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _grafanaPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GrafanaPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specific private link resource information for this grafana resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GrafanaPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GrafanaPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _grafanaPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("GrafanaPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _grafanaPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GrafanaPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
