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
using Azure.Core.Serialization;
using Azure.Quantum.Jobs.Models;

namespace Azure.Quantum.Jobs
{
    internal partial class JobsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly string _resourceGroupName;
        private readonly string _workspaceName;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of JobsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of an Azure resource group. </param>
        /// <param name="workspaceName"> Name of the workspace. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public JobsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string resourceGroupName, string workspaceName, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            _resourceGroupName = resourceGroupName ?? throw new ArgumentNullException(nameof(resourceGroupName));
            _workspaceName = workspaceName ?? throw new ArgumentNullException(nameof(workspaceName));
            _endpoint = endpoint ?? new Uri("https://quantum.azure.com");
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/subscriptions/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(_resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Quantum/workspaces/", false);
            uri.AppendPath(_workspaceName, true);
            uri.AppendPath("/jobs", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List jobs. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<JobDetailsList>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetailsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobDetailsList.DeserializeJobDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List jobs. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<JobDetailsList> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetailsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobDetailsList.DeserializeJobDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string jobId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/subscriptions/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(_resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Quantum/workspaces/", false);
            uri.AppendPath(_workspaceName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get job by id. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public async Task<Response<JobDetails>> GetAsync(string jobId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateGetRequest(jobId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetails value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobDetails.DeserializeJobDetails(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get job by id. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public Response<JobDetails> Get(string jobId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateGetRequest(jobId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetails value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobDetails.DeserializeJobDetails(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string jobId, JobDetails job)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/subscriptions/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(_resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Quantum/workspaces/", false);
            uri.AppendPath(_workspaceName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = job;
            return message;
        }

        /// <summary> Create a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="job"> The complete metadata of the job to submit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="job"/> is null. </exception>
        public async Task<Response<JobDetails>> CreateAsync(string jobId, JobDetails job, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (job == null)
            {
                throw new ArgumentNullException(nameof(job));
            }

            using var message = CreateCreateRequest(jobId, job);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        JobDetails value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobDetails.DeserializeJobDetails(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="job"> The complete metadata of the job to submit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="job"/> is null. </exception>
        public Response<JobDetails> Create(string jobId, JobDetails job, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (job == null)
            {
                throw new ArgumentNullException(nameof(job));
            }

            using var message = CreateCreateRequest(jobId, job);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        JobDetails value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobDetails.DeserializeJobDetails(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string jobId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/subscriptions/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(_resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Quantum/workspaces/", false);
            uri.AppendPath(_workspaceName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancel a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public async Task<Response> CancelAsync(string jobId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateCancelRequest(jobId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancel a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public Response Cancel(string jobId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateCancelRequest(jobId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePatchRequest(string jobId, IEnumerable<Models.JsonPatchDocument> patchJob)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/subscriptions/", false);
            uri.AppendPath(_subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(_resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Quantum/workspaces/", false);
            uri.AppendPath(_workspaceName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartArray();
            foreach (var item in patchJob)
            {
                if (item is null)
                {
                    content.JsonWriter.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<Models.JsonPatchDocument>)item).Serialize(content.JsonWriter, ModelSerializerOptions.DefaultWireOptions);
                }
            }
            content.JsonWriter.WriteEndArray();
            request.Content = content;
            return message;
        }

        /// <summary> Patch a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="patchJob"> The json patch document containing the patch operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="patchJob"/> is null. </exception>
        public async Task<Response<JobDetails>> PatchAsync(string jobId, IEnumerable<Models.JsonPatchDocument> patchJob, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (patchJob == null)
            {
                throw new ArgumentNullException(nameof(patchJob));
            }

            using var message = CreatePatchRequest(jobId, patchJob);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetails value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobDetails.DeserializeJobDetails(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((JobDetails)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Patch a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="patchJob"> The json patch document containing the patch operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="patchJob"/> is null. </exception>
        public Response<JobDetails> Patch(string jobId, IEnumerable<Models.JsonPatchDocument> patchJob, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (patchJob == null)
            {
                throw new ArgumentNullException(nameof(patchJob));
            }

            using var message = CreatePatchRequest(jobId, patchJob);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetails value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobDetails.DeserializeJobDetails(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((JobDetails)null, message.Response);
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
            return message;
        }

        /// <summary> List jobs. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<JobDetailsList>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetailsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobDetailsList.DeserializeJobDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List jobs. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<JobDetailsList> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobDetailsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobDetailsList.DeserializeJobDetailsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
