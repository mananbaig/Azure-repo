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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorOriginGroupResource" /> and their operations.
    /// Each <see cref="FrontDoorOriginGroupResource" /> in the collection will belong to the same instance of <see cref="ProfileResource" />.
    /// To get a <see cref="FrontDoorOriginGroupCollection" /> instance call the GetFrontDoorOriginGroups method from an instance of <see cref="ProfileResource" />.
    /// </summary>
    public partial class FrontDoorOriginGroupCollection : ArmCollection, IEnumerable<FrontDoorOriginGroupResource>, IAsyncEnumerable<FrontDoorOriginGroupResource>
    {
        private readonly ClientDiagnostics _frontDoorOriginGroupClientDiagnostics;
        private readonly FrontDoorOriginGroupsRestOperations _frontDoorOriginGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorOriginGroupCollection"/> class for mocking. </summary>
        protected FrontDoorOriginGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorOriginGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorOriginGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorOriginGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", FrontDoorOriginGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorOriginGroupResource.ResourceType, out string frontDoorOriginGroupApiVersion);
            _frontDoorOriginGroupRestClient = new FrontDoorOriginGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorOriginGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new origin group within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="data"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorOriginGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string originGroupName, FrontDoorOriginGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorOriginGroupRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorOriginGroupResource>(new FrontDoorOriginGroupOperationSource(Client), _frontDoorOriginGroupClientDiagnostics, Pipeline, _frontDoorOriginGroupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new origin group within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="data"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorOriginGroupResource> CreateOrUpdate(WaitUntil waitUntil, string originGroupName, FrontDoorOriginGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorOriginGroupRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, data, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorOriginGroupResource>(new FrontDoorOriginGroupOperationSource(Client), _frontDoorOriginGroupClientDiagnostics, Pipeline, _frontDoorOriginGroupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorOriginGroupResource>> GetAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<FrontDoorOriginGroupResource> Get(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the existing origin groups within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_ListByProfile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorOriginGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorOriginGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorOriginGroupRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorOriginGroupRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new FrontDoorOriginGroupResource(Client, FrontDoorOriginGroupData.DeserializeFrontDoorOriginGroupData(e)), _frontDoorOriginGroupClientDiagnostics, Pipeline, "FrontDoorOriginGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the existing origin groups within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_ListByProfile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorOriginGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorOriginGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorOriginGroupRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorOriginGroupRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new FrontDoorOriginGroupResource(Client, FrontDoorOriginGroupData.DeserializeFrontDoorOriginGroupData(e)), _frontDoorOriginGroupClientDiagnostics, Pipeline, "FrontDoorOriginGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorOriginGroupResource> IEnumerable<FrontDoorOriginGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorOriginGroupResource> IAsyncEnumerable<FrontDoorOriginGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
