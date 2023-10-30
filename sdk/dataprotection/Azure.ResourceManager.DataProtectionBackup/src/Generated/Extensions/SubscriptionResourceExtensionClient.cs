// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataProtectionBackup.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dataProtectionBackupVaultBackupVaultsClientDiagnostics;
        private BackupVaultsRestOperations _dataProtectionBackupVaultBackupVaultsRestClient;
        private ClientDiagnostics _dataProtectionClientDiagnostics;
        private DataProtectionRestOperations _dataProtectionRestClient;
        private ClientDiagnostics _resourceGuardClientDiagnostics;
        private ResourceGuardsRestOperations _resourceGuardRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataProtectionBackupVaultBackupVaultsClientDiagnostics => _dataProtectionBackupVaultBackupVaultsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", DataProtectionBackupVaultResource.ResourceType.Namespace, Diagnostics);
        private BackupVaultsRestOperations DataProtectionBackupVaultBackupVaultsRestClient => _dataProtectionBackupVaultBackupVaultsRestClient ??= new BackupVaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataProtectionBackupVaultResource.ResourceType));
        private ClientDiagnostics DataProtectionClientDiagnostics => _dataProtectionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DataProtectionRestOperations DataProtectionRestClient => _dataProtectionRestClient ??= new DataProtectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ResourceGuardClientDiagnostics => _resourceGuardClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", ResourceGuardResource.ResourceType.Namespace, Diagnostics);
        private ResourceGuardsRestOperations ResourceGuardRestClient => _resourceGuardRestClient ??= new ResourceGuardsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ResourceGuardResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns resource collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProtectionBackupVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProtectionBackupVaultResource> GetDataProtectionBackupVaultsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataProtectionBackupVaultBackupVaultsRestClient.CreateGetInSubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataProtectionBackupVaultBackupVaultsRestClient.CreateGetInSubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupVaultResource(Client, DataProtectionBackupVaultData.DeserializeDataProtectionBackupVaultData(e)), DataProtectionBackupVaultBackupVaultsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDataProtectionBackupVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns resource collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProtectionBackupVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProtectionBackupVaultResource> GetDataProtectionBackupVaults(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataProtectionBackupVaultBackupVaultsRestClient.CreateGetInSubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataProtectionBackupVaultBackupVaultsRestClient.CreateGetInSubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupVaultResource(Client, DataProtectionBackupVaultData.DeserializeDataProtectionBackupVaultData(e)), DataProtectionBackupVaultBackupVaultsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDataProtectionBackupVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Validates if a feature is supported
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/locations/{location}/checkFeatureSupport</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProtection_CheckFeatureSupport</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The AzureLocation to use. </param>
        /// <param name="content"> Feature support request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BackupFeatureValidationResultBase>> CheckDataProtectionBackupFeatureSupportAsync(AzureLocation location, BackupFeatureValidationContentBase content, CancellationToken cancellationToken = default)
        {
            using var scope = DataProtectionClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDataProtectionBackupFeatureSupport");
            scope.Start();
            try
            {
                var response = await DataProtectionRestClient.CheckFeatureSupportAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates if a feature is supported
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/locations/{location}/checkFeatureSupport</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProtection_CheckFeatureSupport</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The AzureLocation to use. </param>
        /// <param name="content"> Feature support request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BackupFeatureValidationResultBase> CheckDataProtectionBackupFeatureSupport(AzureLocation location, BackupFeatureValidationContentBase content, CancellationToken cancellationToken = default)
        {
            using var scope = DataProtectionClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDataProtectionBackupFeatureSupport");
            scope.Start();
            try
            {
                var response = DataProtectionRestClient.CheckFeatureSupport(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns ResourceGuards collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/resourceGuards</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuards_GetResourcesInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGuardResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGuardResource> GetResourceGuardsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceGuardRestClient.CreateGetResourcesInSubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceGuardRestClient.CreateGetResourcesInSubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceGuardResource(Client, ResourceGuardData.DeserializeResourceGuardData(e)), ResourceGuardClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourceGuards", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns ResourceGuards collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/resourceGuards</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuards_GetResourcesInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGuardResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGuardResource> GetResourceGuards(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceGuardRestClient.CreateGetResourcesInSubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceGuardRestClient.CreateGetResourcesInSubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceGuardResource(Client, ResourceGuardData.DeserializeResourceGuardData(e)), ResourceGuardClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourceGuards", "value", "nextLink", cancellationToken);
        }
    }
}
