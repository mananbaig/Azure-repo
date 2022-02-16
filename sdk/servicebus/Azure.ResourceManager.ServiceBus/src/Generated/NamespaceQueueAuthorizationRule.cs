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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A Class representing a NamespaceQueueAuthorizationRule along with the instance operations that can be performed on it. </summary>
    public partial class NamespaceQueueAuthorizationRule : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NamespaceQueueAuthorizationRule"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics;
        private readonly QueueAuthorizationRulesRestOperations _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient;
        private readonly ServiceBusAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRule"/> class for mocking. </summary>
        protected NamespaceQueueAuthorizationRule()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NamespaceQueueAuthorizationRule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRule(ArmClient client, ServiceBusAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRule(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string namespaceQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
            _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(_namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, namespaceQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/queues/authorizationRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusAuthorizationRuleData Data
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
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<NamespaceQueueAuthorizationRule>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Get");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NamespaceQueueAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NamespaceQueueAuthorizationRule> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Get");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceQueueAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a queue authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Delete");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
                if (waitForCompletion)
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
        /// Deletes a queue authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Delete");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
                if (waitForCompletion)
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
        /// Primary and secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/ListKeys
        /// Operation Id: QueueAuthorizationRules_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.GetKeys");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Primary and secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/ListKeys
        /// Operation Id: QueueAuthorizationRules_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.GetKeys");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: QueueAuthorizationRules_RegenerateKeys
        /// </summary>
        /// <param name="parameters"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<AccessKeys>> RegenerateKeysAsync(RegenerateAccessKeyOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: QueueAuthorizationRules_RegenerateKeys
        /// </summary>
        /// <param name="parameters"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<AccessKeys> RegenerateKeys(RegenerateAccessKeyOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
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
