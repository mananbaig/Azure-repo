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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupJobResource" /> and their operations.
    /// Each <see cref="BackupJobResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="BackupJobCollection" /> instance call the GetBackupJobs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class BackupJobCollection : ArmCollection, IEnumerable<BackupJobResource>, IAsyncEnumerable<BackupJobResource>
    {
        private readonly ClientDiagnostics _backupJobJobDetailsClientDiagnostics;
        private readonly JobDetailsRestOperations _backupJobJobDetailsRestClient;
        private readonly ClientDiagnostics _backupJobClientDiagnostics;
        private readonly BackupJobsRestOperations _backupJobRestClient;
        private readonly string _vaultName;

        /// <summary> Initializes a new instance of the <see cref="BackupJobCollection"/> class for mocking. </summary>
        protected BackupJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        internal BackupJobCollection(ArmClient client, ResourceIdentifier id, string vaultName) : base(client, id)
        {
            _vaultName = vaultName;
            _backupJobJobDetailsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupJobResource.ResourceType, out string backupJobJobDetailsApiVersion);
            _backupJobJobDetailsRestClient = new JobDetailsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupJobJobDetailsApiVersion);
            _backupJobClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupJobResource.ResourceType, out string backupJobApiVersion);
            _backupJobRestClient = new BackupJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupJobApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets extended information associated with the job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the job whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<BackupJobResource>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupJobJobDetailsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets extended information associated with the job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the job whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<BackupJobResource> Get(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobCollection.Get");
            scope.Start();
            try
            {
                var response = _backupJobJobDetailsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, jobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides a pageable list of jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupJobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackupJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackupJobResource> GetAllAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupJobRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupJobRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new BackupJobResource(Client, BackupJobData.DeserializeBackupJobData(e)), _backupJobClientDiagnostics, Pipeline, "BackupJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Provides a pageable list of jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupJobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackupJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackupJobResource> GetAll(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupJobRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupJobRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new BackupJobResource(Client, BackupJobData.DeserializeBackupJobData(e)), _backupJobClientDiagnostics, Pipeline, "BackupJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the job whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupJobJobDetailsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the job whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupJobJobDetailsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, jobName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the job whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupJobResource>> GetIfExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupJobJobDetailsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupJobResource>(response.GetRawResponse());
                return Response.FromValue(new BackupJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the job whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual NullableResponse<BackupJobResource> GetIfExists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupJobJobDetailsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, jobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupJobResource>(response.GetRawResponse());
                return Response.FromValue(new BackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BackupJobResource> IEnumerable<BackupJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackupJobResource> IAsyncEnumerable<BackupJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
