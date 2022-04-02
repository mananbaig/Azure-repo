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
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    internal partial class AfdSecretsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AfdSecretsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AfdSecretsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByProfileRequest(string subscriptionId, string resourceGroupName, string profileName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/secrets", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecretListResult>> ListByProfileAsync(string subscriptionId, string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var message = CreateListByProfileRequest(subscriptionId, resourceGroupName, profileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretListResult.DeserializeSecretListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecretListResult> ListByProfile(string subscriptionId, string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var message = CreateListByProfileRequest(subscriptionId, resourceGroupName, profileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretListResult.DeserializeSecretListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string profileName, string secretName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/secrets/", false);
            uri.AppendPath(secretName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AfdSecretData>> GetAsync(string subscriptionId, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, profileName, secretName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AfdSecretData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AfdSecretData.DeserializeAfdSecretData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AfdSecretData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AfdSecretData> Get(string subscriptionId, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, profileName, secretName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AfdSecretData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AfdSecretData.DeserializeAfdSecretData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AfdSecretData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string profileName, string secretName, AfdSecretData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/secrets/", false);
            uri.AppendPath(secretName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a new Secret within the specified profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="data"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="secretName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string profileName, string secretName, AfdSecretData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, profileName, secretName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new Secret within the specified profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="data"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="secretName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string profileName, string secretName, AfdSecretData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, profileName, secretName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string profileName, string secretName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/secrets/", false);
            uri.AppendPath(secretName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an existing Secret within profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, profileName, secretName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an existing Secret within profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, profileName, secretName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByProfileNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string profileName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecretListResult>> ListByProfileNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var message = CreateListByProfileNextPageRequest(nextLink, subscriptionId, resourceGroupName, profileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecretListResult.DeserializeSecretListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecretListResult> ListByProfileNextPage(string nextLink, string subscriptionId, string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var message = CreateListByProfileNextPageRequest(nextLink, subscriptionId, resourceGroupName, profileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecretListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecretListResult.DeserializeSecretListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
