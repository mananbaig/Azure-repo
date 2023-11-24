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

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing a collection of <see cref="FleetUpdateStrategyResource"/> and their operations.
    /// Each <see cref="FleetUpdateStrategyResource"/> in the collection will belong to the same instance of <see cref="ContainerServiceFleetResource"/>.
    /// To get a <see cref="FleetUpdateStrategyCollection"/> instance call the GetFleetUpdateStrategies method from an instance of <see cref="ContainerServiceFleetResource"/>.
    /// </summary>
    public partial class FleetUpdateStrategyCollection : ArmCollection, IEnumerable<FleetUpdateStrategyResource>, IAsyncEnumerable<FleetUpdateStrategyResource>
    {
        private readonly ClientDiagnostics _fleetUpdateStrategyClientDiagnostics;
        private readonly FleetUpdateStrategiesRestOperations _fleetUpdateStrategyRestClient;

        /// <summary> Initializes a new instance of the <see cref="FleetUpdateStrategyCollection"/> class for mocking. </summary>
        protected FleetUpdateStrategyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FleetUpdateStrategyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FleetUpdateStrategyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fleetUpdateStrategyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", FleetUpdateStrategyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FleetUpdateStrategyResource.ResourceType, out string fleetUpdateStrategyApiVersion);
            _fleetUpdateStrategyRestClient = new FleetUpdateStrategiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fleetUpdateStrategyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerServiceFleetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerServiceFleetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a FleetUpdateStrategy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FleetUpdateStrategyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string updateStrategyName, FleetUpdateStrategyData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fleetUpdateStrategyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<FleetUpdateStrategyResource>(new FleetUpdateStrategyOperationSource(Client), _fleetUpdateStrategyClientDiagnostics, Pipeline, _fleetUpdateStrategyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Create a FleetUpdateStrategy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FleetUpdateStrategyResource> CreateOrUpdate(WaitUntil waitUntil, string updateStrategyName, FleetUpdateStrategyData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fleetUpdateStrategyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<FleetUpdateStrategyResource>(new FleetUpdateStrategyOperationSource(Client), _fleetUpdateStrategyClientDiagnostics, Pipeline, _fleetUpdateStrategyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation, apiVersionOverrideValue: "2016-03-30");
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
        /// Get a FleetUpdateStrategy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> is null. </exception>
        public virtual async Task<Response<FleetUpdateStrategyResource>> GetAsync(string updateStrategyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.Get");
            scope.Start();
            try
            {
                var response = await _fleetUpdateStrategyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FleetUpdateStrategyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FleetUpdateStrategy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> is null. </exception>
        public virtual Response<FleetUpdateStrategyResource> Get(string updateStrategyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.Get");
            scope.Start();
            try
            {
                var response = _fleetUpdateStrategyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FleetUpdateStrategyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FleetUpdateStrategy resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_ListByFleet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FleetUpdateStrategyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FleetUpdateStrategyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fleetUpdateStrategyRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fleetUpdateStrategyRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new FleetUpdateStrategyResource(Client, FleetUpdateStrategyData.DeserializeFleetUpdateStrategyData(e)), _fleetUpdateStrategyClientDiagnostics, Pipeline, "FleetUpdateStrategyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FleetUpdateStrategy resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_ListByFleet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FleetUpdateStrategyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FleetUpdateStrategyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fleetUpdateStrategyRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fleetUpdateStrategyRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new FleetUpdateStrategyResource(Client, FleetUpdateStrategyData.DeserializeFleetUpdateStrategyData(e)), _fleetUpdateStrategyClientDiagnostics, Pipeline, "FleetUpdateStrategyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string updateStrategyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fleetUpdateStrategyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> is null. </exception>
        public virtual Response<bool> Exists(string updateStrategyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.Exists");
            scope.Start();
            try
            {
                var response = _fleetUpdateStrategyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> is null. </exception>
        public virtual async Task<NullableResponse<FleetUpdateStrategyResource>> GetIfExistsAsync(string updateStrategyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fleetUpdateStrategyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FleetUpdateStrategyResource>(response.GetRawResponse());
                return Response.FromValue(new FleetUpdateStrategyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateStrategies/{updateStrategyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetUpdateStrategies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateStrategyName"> The name of the UpdateStrategy resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateStrategyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateStrategyName"/> is null. </exception>
        public virtual NullableResponse<FleetUpdateStrategyResource> GetIfExists(string updateStrategyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateStrategyName, nameof(updateStrategyName));

            using var scope = _fleetUpdateStrategyClientDiagnostics.CreateScope("FleetUpdateStrategyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fleetUpdateStrategyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, updateStrategyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FleetUpdateStrategyResource>(response.GetRawResponse());
                return Response.FromValue(new FleetUpdateStrategyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FleetUpdateStrategyResource> IEnumerable<FleetUpdateStrategyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FleetUpdateStrategyResource> IAsyncEnumerable<FleetUpdateStrategyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
