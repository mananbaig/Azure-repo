// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The SecurityPartnerProviders service client. </summary>
    public partial class SecurityPartnerProvidersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SecurityPartnerProvidersRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SecurityPartnerProvidersClient for mocking. </summary>
        protected SecurityPartnerProvidersClient()
        {
        }
        /// <summary> Initializes a new instance of SecurityPartnerProvidersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal SecurityPartnerProvidersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new SecurityPartnerProvidersRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified Security Partner Provider. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityPartnerProvider>> GetAsync(string resourceGroupName, string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, securityPartnerProviderName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Security Partner Provider. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityPartnerProvider> Get(string resourceGroupName, string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, securityPartnerProviderName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates tags of a Security Partner Provider resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to update Security Partner Provider tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityPartnerProvider>> UpdateTagsAsync(string resourceGroupName, string securityPartnerProviderName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, securityPartnerProviderName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates tags of a Security Partner Provider resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to update Security Partner Provider tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityPartnerProvider> UpdateTags(string resourceGroupName, string securityPartnerProviderName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, securityPartnerProviderName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Security Partner Providers in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SecurityPartnerProvider> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<SecurityPartnerProvider>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityPartnerProvider>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Security Partner Providers in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SecurityPartnerProvider> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<SecurityPartnerProvider> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityPartnerProvider> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the Security Partner Providers in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SecurityPartnerProvider> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SecurityPartnerProvider>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityPartnerProvider>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the Security Partner Providers in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SecurityPartnerProvider> List(CancellationToken cancellationToken = default)
        {
            Page<SecurityPartnerProvider> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityPartnerProvider> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified Security Partner Provider. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<SecurityPartnerProvidersDeleteOperation> StartDeleteAsync(string resourceGroupName, string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, securityPartnerProviderName, cancellationToken).ConfigureAwait(false);
                return new SecurityPartnerProvidersDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, securityPartnerProviderName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Security Partner Provider. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SecurityPartnerProvidersDeleteOperation StartDelete(string resourceGroupName, string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, securityPartnerProviderName, cancellationToken);
                return new SecurityPartnerProvidersDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, securityPartnerProviderName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Security Partner Provider. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<SecurityPartnerProvidersCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string securityPartnerProviderName, SecurityPartnerProvider parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, securityPartnerProviderName, parameters, cancellationToken).ConfigureAwait(false);
                return new SecurityPartnerProvidersCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, securityPartnerProviderName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Security Partner Provider. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SecurityPartnerProvidersCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string securityPartnerProviderName, SecurityPartnerProvider parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (securityPartnerProviderName == null)
            {
                throw new ArgumentNullException(nameof(securityPartnerProviderName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecurityPartnerProvidersClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, securityPartnerProviderName, parameters, cancellationToken);
                return new SecurityPartnerProvidersCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, securityPartnerProviderName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
