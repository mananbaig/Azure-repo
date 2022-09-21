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
using Azure.ResourceManager.MarketplaceOrdering.Models;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    internal partial class MarketplaceAgreementsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of MarketplaceAgreementsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public MarketplaceAgreementsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MarketplaceOrdering/offerTypes/", false);
            uri.AppendPath(offerType.ToString(), true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendPath("/plans/", false);
            uri.AppendPath(planId, true);
            uri.AppendPath("/agreements/current", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MarketplaceAgreementTermData>> GetAsync(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateGetRequest(subscriptionId, offerType, publisherId, offerId, planId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MarketplaceAgreementTermData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MarketplaceAgreementTermData> Get(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateGetRequest(subscriptionId, offerType, publisherId, offerId, planId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MarketplaceAgreementTermData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId, MarketplaceAgreementTermData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MarketplaceOrdering/offerTypes/", false);
            uri.AppendPath(offerType.ToString(), true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendPath("/plans/", false);
            uri.AppendPath(planId, true);
            uri.AppendPath("/agreements/current", false);
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

        /// <summary> Save marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="data"> Parameters supplied to the Create Marketplace Terms operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/>, <paramref name="planId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MarketplaceAgreementTermData>> CreateAsync(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId, MarketplaceAgreementTermData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, offerType, publisherId, offerId, planId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Save marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="data"> Parameters supplied to the Create Marketplace Terms operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/>, <paramref name="planId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MarketplaceAgreementTermData> Create(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId, MarketplaceAgreementTermData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, offerType, publisherId, offerId, planId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSignRequest(string subscriptionId, string publisherId, string offerId, string planId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MarketplaceOrdering/agreements/", false);
            uri.AppendPath(publisherId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendPath("/plans/", false);
            uri.AppendPath(planId, true);
            uri.AppendPath("/sign", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Sign marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MarketplaceAgreementTermData>> SignAsync(string subscriptionId, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateSignRequest(subscriptionId, publisherId, offerId, planId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Sign marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MarketplaceAgreementTermData> Sign(string subscriptionId, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateSignRequest(subscriptionId, publisherId, offerId, planId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string subscriptionId, string publisherId, string offerId, string planId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MarketplaceOrdering/agreements/", false);
            uri.AppendPath(publisherId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendPath("/plans/", false);
            uri.AppendPath(planId, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Cancel marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MarketplaceAgreementTermData>> CancelAsync(string subscriptionId, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateCancelRequest(subscriptionId, publisherId, offerId, planId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancel marketplace terms. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MarketplaceAgreementTermData> Cancel(string subscriptionId, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateCancelRequest(subscriptionId, publisherId, offerId, planId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAgreementRequest(string subscriptionId, string publisherId, string offerId, string planId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MarketplaceOrdering/agreements/", false);
            uri.AppendPath(publisherId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendPath("/plans/", false);
            uri.AppendPath(planId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get marketplace agreement. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MarketplaceAgreementTermData>> GetAgreementAsync(string subscriptionId, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateGetAgreementRequest(subscriptionId, publisherId, offerId, planId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MarketplaceAgreementTermData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get marketplace agreement. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MarketplaceAgreementTermData> GetAgreement(string subscriptionId, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publisherId, nameof(publisherId));
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNullOrEmpty(planId, nameof(planId));

            using var message = CreateGetAgreementRequest(subscriptionId, publisherId, offerId, planId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MarketplaceAgreementTermData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MarketplaceAgreementTermData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MarketplaceOrdering/agreements", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List marketplace agreements in the subscription. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<MarketplaceAgreementTermData>>> ListAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<MarketplaceAgreementTermData> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<MarketplaceAgreementTermData> array = new List<MarketplaceAgreementTermData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List marketplace agreements in the subscription. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<MarketplaceAgreementTermData>> List(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<MarketplaceAgreementTermData> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<MarketplaceAgreementTermData> array = new List<MarketplaceAgreementTermData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(MarketplaceAgreementTermData.DeserializeMarketplaceAgreementTermData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
