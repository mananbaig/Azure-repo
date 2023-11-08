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

namespace Azure.ResourceManager.RecoveryServices
{
    /// <summary>
    /// A class representing a collection of <see cref="RecoveryServicesVaultResource" /> and their operations.
    /// Each <see cref="RecoveryServicesVaultResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RecoveryServicesVaultCollection" /> instance call the GetRecoveryServicesVaults method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RecoveryServicesVaultCollection : ArmCollection, IEnumerable<RecoveryServicesVaultResource>, IAsyncEnumerable<RecoveryServicesVaultResource>
    {
        private readonly ClientDiagnostics _recoveryServicesVaultVaultsClientDiagnostics;
        private readonly VaultsRestOperations _recoveryServicesVaultVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecoveryServicesVaultCollection"/> class for mocking. </summary>
        protected RecoveryServicesVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoveryServicesVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RecoveryServicesVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recoveryServicesVaultVaultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServices", RecoveryServicesVaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RecoveryServicesVaultResource.ResourceType, out string recoveryServicesVaultVaultsApiVersion);
            _recoveryServicesVaultVaultsRestClient = new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoveryServicesVaultVaultsApiVersion);
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
        /// Creates or updates a Recovery Services vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="data"> Recovery Services Vault to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RecoveryServicesVaultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, RecoveryServicesVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _recoveryServicesVaultVaultsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesArmOperation<RecoveryServicesVaultResource>(new RecoveryServicesVaultOperationSource(Client), _recoveryServicesVaultVaultsClientDiagnostics, Pipeline, _recoveryServicesVaultVaultsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a Recovery Services vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="data"> Recovery Services Vault to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RecoveryServicesVaultResource> CreateOrUpdate(WaitUntil waitUntil, string vaultName, RecoveryServicesVaultData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _recoveryServicesVaultVaultsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken);
                var operation = new RecoveryServicesArmOperation<RecoveryServicesVaultResource>(new RecoveryServicesVaultOperationSource(Client), _recoveryServicesVaultVaultsClientDiagnostics, Pipeline, _recoveryServicesVaultVaultsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the Vault details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<RecoveryServicesVaultResource>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _recoveryServicesVaultVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoveryServicesVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Vault details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<RecoveryServicesVaultResource> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _recoveryServicesVaultVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoveryServicesVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of Vaults.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoveryServicesVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoveryServicesVaultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoveryServicesVaultVaultsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoveryServicesVaultVaultsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RecoveryServicesVaultResource(Client, RecoveryServicesVaultData.DeserializeRecoveryServicesVaultData(e)), _recoveryServicesVaultVaultsClientDiagnostics, Pipeline, "RecoveryServicesVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of Vaults.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoveryServicesVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoveryServicesVaultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoveryServicesVaultVaultsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoveryServicesVaultVaultsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RecoveryServicesVaultResource(Client, RecoveryServicesVaultData.DeserializeRecoveryServicesVaultData(e)), _recoveryServicesVaultVaultsClientDiagnostics, Pipeline, "RecoveryServicesVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _recoveryServicesVaultVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = _recoveryServicesVaultVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<NullableResponse<RecoveryServicesVaultResource>> GetIfExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _recoveryServicesVaultVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RecoveryServicesVaultResource>(response.GetRawResponse());
                return Response.FromValue(new RecoveryServicesVaultResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual NullableResponse<RecoveryServicesVaultResource> GetIfExists(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _recoveryServicesVaultVaultsClientDiagnostics.CreateScope("RecoveryServicesVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recoveryServicesVaultVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RecoveryServicesVaultResource>(response.GetRawResponse());
                return Response.FromValue(new RecoveryServicesVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecoveryServicesVaultResource> IEnumerable<RecoveryServicesVaultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoveryServicesVaultResource> IAsyncEnumerable<RecoveryServicesVaultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
