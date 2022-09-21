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
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing an AscLocationLocationAlert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AscLocationLocationAlertResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAscLocationLocationAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="AscLocationResource" /> using the GetAscLocationLocationAlert method.
    /// </summary>
    public partial class AscLocationLocationAlertResource : AlertResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AscLocationLocationAlertResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string ascLocation, string alertName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _ascLocationLocationAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _ascLocationLocationAlertAlertsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AscLocationLocationAlertResource"/> class for mocking. </summary>
        protected AscLocationLocationAlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AscLocationLocationAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AscLocationLocationAlertResource(ArmClient client, AlertData data) : base(client, data)
        {
            _ascLocationLocationAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string ascLocationLocationAlertAlertsApiVersion);
            _ascLocationLocationAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ascLocationLocationAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="AscLocationLocationAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AscLocationLocationAlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ascLocationLocationAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string ascLocationLocationAlertAlertsApiVersion);
            _ascLocationLocationAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ascLocationLocationAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/alerts";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Get an alert that is associated with a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}
        /// Operation Id: Alerts_GetSubscriptionLevel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<AlertResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.GetCore");
            scope.Start();
            try
            {
                var response = await _ascLocationLocationAlertAlertsRestClient.GetSubscriptionLevelAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}
        /// Operation Id: Alerts_GetSubscriptionLevel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<AscLocationLocationAlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((AscLocationLocationAlertResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Get an alert that is associated with a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}
        /// Operation Id: Alerts_GetSubscriptionLevel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<AlertResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.GetCore");
            scope.Start();
            try
            {
                var response = _ascLocationLocationAlertAlertsRestClient.GetSubscriptionLevel(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}
        /// Operation Id: Alerts_GetSubscriptionLevel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<AscLocationLocationAlertResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((AscLocationLocationAlertResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/dismiss
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToDismiss
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSubscriptionLevelStateToDismissAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToDismiss");
            scope.Start();
            try
            {
                var response = await _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToDismissAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/dismiss
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToDismiss
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSubscriptionLevelStateToDismiss(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToDismiss");
            scope.Start();
            try
            {
                var response = _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToDismiss(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/resolve
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToResolve
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSubscriptionLevelStateToResolveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToResolve");
            scope.Start();
            try
            {
                var response = await _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToResolveAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/resolve
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToResolve
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSubscriptionLevelStateToResolve(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToResolve");
            scope.Start();
            try
            {
                var response = _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToResolve(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/activate
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToActivate
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSubscriptionLevelStateToActivateAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToActivate");
            scope.Start();
            try
            {
                var response = await _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToActivateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/activate
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToActivate
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSubscriptionLevelStateToActivate(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToActivate");
            scope.Start();
            try
            {
                var response = _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToActivate(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/inProgress
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToInProgress
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSubscriptionLevelStateToInProgressAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToInProgress");
            scope.Start();
            try
            {
                var response = await _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToInProgressAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/inProgress
        /// Operation Id: Alerts_UpdateSubscriptionLevelStateToInProgress
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSubscriptionLevelStateToInProgress(CancellationToken cancellationToken = default)
        {
            using var scope = _ascLocationLocationAlertAlertsClientDiagnostics.CreateScope("AscLocationLocationAlertResource.UpdateSubscriptionLevelStateToInProgress");
            scope.Start();
            try
            {
                var response = _ascLocationLocationAlertAlertsRestClient.UpdateSubscriptionLevelStateToInProgress(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
