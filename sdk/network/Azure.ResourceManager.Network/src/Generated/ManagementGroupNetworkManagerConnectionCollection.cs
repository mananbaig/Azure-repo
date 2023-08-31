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
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagementGroupNetworkManagerConnectionResource" /> and their operations.
    /// Each <see cref="ManagementGroupNetworkManagerConnectionResource" /> in the collection will belong to the same instance of <see cref="ManagementGroupResource" />.
    /// To get a <see cref="ManagementGroupNetworkManagerConnectionCollection" /> instance call the GetManagementGroupNetworkManagerConnections method from an instance of <see cref="ManagementGroupResource" />.
    /// </summary>
    public partial class ManagementGroupNetworkManagerConnectionCollection : ArmCollection, IEnumerable<ManagementGroupNetworkManagerConnectionResource>, IAsyncEnumerable<ManagementGroupNetworkManagerConnectionResource>
    {
        private readonly ClientDiagnostics _managementGroupNetworkManagerConnectionClientDiagnostics;
        private readonly ManagementGroupNetworkManagerConnectionsRestOperations _managementGroupNetworkManagerConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupNetworkManagerConnectionCollection"/> class for mocking. </summary>
        protected ManagementGroupNetworkManagerConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupNetworkManagerConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagementGroupNetworkManagerConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupNetworkManagerConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ManagementGroupNetworkManagerConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagementGroupNetworkManagerConnectionResource.ResourceType, out string managementGroupNetworkManagerConnectionApiVersion);
            _managementGroupNetworkManagerConnectionRestClient = new ManagementGroupNetworkManagerConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementGroupNetworkManagerConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a network manager connection on this management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="data"> Network manager connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagementGroupNetworkManagerConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkManagerConnectionName, NetworkManagerConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupNetworkManagerConnectionClientDiagnostics.CreateScope("ManagementGroupNetworkManagerConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementGroupNetworkManagerConnectionRestClient.CreateOrUpdateAsync(Id.Name, networkManagerConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ManagementGroupNetworkManagerConnectionResource>(Response.FromValue(new ManagementGroupNetworkManagerConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Create a network manager connection on this management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="data"> Network manager connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagementGroupNetworkManagerConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string networkManagerConnectionName, NetworkManagerConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupNetworkManagerConnectionClientDiagnostics.CreateScope("ManagementGroupNetworkManagerConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementGroupNetworkManagerConnectionRestClient.CreateOrUpdate(Id.Name, networkManagerConnectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<ManagementGroupNetworkManagerConnectionResource>(Response.FromValue(new ManagementGroupNetworkManagerConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Get a specified connection created by this management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual async Task<Response<ManagementGroupNetworkManagerConnectionResource>> GetAsync(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _managementGroupNetworkManagerConnectionClientDiagnostics.CreateScope("ManagementGroupNetworkManagerConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupNetworkManagerConnectionRestClient.GetAsync(Id.Name, networkManagerConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specified connection created by this management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual Response<ManagementGroupNetworkManagerConnectionResource> Get(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _managementGroupNetworkManagerConnectionClientDiagnostics.CreateScope("ManagementGroupNetworkManagerConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _managementGroupNetworkManagerConnectionRestClient.Get(Id.Name, networkManagerConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all network manager connections created by this management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementGroupNetworkManagerConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementGroupNetworkManagerConnectionResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupNetworkManagerConnectionRestClient.CreateListRequest(Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupNetworkManagerConnectionRestClient.CreateListNextPageRequest(nextLink, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagementGroupNetworkManagerConnectionResource(Client, NetworkManagerConnectionData.DeserializeNetworkManagerConnectionData(e)), _managementGroupNetworkManagerConnectionClientDiagnostics, Pipeline, "ManagementGroupNetworkManagerConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all network manager connections created by this management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementGroupNetworkManagerConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementGroupNetworkManagerConnectionResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupNetworkManagerConnectionRestClient.CreateListRequest(Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupNetworkManagerConnectionRestClient.CreateListNextPageRequest(nextLink, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagementGroupNetworkManagerConnectionResource(Client, NetworkManagerConnectionData.DeserializeNetworkManagerConnectionData(e)), _managementGroupNetworkManagerConnectionClientDiagnostics, Pipeline, "ManagementGroupNetworkManagerConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _managementGroupNetworkManagerConnectionClientDiagnostics.CreateScope("ManagementGroupNetworkManagerConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managementGroupNetworkManagerConnectionRestClient.GetAsync(Id.Name, networkManagerConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroupNetworkManagerConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _managementGroupNetworkManagerConnectionClientDiagnostics.CreateScope("ManagementGroupNetworkManagerConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _managementGroupNetworkManagerConnectionRestClient.Get(Id.Name, networkManagerConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagementGroupNetworkManagerConnectionResource> IEnumerable<ManagementGroupNetworkManagerConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementGroupNetworkManagerConnectionResource> IAsyncEnumerable<ManagementGroupNetworkManagerConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
