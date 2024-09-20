// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    internal partial class CertificatesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CertificatesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CertificatesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByCatalogRequestUri(string subscriptionId, string resourceGroupName, string catalogName, string filter, int? top, int? skip, int? maxpagesize)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", maxpagesize.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByCatalogRequest(string subscriptionId, string resourceGroupName, string catalogName, string filter, int? top, int? skip, int? maxpagesize)
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
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", maxpagesize.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List Certificate resources by Catalog. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CertificateListResult>> ListByCatalogAsync(string subscriptionId, string resourceGroupName, string catalogName, string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var message = CreateListByCatalogRequest(subscriptionId, resourceGroupName, catalogName, filter, top, skip, maxpagesize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CertificateListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CertificateListResult.DeserializeCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Certificate resources by Catalog. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CertificateListResult> ListByCatalog(string subscriptionId, string resourceGroupName, string catalogName, string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var message = CreateListByCatalogRequest(subscriptionId, resourceGroupName, catalogName, filter, top, skip, maxpagesize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CertificateListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CertificateListResult.DeserializeCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber)
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
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a Certificate. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SphereCertificateData>> GetAsync(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, catalogName, serialNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SphereCertificateData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SphereCertificateData.DeserializeSphereCertificateData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SphereCertificateData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Certificate. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SphereCertificateData> Get(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, catalogName, serialNumber);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SphereCertificateData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SphereCertificateData.DeserializeSphereCertificateData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SphereCertificateData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateRetrieveCertChainRequestUri(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendPath("/retrieveCertChain", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateRetrieveCertChainRequest(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendPath("/retrieveCertChain", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves cert chain. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SphereCertificateChainResult>> RetrieveCertChainAsync(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var message = CreateRetrieveCertChainRequest(subscriptionId, resourceGroupName, catalogName, serialNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SphereCertificateChainResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SphereCertificateChainResult.DeserializeSphereCertificateChainResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves cert chain. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SphereCertificateChainResult> RetrieveCertChain(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var message = CreateRetrieveCertChainRequest(subscriptionId, resourceGroupName, catalogName, serialNumber);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SphereCertificateChainResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SphereCertificateChainResult.DeserializeSphereCertificateChainResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateRetrieveProofOfPossessionNonceRequestUri(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, ProofOfPossessionNonceContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendPath("/retrieveProofOfPossessionNonce", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateRetrieveProofOfPossessionNonceRequest(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, ProofOfPossessionNonceContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AzureSphere/catalogs/", false);
            uri.AppendPath(catalogName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendPath("/retrieveProofOfPossessionNonce", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the proof of possession nonce. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="content"> Proof of possession nonce request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/>, <paramref name="serialNumber"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ProofOfPossessionNonceResponse>> RetrieveProofOfPossessionNonceAsync(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, ProofOfPossessionNonceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRetrieveProofOfPossessionNonceRequest(subscriptionId, resourceGroupName, catalogName, serialNumber, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProofOfPossessionNonceResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ProofOfPossessionNonceResponse.DeserializeProofOfPossessionNonceResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the proof of possession nonce. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="content"> Proof of possession nonce request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/>, <paramref name="serialNumber"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="catalogName"/> or <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ProofOfPossessionNonceResponse> RetrieveProofOfPossessionNonce(string subscriptionId, string resourceGroupName, string catalogName, string serialNumber, ProofOfPossessionNonceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRetrieveProofOfPossessionNonceRequest(subscriptionId, resourceGroupName, catalogName, serialNumber, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProofOfPossessionNonceResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ProofOfPossessionNonceResponse.DeserializeProofOfPossessionNonceResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByCatalogNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string catalogName, string filter, int? top, int? skip, int? maxpagesize)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByCatalogNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string catalogName, string filter, int? top, int? skip, int? maxpagesize)
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

        /// <summary> List Certificate resources by Catalog. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CertificateListResult>> ListByCatalogNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string catalogName, string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var message = CreateListByCatalogNextPageRequest(nextLink, subscriptionId, resourceGroupName, catalogName, filter, top, skip, maxpagesize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CertificateListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CertificateListResult.DeserializeCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Certificate resources by Catalog. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CertificateListResult> ListByCatalogNextPage(string nextLink, string subscriptionId, string resourceGroupName, string catalogName, string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var message = CreateListByCatalogNextPageRequest(nextLink, subscriptionId, resourceGroupName, catalogName, filter, top, skip, maxpagesize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CertificateListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CertificateListResult.DeserializeCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
