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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingEndpointResource"/> and their operations.
    /// Each <see cref="StreamingEndpointResource"/> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource"/>.
    /// To get a <see cref="StreamingEndpointCollection"/> instance call the GetStreamingEndpoints method from an instance of <see cref="MediaServicesAccountResource"/>.
    /// </summary>
    public partial class StreamingEndpointCollection : ArmCollection, IEnumerable<StreamingEndpointResource>, IAsyncEnumerable<StreamingEndpointResource>
    {
        private readonly ClientDiagnostics _streamingEndpointClientDiagnostics;
        private readonly StreamingEndpointsRestOperations _streamingEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingEndpointCollection"/> class for mocking. </summary>
        protected StreamingEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", StreamingEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingEndpointResource.ResourceType, out string streamingEndpointApiVersion);
            _streamingEndpointRestClient = new StreamingEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a streaming endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="data"> Streaming endpoint properties needed for creation. </param>
        /// <param name="autoStart"> The flag indicates if the resource should be automatically started on creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string streamingEndpointName, StreamingEndpointData data, bool? autoStart = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingEndpointRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, data, autoStart, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<StreamingEndpointResource>(new StreamingEndpointOperationSource(Client), _streamingEndpointClientDiagnostics, Pipeline, _streamingEndpointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, data, autoStart).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a streaming endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="data"> Streaming endpoint properties needed for creation. </param>
        /// <param name="autoStart"> The flag indicates if the resource should be automatically started on creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamingEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string streamingEndpointName, StreamingEndpointData data, bool? autoStart = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingEndpointRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, data, autoStart, cancellationToken);
                var operation = new MediaArmOperation<StreamingEndpointResource>(new StreamingEndpointOperationSource(Client), _streamingEndpointClientDiagnostics, Pipeline, _streamingEndpointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, data, autoStart).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a streaming endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> is null. </exception>
        public virtual async Task<Response<StreamingEndpointResource>> GetAsync(string streamingEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a streaming endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> is null. </exception>
        public virtual Response<StreamingEndpointResource> Get(string streamingEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the streaming endpoints in the account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingEndpointRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingEndpointRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamingEndpointResource(Client, StreamingEndpointData.DeserializeStreamingEndpointData(e)), _streamingEndpointClientDiagnostics, Pipeline, "StreamingEndpointCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the streaming endpoints in the account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingEndpointRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingEndpointRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamingEndpointResource(Client, StreamingEndpointData.DeserializeStreamingEndpointData(e)), _streamingEndpointClientDiagnostics, Pipeline, "StreamingEndpointCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string streamingEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string streamingEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<StreamingEndpointResource>> GetIfExistsAsync(string streamingEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _streamingEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StreamingEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/streamingEndpoints/{streamingEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="streamingEndpointName"> The name of the streaming endpoint, maximum length is 24. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="streamingEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingEndpointName"/> is null. </exception>
        public virtual NullableResponse<StreamingEndpointResource> GetIfExists(string streamingEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(streamingEndpointName, nameof(streamingEndpointName));

            using var scope = _streamingEndpointClientDiagnostics.CreateScope("StreamingEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _streamingEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, streamingEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StreamingEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new StreamingEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingEndpointResource> IEnumerable<StreamingEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingEndpointResource> IAsyncEnumerable<StreamingEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
