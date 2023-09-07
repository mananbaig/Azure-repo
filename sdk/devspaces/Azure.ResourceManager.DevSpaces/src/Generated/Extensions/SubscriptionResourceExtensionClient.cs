// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevSpaces
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _controllerClientDiagnostics;
        private ControllersRestOperations _controllerRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ControllerClientDiagnostics => _controllerClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevSpaces", ControllerResource.ResourceType.Namespace, Diagnostics);
        private ControllersRestOperations ControllerRestClient => _controllerRestClient ??= new ControllersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ControllerResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the Azure Dev Spaces Controllers with their properties in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevSpaces/controllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Controllers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ControllerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ControllerResource> GetControllersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ControllerRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ControllerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ControllerResource(Client, ControllerData.DeserializeControllerData(e)), ControllerClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetControllers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the Azure Dev Spaces Controllers with their properties in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevSpaces/controllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Controllers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ControllerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ControllerResource> GetControllers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ControllerRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ControllerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ControllerResource(Client, ControllerData.DeserializeControllerData(e)), ControllerClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetControllers", "value", "nextLink", cancellationToken);
        }
    }
}
