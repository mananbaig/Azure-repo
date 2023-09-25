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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    internal partial class SourceControlRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of SourceControlRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> is null. </exception>
        public SourceControlRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, AutomationSourceControlCreateOrUpdateContent content)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls/", false);
            uri.AppendPath(sourceControlName, true);
            uri.AppendQuery("api-version", "2020-01-13-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a source control. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="content"> The parameters supplied to the create or update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationSourceControlData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, AutomationSourceControlCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AutomationSourceControlData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationSourceControlData.DeserializeAutomationSourceControlData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a source control. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="content"> The parameters supplied to the create or update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationSourceControlData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, AutomationSourceControlCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AutomationSourceControlData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationSourceControlData.DeserializeAutomationSourceControlData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, AutomationSourceControlPatch patch)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls/", false);
            uri.AppendPath(sourceControlName, true);
            uri.AppendQuery("api-version", "2020-01-13-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update a source control. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="patch"> The parameters supplied to the update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationSourceControlData>> UpdateAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, AutomationSourceControlPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationSourceControlData.DeserializeAutomationSourceControlData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update a source control. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="patch"> The parameters supplied to the update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationSourceControlData> Update(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, AutomationSourceControlPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationSourceControlData.DeserializeAutomationSourceControlData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls/", false);
            uri.AppendPath(sourceControlName, true);
            uri.AppendQuery("api-version", "2020-01-13-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete the source control. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete the source control. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls/", false);
            uri.AppendPath(sourceControlName, true);
            uri.AppendQuery("api-version", "2020-01-13-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve the source control identified by source control name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationSourceControlData>> GetAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationSourceControlData.DeserializeAutomationSourceControlData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AutomationSourceControlData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve the source control identified by source control name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationSourceControlData> Get(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationSourceControlData.DeserializeAutomationSourceControlData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AutomationSourceControlData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByAutomationAccountRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string filter)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", "2020-01-13-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of source controls. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationSourceControlListResult>> ListByAutomationAccountAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));

            using var message = CreateListByAutomationAccountRequest(subscriptionId, resourceGroupName, automationAccountName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationSourceControlListResult.DeserializeAutomationSourceControlListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of source controls. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationSourceControlListResult> ListByAutomationAccount(string subscriptionId, string resourceGroupName, string automationAccountName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));

            using var message = CreateListByAutomationAccountRequest(subscriptionId, resourceGroupName, automationAccountName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationSourceControlListResult.DeserializeAutomationSourceControlListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByAutomationAccountNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string filter)
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

        /// <summary> Retrieve a list of source controls. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationSourceControlListResult>> ListByAutomationAccountNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));

            using var message = CreateListByAutomationAccountNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationSourceControlListResult.DeserializeAutomationSourceControlListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of source controls. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationSourceControlListResult> ListByAutomationAccountNextPage(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));

            using var message = CreateListByAutomationAccountNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationSourceControlListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationSourceControlListResult.DeserializeAutomationSourceControlListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
