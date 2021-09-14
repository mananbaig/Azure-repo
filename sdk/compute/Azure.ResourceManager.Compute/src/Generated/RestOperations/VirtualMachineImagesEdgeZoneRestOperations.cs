// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    internal partial class VirtualMachineImagesEdgeZoneRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of VirtualMachineImagesEdgeZoneRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public VirtualMachineImagesEdgeZoneRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null)
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string location, string edgeZone, string publisherName, string offer, string skus, string version)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers/", false);
            uri.AppendPath(offer, true);
            uri.AppendPath("/skus/", false);
            uri.AppendPath(skus, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a virtual machine image in an edge zone. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="version"> A valid image SKU version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, <paramref name="skus"/>, or <paramref name="version"/> is null. </exception>
        public async Task<Response<VirtualMachineImageData>> GetAsync(string location, string edgeZone, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (skus == null)
            {
                throw new ArgumentNullException(nameof(skus));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(location, edgeZone, publisherName, offer, skus, version);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineImageData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineImageData.DeserializeVirtualMachineImageData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a virtual machine image in an edge zone. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="version"> A valid image SKU version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, <paramref name="skus"/>, or <paramref name="version"/> is null. </exception>
        public Response<VirtualMachineImageData> Get(string location, string edgeZone, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (skus == null)
            {
                throw new ArgumentNullException(nameof(skus));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(location, edgeZone, publisherName, offer, skus, version);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineImageData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineImageData.DeserializeVirtualMachineImageData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest(string location, string edgeZone, string publisherName, string offer, string skus, string expand, int? top, string orderby)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers/", false);
            uri.AppendPath(offer, true);
            uri.AppendPath("/skus/", false);
            uri.AppendPath(skus, true);
            uri.AppendPath("/versions", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of all virtual machine image versions for the specified location, edge zone, publisher, offer, and SKU. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="top"> An integer value specifying the number of images to return that matches supplied values. </param>
        /// <param name="orderby"> Specifies the order of the results returned. Formatted as an OData query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, or <paramref name="skus"/> is null. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageResource>>> GetAllAsync(string location, string edgeZone, string publisherName, string offer, string skus, string expand = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (skus == null)
            {
                throw new ArgumentNullException(nameof(skus));
            }

            using var message = CreateGetAllRequest(location, edgeZone, publisherName, offer, skus, expand, top, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all virtual machine image versions for the specified location, edge zone, publisher, offer, and SKU. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="top"> An integer value specifying the number of images to return that matches supplied values. </param>
        /// <param name="orderby"> Specifies the order of the results returned. Formatted as an OData query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, or <paramref name="skus"/> is null. </exception>
        public Response<IReadOnlyList<VirtualMachineImageResource>> GetAll(string location, string edgeZone, string publisherName, string offer, string skus, string expand = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (skus == null)
            {
                throw new ArgumentNullException(nameof(skus));
            }

            using var message = CreateGetAllRequest(location, edgeZone, publisherName, offer, skus, expand, top, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOffersRequest(string location, string edgeZone, string publisherName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers", false);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of virtual machine image offers for the specified location, edge zone and publisher. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, or <paramref name="publisherName"/> is null. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageResource>>> GetOffersAsync(string location, string edgeZone, string publisherName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            using var message = CreateGetOffersRequest(location, edgeZone, publisherName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of virtual machine image offers for the specified location, edge zone and publisher. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, or <paramref name="publisherName"/> is null. </exception>
        public Response<IReadOnlyList<VirtualMachineImageResource>> GetOffers(string location, string edgeZone, string publisherName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            using var message = CreateGetOffersRequest(location, edgeZone, publisherName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPublishersRequest(string location, string edgeZone)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers", false);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of virtual machine image publishers for the specified Azure location and edge zone. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="edgeZone"/> is null. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageResource>>> GetPublishersAsync(string location, string edgeZone, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }

            using var message = CreateGetPublishersRequest(location, edgeZone);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of virtual machine image publishers for the specified Azure location and edge zone. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="edgeZone"/> is null. </exception>
        public Response<IReadOnlyList<VirtualMachineImageResource>> GetPublishers(string location, string edgeZone, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }

            using var message = CreateGetPublishersRequest(location, edgeZone);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSkusRequest(string location, string edgeZone, string publisherName, string offer)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers/", false);
            uri.AppendPath(offer, true);
            uri.AppendPath("/skus", false);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of virtual machine image SKUs for the specified location, edge zone, publisher, and offer. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, or <paramref name="offer"/> is null. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageResource>>> GetSkusAsync(string location, string edgeZone, string publisherName, string offer, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }

            using var message = CreateGetSkusRequest(location, edgeZone, publisherName, offer);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of virtual machine image SKUs for the specified location, edge zone, publisher, and offer. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, or <paramref name="offer"/> is null. </exception>
        public Response<IReadOnlyList<VirtualMachineImageResource>> GetSkus(string location, string edgeZone, string publisherName, string offer, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (edgeZone == null)
            {
                throw new ArgumentNullException(nameof(edgeZone));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }

            using var message = CreateGetSkusRequest(location, edgeZone, publisherName, offer);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageResource> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageResource> array = new List<VirtualMachineImageResource>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageResource.DeserializeVirtualMachineImageResource(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
