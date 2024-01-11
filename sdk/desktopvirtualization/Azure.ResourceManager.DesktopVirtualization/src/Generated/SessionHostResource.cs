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
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A Class representing a SessionHost along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SessionHostResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSessionHostResource method.
    /// Otherwise you can get one from its parent resource <see cref="HostPoolResource"/> using the GetSessionHost method.
    /// </summary>
    public partial class SessionHostResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SessionHostResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hostPoolName"> The hostPoolName. </param>
        /// <param name="sessionHostName"> The sessionHostName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostPoolName, string sessionHostName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sessionHostClientDiagnostics;
        private readonly SessionHostsRestOperations _sessionHostRestClient;
        private readonly SessionHostData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DesktopVirtualization/hostPools/sessionHosts";

        /// <summary> Initializes a new instance of the <see cref="SessionHostResource"/> class for mocking. </summary>
        protected SessionHostResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SessionHostResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SessionHostResource(ArmClient client, SessionHostData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SessionHostResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SessionHostResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sessionHostClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sessionHostApiVersion);
            _sessionHostRestClient = new SessionHostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sessionHostApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SessionHostData Data
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

        /// <summary> Gets a collection of UserSessionResources in the SessionHost. </summary>
        /// <returns> An object representing collection of UserSessionResources and their operations over a UserSessionResource. </returns>
        public virtual UserSessionCollection GetUserSessions()
        {
            return GetCachedClient(client => new UserSessionCollection(client, Id));
        }

        /// <summary>
        /// Get a userSession.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<UserSessionResource>> GetUserSessionAsync(string userSessionId, CancellationToken cancellationToken = default)
        {
            return await GetUserSessions().GetAsync(userSessionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a userSession.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<UserSessionResource> GetUserSession(string userSessionId, CancellationToken cancellationToken = default)
        {
            return GetUserSessions().Get(userSessionId, cancellationToken);
        }

        /// <summary>
        /// Get a session host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SessionHostResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostResource.Get");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SessionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a session host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SessionHostResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostResource.Get");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SessionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove a SessionHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="force"> Force flag to force sessionHost deletion even when userSession exists. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostResource.Delete");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, force, cancellationToken).ConfigureAwait(false);
                var uri = _sessionHostRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, force);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new DesktopVirtualizationArmOperation(response, operationId);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove a SessionHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="force"> Force flag to force sessionHost deletion even when userSession exists. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostResource.Delete");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, force, cancellationToken);
                var uri = _sessionHostRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, force);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new DesktopVirtualizationArmOperation(response, operationId);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a session host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Object containing SessionHost definitions. </param>
        /// <param name="force"> Force flag to update assign, unassign or reassign personal desktop. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<SessionHostResource>> UpdateAsync(SessionHostPatch patch, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostResource.Update");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, force, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SessionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a session host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-05</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Object containing SessionHost definitions. </param>
        /// <param name="force"> Force flag to update assign, unassign or reassign personal desktop. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<SessionHostResource> Update(SessionHostPatch patch, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostResource.Update");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, force, cancellationToken);
                return Response.FromValue(new SessionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
