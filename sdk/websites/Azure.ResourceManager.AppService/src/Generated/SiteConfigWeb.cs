// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteConfigWeb along with the instance operations that can be performed on it. </summary>
    public partial class SiteConfigWeb : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteConfigWeb"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteConfigWebWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigWebWebAppsRestClient;
        private readonly ClientDiagnostics _siteConfigSnapshotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigSnapshotWebAppsRestClient;
        private readonly SiteConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigWeb"/> class for mocking. </summary>
        protected SiteConfigWeb()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteConfigWeb"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteConfigWeb(ArmClient armClient, SiteConfigData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigWeb"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigWeb(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _siteConfigWebWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string siteConfigWebWebAppsApiVersion);
            _siteConfigWebWebAppsRestClient = new WebAppsRestOperations(_siteConfigWebWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteConfigWebWebAppsApiVersion);
            _siteConfigSnapshotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteConfigSnapshot.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(SiteConfigSnapshot.ResourceType, out string siteConfigSnapshotWebAppsApiVersion);
            _siteConfigSnapshotWebAppsRestClient = new WebAppsRestOperations(_siteConfigSnapshotWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteConfigSnapshotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_GetConfiguration
        /// <summary> Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteConfigWeb>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.Get");
            scope.Start();
            try
            {
                var response = await _siteConfigWebWebAppsRestClient.GetConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteConfigWebWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigWeb(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_GetConfiguration
        /// <summary> Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteConfigWeb> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.Get");
            scope.Start();
            try
            {
                var response = _siteConfigWebWebAppsRestClient.GetConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteConfigWebWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigWeb(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_CreateOrUpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public async virtual Task<SiteConfigWebCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, SiteConfigData siteConfig, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteConfigWebWebAppsRestClient.CreateOrUpdateConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken).ConfigureAwait(false);
                var operation = new SiteConfigWebCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_CreateOrUpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public virtual SiteConfigWebCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, SiteConfigData siteConfig, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteConfigWebWebAppsRestClient.CreateOrUpdateConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken);
                var operation = new SiteConfigWebCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_UpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public async virtual Task<Response<SiteConfigWeb>> UpdateAsync(SiteConfigData siteConfig, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.Update");
            scope.Start();
            try
            {
                var response = await _siteConfigWebWebAppsRestClient.UpdateConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigWeb(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_UpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public virtual Response<SiteConfigWeb> Update(SiteConfigData siteConfig, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _siteConfigWebWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.Update");
            scope.Start();
            try
            {
                var response = _siteConfigWebWebAppsRestClient.UpdateConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken);
                return Response.FromValue(new SiteConfigWeb(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_ListConfigurationSnapshotInfo
        /// <summary> Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigurationSnapshotInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteConfigurationSnapshotInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = await _siteConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteConfigurationSnapshotInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = await _siteConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_ListConfigurationSnapshotInfo
        /// <summary> Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigurationSnapshotInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfo(CancellationToken cancellationToken = default)
        {
            Page<SiteConfigurationSnapshotInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = _siteConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteConfigurationSnapshotInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = _siteConfigSnapshotWebAppsRestClient.ListConfigurationSnapshotInfoNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        #region SiteConfigSnapshot

        /// <summary> Gets a collection of SiteConfigSnapshots in the SiteConfigWeb. </summary>
        /// <returns> An object representing collection of SiteConfigSnapshots and their operations over a SiteConfigWeb. </returns>
        public virtual SiteConfigSnapshotCollection GetSiteConfigSnapshots()
        {
            return new SiteConfigSnapshotCollection(this);
        }
        #endregion
    }
}
