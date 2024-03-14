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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class AssessmentsMetadataRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AssessmentsMetadataRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AssessmentsMetadataRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Security/assessmentMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get metadata information on all assessment types. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SecurityAssessmentMetadataResponseList>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get metadata information on all assessment types. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SecurityAssessmentMetadataResponseList> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string assessmentMetadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Security/assessmentMetadata/", false);
            uri.AppendPath(assessmentMetadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get metadata information on an assessment type. </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentMetadataData>> GetAsync(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var message = CreateGetRequest(assessmentMetadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAssessmentMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get metadata information on an assessment type. </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentMetadataData> Get(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var message = CreateGetRequest(assessmentMetadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAssessmentMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/assessmentMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get metadata information on all assessment types in a specific subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentMetadataResponseList>> ListBySubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get metadata information on all assessment types in a specific subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentMetadataResponseList> ListBySubscription(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetInSubscriptionRequest(string subscriptionId, string assessmentMetadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/assessmentMetadata/", false);
            uri.AppendPath(assessmentMetadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get metadata information on an assessment type in a specific subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentMetadataData>> GetInSubscriptionAsync(string subscriptionId, string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var message = CreateGetInSubscriptionRequest(subscriptionId, assessmentMetadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAssessmentMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get metadata information on an assessment type in a specific subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentMetadataData> GetInSubscription(string subscriptionId, string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var message = CreateGetInSubscriptionRequest(subscriptionId, assessmentMetadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAssessmentMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateInSubscriptionRequest(string subscriptionId, string assessmentMetadataName, SecurityAssessmentMetadataData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/assessmentMetadata/", false);
            uri.AppendPath(assessmentMetadataName, true);
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

        /// <summary> Create metadata information on an assessment type in a specific subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="data"> AssessmentMetadata object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="assessmentMetadataName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentMetadataData>> CreateInSubscriptionAsync(string subscriptionId, string assessmentMetadataName, SecurityAssessmentMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateInSubscriptionRequest(subscriptionId, assessmentMetadataName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create metadata information on an assessment type in a specific subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="data"> AssessmentMetadata object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="assessmentMetadataName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentMetadataData> CreateInSubscription(string subscriptionId, string assessmentMetadataName, SecurityAssessmentMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateInSubscriptionRequest(subscriptionId, assessmentMetadataName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteInSubscriptionRequest(string subscriptionId, string assessmentMetadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/assessmentMetadata/", false);
            uri.AppendPath(assessmentMetadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete metadata information on an assessment type in a specific subscription, will cause the deletion of all the assessments of that type in that subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteInSubscriptionAsync(string subscriptionId, string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var message = CreateDeleteInSubscriptionRequest(subscriptionId, assessmentMetadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete metadata information on an assessment type in a specific subscription, will cause the deletion of all the assessments of that type in that subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response DeleteInSubscription(string subscriptionId, string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var message = CreateDeleteInSubscriptionRequest(subscriptionId, assessmentMetadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
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

        /// <summary> Get metadata information on all assessment types. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<SecurityAssessmentMetadataResponseList>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get metadata information on all assessment types. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<SecurityAssessmentMetadataResponseList> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionNextPageRequest(string nextLink, string subscriptionId)
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

        /// <summary> Get metadata information on all assessment types in a specific subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAssessmentMetadataResponseList>> ListBySubscriptionNextPageAsync(string nextLink, string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionNextPageRequest(nextLink, subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get metadata information on all assessment types in a specific subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAssessmentMetadataResponseList> ListBySubscriptionNextPage(string nextLink, string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionNextPageRequest(nextLink, subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAssessmentMetadataResponseList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAssessmentMetadataResponseList.DeserializeSecurityAssessmentMetadataResponseList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
