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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Orbital
{
    /// <summary>
    /// A class representing a collection of <see cref="OrbitalSpacecraftResource" /> and their operations.
    /// Each <see cref="OrbitalSpacecraftResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="OrbitalSpacecraftCollection" /> instance call the GetOrbitalSpacecrafts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class OrbitalSpacecraftCollection : ArmCollection, IEnumerable<OrbitalSpacecraftResource>, IAsyncEnumerable<OrbitalSpacecraftResource>
    {
        private readonly ClientDiagnostics _orbitalSpacecraftSpacecraftsClientDiagnostics;
        private readonly SpacecraftsRestOperations _orbitalSpacecraftSpacecraftsRestClient;

        /// <summary> Initializes a new instance of the <see cref="OrbitalSpacecraftCollection"/> class for mocking. </summary>
        protected OrbitalSpacecraftCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OrbitalSpacecraftCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OrbitalSpacecraftCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _orbitalSpacecraftSpacecraftsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Orbital", OrbitalSpacecraftResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OrbitalSpacecraftResource.ResourceType, out string orbitalSpacecraftSpacecraftsApiVersion);
            _orbitalSpacecraftSpacecraftsRestClient = new SpacecraftsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, orbitalSpacecraftSpacecraftsApiVersion);
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
        /// Creates or updates a spacecraft resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="data"> The parameters to provide for the created spacecraft. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OrbitalSpacecraftResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string spacecraftName, OrbitalSpacecraftData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(spacecraftName, nameof(spacecraftName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _orbitalSpacecraftSpacecraftsClientDiagnostics.CreateScope("OrbitalSpacecraftCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _orbitalSpacecraftSpacecraftsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OrbitalArmOperation<OrbitalSpacecraftResource>(new OrbitalSpacecraftOperationSource(Client), _orbitalSpacecraftSpacecraftsClientDiagnostics, Pipeline, _orbitalSpacecraftSpacecraftsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a spacecraft resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="data"> The parameters to provide for the created spacecraft. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OrbitalSpacecraftResource> CreateOrUpdate(WaitUntil waitUntil, string spacecraftName, OrbitalSpacecraftData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(spacecraftName, nameof(spacecraftName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _orbitalSpacecraftSpacecraftsClientDiagnostics.CreateScope("OrbitalSpacecraftCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _orbitalSpacecraftSpacecraftsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, data, cancellationToken);
                var operation = new OrbitalArmOperation<OrbitalSpacecraftResource>(new OrbitalSpacecraftOperationSource(Client), _orbitalSpacecraftSpacecraftsClientDiagnostics, Pipeline, _orbitalSpacecraftSpacecraftsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified spacecraft in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> is null. </exception>
        public virtual async Task<Response<OrbitalSpacecraftResource>> GetAsync(string spacecraftName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(spacecraftName, nameof(spacecraftName));

            using var scope = _orbitalSpacecraftSpacecraftsClientDiagnostics.CreateScope("OrbitalSpacecraftCollection.Get");
            scope.Start();
            try
            {
                var response = await _orbitalSpacecraftSpacecraftsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrbitalSpacecraftResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified spacecraft in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> is null. </exception>
        public virtual Response<OrbitalSpacecraftResource> Get(string spacecraftName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(spacecraftName, nameof(spacecraftName));

            using var scope = _orbitalSpacecraftSpacecraftsClientDiagnostics.CreateScope("OrbitalSpacecraftCollection.Get");
            scope.Start();
            try
            {
                var response = _orbitalSpacecraftSpacecraftsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrbitalSpacecraftResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of spacecrafts by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrbitalSpacecraftResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrbitalSpacecraftResource> GetAllAsync(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _orbitalSpacecraftSpacecraftsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _orbitalSpacecraftSpacecraftsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new OrbitalSpacecraftResource(Client, OrbitalSpacecraftData.DeserializeOrbitalSpacecraftData(e)), _orbitalSpacecraftSpacecraftsClientDiagnostics, Pipeline, "OrbitalSpacecraftCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of spacecrafts by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrbitalSpacecraftResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrbitalSpacecraftResource> GetAll(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _orbitalSpacecraftSpacecraftsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _orbitalSpacecraftSpacecraftsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skiptoken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new OrbitalSpacecraftResource(Client, OrbitalSpacecraftData.DeserializeOrbitalSpacecraftData(e)), _orbitalSpacecraftSpacecraftsClientDiagnostics, Pipeline, "OrbitalSpacecraftCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string spacecraftName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(spacecraftName, nameof(spacecraftName));

            using var scope = _orbitalSpacecraftSpacecraftsClientDiagnostics.CreateScope("OrbitalSpacecraftCollection.Exists");
            scope.Start();
            try
            {
                var response = await _orbitalSpacecraftSpacecraftsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> is null. </exception>
        public virtual Response<bool> Exists(string spacecraftName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(spacecraftName, nameof(spacecraftName));

            using var scope = _orbitalSpacecraftSpacecraftsClientDiagnostics.CreateScope("OrbitalSpacecraftCollection.Exists");
            scope.Start();
            try
            {
                var response = _orbitalSpacecraftSpacecraftsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, spacecraftName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OrbitalSpacecraftResource> IEnumerable<OrbitalSpacecraftResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OrbitalSpacecraftResource> IAsyncEnumerable<OrbitalSpacecraftResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
