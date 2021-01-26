// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Quantum.Jobs.Models;
using Azure.Identity;

namespace Azure.Quantum.Jobs
{
    /// <summary>
    /// The sample jobs client.
    /// </summary>
    public class QuantumJobClient
    {
        private static Page<JobDetails> ToPage(Response<JobDetailsList> list) =>
    Page.FromValues(list.Value.Value, list.Value.NextLink, list.GetRawResponse());

        /// <summary> Return list of jobs. </summary>
        public virtual Pageable<JobDetails> GetJobs(CancellationToken cancellationToken = default)
        {
            return PageResponseEnumerator.CreateEnumerable(cont => ToPage(cont == null ? _jobs.List() : _jobs.ListNextPage(cont)));
        }

        /// <summary> Return list of jobs. </summary>
        public virtual AsyncPageable<JobDetails> GetJobsAsync(CancellationToken cancellationToken = default)
        {
            return PageResponseEnumerator.CreateAsyncEnumerable(async cont => ToPage(cont == null ? await _jobs.ListAsync().ConfigureAwait(false) : await _jobs.ListNextPageAsync(cont).ConfigureAwait(false)));
        }

        private JobsRestClient _jobs;

        /// <summary> Initializes a new instance of QuantumJobClient for mocking. </summary>
        protected QuantumJobClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantumJobClient"/> class.
        /// </summary>
        /// <param name="subscriptionId">The subscription identifier.</param>
        /// <param name="resourceGroupName">Name of the resource group.</param>
        /// <param name="workspaceName">Name of the workspace.</param>
        /// <param name="location">The location.</param>
        /// <param name="tokenCredential">The token credential.</param>
        /// <param name="options">The options.</param>
        public QuantumJobClient(
            string subscriptionId,
            string resourceGroupName,
            string workspaceName,
            string location,
            TokenCredential tokenCredential = default,
            QuantumJobClientOptions options = default)
        {
            if (options == null)
            {
                options = new QuantumJobClientOptions();
            }

            if (tokenCredential == null)
            {
                tokenCredential = new DefaultAzureCredential(new DefaultAzureCredentialOptions());
            }

            var authPolicy = new BearerTokenAuthenticationPolicy(tokenCredential, "https://quantum.microsoft.com");

            _jobs = new JobsRestClient(
                new ClientDiagnostics(options),
                HttpPipelineBuilder.Build(options, authPolicy),
                subscriptionId,
                resourceGroupName,
                workspaceName,
                new Uri($"https://{location}.quantum.azure.com"));
        }

        /// <summary> Create a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="job"> The complete metadata of the job to submit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="job"/> is null. </exception>
        public Response<JobDetails> Create(string jobId, JobDetails job, CancellationToken cancellationToken = default)
        {
            return _jobs.Create(jobId, job, cancellationToken);
        }

        /// <summary> Get job by id. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public Response<JobDetails> Get(string jobId, CancellationToken cancellationToken = default)
        {
            return _jobs.Get(jobId, cancellationToken);
        }

        /// <summary> Cancel a job. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public Response Cancel(string jobId, CancellationToken cancellationToken = default)
        {
            return _jobs.Cancel(jobId, cancellationToken);
        }
    }
}
