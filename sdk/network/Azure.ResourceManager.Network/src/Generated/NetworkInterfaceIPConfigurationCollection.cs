// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    /// <summary> A class representing collection of NetworkInterfaceIPConfiguration and their operations over its parent. </summary>
    public partial class NetworkInterfaceIPConfigurationCollection : ArmCollection, IEnumerable<NetworkInterfaceIPConfiguration>, IAsyncEnumerable<NetworkInterfaceIPConfiguration>
    {
        private readonly ClientDiagnostics _networkInterfaceIPConfigurationClientDiagnostics;
        private readonly NetworkInterfaceIPConfigurationsRestOperations _networkInterfaceIPConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceIPConfigurationCollection"/> class for mocking. </summary>
        protected NetworkInterfaceIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceIPConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceIPConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceIPConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterfaceIPConfiguration.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NetworkInterfaceIPConfiguration.ResourceType, out string networkInterfaceIPConfigurationApiVersion);
            _networkInterfaceIPConfigurationRestClient = new NetworkInterfaceIPConfigurationsRestOperations(_networkInterfaceIPConfigurationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkInterfaceIPConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkInterface.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkInterface.ResourceType), nameof(id));
        }

        /// <summary> Gets the specified network interface ip configuration. </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterfaceIPConfiguration>> GetAsync(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkInterfaceIPConfigurationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterfaceIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network interface ip configuration. </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceIPConfiguration> Get(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw _networkInterfaceIPConfigurationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all ip configurations in a network interface. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceIPConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterfaceIPConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceIPConfigurationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceIPConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceIPConfigurationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all ip configurations in a network interface. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceIPConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterfaceIPConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceIPConfigurationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceIPConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceIPConfigurationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ipConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ipConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterfaceIPConfiguration>> GetIfExistsAsync(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterfaceIPConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceIPConfiguration> GetIfExists(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterfaceIPConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterfaceIPConfiguration> IEnumerable<NetworkInterfaceIPConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterfaceIPConfiguration> IAsyncEnumerable<NetworkInterfaceIPConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
