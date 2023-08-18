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
    /// A class representing a collection of <see cref="DataProtectionBackupPolicyResource" /> and their operations.
    /// Each <see cref="DataProtectionBackupPolicyResource" /> in the collection will belong to the same instance of <see cref="DataProtectionBackupVaultResource" />.
    /// To get a <see cref="DataProtectionBackupPolicyCollection" /> instance call the GetDataProtectionBackupPolicies method from an instance of <see cref="DataProtectionBackupVaultResource" />.
    /// </summary>
    public partial class DataProtectionBackupPolicyCollection : ArmCollection, IEnumerable<DataProtectionBackupPolicyResource>, IAsyncEnumerable<DataProtectionBackupPolicyResource>
    {
        private readonly ClientDiagnostics _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics;
        private readonly BackupPoliciesRestOperations _dataProtectionBackupPolicyBackupPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupPolicyCollection"/> class for mocking. </summary>
        protected DataProtectionBackupPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataProtectionBackupPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", DataProtectionBackupPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataProtectionBackupPolicyResource.ResourceType, out string dataProtectionBackupPolicyBackupPoliciesApiVersion);
            _dataProtectionBackupPolicyBackupPoliciesRestClient = new BackupPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataProtectionBackupPolicyBackupPoliciesApiVersion);
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
        /// Creates or Updates a backup policy belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupPolicyName"> Name of the policy. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataProtectionBackupPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backupPolicyName, DataProtectionBackupPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("DataProtectionBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupPolicyBackupPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataProtectionBackupArmOperation<DataProtectionBackupPolicyResource>(Response.FromValue(new DataProtectionBackupPolicyResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or Updates a backup policy belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupPolicyName"> Name of the policy. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataProtectionBackupPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string backupPolicyName, DataProtectionBackupPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("DataProtectionBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupPolicyBackupPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, data, cancellationToken);
                var operation = new DataProtectionBackupArmOperation<DataProtectionBackupPolicyResource>(Response.FromValue(new DataProtectionBackupPolicyResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a backup policy belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual async Task<Response<DataProtectionBackupPolicyResource>> GetAsync(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("DataProtectionBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupPolicyBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a backup policy belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual Response<DataProtectionBackupPolicyResource> Get(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("DataProtectionBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupPolicyBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of backup policies belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProtectionBackupPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProtectionBackupPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupPolicyBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupPolicyBackupPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupPolicyResource(Client, DataProtectionBackupPolicyData.DeserializeDataProtectionBackupPolicyData(e)), _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics, Pipeline, "DataProtectionBackupPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of backup policies belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProtectionBackupPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProtectionBackupPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupPolicyBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupPolicyBackupPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupPolicyResource(Client, DataProtectionBackupPolicyData.DeserializeDataProtectionBackupPolicyData(e)), _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics, Pipeline, "DataProtectionBackupPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("DataProtectionBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupPolicyBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _dataProtectionBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("DataProtectionBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupPolicyBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataProtectionBackupPolicyResource> IEnumerable<DataProtectionBackupPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataProtectionBackupPolicyResource> IAsyncEnumerable<DataProtectionBackupPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
