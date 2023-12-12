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

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A Class representing a PeeringRegisteredAsn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PeeringRegisteredAsnResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPeeringRegisteredAsnResource method.
    /// Otherwise you can get one from its parent resource <see cref="PeeringResource"/> using the GetPeeringRegisteredAsn method.
    /// </summary>
    public partial class PeeringRegisteredAsnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PeeringRegisteredAsnResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="peeringName"> The peeringName. </param>
        /// <param name="registeredAsnName"> The registeredAsnName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string peeringName, string registeredAsnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _peeringRegisteredAsnRegisteredAsnsClientDiagnostics;
        private readonly RegisteredAsnsRestOperations _peeringRegisteredAsnRegisteredAsnsRestClient;
        private readonly PeeringRegisteredAsnData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Peering/peerings/registeredAsns";

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredAsnResource"/> class for mocking. </summary>
        protected PeeringRegisteredAsnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredAsnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PeeringRegisteredAsnResource(ArmClient client, PeeringRegisteredAsnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PeeringRegisteredAsnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PeeringRegisteredAsnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peeringRegisteredAsnRegisteredAsnsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string peeringRegisteredAsnRegisteredAsnsApiVersion);
            _peeringRegisteredAsnRegisteredAsnsRestClient = new RegisteredAsnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peeringRegisteredAsnRegisteredAsnsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PeeringRegisteredAsnData Data
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
        /// Gets an existing registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PeeringRegisteredAsnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnResource.Get");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PeeringRegisteredAsnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnResource.Get");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringRegisteredAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnResource.Delete");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation(response);
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
        /// Deletes an existing registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnResource.Delete");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new PeeringArmOperation(response);
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
        /// Creates a new registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The properties needed to create a registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeeringRegisteredAsnResource>> UpdateAsync(WaitUntil waitUntil, PeeringRegisteredAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnResource.Update");
            scope.Start();
            try
            {
                var response = await _peeringRegisteredAsnRegisteredAsnsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation<PeeringRegisteredAsnResource>(Response.FromValue(new PeeringRegisteredAsnResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new registered ASN with the specified name under the given subscription, resource group and peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peerings/{peeringName}/registeredAsns/{registeredAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredAsns_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The properties needed to create a registered ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeeringRegisteredAsnResource> Update(WaitUntil waitUntil, PeeringRegisteredAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringRegisteredAsnRegisteredAsnsClientDiagnostics.CreateScope("PeeringRegisteredAsnResource.Update");
            scope.Start();
            try
            {
                var response = _peeringRegisteredAsnRegisteredAsnsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new PeeringArmOperation<PeeringRegisteredAsnResource>(Response.FromValue(new PeeringRegisteredAsnResource(Client, response), response.GetRawResponse()));
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
