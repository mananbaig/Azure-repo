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
    /// <summary> A class representing collection of CloudService and their operations over a ResourceGroup. </summary>
    public partial class CloudServiceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, CloudService, CloudServiceData>
    {
        /// <summary> Initializes a new instance of the <see cref="CloudServiceContainer"/> class for mocking. </summary>
        protected CloudServiceContainer()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CloudServiceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private CloudServicesRestOperations _restClient => new CloudServicesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a cloud service. Please note some properties can be set only during cloud service creation. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public Response<CloudService> CreateOrUpdate(string cloudServiceName, CloudServiceData parameters = null, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(cloudServiceName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a cloud service. Please note some properties can be set only during cloud service creation. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response<CloudService>> CreateOrUpdateAsync(string cloudServiceName, CloudServiceData parameters = null, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(cloudServiceName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a cloud service. Please note some properties can be set only during cloud service creation. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public CloudServicesCreateOrUpdateOperation StartCreateOrUpdate(string cloudServiceName, CloudServiceData parameters = null, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, cloudServiceName, parameters, cancellationToken);
                return new CloudServicesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, cloudServiceName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a cloud service. Please note some properties can be set only during cloud service creation. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<CloudServicesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string cloudServiceName, CloudServiceData parameters = null, CancellationToken cancellationToken = default)
        {
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, cloudServiceName, parameters, cancellationToken).ConfigureAwait(false);
                return new CloudServicesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, cloudServiceName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<CloudService> Get(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.Get");
            scope.Start();
            try
            {
                if (cloudServiceName == null)
                {
                    throw new ArgumentNullException(nameof(cloudServiceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(new CloudService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<CloudService>> GetAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.Get");
            scope.Start();
            try
            {
                if (cloudServiceName == null)
                {
                    throw new ArgumentNullException(nameof(cloudServiceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CloudService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public CloudService TryGet(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.TryGet");
            scope.Start();
            try
            {
                if (cloudServiceName == null)
                {
                    throw new ArgumentNullException(nameof(cloudServiceName));
                }

                return Get(cloudServiceName, cancellationToken: cancellationToken).Value;
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
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<CloudService> TryGetAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.TryGet");
            scope.Start();
            try
            {
                if (cloudServiceName == null)
                {
                    throw new ArgumentNullException(nameof(cloudServiceName));
                }

                return await GetAsync(cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public bool DoesExist(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.DoesExist");
            scope.Start();
            try
            {
                if (cloudServiceName == null)
                {
                    throw new ArgumentNullException(nameof(cloudServiceName));
                }

                return TryGet(cloudServiceName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<bool> DoesExistAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.DoesExist");
            scope.Start();
            try
            {
                if (cloudServiceName == null)
                {
                    throw new ArgumentNullException(nameof(cloudServiceName));
                }

                return await TryGetAsync(cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudService" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<CloudService> List(CancellationToken cancellationToken = default)
        {
            Page<CloudService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CloudService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudService" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<CloudService> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CloudService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CloudService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of CloudService for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CloudServiceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of CloudService for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CloudServiceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CloudServiceOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, CloudService, CloudServiceData> Construct() { }
    }
}
