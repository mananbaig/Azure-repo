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
    /// <summary> A class representing collection of Gallery and their operations over a ResourceGroup. </summary>
    public partial class GalleryContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, Gallery, GalleryData>
    {
        /// <summary> Initializes a new instance of the <see cref="GalleryContainer"/> class for mocking. </summary>
        protected GalleryContainer()
        {
        }

        /// <summary> Initializes a new instance of GalleryContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private GalleriesRestOperations _restClient => new GalleriesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="gallery"/> is null. </exception>
        public Response<Gallery> CreateOrUpdate(string galleryName, GalleryData gallery, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(galleryName, gallery, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="gallery"/> is null. </exception>
        public async Task<Response<Gallery>> CreateOrUpdateAsync(string galleryName, GalleryData gallery, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(galleryName, gallery, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="gallery"/> is null. </exception>
        public GalleriesCreateOrUpdateOperation StartCreateOrUpdate(string galleryName, GalleryData gallery, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, galleryName, gallery, cancellationToken);
                return new GalleriesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, galleryName, gallery).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="gallery"/> is null. </exception>
        public async Task<GalleriesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string galleryName, GalleryData gallery, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, galleryName, gallery, cancellationToken).ConfigureAwait(false);
                return new GalleriesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, galleryName, gallery).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<Gallery> Get(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.Get");
            scope.Start();
            try
            {
                if (galleryName == null)
                {
                    throw new ArgumentNullException(nameof(galleryName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, galleryName, select, cancellationToken: cancellationToken);
                return Response.FromValue(new Gallery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<Gallery>> GetAsync(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.Get");
            scope.Start();
            try
            {
                if (galleryName == null)
                {
                    throw new ArgumentNullException(nameof(galleryName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, galleryName, select, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Gallery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Gallery TryGet(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.TryGet");
            scope.Start();
            try
            {
                if (galleryName == null)
                {
                    throw new ArgumentNullException(nameof(galleryName));
                }

                return Get(galleryName, select, cancellationToken: cancellationToken).Value;
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
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Gallery> TryGetAsync(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.TryGet");
            scope.Start();
            try
            {
                if (galleryName == null)
                {
                    throw new ArgumentNullException(nameof(galleryName));
                }

                return await GetAsync(galleryName, select, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public bool DoesExist(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.DoesExist");
            scope.Start();
            try
            {
                if (galleryName == null)
                {
                    throw new ArgumentNullException(nameof(galleryName));
                }

                return TryGet(galleryName, select, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<bool> DoesExistAsync(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.DoesExist");
            scope.Start();
            try
            {
                if (galleryName == null)
                {
                    throw new ArgumentNullException(nameof(galleryName));
                }

                return await TryGetAsync(galleryName, select, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List galleries under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Gallery" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<Gallery> List(CancellationToken cancellationToken = default)
        {
            Page<Gallery> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Gallery> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List galleries under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Gallery" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Gallery> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Gallery>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Gallery>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of Gallery for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of Gallery for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, Gallery, GalleryData> Construct() { }
    }
}
