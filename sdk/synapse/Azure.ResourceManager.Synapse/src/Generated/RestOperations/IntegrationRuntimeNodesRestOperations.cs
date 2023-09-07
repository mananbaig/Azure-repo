// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    internal partial class IntegrationRuntimeNodesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationRuntimeNodesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationRuntimeNodesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/integrationRuntimes/", false);
            uri.AppendPath(integrationRuntimeName, true);
            uri.AppendPath("/nodes/", false);
            uri.AppendPath(nodeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get an integration runtime node. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="integrationRuntimeName"> Integration runtime name. </param>
        /// <param name="nodeName"> Integration runtime node name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseSelfHostedIntegrationRuntimeNode>> GetAsync(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNullOrEmpty(nodeName, nameof(nodeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, integrationRuntimeName, nodeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseSelfHostedIntegrationRuntimeNode value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SynapseSelfHostedIntegrationRuntimeNode.DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get an integration runtime node. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="integrationRuntimeName"> Integration runtime name. </param>
        /// <param name="nodeName"> Integration runtime node name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseSelfHostedIntegrationRuntimeNode> Get(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNullOrEmpty(nodeName, nameof(nodeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, integrationRuntimeName, nodeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseSelfHostedIntegrationRuntimeNode value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SynapseSelfHostedIntegrationRuntimeNode.DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/integrationRuntimes/", false);
            uri.AppendPath(integrationRuntimeName, true);
            uri.AppendPath("/nodes/", false);
            uri.AppendPath(nodeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create an integration runtime node. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="integrationRuntimeName"> Integration runtime name. </param>
        /// <param name="nodeName"> Integration runtime node name. </param>
        /// <param name="content"> The parameters for updating an integration runtime node. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/>, <paramref name="nodeName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseSelfHostedIntegrationRuntimeNode>> UpdateAsync(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNullOrEmpty(nodeName, nameof(nodeName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, workspaceName, integrationRuntimeName, nodeName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseSelfHostedIntegrationRuntimeNode value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SynapseSelfHostedIntegrationRuntimeNode.DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create an integration runtime node. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="integrationRuntimeName"> Integration runtime name. </param>
        /// <param name="nodeName"> Integration runtime node name. </param>
        /// <param name="content"> The parameters for updating an integration runtime node. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/>, <paramref name="nodeName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseSelfHostedIntegrationRuntimeNode> Update(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNullOrEmpty(nodeName, nameof(nodeName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, workspaceName, integrationRuntimeName, nodeName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseSelfHostedIntegrationRuntimeNode value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SynapseSelfHostedIntegrationRuntimeNode.DeserializeSynapseSelfHostedIntegrationRuntimeNode(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/integrationRuntimes/", false);
            uri.AppendPath(integrationRuntimeName, true);
            uri.AppendPath("/nodes/", false);
            uri.AppendPath(nodeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete an integration runtime node. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="integrationRuntimeName"> Integration runtime name. </param>
        /// <param name="nodeName"> Integration runtime node name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNullOrEmpty(nodeName, nameof(nodeName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, integrationRuntimeName, nodeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete an integration runtime node. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="integrationRuntimeName"> Integration runtime name. </param>
        /// <param name="nodeName"> Integration runtime node name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="integrationRuntimeName"/> or <paramref name="nodeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNullOrEmpty(nodeName, nameof(nodeName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, integrationRuntimeName, nodeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
