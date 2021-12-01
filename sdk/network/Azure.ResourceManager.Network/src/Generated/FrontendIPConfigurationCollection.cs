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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of FrontendIPConfiguration and their operations over its parent. </summary>
    public partial class FrontendIPConfigurationCollection : ArmCollection, IEnumerable<FrontendIPConfiguration>, IAsyncEnumerable<FrontendIPConfiguration>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LoadBalancerFrontendIPConfigurationsRestOperations _loadBalancerFrontendIPConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationCollection"/> class for mocking. </summary>
        protected FrontendIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of FrontendIPConfigurationCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FrontendIPConfigurationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancerFrontendIPConfigurationsRestClient = new LoadBalancerFrontendIPConfigurationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => LoadBalancer.ResourceType;

        // Collection level operations.

        /// <summary> Gets load balancer frontend IP configuration. </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<FrontendIPConfiguration> Get(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            if (frontendIPConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets load balancer frontend IP configuration. </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public async virtual Task<Response<FrontendIPConfiguration>> GetAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            if (frontendIPConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FrontendIPConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<FrontendIPConfiguration> GetIfExists(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            if (frontendIPConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FrontendIPConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new FrontendIPConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public async virtual Task<Response<FrontendIPConfiguration>> GetIfExistsAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            if (frontendIPConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _loadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FrontendIPConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new FrontendIPConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            if (frontendIPConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(frontendIPConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            if (frontendIPConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(frontendIPConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancer frontend IP configurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontendIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontendIPConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FrontendIPConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerFrontendIPConfigurationsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FrontendIPConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerFrontendIPConfigurationsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the load balancer frontend IP configurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontendIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontendIPConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FrontendIPConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerFrontendIPConfigurationsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FrontendIPConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerFrontendIPConfigurationsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FrontendIPConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FrontendIPConfiguration> IEnumerable<FrontendIPConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontendIPConfiguration> IAsyncEnumerable<FrontendIPConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, FrontendIPConfiguration, FrontendIPConfigurationData> Construct() { }
    }
}
