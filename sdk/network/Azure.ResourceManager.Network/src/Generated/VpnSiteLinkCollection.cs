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
    /// <summary> A class representing collection of VpnSiteLink and their operations over its parent. </summary>
    public partial class VpnSiteLinkCollection : ArmCollection, IEnumerable<VpnSiteLink>, IAsyncEnumerable<VpnSiteLink>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnSiteLinksRestOperations _vpnSiteLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkCollection"/> class for mocking. </summary>
        protected VpnSiteLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of VpnSiteLinkCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnSiteLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSiteLinksRestClient = new VpnSiteLinksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VpnSite.ResourceType;

        // Collection level operations.

        /// <summary> Retrieves the details of a VPN site link. </summary>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteLinkName"/> is null. </exception>
        public virtual Response<VpnSiteLink> Get(string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnSiteLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnSiteLinkName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VPN site link. </summary>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteLinkName"/> is null. </exception>
        public async virtual Task<Response<VpnSiteLink>> GetAsync(string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnSiteLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnSiteLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteLinkName"/> is null. </exception>
        public virtual Response<VpnSiteLink> GetIfExists(string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnSiteLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnSiteLinkName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VpnSiteLink>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnSiteLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteLinkName"/> is null. </exception>
        public async virtual Task<Response<VpnSiteLink>> GetIfExistsAsync(string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnSiteLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VpnSiteLink>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnSiteLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteLinkName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(vpnSiteLinkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteLinkName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vpnSiteLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnSiteLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnSiteLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnSiteLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnSiteLinksRestClient.ListByVpnSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSiteLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnSiteLinksRestClient.ListByVpnSiteNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnSiteLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnSiteLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnSiteLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnSiteLinksRestClient.ListByVpnSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSiteLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnSiteLinksRestClient.ListByVpnSiteNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VpnSiteLink> IEnumerable<VpnSiteLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnSiteLink> IAsyncEnumerable<VpnSiteLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VpnSiteLink, VpnSiteLinkData> Construct() { }
    }
}
