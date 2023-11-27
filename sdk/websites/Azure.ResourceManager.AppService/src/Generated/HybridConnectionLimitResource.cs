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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a HybridConnectionLimit along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HybridConnectionLimitResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHybridConnectionLimitResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServicePlanResource"/> using the GetHybridConnectionLimit method.
    /// </summary>
    public partial class HybridConnectionLimitResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HybridConnectionLimitResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionPlanLimits/limit";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hybridConnectionLimitAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _hybridConnectionLimitAppServicePlansRestClient;
        private readonly HybridConnectionLimitData _data;

        /// <summary> Initializes a new instance of the <see cref="HybridConnectionLimitResource"/> class for mocking. </summary>
        protected HybridConnectionLimitResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectionLimitResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HybridConnectionLimitResource(ArmClient client, HybridConnectionLimitData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectionLimitResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HybridConnectionLimitResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridConnectionLimitAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hybridConnectionLimitAppServicePlansApiVersion);
            _hybridConnectionLimitAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridConnectionLimitAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/hybridConnectionPlanLimits";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridConnectionLimitData Data
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
        /// Description for Get the maximum number of Hybrid Connections allowed in an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionPlanLimits/limit</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetHybridConnectionPlanLimit</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridConnectionLimitResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridConnectionLimitAppServicePlansClientDiagnostics.CreateScope("HybridConnectionLimitResource.Get");
            scope.Start();
            try
            {
                var response = await _hybridConnectionLimitAppServicePlansRestClient.GetHybridConnectionPlanLimitAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectionLimitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the maximum number of Hybrid Connections allowed in an App Service plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionPlanLimits/limit</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetHybridConnectionPlanLimit</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridConnectionLimitResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridConnectionLimitAppServicePlansClientDiagnostics.CreateScope("HybridConnectionLimitResource.Get");
            scope.Start();
            try
            {
                var response = _hybridConnectionLimitAppServicePlansRestClient.GetHybridConnectionPlanLimit(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectionLimitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
