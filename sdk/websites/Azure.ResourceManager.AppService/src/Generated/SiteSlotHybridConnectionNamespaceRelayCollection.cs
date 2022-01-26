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
    /// <summary> A class representing collection of HybridConnection and their operations over its parent. </summary>
    public partial class SiteSlotHybridConnectionNamespaceRelayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelayCollection"/> class for mocking. </summary>
        protected SiteSlotHybridConnectionNamespaceRelayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelayCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotHybridConnectionNamespaceRelayCollection(ArmResource parent) : base(parent)
        {
            _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotHybridConnectionNamespaceRelay.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(SiteSlotHybridConnectionNamespaceRelay.ResourceType, out string siteSlotHybridConnectionNamespaceRelayWebAppsApiVersion);
            _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient = new WebAppsRestOperations(_siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotHybridConnectionNamespaceRelayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateHybridConnectionSlot
        /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/>, <paramref name="relayName"/>, or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string namespaceName, string relayName, HybridConnectionData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.CreateOrUpdateHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, connectionEnvelope, cancellationToken);
                var operation = new SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateHybridConnectionSlot
        /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/>, <paramref name="relayName"/>, or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string namespaceName, string relayName, HybridConnectionData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.CreateOrUpdateHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotHybridConnectionNamespaceRelayCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetHybridConnectionSlot
        /// <summary> Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelay> Get(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetHybridConnectionSlot
        /// <summary> Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridConnectionNamespaceRelay>> GetAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelay> GetIfExists(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHybridConnectionNamespaceRelay>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridConnectionNamespaceRelay>> GetIfExistsAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHybridConnectionNamespaceRelay>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(namespaceName, relayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(namespaceName, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
