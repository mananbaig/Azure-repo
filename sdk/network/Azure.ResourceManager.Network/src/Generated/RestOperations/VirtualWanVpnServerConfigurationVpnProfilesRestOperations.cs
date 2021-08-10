// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VirtualWanVpnServerConfigurationVpnProfilesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VirtualWanVpnServerConfigurationVpnProfilesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualWanVpnServerConfigurationVpnProfilesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGenerateRequest(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualWans/", false);
            uri.AppendPath(virtualWANName, true);
            uri.AppendPath("/GenerateVpnProfile", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(vpnClientParams);
            request.Content = content;
            return message;
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN whose associated VpnServerConfigurations is needed. </param>
        /// <param name="vpnClientParams"> Parameters supplied to the generate VirtualWan VPN profile generation operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualWANName"/>, or <paramref name="vpnClientParams"/> is null. </exception>
        public async Task<Response> GenerateAsync(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (vpnClientParams == null)
            {
                throw new ArgumentNullException(nameof(vpnClientParams));
            }

            using var message = CreateGenerateRequest(resourceGroupName, virtualWANName, vpnClientParams);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN whose associated VpnServerConfigurations is needed. </param>
        /// <param name="vpnClientParams"> Parameters supplied to the generate VirtualWan VPN profile generation operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualWANName"/>, or <paramref name="vpnClientParams"/> is null. </exception>
        public Response Generate(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (vpnClientParams == null)
            {
                throw new ArgumentNullException(nameof(vpnClientParams));
            }

            using var message = CreateGenerateRequest(resourceGroupName, virtualWANName, vpnClientParams);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
