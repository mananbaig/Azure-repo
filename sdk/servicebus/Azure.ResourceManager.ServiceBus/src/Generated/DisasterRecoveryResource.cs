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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a DisasterRecovery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DisasterRecoveryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDisasterRecoveryResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusNamespaceResource" /> using the GetDisasterRecovery method.
    /// </summary>
    public partial class DisasterRecoveryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DisasterRecoveryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string alias)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryDisasterRecoveryConfigsRestClient;
        private readonly DisasterRecoveryData _data;

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryResource"/> class for mocking. </summary>
        protected DisasterRecoveryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DisasterRecoveryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DisasterRecoveryResource(ArmClient client, DisasterRecoveryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DisasterRecoveryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string disasterRecoveryDisasterRecoveryConfigsApiVersion);
            _disasterRecoveryDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, disasterRecoveryDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DisasterRecoveryData Data
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

        /// <summary> Gets a collection of NamespaceDisasterRecoveryAuthorizationRuleResources in the DisasterRecovery. </summary>
        /// <returns> An object representing collection of NamespaceDisasterRecoveryAuthorizationRuleResources and their operations over a NamespaceDisasterRecoveryAuthorizationRuleResource. </returns>
        public virtual NamespaceDisasterRecoveryAuthorizationRuleCollection GetNamespaceDisasterRecoveryAuthorizationRules()
        {
            return GetCachedClient(Client => new NamespaceDisasterRecoveryAuthorizationRuleCollection(Client, Id));
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NamespaceDisasterRecoveryAuthorizationRuleResource>> GetNamespaceDisasterRecoveryAuthorizationRuleAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            return await GetNamespaceDisasterRecoveryAuthorizationRules().GetAsync(authorizationRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<NamespaceDisasterRecoveryAuthorizationRuleResource> GetNamespaceDisasterRecoveryAuthorizationRule(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            return GetNamespaceDisasterRecoveryAuthorizationRules().Get(authorizationRuleName, cancellationToken);
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DisasterRecoveryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.Get");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DisasterRecoveryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.Get");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Alias(Disaster Recovery configuration)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.Delete");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
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
        /// Deletes an Alias(Disaster Recovery configuration)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.Delete");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
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
        /// This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/breakPairing
        /// Operation Id: DisasterRecoveryConfigs_BreakPairing
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> BreakPairingAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.BreakPairing");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.BreakPairingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/breakPairing
        /// Operation Id: DisasterRecoveryConfigs_BreakPairing
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response BreakPairing(CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.BreakPairing");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.BreakPairing(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/failover
        /// Operation Id: DisasterRecoveryConfigs_FailOver
        /// </summary>
        /// <param name="failoverProperties"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> FailOverAsync(FailoverProperties failoverProperties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.FailOver");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.FailOverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, failoverProperties, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/failover
        /// Operation Id: DisasterRecoveryConfigs_FailOver
        /// </summary>
        /// <param name="failoverProperties"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response FailOver(FailoverProperties failoverProperties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryResource.FailOver");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.FailOver(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, failoverProperties, cancellationToken);
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
