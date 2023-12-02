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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseServerBlobAuditingPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SynapseServerBlobAuditingPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSynapseServerBlobAuditingPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource"/> using the GetSynapseServerBlobAuditingPolicy method.
    /// </summary>
    public partial class SynapseServerBlobAuditingPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseServerBlobAuditingPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="blobAuditingPolicyName"> The blobAuditingPolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, SynapseBlobAuditingPolicyName blobAuditingPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics;
        private readonly WorkspaceManagedSqlServerBlobAuditingPoliciesRestOperations _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient;
        private readonly SynapseServerBlobAuditingPolicyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/auditingSettings";

        /// <summary> Initializes a new instance of the <see cref="SynapseServerBlobAuditingPolicyResource"/> class for mocking. </summary>
        protected SynapseServerBlobAuditingPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseServerBlobAuditingPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseServerBlobAuditingPolicyResource(ArmClient client, SynapseServerBlobAuditingPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseServerBlobAuditingPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseServerBlobAuditingPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesApiVersion);
            _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient = new WorkspaceManagedSqlServerBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseServerBlobAuditingPolicyData Data
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
        /// Get a workspace managed sql server's blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseServerBlobAuditingPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace managed sql server's blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseServerBlobAuditingPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update a workspace managed sql server's blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseServerBlobAuditingPolicyResource>> UpdateAsync(WaitUntil waitUntil, SynapseServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseServerBlobAuditingPolicyResource>(new SynapseServerBlobAuditingPolicyOperationSource(Client), _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a workspace managed sql server's blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseServerBlobAuditingPolicyResource> Update(WaitUntil waitUntil, SynapseServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseServerBlobAuditingPolicyResource>(new SynapseServerBlobAuditingPolicyOperationSource(Client), _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
