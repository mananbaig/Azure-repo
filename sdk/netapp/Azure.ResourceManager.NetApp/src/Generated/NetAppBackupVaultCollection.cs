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

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="NetAppBackupVaultResource"/> and their operations.
    /// Each <see cref="NetAppBackupVaultResource"/> in the collection will belong to the same instance of <see cref="NetAppAccountResource"/>.
    /// To get a <see cref="NetAppBackupVaultCollection"/> instance call the GetNetAppBackupVaults method from an instance of <see cref="NetAppAccountResource"/>.
    /// </summary>
    public partial class NetAppBackupVaultCollection : ArmCollection, IEnumerable<NetAppBackupVaultResource>, IAsyncEnumerable<NetAppBackupVaultResource>
    {
        private readonly ClientDiagnostics _netAppBackupVaultBackupVaultsClientDiagnostics;
        private readonly BackupVaultsRestOperations _netAppBackupVaultBackupVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppBackupVaultCollection"/> class for mocking. </summary>
        protected NetAppBackupVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppBackupVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppBackupVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppBackupVaultBackupVaultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppBackupVaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppBackupVaultResource.ResourceType, out string netAppBackupVaultBackupVaultsApiVersion);
            _netAppBackupVaultBackupVaultsRestClient = new BackupVaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppBackupVaultBackupVaultsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the specified Backup Vault in the NetApp account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="data"> BackupVault object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppBackupVaultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backupVaultName, NetAppBackupVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppBackupVaultBackupVaultsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppBackupVaultResource>(new NetAppBackupVaultOperationSource(Client), _netAppBackupVaultBackupVaultsClientDiagnostics, Pipeline, _netAppBackupVaultBackupVaultsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update the specified Backup Vault in the NetApp account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="data"> BackupVault object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppBackupVaultResource> CreateOrUpdate(WaitUntil waitUntil, string backupVaultName, NetAppBackupVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppBackupVaultBackupVaultsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppBackupVaultResource>(new NetAppBackupVaultOperationSource(Client), _netAppBackupVaultBackupVaultsClientDiagnostics, Pipeline, _netAppBackupVaultBackupVaultsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the Backup Vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> is null. </exception>
        public virtual async Task<Response<NetAppBackupVaultResource>> GetAsync(string backupVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppBackupVaultBackupVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Backup Vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> is null. </exception>
        public virtual Response<NetAppBackupVaultResource> Get(string backupVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppBackupVaultBackupVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List and describe all Backup Vaults in the NetApp account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_ListByNetAppAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppBackupVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppBackupVaultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppBackupVaultBackupVaultsRestClient.CreateListByNetAppAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _netAppBackupVaultBackupVaultsRestClient.CreateListByNetAppAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetAppBackupVaultResource(Client, NetAppBackupVaultData.DeserializeNetAppBackupVaultData(e)), _netAppBackupVaultBackupVaultsClientDiagnostics, Pipeline, "NetAppBackupVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List and describe all Backup Vaults in the NetApp account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_ListByNetAppAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppBackupVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppBackupVaultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppBackupVaultBackupVaultsRestClient.CreateListByNetAppAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _netAppBackupVaultBackupVaultsRestClient.CreateListByNetAppAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetAppBackupVaultResource(Client, NetAppBackupVaultData.DeserializeNetAppBackupVaultData(e)), _netAppBackupVaultBackupVaultsClientDiagnostics, Pipeline, "NetAppBackupVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppBackupVaultBackupVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppBackupVaultBackupVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetAppBackupVaultResource>> GetIfExistsAsync(string backupVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _netAppBackupVaultBackupVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetAppBackupVaultResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupVaultResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupVaults/{backupVaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupVaultName"> The name of the Backup Vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupVaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupVaultName"/> is null. </exception>
        public virtual NullableResponse<NetAppBackupVaultResource> GetIfExists(string backupVaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupVaultName, nameof(backupVaultName));

            using var scope = _netAppBackupVaultBackupVaultsClientDiagnostics.CreateScope("NetAppBackupVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _netAppBackupVaultBackupVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupVaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetAppBackupVaultResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppBackupVaultResource> IEnumerable<NetAppBackupVaultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppBackupVaultResource> IAsyncEnumerable<NetAppBackupVaultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
