// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnServerConfiguration and their operations over a ResourceGroup. </summary>
    public partial class VpnServerConfigurationContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationContainer"/> class for mocking. </summary>
        protected VpnServerConfigurationContainer()
        {
        }

        /// <summary> Initializes a new instance of VpnServerConfigurationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnServerConfigurationContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VpnServerConfigurationsRestOperations _restClient => new VpnServerConfigurationsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public virtual Response<VpnServerConfiguration> CreateOrUpdate(string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public async virtual Task<Response<VpnServerConfiguration>> CreateOrUpdateAsync(string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public virtual VpnServerConfigurationCreateOrUpdateOperation StartCreateOrUpdate(string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken);
                return new VpnServerConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public async virtual Task<VpnServerConfigurationCreateOrUpdateOperation> StartCreateOrUpdateAsync(string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken).ConfigureAwait(false);
                return new VpnServerConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VpnServerConfiguration> Get(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.Get");
            scope.Start();
            try
            {
                if (vpnServerConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(vpnServerConfigurationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VpnServerConfiguration>> GetAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.Get");
            scope.Start();
            try
            {
                if (vpnServerConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(vpnServerConfigurationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnServerConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VpnServerConfiguration> GetIfExists(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (vpnServerConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(vpnServerConfigurationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VpnServerConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnServerConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VpnServerConfiguration>> GetIfExistsAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (vpnServerConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(vpnServerConfigurationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VpnServerConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnServerConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (vpnServerConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(vpnServerConfigurationName));
                }

                var response = GetIfExists(vpnServerConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (vpnServerConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(vpnServerConfigurationName));
                }

                var response = await GetIfExistsAsync(vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnServerConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VpnServerConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnServerConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnServerConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnServerConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VpnServerConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnServerConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnServerConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VpnServerConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VpnServerConfigurationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VpnServerConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VpnServerConfigurationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VpnServerConfiguration, VpnServerConfigurationData> Construct() { }
    }
}
