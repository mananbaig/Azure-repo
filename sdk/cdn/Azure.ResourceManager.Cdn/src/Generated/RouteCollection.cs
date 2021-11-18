// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of Route and their operations over its parent. </summary>
    public partial class RouteCollection : ArmCollection, IEnumerable<Route>, IAsyncEnumerable<Route>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RoutesRestOperations _routesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteCollection"/> class for mocking. </summary>
        protected RouteCollection()
        {
        }

        /// <summary> Initializes a new instance of RouteCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RouteCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _routesRestClient = new RoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AFDEndpoint.ResourceType;

        // Collection level operations.

        /// <summary> Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="route"> Route properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual RouteCreateOperation CreateOrUpdate(string routeName, RouteData route, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routesRestClient.Create(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                var operation = new RouteCreateOperation(Parent, _clientDiagnostics, Pipeline, _routesRestClient.CreateCreateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="route"> Route properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public async virtual Task<RouteCreateOperation> CreateOrUpdateAsync(string routeName, RouteData route, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routesRestClient.CreateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                var operation = new RouteCreateOperation(Parent, _clientDiagnostics, Pipeline, _routesRestClient.CreateCreateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<Route> Get(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.Get");
            scope.Start();
            try
            {
                var response = _routesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Route(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<Route>> GetAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.Get");
            scope.Start();
            try
            {
                var response = await _routesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Route(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<Route> GetIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Route>(null, response.GetRawResponse())
                    : Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<Route>> GetIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _routesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Route>(null, response.GetRawResponse())
                    : Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Route> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Route> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routesRestClient.ListByEndpoint(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Route> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routesRestClient.ListByEndpointNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Route> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Route>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routesRestClient.ListByEndpointAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Route>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routesRestClient.ListByEndpointNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Route> IEnumerable<Route>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Route> IAsyncEnumerable<Route>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Route, RouteData> Construct() { }
    }
}
