// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ContainerInstance
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerGroupProfileRevisionResource"/> and their operations.
    /// Each <see cref="ContainerGroupProfileRevisionResource"/> in the collection will belong to the same instance of <see cref="ContainerGroupProfileResource"/>.
    /// To get a <see cref="ContainerGroupProfileRevisionCollection"/> instance call the GetContainerGroupProfileRevisions method from an instance of <see cref="ContainerGroupProfileResource"/>.
    /// </summary>
    public partial class ContainerGroupProfileRevisionCollection : ArmCollection, IEnumerable<ContainerGroupProfileRevisionResource>, IAsyncEnumerable<ContainerGroupProfileRevisionResource>
    {
        private readonly ClientDiagnostics _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics;
        private readonly ContainerGroupProfileRestOperations _containerGroupProfileRevisionContainerGroupProfileRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerGroupProfileRevisionCollection"/> class for mocking. </summary>
        protected ContainerGroupProfileRevisionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerGroupProfileRevisionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerGroupProfileRevisionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ContainerGroupProfileRevisionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerGroupProfileRevisionResource.ResourceType, out string containerGroupProfileRevisionContainerGroupProfileApiVersion);
            _containerGroupProfileRevisionContainerGroupProfileRestClient = new ContainerGroupProfileRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerGroupProfileRevisionContainerGroupProfileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerGroupProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerGroupProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the properties of the specified revision of the container group profile in the given subscription and resource group. The operation returns the properties of container group profile including containers, image registry credentials, restart policy, IP address type, OS type, volumes, current revision number, etc.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions/{revisionNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_GetByRevisionNumber</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionNumber"> The revision number of the container group profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionNumber"/> is null. </exception>
        public virtual async Task<Response<ContainerGroupProfileRevisionResource>> GetAsync(string revisionNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionNumber, nameof(revisionNumber));

            using var scope = _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics.CreateScope("ContainerGroupProfileRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileRevisionContainerGroupProfileRestClient.GetByRevisionNumberAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionNumber, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified revision of the container group profile in the given subscription and resource group. The operation returns the properties of container group profile including containers, image registry credentials, restart policy, IP address type, OS type, volumes, current revision number, etc.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions/{revisionNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_GetByRevisionNumber</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionNumber"> The revision number of the container group profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionNumber"/> is null. </exception>
        public virtual Response<ContainerGroupProfileRevisionResource> Get(string revisionNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionNumber, nameof(revisionNumber));

            using var scope = _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics.CreateScope("ContainerGroupProfileRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = _containerGroupProfileRevisionContainerGroupProfileRestClient.GetByRevisionNumber(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionNumber, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all the revisions of the specified container group profile in the given subscription and resource group. This operation returns properties of each revision of the specified container group profile including containers, image registry credentials, restart policy, IP address type, OS type volumes, revision number, etc.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_ListAllRevisions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerGroupProfileRevisionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerGroupProfileRevisionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerGroupProfileRevisionContainerGroupProfileRestClient.CreateListAllRevisionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerGroupProfileRevisionContainerGroupProfileRestClient.CreateListAllRevisionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupProfileRevisionResource(Client, ContainerGroupProfileData.DeserializeContainerGroupProfileData(e)), _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics, Pipeline, "ContainerGroupProfileRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all the revisions of the specified container group profile in the given subscription and resource group. This operation returns properties of each revision of the specified container group profile including containers, image registry credentials, restart policy, IP address type, OS type volumes, revision number, etc.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_ListAllRevisions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerGroupProfileRevisionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerGroupProfileRevisionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerGroupProfileRevisionContainerGroupProfileRestClient.CreateListAllRevisionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerGroupProfileRevisionContainerGroupProfileRestClient.CreateListAllRevisionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupProfileRevisionResource(Client, ContainerGroupProfileData.DeserializeContainerGroupProfileData(e)), _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics, Pipeline, "ContainerGroupProfileRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions/{revisionNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_GetByRevisionNumber</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionNumber"> The revision number of the container group profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionNumber"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string revisionNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionNumber, nameof(revisionNumber));

            using var scope = _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics.CreateScope("ContainerGroupProfileRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileRevisionContainerGroupProfileRestClient.GetByRevisionNumberAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionNumber, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions/{revisionNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_GetByRevisionNumber</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionNumber"> The revision number of the container group profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionNumber"/> is null. </exception>
        public virtual Response<bool> Exists(string revisionNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionNumber, nameof(revisionNumber));

            using var scope = _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics.CreateScope("ContainerGroupProfileRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerGroupProfileRevisionContainerGroupProfileRestClient.GetByRevisionNumber(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionNumber, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions/{revisionNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_GetByRevisionNumber</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionNumber"> The revision number of the container group profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionNumber"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerGroupProfileRevisionResource>> GetIfExistsAsync(string revisionNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionNumber, nameof(revisionNumber));

            using var scope = _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics.CreateScope("ContainerGroupProfileRevisionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerGroupProfileRevisionContainerGroupProfileRestClient.GetByRevisionNumberAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionNumber, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerGroupProfileRevisionResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroupProfiles/{containerGroupProfileName}/revisions/{revisionNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroupProfile_GetByRevisionNumber</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileRevisionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionNumber"> The revision number of the container group profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionNumber"/> is null. </exception>
        public virtual NullableResponse<ContainerGroupProfileRevisionResource> GetIfExists(string revisionNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionNumber, nameof(revisionNumber));

            using var scope = _containerGroupProfileRevisionContainerGroupProfileClientDiagnostics.CreateScope("ContainerGroupProfileRevisionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerGroupProfileRevisionContainerGroupProfileRestClient.GetByRevisionNumber(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionNumber, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerGroupProfileRevisionResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerGroupProfileRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerGroupProfileRevisionResource> IEnumerable<ContainerGroupProfileRevisionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerGroupProfileRevisionResource> IAsyncEnumerable<ContainerGroupProfileRevisionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
