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

namespace Azure.Management.Network
{
    internal partial class VpnServerConfigurationsAssociatedWithVirtualWanRestClient
    {
        private string subscriptionId;
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VpnServerConfigurationsAssociatedWithVirtualWanRestClient. </summary>
        public VpnServerConfigurationsAssociatedWithVirtualWanRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.subscriptionId = subscriptionId;
            this.host = host;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string virtualWANName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualWans/", false);
            uri.AppendPath(virtualWANName, true);
            uri.AppendPath("/vpnServerConfigurations", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gives the list of VpnServerConfigurations associated with Virtual Wan in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN whose associated VpnServerConfigurations is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> ListAsync(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }

            using var message = CreateListRequest(resourceGroupName, virtualWANName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gives the list of VpnServerConfigurations associated with Virtual Wan in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN whose associated VpnServerConfigurations is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response List(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }

            using var message = CreateListRequest(resourceGroupName, virtualWANName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
