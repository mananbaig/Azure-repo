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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="DataProtectionBackupJobResource" /> and their operations.
    /// Each <see cref="DataProtectionBackupJobResource" /> in the collection will belong to the same instance of <see cref="DataProtectionBackupVaultResource" />.
    /// To get a <see cref="DataProtectionBackupJobCollection" /> instance call the GetDataProtectionBackupJobs method from an instance of <see cref="DataProtectionBackupVaultResource" />.
    /// </summary>
    public partial class DataProtectionBackupJobCollection : ArmCollection, IEnumerable<DataProtectionBackupJobResource>, IAsyncEnumerable<DataProtectionBackupJobResource>
    {
        private readonly ClientDiagnostics _dataProtectionBackupJobJobsClientDiagnostics;
        private readonly JobsRestOperations _dataProtectionBackupJobJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupJobCollection"/> class for mocking. </summary>
        protected DataProtectionBackupJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataProtectionBackupJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataProtectionBackupJobJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", DataProtectionBackupJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataProtectionBackupJobResource.ResourceType, out string dataProtectionBackupJobJobsApiVersion);
            _dataProtectionBackupJobJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataProtectionBackupJobJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataProtectionBackupVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataProtectionBackupVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a job with id in a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupJobs/{jobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual async Task<Response<DataProtectionBackupJobResource>> GetAsync(string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = _dataProtectionBackupJobJobsClientDiagnostics.CreateScope("DataProtectionBackupJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job with id in a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupJobs/{jobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual Response<DataProtectionBackupJobResource> Get(string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = _dataProtectionBackupJobJobsClientDiagnostics.CreateScope("DataProtectionBackupJobCollection.Get");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of jobs belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProtectionBackupJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProtectionBackupJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupJobJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupJobJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupJobResource(Client, DataProtectionBackupJobData.DeserializeDataProtectionBackupJobData(e)), _dataProtectionBackupJobJobsClientDiagnostics, Pipeline, "DataProtectionBackupJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of jobs belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProtectionBackupJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProtectionBackupJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupJobJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupJobJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupJobResource(Client, DataProtectionBackupJobData.DeserializeDataProtectionBackupJobData(e)), _dataProtectionBackupJobJobsClientDiagnostics, Pipeline, "DataProtectionBackupJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupJobs/{jobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = _dataProtectionBackupJobJobsClientDiagnostics.CreateScope("DataProtectionBackupJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupJobs/{jobId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual Response<bool> Exists(string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = _dataProtectionBackupJobJobsClientDiagnostics.CreateScope("DataProtectionBackupJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataProtectionBackupJobResource> IEnumerable<DataProtectionBackupJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataProtectionBackupJobResource> IAsyncEnumerable<DataProtectionBackupJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
