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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VpnServerConfigurationResource"/> and their operations.
    /// Each <see cref="VpnServerConfigurationResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VpnServerConfigurationCollection"/> instance call the GetVpnServerConfigurations method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VpnServerConfigurationCollection : ArmCollection, IEnumerable<VpnServerConfigurationResource>, IAsyncEnumerable<VpnServerConfigurationResource>
    {
        private readonly ClientDiagnostics _vpnServerConfigurationClientDiagnostics;
        private readonly VpnServerConfigurationsRestOperations _vpnServerConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationCollection"/> class for mocking. </summary>
        protected VpnServerConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnServerConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnServerConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnServerConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnServerConfigurationResource.ResourceType, out string vpnServerConfigurationApiVersion);
            _vpnServerConfigurationRestClient = new VpnServerConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnServerConfigurationApiVersion);
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
        /// Creates a VpnServerConfiguration resource if it doesn't exist else updates the existing VpnServerConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="data"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnServerConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vpnServerConfigurationName, VpnServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnServerConfigurationResource>(new VpnServerConfigurationOperationSource(Client), _vpnServerConfigurationClientDiagnostics, Pipeline, _vpnServerConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VpnServerConfiguration resource if it doesn't exist else updates the existing VpnServerConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="data"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VpnServerConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string vpnServerConfigurationName, VpnServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, data, cancellationToken);
                var operation = new NetworkArmOperation<VpnServerConfigurationResource>(new VpnServerConfigurationOperationSource(Client), _vpnServerConfigurationClientDiagnostics, Pipeline, _vpnServerConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a VpnServerConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual async Task<Response<VpnServerConfigurationResource>> GetAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VpnServerConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual Response<VpnServerConfigurationResource> Get(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the vpnServerConfigurations in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnServerConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnServerConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vpnServerConfigurationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vpnServerConfigurationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VpnServerConfigurationResource(Client, VpnServerConfigurationData.DeserializeVpnServerConfigurationData(e)), _vpnServerConfigurationClientDiagnostics, Pipeline, "VpnServerConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the vpnServerConfigurations in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnServerConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnServerConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vpnServerConfigurationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vpnServerConfigurationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VpnServerConfigurationResource(Client, VpnServerConfigurationData.DeserializeVpnServerConfigurationData(e)), _vpnServerConfigurationClientDiagnostics, Pipeline, "VpnServerConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<VpnServerConfigurationResource>> GetIfExistsAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VpnServerConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnServerConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnServerConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual NullableResponse<VpnServerConfigurationResource> GetIfExists(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _vpnServerConfigurationClientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VpnServerConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnServerConfigurationResource> IEnumerable<VpnServerConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnServerConfigurationResource> IAsyncEnumerable<VpnServerConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
