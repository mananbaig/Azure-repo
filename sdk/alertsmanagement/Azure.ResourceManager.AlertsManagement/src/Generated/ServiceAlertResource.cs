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
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A Class representing a ServiceAlert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceAlertResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetServiceAlert method.
    /// </summary>
    public partial class ServiceAlertResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceAlertResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="alertId"> The alertId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, Guid alertId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _serviceAlertAlertsRestClient;
        private readonly ServiceAlertData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertResource"/> class for mocking. </summary>
        protected ServiceAlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceAlertResource(ArmClient client, ServiceAlertData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceAlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceAlertAlertsApiVersion);
            _serviceAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AlertsManagement/alerts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceAlertData Data
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

        /// <summary>
        /// Get information related to a specific alert
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceAlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.GetByIdAsync(Id.SubscriptionId, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information related to a specific alert
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceAlertResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertResource.Get");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.GetById(Id.SubscriptionId, Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Change the state of an alert.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}/changestate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_ChangeState</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="newState"> New state of the alert. </param>
        /// <param name="comment"> reason of change alert state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceAlertResource>> ChangeStateAsync(ServiceAlertState newState, string comment = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertResource.ChangeState");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.ChangeStateAsync(Id.SubscriptionId, Guid.Parse(Id.Name), newState, comment, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Change the state of an alert.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}/changestate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_ChangeState</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="newState"> New state of the alert. </param>
        /// <param name="comment"> reason of change alert state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceAlertResource> ChangeState(ServiceAlertState newState, string comment = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertResource.ChangeState");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.ChangeState(Id.SubscriptionId, Guid.Parse(Id.Name), newState, comment, cancellationToken);
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the history of an alert, which captures any monitor condition changes (Fired/Resolved) and alert state changes (New/Acknowledged/Closed).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceAlertModification>> GetHistoryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertResource.GetHistory");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.GetHistoryAsync(Id.SubscriptionId, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the history of an alert, which captures any monitor condition changes (Fired/Resolved) and alert state changes (New/Acknowledged/Closed).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceAlertModification> GetHistory(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertResource.GetHistory");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.GetHistory(Id.SubscriptionId, Guid.Parse(Id.Name), cancellationToken);
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
