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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorRouteResource" /> and their operations.
    /// Each <see cref="FrontDoorRouteResource" /> in the collection will belong to the same instance of <see cref="FrontDoorEndpointResource" />.
    /// To get a <see cref="FrontDoorRouteCollection" /> instance call the GetFrontDoorRoutes method from an instance of <see cref="FrontDoorEndpointResource" />.
    /// </summary>
    public partial class FrontDoorRouteCollection : ArmCollection, IEnumerable<FrontDoorRouteResource>, IAsyncEnumerable<FrontDoorRouteResource>
    {
        private readonly ClientDiagnostics _frontDoorRouteClientDiagnostics;
        private readonly FrontDoorRoutesRestOperations _frontDoorRouteRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorRouteCollection"/> class for mocking. </summary>
        protected FrontDoorRouteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorRouteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorRouteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorRouteClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", FrontDoorRouteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorRouteResource.ResourceType, out string frontDoorRouteApiVersion);
            _frontDoorRouteRestClient = new FrontDoorRoutesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorRouteApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FrontDoorEndpointResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FrontDoorEndpointResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="data"> Route properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorRouteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string routeName, FrontDoorRouteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorRouteClientDiagnostics.CreateScope("FrontDoorRouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorRouteRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorRouteResource>(new FrontDoorRouteOperationSource(Client), _frontDoorRouteClientDiagnostics, Pipeline, _frontDoorRouteRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="data"> Route properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorRouteResource> CreateOrUpdate(WaitUntil waitUntil, string routeName, FrontDoorRouteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorRouteClientDiagnostics.CreateScope("FrontDoorRouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorRouteRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, data, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorRouteResource>(new FrontDoorRouteOperationSource(Client), _frontDoorRouteClientDiagnostics, Pipeline, _frontDoorRouteRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorRouteResource>> GetAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _frontDoorRouteClientDiagnostics.CreateScope("FrontDoorRouteCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorRouteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorRouteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<FrontDoorRouteResource> Get(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _frontDoorRouteClientDiagnostics.CreateScope("FrontDoorRouteCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorRouteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorRouteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the existing origins within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_ListByEndpoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorRouteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorRouteResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorRouteRestClient.CreateListByEndpointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorRouteRestClient.CreateListByEndpointNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new FrontDoorRouteResource(Client, FrontDoorRouteData.DeserializeFrontDoorRouteData(e)), _frontDoorRouteClientDiagnostics, Pipeline, "FrontDoorRouteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the existing origins within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_ListByEndpoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorRouteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorRouteResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorRouteRestClient.CreateListByEndpointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorRouteRestClient.CreateListByEndpointNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new FrontDoorRouteResource(Client, FrontDoorRouteData.DeserializeFrontDoorRouteData(e)), _frontDoorRouteClientDiagnostics, Pipeline, "FrontDoorRouteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _frontDoorRouteClientDiagnostics.CreateScope("FrontDoorRouteCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorRouteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorRoutes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _frontDoorRouteClientDiagnostics.CreateScope("FrontDoorRouteCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorRouteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorRouteResource> IEnumerable<FrontDoorRouteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorRouteResource> IAsyncEnumerable<FrontDoorRouteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
