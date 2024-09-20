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
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    internal partial class ThreatIntelligenceIndicatorRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ThreatIntelligenceIndicatorRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ThreatIntelligenceIndicatorRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-01-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateQueryIndicatorsRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/threatIntelligence/main/queryIndicators", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateQueryIndicatorsRequest(string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria)
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
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/threatIntelligence/main/queryIndicators", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(threatIntelligenceFilteringCriteria, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Query threat intelligence indicators as per filtering criteria. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="threatIntelligenceFilteringCriteria"> Filtering criteria for querying threat intelligence indicators. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="threatIntelligenceFilteringCriteria"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ThreatIntelligenceInformationList>> QueryIndicatorsAsync(string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(threatIntelligenceFilteringCriteria, nameof(threatIntelligenceFilteringCriteria));

            using var message = CreateQueryIndicatorsRequest(subscriptionId, resourceGroupName, workspaceName, threatIntelligenceFilteringCriteria);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ThreatIntelligenceInformationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ThreatIntelligenceInformationList.DeserializeThreatIntelligenceInformationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Query threat intelligence indicators as per filtering criteria. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="threatIntelligenceFilteringCriteria"> Filtering criteria for querying threat intelligence indicators. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="threatIntelligenceFilteringCriteria"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ThreatIntelligenceInformationList> QueryIndicators(string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(threatIntelligenceFilteringCriteria, nameof(threatIntelligenceFilteringCriteria));

            using var message = CreateQueryIndicatorsRequest(subscriptionId, resourceGroupName, workspaceName, threatIntelligenceFilteringCriteria);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ThreatIntelligenceInformationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ThreatIntelligenceInformationList.DeserializeThreatIntelligenceInformationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateQueryIndicatorsNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateQueryIndicatorsNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria)
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

        /// <summary> Query threat intelligence indicators as per filtering criteria. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="threatIntelligenceFilteringCriteria"> Filtering criteria for querying threat intelligence indicators. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="threatIntelligenceFilteringCriteria"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ThreatIntelligenceInformationList>> QueryIndicatorsNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(threatIntelligenceFilteringCriteria, nameof(threatIntelligenceFilteringCriteria));

            using var message = CreateQueryIndicatorsNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, threatIntelligenceFilteringCriteria);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ThreatIntelligenceInformationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ThreatIntelligenceInformationList.DeserializeThreatIntelligenceInformationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Query threat intelligence indicators as per filtering criteria. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="threatIntelligenceFilteringCriteria"> Filtering criteria for querying threat intelligence indicators. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="threatIntelligenceFilteringCriteria"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ThreatIntelligenceInformationList> QueryIndicatorsNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, ThreatIntelligenceFilteringCriteria threatIntelligenceFilteringCriteria, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(threatIntelligenceFilteringCriteria, nameof(threatIntelligenceFilteringCriteria));

            using var message = CreateQueryIndicatorsNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, threatIntelligenceFilteringCriteria);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ThreatIntelligenceInformationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ThreatIntelligenceInformationList.DeserializeThreatIntelligenceInformationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
