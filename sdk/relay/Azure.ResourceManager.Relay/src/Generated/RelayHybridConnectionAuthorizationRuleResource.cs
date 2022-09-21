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
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A Class representing a RelayHybridConnectionAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RelayHybridConnectionAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRelayHybridConnectionAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="RelayHybridConnectionResource" /> using the GetRelayHybridConnectionAuthorizationRule method.
    /// </summary>
    public partial class RelayHybridConnectionAuthorizationRuleResource : RelayAuthorizationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RelayHybridConnectionAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics;
        private readonly HybridConnectionsRestOperations _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RelayHybridConnectionAuthorizationRuleResource"/> class for mocking. </summary>
        protected RelayHybridConnectionAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RelayHybridConnectionAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RelayHybridConnectionAuthorizationRuleResource(ArmClient client, RelayAuthorizationRuleData data) : base(client, data)
        {
            _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string relayHybridConnectionAuthorizationRuleHybridConnectionsApiVersion);
            _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient = new HybridConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayHybridConnectionAuthorizationRuleHybridConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="RelayHybridConnectionAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RelayHybridConnectionAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string relayHybridConnectionAuthorizationRuleHybridConnectionsApiVersion);
            _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient = new HybridConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayHybridConnectionAuthorizationRuleHybridConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Relay/namespaces/hybridConnections/authorizationRules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Hybrid connection authorization rule for a hybrid connection by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RelayAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.GetCore");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Hybrid connection authorization rule for a hybrid connection by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<RelayHybridConnectionAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((RelayHybridConnectionAuthorizationRuleResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Hybrid connection authorization rule for a hybrid connection by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RelayAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.GetCore");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Hybrid connection authorization rule for a hybrid connection by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<RelayHybridConnectionAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((RelayHybridConnectionAuthorizationRuleResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a hybrid connection authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.DeleteAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation(response);
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
        /// The core implementation for operation Delete
        /// Deletes a hybrid connection authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.DeleteAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RelayArmOperation(response);
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
        /// The core implementation for operation Update
        /// Creates or updates an authorization rule for a hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<RelayAuthorizationRuleResource>> UpdateCoreAsync(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation<RelayAuthorizationRuleResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an authorization rule for a hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<ArmOperation<RelayHybridConnectionAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            return new RelayArmOperation<RelayHybridConnectionAuthorizationRuleResource>(Response.FromValue((RelayHybridConnectionAuthorizationRuleResource)value.Value, value.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Creates or updates an authorization rule for a hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<RelayAuthorizationRuleResource> UpdateCore(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new RelayArmOperation<RelayAuthorizationRuleResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an authorization rule for a hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: HybridConnections_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual ArmOperation<RelayHybridConnectionAuthorizationRuleResource> Update(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(waitUntil, data, cancellationToken);
            return new RelayArmOperation<RelayHybridConnectionAuthorizationRuleResource>(Response.FromValue((RelayHybridConnectionAuthorizationRuleResource)value.Value, value.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation GetKeys
        /// Primary and secondary connection strings to the hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: HybridConnections_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RelayAccessKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.GetKeysCore");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation GetKeys
        /// Primary and secondary connection strings to the hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: HybridConnections_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RelayAccessKeys> GetKeysCore(CancellationToken cancellationToken = default)
        {
            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.GetKeysCore");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation RegenerateKeys
        /// Regenerates the primary or secondary connection strings to the hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: HybridConnections_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected override async Task<Response<RelayAccessKeys>> RegenerateKeysCoreAsync(RelayRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.RegenerateKeysCore");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation RegenerateKeys
        /// Regenerates the primary or secondary connection strings to the hybrid connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: HybridConnections_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected override Response<RelayAccessKeys> RegenerateKeysCore(RelayRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleResource.RegenerateKeysCore");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
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
