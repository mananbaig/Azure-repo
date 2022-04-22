// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of PremierAddOn and their operations over its parent. </summary>
    public partial class SitePremierAddonCollection : ArmCollection
    {
        private readonly ClientDiagnostics _sitePremierAddonWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _sitePremierAddonWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SitePremierAddonCollection"/> class for mocking. </summary>
        protected SitePremierAddonCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SitePremierAddonCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SitePremierAddonCollection(ArmResource parent) : base(parent)
        {
            _sitePremierAddonWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SitePremierAddon.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(SitePremierAddon.ResourceType, out string sitePremierAddonWebAppsApiVersion);
            _sitePremierAddonWebAppsRestClient = new WebAppsRestOperations(_sitePremierAddonWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sitePremierAddonWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_AddPremierAddOn
        /// <summary> Description for Updates a named add-on of an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="premierAddOn"/> is null. </exception>
        public virtual SitePremierAddonCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string premierAddOnName, PremierAddOnData premierAddOn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));
            if (premierAddOn == null)
            {
                throw new ArgumentNullException(nameof(premierAddOn));
            }

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sitePremierAddonWebAppsRestClient.AddPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, premierAddOn, cancellationToken);
                var operation = new SitePremierAddonCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_AddPremierAddOn
        /// <summary> Description for Updates a named add-on of an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="premierAddOn"/> is null. </exception>
        public async virtual Task<SitePremierAddonCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string premierAddOnName, PremierAddOnData premierAddOn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));
            if (premierAddOn == null)
            {
                throw new ArgumentNullException(nameof(premierAddOn));
            }

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sitePremierAddonWebAppsRestClient.AddPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, premierAddOn, cancellationToken).ConfigureAwait(false);
                var operation = new SitePremierAddonCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPremierAddOn
        /// <summary> Description for Gets a named add-on of an app. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<SitePremierAddon> Get(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.Get");
            scope.Start();
            try
            {
                var response = _sitePremierAddonWebAppsRestClient.GetPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken);
                if (response.Value == null)
                    throw _sitePremierAddonWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePremierAddon(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPremierAddOn
        /// <summary> Description for Gets a named add-on of an app. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public async virtual Task<Response<SitePremierAddon>> GetAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.Get");
            scope.Start();
            try
            {
                var response = await _sitePremierAddonWebAppsRestClient.GetPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sitePremierAddonWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SitePremierAddon(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<SitePremierAddon> GetIfExists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sitePremierAddonWebAppsRestClient.GetPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SitePremierAddon>(null, response.GetRawResponse());
                return Response.FromValue(new SitePremierAddon(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public async virtual Task<Response<SitePremierAddon>> GetIfExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sitePremierAddonWebAppsRestClient.GetPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SitePremierAddon>(null, response.GetRawResponse());
                return Response.FromValue(new SitePremierAddon(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<bool> Exists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(premierAddOnName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _sitePremierAddonWebAppsClientDiagnostics.CreateScope("SitePremierAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
