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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing collection of WebPubSubResource and their operations over a ResourceGroup. </summary>
    public partial class WebPubSubResourceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebPubSubRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="WebPubSubResourceContainer"/> class for mocking. </summary>
        protected WebPubSubResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of WebPubSubResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WebPubSubResourceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new WebPubSubRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Create or update a resource. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WebPubSubCreateOrUpdateOperation CreateOrUpdate(string resourceName, WebPubSubResourceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, resourceName, parameters, cancellationToken);
                var operation = new WebPubSubCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, resourceName, parameters).Request, response);
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

        /// <summary> Create or update a resource. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WebPubSubCreateOrUpdateOperation> CreateOrUpdateAsync(string resourceName, WebPubSubResourceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, resourceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, resourceName, parameters).Request, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<WebPubSubResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.Get");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebPubSubResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<WebPubSubResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.Get");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WebPubSubResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<WebPubSubResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<WebPubSubResource>(null, response.GetRawResponse())
                    : Response.FromValue(new WebPubSubResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<WebPubSubResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<WebPubSubResource>(null, response.GetRawResponse())
                    : Response.FromValue(new WebPubSubResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = GetIfExists(resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = await GetIfExistsAsync(resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Handles requests to list all resources in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebPubSubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebPubSubResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WebPubSubResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WebPubSubResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Handles requests to list all resources in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebPubSubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebPubSubResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WebPubSubResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WebPubSubResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="WebPubSubResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WebPubSubResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="WebPubSubResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebPubSubResourceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WebPubSubResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, WebPubSubResource, WebPubSubResourceData> Construct() { }
    }
}
