// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VpnGateway along with the instance operations that can be performed on it. </summary>
    public partial class VpnGateway : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnGatewaysRestOperations _vpnGatewaysRestClient;
        private readonly VpnGatewayData _data;

        /// <summary> Initializes a new instance of the <see cref="VpnGateway"/> class for mocking. </summary>
        protected VpnGateway()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VpnGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VpnGateway(ArmResource options, VpnGatewayData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnGatewaysRestClient = new VpnGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnGateway(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnGatewaysRestClient = new VpnGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGateway"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnGateway(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnGatewaysRestClient = new VpnGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnGateways";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VpnGatewayData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Retrieves the details of a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VpnGateway>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Get");
            scope.Start();
            try
            {
                var response = await _vpnGatewaysRestClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnGateway> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Get");
            scope.Start();
            try
            {
                var response = _vpnGatewaysRestClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Delete");
            scope.Start();
            try
            {
                var response = await _vpnGatewaysRestClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VpnGatewayDeleteOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Delete");
            scope.Start();
            try
            {
                var response = _vpnGatewaysRestClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new VpnGatewayDeleteOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnGatewayParameters"/> is null. </exception>
        public async virtual Task<VpnGatewayUpdateTagsOperation> UpdateAsync(TagsObject vpnGatewayParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Update");
            scope.Start();
            try
            {
                var response = await _vpnGatewaysRestClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VpnGatewayUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, vpnGatewayParameters).Request, response);
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

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnGatewayParameters"/> is null. </exception>
        public virtual VpnGatewayUpdateTagsOperation Update(TagsObject vpnGatewayParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Update");
            scope.Start();
            try
            {
                var response = _vpnGatewaysRestClient.UpdateTags(Id.ResourceGroupName, Id.Name, vpnGatewayParameters, cancellationToken);
                var operation = new VpnGatewayUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, vpnGatewayParameters).Request, response);
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

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayResetOperation> ResetAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Reset");
            scope.Start();
            try
            {
                var response = await _vpnGatewaysRestClient.ResetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VpnGatewayResetOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateResetRequest(Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayResetOperation Reset(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Reset");
            scope.Start();
            try
            {
                var response = _vpnGatewaysRestClient.Reset(Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new VpnGatewayResetOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateResetRequest(Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Starts packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to start packet capture on vpn gateway. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayStartPacketCaptureOperation> StartPacketCaptureAsync(VpnGatewayPacketCaptureStartParameters parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartPacketCapture");
            scope.Start();
            try
            {
                var response = await _vpnGatewaysRestClient.StartPacketCaptureAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VpnGatewayStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Starts packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to start packet capture on vpn gateway. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayStartPacketCaptureOperation StartPacketCapture(VpnGatewayPacketCaptureStartParameters parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartPacketCapture");
            scope.Start();
            try
            {
                var response = _vpnGatewaysRestClient.StartPacketCapture(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                var operation = new VpnGatewayStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Stops packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to stop packet capture on vpn gateway. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayStopPacketCaptureOperation> StopPacketCaptureAsync(VpnGatewayPacketCaptureStopParameters parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StopPacketCapture");
            scope.Start();
            try
            {
                var response = await _vpnGatewaysRestClient.StopPacketCaptureAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VpnGatewayStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Stops packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to stop packet capture on vpn gateway. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayStopPacketCaptureOperation StopPacketCapture(VpnGatewayPacketCaptureStopParameters parameters = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StopPacketCapture");
            scope.Start();
            try
            {
                var response = _vpnGatewaysRestClient.StopPacketCapture(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                var operation = new VpnGatewayStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _vpnGatewaysRestClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        #region VpnConnection

        /// <summary> Gets a collection of VpnConnections in the VpnGateway. </summary>
        /// <returns> An object representing collection of VpnConnections and their operations over a VpnGateway. </returns>
        public virtual VpnConnectionCollection GetVpnConnections()
        {
            return new VpnConnectionCollection(this);
        }
        #endregion

        #region VpnGatewayNatRule

        /// <summary> Gets a collection of VpnGatewayNatRules in the VpnGateway. </summary>
        /// <returns> An object representing collection of VpnGatewayNatRules and their operations over a VpnGateway. </returns>
        public virtual VpnGatewayNatRuleCollection GetVpnGatewayNatRules()
        {
            return new VpnGatewayNatRuleCollection(this);
        }
        #endregion
    }
}
