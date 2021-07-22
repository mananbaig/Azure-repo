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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of SshPublicKey and their operations over a ResourceGroup. </summary>
    public partial class SshPublicKeyContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, SshPublicKey, SshPublicKeyData>
    {
        /// <summary> Initializes a new instance of the <see cref="SshPublicKeyContainer"/> class for mocking. </summary>
        protected SshPublicKeyContainer()
        {
        }

        /// <summary> Initializes a new instance of SshPublicKeyContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SshPublicKeyContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SshPublicKeysRestOperations _restClient => new SshPublicKeysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to create the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<SshPublicKey> CreateOrUpdate(string sshPublicKeyName, SshPublicKeyData parameters, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(sshPublicKeyName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to create the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<SshPublicKey>> CreateOrUpdateAsync(string sshPublicKeyName, SshPublicKeyData parameters, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(sshPublicKeyName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to create the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SshPublicKeysCreateOperation StartCreateOrUpdate(string sshPublicKeyName, SshPublicKeyData parameters, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Create(Id.ResourceGroupName, sshPublicKeyName, parameters, cancellationToken);
                return new SshPublicKeysCreateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to create the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SshPublicKeysCreateOperation> StartCreateOrUpdateAsync(string sshPublicKeyName, SshPublicKeyData parameters, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAsync(Id.ResourceGroupName, sshPublicKeyName, parameters, cancellationToken).ConfigureAwait(false);
                return new SshPublicKeysCreateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SshPublicKey> Get(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.Get");
            scope.Start();
            try
            {
                if (sshPublicKeyName == null)
                {
                    throw new ArgumentNullException(nameof(sshPublicKeyName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, sshPublicKeyName, cancellationToken: cancellationToken);
                return Response.FromValue(new SshPublicKey(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SshPublicKey>> GetAsync(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.Get");
            scope.Start();
            try
            {
                if (sshPublicKeyName == null)
                {
                    throw new ArgumentNullException(nameof(sshPublicKeyName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, sshPublicKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SshPublicKey(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual SshPublicKey TryGet(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.TryGet");
            scope.Start();
            try
            {
                if (sshPublicKeyName == null)
                {
                    throw new ArgumentNullException(nameof(sshPublicKeyName));
                }

                return Get(sshPublicKeyName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<SshPublicKey> TryGetAsync(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.TryGet");
            scope.Start();
            try
            {
                if (sshPublicKeyName == null)
                {
                    throw new ArgumentNullException(nameof(sshPublicKeyName));
                }

                return await GetAsync(sshPublicKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.DoesExist");
            scope.Start();
            try
            {
                if (sshPublicKeyName == null)
                {
                    throw new ArgumentNullException(nameof(sshPublicKeyName));
                }

                return TryGet(sshPublicKeyName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.DoesExist");
            scope.Start();
            try
            {
                if (sshPublicKeyName == null)
                {
                    throw new ArgumentNullException(nameof(sshPublicKeyName));
                }

                return await TryGetAsync(sshPublicKeyName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the SSH public keys in the specified resource group. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SshPublicKey" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<SshPublicKey> List(CancellationToken cancellationToken = default)
        {
            Page<SshPublicKey> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKey(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SshPublicKey> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKey(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the SSH public keys in the specified resource group. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SshPublicKey" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<SshPublicKey> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SshPublicKey>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKey(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SshPublicKey>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKey(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SshPublicKey" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SshPublicKeyOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SshPublicKey" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SshPublicKeyOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, SshPublicKey, SshPublicKeyData> Construct() { }
    }
}
