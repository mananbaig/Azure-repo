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
    /// A Class representing a RelayNamespaceAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RelayNamespaceAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRelayNamespaceAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="RelayNamespaceResource" /> using the GetRelayNamespaceAuthorizationRule method.
    /// </summary>
    public partial class RelayNamespaceAuthorizationRuleResource : RelayAuthorizationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RelayNamespaceAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _relayNamespaceAuthorizationRuleNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RelayNamespaceAuthorizationRuleResource"/> class for mocking. </summary>
        protected RelayNamespaceAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RelayNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RelayNamespaceAuthorizationRuleResource(ArmClient client, RelayAuthorizationRuleData data) : base(client, data)
        {
            _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string relayNamespaceAuthorizationRuleNamespacesApiVersion);
            _relayNamespaceAuthorizationRuleNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayNamespaceAuthorizationRuleNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="RelayNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RelayNamespaceAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string relayNamespaceAuthorizationRuleNamespacesApiVersion);
            _relayNamespaceAuthorizationRuleNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayNamespaceAuthorizationRuleNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Relay/namespaces/authorizationRules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Authorization rule for a namespace by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RelayAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.GetCore");
            scope.Start();
            try
            {
                var response = await _relayNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Authorization rule for a namespace by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<RelayNamespaceAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((RelayNamespaceAuthorizationRuleResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Authorization rule for a namespace by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RelayAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.GetCore");
            scope.Start();
            try
            {
                var response = _relayNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Authorization rule for a namespace by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<RelayNamespaceAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((RelayNamespaceAuthorizationRuleResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a namespace authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _relayNamespaceAuthorizationRuleNamespacesRestClient.DeleteAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Deletes a namespace authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _relayNamespaceAuthorizationRuleNamespacesRestClient.DeleteAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Creates or updates an authorization rule for a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<RelayAuthorizationRuleResource>> UpdateCoreAsync(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _relayNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
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
        /// Creates or updates an authorization rule for a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<ArmOperation<RelayNamespaceAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            return new RelayArmOperation<RelayNamespaceAuthorizationRuleResource>(Response.FromValue((RelayNamespaceAuthorizationRuleResource)value.Value, value.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Creates or updates an authorization rule for a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<RelayAuthorizationRuleResource> UpdateCore(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _relayNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
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
        /// Creates or updates an authorization rule for a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual ArmOperation<RelayNamespaceAuthorizationRuleResource> Update(WaitUntil waitUntil, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(waitUntil, data, cancellationToken);
            return new RelayArmOperation<RelayNamespaceAuthorizationRuleResource>(Response.FromValue((RelayNamespaceAuthorizationRuleResource)value.Value, value.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation GetKeys
        /// Primary and secondary connection strings to the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: Namespaces_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RelayAccessKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.GetKeysCore");
            scope.Start();
            try
            {
                var response = await _relayNamespaceAuthorizationRuleNamespacesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Primary and secondary connection strings to the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: Namespaces_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RelayAccessKeys> GetKeysCore(CancellationToken cancellationToken = default)
        {
            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.GetKeysCore");
            scope.Start();
            try
            {
                var response = _relayNamespaceAuthorizationRuleNamespacesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Regenerates the primary or secondary connection strings to the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: Namespaces_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected override async Task<Response<RelayAccessKeys>> RegenerateKeysCoreAsync(RelayRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.RegenerateKeysCore");
            scope.Start();
            try
            {
                var response = await _relayNamespaceAuthorizationRuleNamespacesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
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
        /// Regenerates the primary or secondary connection strings to the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: Namespaces_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected override Response<RelayAccessKeys> RegenerateKeysCore(RelayRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _relayNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("RelayNamespaceAuthorizationRuleResource.RegenerateKeysCore");
            scope.Start();
            try
            {
                var response = _relayNamespaceAuthorizationRuleNamespacesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
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
