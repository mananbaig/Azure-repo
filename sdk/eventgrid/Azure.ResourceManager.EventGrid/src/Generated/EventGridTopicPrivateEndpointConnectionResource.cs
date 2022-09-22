// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing an EventGridTopicPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EventGridTopicPrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEventGridTopicPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetEventGridTopicPrivateEndpointConnection method.
    /// </summary>
    public partial class EventGridTopicPrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventGridTopicPrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string parentName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _privateEndpointConnectionsRestClient;
        private readonly EventGridPrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="EventGridTopicPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected EventGridTopicPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EventGridTopicPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventGridTopicPrivateEndpointConnectionResource(ArmClient client, EventGridPrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridTopicPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventGridTopicPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _privateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/topics/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventGridPrivateEndpointConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a specific private endpoint connection under a topic, domain, or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual async Task<Response<EventGridPrivateEndpointConnectionData>> GetAsync(string parentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            using var scope = _privateEndpointConnectionsClientDiagnostics.CreateScope("EventGridTopicPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", parentName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific private endpoint connection under a topic, domain, or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual Response<EventGridPrivateEndpointConnectionData> Get(string parentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            using var scope = _privateEndpointConnectionsClientDiagnostics.CreateScope("EventGridTopicPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "topics", parentName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a specific private endpoint connection under a topic, domain, or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string parentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            using var scope = _privateEndpointConnectionsClientDiagnostics.CreateScope("EventGridTopicPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", parentName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_privateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", parentName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a specific private endpoint connection under a topic, domain, or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string parentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            using var scope = _privateEndpointConnectionsClientDiagnostics.CreateScope("EventGridTopicPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, "topics", parentName, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_privateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", parentName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a specific private endpoint connection under a topic, domain or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection object to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridPrivateEndpointConnectionData>> UpdateAsync(WaitUntil waitUntil, EventGridPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionsClientDiagnostics.CreateScope("EventGridTopicPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridPrivateEndpointConnectionData>(new EventGridPrivateEndpointConnectionDataOperationSource(), _privateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update a specific private endpoint connection under a topic, domain or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection object to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridPrivateEndpointConnectionData> Update(WaitUntil waitUntil, EventGridPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionsClientDiagnostics.CreateScope("EventGridTopicPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridPrivateEndpointConnectionData>(new EventGridPrivateEndpointConnectionDataOperationSource(), _privateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
