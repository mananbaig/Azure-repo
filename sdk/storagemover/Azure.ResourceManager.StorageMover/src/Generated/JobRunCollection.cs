// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A class representing a collection of <see cref="JobRunResource"/> and their operations.
    /// Each <see cref="JobRunResource"/> in the collection will belong to the same instance of <see cref="JobDefinitionResource"/>.
    /// To get a <see cref="JobRunCollection"/> instance call the GetJobRuns method from an instance of <see cref="JobDefinitionResource"/>.
    /// </summary>
    public partial class JobRunCollection : ArmCollection, IEnumerable<JobRunResource>, IAsyncEnumerable<JobRunResource>
    {
        private readonly ClientDiagnostics _jobRunClientDiagnostics;
        private readonly JobRunsRestOperations _jobRunRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobRunCollection"/> class for mocking. </summary>
        protected JobRunCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobRunCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JobRunCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobRunClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", JobRunResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(JobRunResource.ResourceType, out string jobRunApiVersion);
            _jobRunRestClient = new JobRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jobRunApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobDefinitionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobDefinitionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        public virtual async Task<Response<JobRunResource>> GetAsync(string jobRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobRunName, nameof(jobRunName));

            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobRunName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Job Run resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        public virtual Response<JobRunResource> Get(string jobRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobRunName, nameof(jobRunName));

            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunCollection.Get");
            scope.Start();
            try
            {
                var response = _jobRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobRunName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Job Runs in a Job Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobRunResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobRunResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jobRunRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _jobRunRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new JobRunResource(Client, JobRunData.DeserializeJobRunData(e)), _jobRunClientDiagnostics, Pipeline, "JobRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Job Runs in a Job Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobRunResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobRunResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jobRunRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _jobRunRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new JobRunResource(Client, JobRunData.DeserializeJobRunData(e)), _jobRunClientDiagnostics, Pipeline, "JobRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobRunName, nameof(jobRunName));

            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunCollection.Exists");
            scope.Start();
            try
            {
                var response = await _jobRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobRunName, nameof(jobRunName));

            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunCollection.Exists");
            scope.Start();
            try
            {
                var response = _jobRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobRunName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        public virtual async Task<NullableResponse<JobRunResource>> GetIfExistsAsync(string jobRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobRunName, nameof(jobRunName));

            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<JobRunResource>(response.GetRawResponse());
                return Response.FromValue(new JobRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/projects/{projectName}/jobDefinitions/{jobDefinitionName}/jobRuns/{jobRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobRunName"> The name of the Job Run resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobRunName"/> is null. </exception>
        public virtual NullableResponse<JobRunResource> GetIfExists(string jobRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobRunName, nameof(jobRunName));

            using var scope = _jobRunClientDiagnostics.CreateScope("JobRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobRunName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<JobRunResource>(response.GetRawResponse());
                return Response.FromValue(new JobRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JobRunResource> IEnumerable<JobRunResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobRunResource> IAsyncEnumerable<JobRunResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
