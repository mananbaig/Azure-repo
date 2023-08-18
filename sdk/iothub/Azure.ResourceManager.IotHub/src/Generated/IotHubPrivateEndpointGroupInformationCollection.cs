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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing a collection of <see cref="IotHubPrivateEndpointGroupInformationResource" /> and their operations.
    /// Each <see cref="IotHubPrivateEndpointGroupInformationResource" /> in the collection will belong to the same instance of <see cref="IotHubDescriptionResource" />.
    /// To get an <see cref="IotHubPrivateEndpointGroupInformationCollection" /> instance call the GetIotHubPrivateEndpointGroupInformation method from an instance of <see cref="IotHubDescriptionResource" />.
    /// </summary>
    public partial class IotHubPrivateEndpointGroupInformationCollection : ArmCollection, IEnumerable<IotHubPrivateEndpointGroupInformationResource>, IAsyncEnumerable<IotHubPrivateEndpointGroupInformationResource>
    {
        private readonly ClientDiagnostics _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotHubPrivateEndpointGroupInformationCollection"/> class for mocking. </summary>
        protected IotHubPrivateEndpointGroupInformationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotHubPrivateEndpointGroupInformationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotHubPrivateEndpointGroupInformationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotHub", IotHubPrivateEndpointGroupInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotHubPrivateEndpointGroupInformationResource.ResourceType, out string iotHubPrivateEndpointGroupInformationPrivateLinkResourcesApiVersion);
            _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotHubPrivateEndpointGroupInformationPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotHubDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotHubDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the specified private link resource for the given IotHub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<IotHubPrivateEndpointGroupInformationResource>> GetAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics.CreateScope("IotHubPrivateEndpointGroupInformationCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotHubPrivateEndpointGroupInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource for the given IotHub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<IotHubPrivateEndpointGroupInformationResource> Get(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics.CreateScope("IotHubPrivateEndpointGroupInformationCollection.Get");
            scope.Start();
            try
            {
                var response = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotHubPrivateEndpointGroupInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private link resources for the given IotHub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotHubPrivateEndpointGroupInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotHubPrivateEndpointGroupInformationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new IotHubPrivateEndpointGroupInformationResource(Client, IotHubPrivateEndpointGroupInformationData.DeserializeIotHubPrivateEndpointGroupInformationData(e)), _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics, Pipeline, "IotHubPrivateEndpointGroupInformationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List private link resources for the given IotHub
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotHubPrivateEndpointGroupInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotHubPrivateEndpointGroupInformationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new IotHubPrivateEndpointGroupInformationResource(Client, IotHubPrivateEndpointGroupInformationData.DeserializeIotHubPrivateEndpointGroupInformationData(e)), _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics, Pipeline, "IotHubPrivateEndpointGroupInformationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics.CreateScope("IotHubPrivateEndpointGroupInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/iotHubs/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<bool> Exists(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesClientDiagnostics.CreateScope("IotHubPrivateEndpointGroupInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotHubPrivateEndpointGroupInformationPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotHubPrivateEndpointGroupInformationResource> IEnumerable<IotHubPrivateEndpointGroupInformationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotHubPrivateEndpointGroupInformationResource> IAsyncEnumerable<IotHubPrivateEndpointGroupInformationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
