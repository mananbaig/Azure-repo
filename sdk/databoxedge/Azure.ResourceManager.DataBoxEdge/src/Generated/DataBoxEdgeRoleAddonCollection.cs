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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeRoleAddonResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeRoleAddonResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeRoleResource" />.
    /// To get a <see cref="DataBoxEdgeRoleAddonCollection" /> instance call the GetDataBoxEdgeRoleAddons method from an instance of <see cref="DataBoxEdgeRoleResource" />.
    /// </summary>
    public partial class DataBoxEdgeRoleAddonCollection : ArmCollection, IEnumerable<DataBoxEdgeRoleAddonResource>, IAsyncEnumerable<DataBoxEdgeRoleAddonResource>
    {
        private readonly ClientDiagnostics _dataBoxEdgeRoleAddonAddonsClientDiagnostics;
        private readonly AddonsRestOperations _dataBoxEdgeRoleAddonAddonsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeRoleAddonCollection"/> class for mocking. </summary>
        protected DataBoxEdgeRoleAddonCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeRoleAddonCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeRoleAddonCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeRoleAddonAddonsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeRoleAddonResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeRoleAddonResource.ResourceType, out string dataBoxEdgeRoleAddonAddonsApiVersion);
            _dataBoxEdgeRoleAddonAddonsRestClient = new AddonsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeRoleAddonAddonsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeRoleResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeRoleResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a addon.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="data"> The addon properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeRoleAddonResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string addonName, DataBoxEdgeRoleAddonData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeRoleAddonAddonsClientDiagnostics.CreateScope("DataBoxEdgeRoleAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeRoleAddonAddonsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeRoleAddonResource>(new DataBoxEdgeRoleAddonOperationSource(Client), _dataBoxEdgeRoleAddonAddonsClientDiagnostics, Pipeline, _dataBoxEdgeRoleAddonAddonsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a addon.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="data"> The addon properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeRoleAddonResource> CreateOrUpdate(WaitUntil waitUntil, string addonName, DataBoxEdgeRoleAddonData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeRoleAddonAddonsClientDiagnostics.CreateScope("DataBoxEdgeRoleAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeRoleAddonAddonsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeRoleAddonResource>(new DataBoxEdgeRoleAddonOperationSource(Client), _dataBoxEdgeRoleAddonAddonsClientDiagnostics, Pipeline, _dataBoxEdgeRoleAddonAddonsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a specific addon by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeRoleAddonResource>> GetAsync(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _dataBoxEdgeRoleAddonAddonsClientDiagnostics.CreateScope("DataBoxEdgeRoleAddonCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeRoleAddonAddonsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeRoleAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific addon by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual Response<DataBoxEdgeRoleAddonResource> Get(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _dataBoxEdgeRoleAddonAddonsClientDiagnostics.CreateScope("DataBoxEdgeRoleAddonCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeRoleAddonAddonsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeRoleAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the addons configured in the role.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_ListByRole</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeRoleAddonResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeRoleAddonResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeRoleAddonAddonsRestClient.CreateListByRoleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeRoleAddonAddonsRestClient.CreateListByRoleNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DataBoxEdgeRoleAddonResource(Client, DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(e)), _dataBoxEdgeRoleAddonAddonsClientDiagnostics, Pipeline, "DataBoxEdgeRoleAddonCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the addons configured in the role.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_ListByRole</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeRoleAddonResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeRoleAddonResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeRoleAddonAddonsRestClient.CreateListByRoleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeRoleAddonAddonsRestClient.CreateListByRoleNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DataBoxEdgeRoleAddonResource(Client, DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(e)), _dataBoxEdgeRoleAddonAddonsClientDiagnostics, Pipeline, "DataBoxEdgeRoleAddonCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _dataBoxEdgeRoleAddonAddonsClientDiagnostics.CreateScope("DataBoxEdgeRoleAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeRoleAddonAddonsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{roleName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> The addon name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual Response<bool> Exists(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _dataBoxEdgeRoleAddonAddonsClientDiagnostics.CreateScope("DataBoxEdgeRoleAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeRoleAddonAddonsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, addonName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxEdgeRoleAddonResource> IEnumerable<DataBoxEdgeRoleAddonResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxEdgeRoleAddonResource> IAsyncEnumerable<DataBoxEdgeRoleAddonResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
